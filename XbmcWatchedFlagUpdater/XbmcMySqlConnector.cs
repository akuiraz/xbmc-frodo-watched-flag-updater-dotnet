using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace XbmcWatchedFlagUpdater
{
    /// <summary>
    /// Uses the static XmlReader class to retrieve a collection of XbmcFile objects, then executes an SQL update statement to mark them as watched.  Used to work with a remote MySql database used in an XBMC shared library.
    /// </summary>
    class XbmcMySqlConnector
    {
        private List<XbmcFile> WatchedFiles;
        private string serverLocation;
        private string sqlUserName;
        private string sqlPassword;
        public MySqlCommand command;

        /// <summary>
        /// A class that can communicate with a remote MySQL database to runs a batch of SQL commands to update the watched flag in XBMC.  This constructor is for importing watched flags.
        /// </summary>
        /// <param name="serverLocation">The IP address of the server</param>
        /// <param name="sqlUsername">The username for the SQL database - this is normally 'xbmc'</param>
        /// <param name="sqlPassword">The password for the SQL database - this is normally 'xbmc'</param>
        /// <param name="watchedFiles">A collection of XbmcFile objects that has been parsed from a watched.xml file</param>
        public XbmcMySqlConnector(string serverLocation, string sqlUsername, string sqlPassword, List<XbmcFile> watchedFiles)
        {
            //populate properties
            WatchedFiles = watchedFiles;
            this.serverLocation = serverLocation;
            this.sqlUserName = sqlUsername;
            this.sqlPassword = sqlPassword;
            MySqlConnection connection = new MySqlConnection(buildConnectionString()); //build the connection string

            string updateCommand = buildSqlImportCommand(); //build the SQL command

            //System.Windows.Forms.MessageBox.Show(updateCommand);

            command = new MySqlCommand(updateCommand, connection);
            command.CommandTimeout = 0; //disable timeout setting
        }

        /// <summary>
        /// A class that can communicate with a remote MySQL database to runs a batch of SQL commands to update the watched flag in XBMC.  This constructor is for exporting watched flags.
        /// </summary>
        /// <param name="serverLocation">The IP address of the server</param>
        /// <param name="sqlUsername">The username for the SQL database - this is normally 'xbmc'</param>
        /// <param name="sqlPassword">The password for the SQL database - this is normally 'xbmc'</param>
        /// <param name="watchedFiles">A collection of XbmcFile objects that has been parsed from a watched.xml file</param>
        public XbmcMySqlConnector(string serverLocation, string sqlUsername, string sqlPassword)
        {
            //populate properties
            this.serverLocation = serverLocation;
            this.sqlUserName = sqlUsername;
            this.sqlPassword = sqlPassword;
            MySqlConnection connection = new MySqlConnection(buildConnectionString()); //build the connection string

            string updateCommand = "SELECT strFileName, lastPlayed, playCount FROM " + Properties.Settings.Default.DatabaseName + ".files WHERE playCount >= 1 and strFileName != '';"; //build the SQL command

            command = new MySqlCommand(updateCommand, connection);
            command.CommandTimeout = 0; //disable timeout setting
        }

        /// <summary>
        /// Build SQL command using list of XbmcFile objects
        /// </summary>
        /// <returns>An SQL command with multiple UPDATE statements</returns>
        private string buildSqlImportCommand()
        {
            StringBuilder commands = new StringBuilder();
            foreach (XbmcFile file in WatchedFiles)
            {
                //System.Windows.Forms.MessageBox.Show(file.FileName);
                string command = "UPDATE " + Properties.Settings.Default.DatabaseName + ".files SET playCount='" + file.WatchedCount + "', lastPlayed='" + file.LastWatchedDate + "' WHERE strFileName= '" + file.FileName + "'; " + Environment.NewLine;           
                commands.Append(command);
            }

            return commands.ToString();
        }

        /// <summary>
        /// Build the MySQL Connection String.
        /// </summary>
        /// <returns>A connection string that will connect to a MySQL database</returns>
        private string buildConnectionString()
        {
            string connectionString = "server=" + serverLocation + ";User Id='" + sqlUserName + "';password='" + sqlPassword + "';Persist Security Info=True;database=" + Properties.Settings.Default.DatabaseName;
            return connectionString;
        }

        /// <summary>
        /// Import the watched flags into a SQL database
        /// </summary>
        /// <returns>The number of SQL Database rows affected by the change</returns>
        public int ImportWatchedFlags()
        {
            int count = -1;
            try
            {
                command.Connection.Open();
                count = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                command.Connection.Close();            
            }
            return count; //return the number of database rows affected
        }

        /// <summary>
        /// Export the watched flags from the MySQL database into a .net collection
        /// </summary>
        /// <returns>A collection of XbmcFile objects, representing films/episodes in XBMC that have been watched</returns>
        public List<XbmcFile> ExportWatchedFlags()
        {
            List<XbmcFile> files = new List<XbmcFile>();

            MySqlDataReader myReader = null;    
            try
            {
                command.Connection.Open();
                myReader = command.ExecuteReader();
                //read the data sent back from MySQL server and create the XbmcFile objects
                while (myReader.Read())
                {
                    string name = myReader.GetString(0);
                    string date = myReader.GetString(1);
                    int count = Convert.ToInt32(myReader.GetString(2));
                    files.Add(new XbmcFile(name, count, date));
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (myReader != null)
                    myReader.Close();
                command.Connection.Close();
            }
            return files;
        }
    }
}
