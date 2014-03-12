using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace XbmcWatchedFlagUpdater
{
    /// <summary>
    /// Uses the static XmlReader class to retrieve a collection of XbmcFile objects, then executes an SQL update statement to mark them as watched.  Used to work with a local XBMC SQLite database file.
    /// </summary>
    class XbmcSqlLiteConnector
    {
        private List<XbmcFile> WatchedFiles;
        SQLiteCommand command;

        /// <summary>
        ///  Communicates with a local SQLite database file to runs a batch of SQL commands to update the watched flag in XBMC.  This constructor is for importing watched flags. 
        /// </summary>
        /// <param name="watchedFiles">A collection of XbmcFile objects that has been parsed from a watched.xml file</param>
        public XbmcSqlLiteConnector(string path, List<XbmcFile> watchedFiles)
        {
            //populate properties
            WatchedFiles = watchedFiles;
            SQLiteConnection connection = new SQLiteConnection(buildConnectionString(path));

            string updateCommand = buildSqliteImportCommand();

            command = new SQLiteCommand(updateCommand, connection); //build the connection string
            command.CommandTimeout = 0; //build the SQL command         
        }

        /// <summary>
        /// A class that can communicate with a local SQLite database file to run a batch of SQL commands to update the watched flag in XBMC.  This constructor is for exporting watched flags.
        /// </summary>
        public XbmcSqlLiteConnector(string path)
        {
            SQLiteConnection connection = new SQLiteConnection(buildConnectionString(path)); //build the connection string
            string updateCommand = "SELECT strFileName, lastPlayed, playCount FROM files WHERE playCount >= 1 and strFileName != '';"; //build the SQL command
            command = new SQLiteCommand(updateCommand, connection);
            command.CommandTimeout = 0; //disable timeout setting


            List<XbmcFile> files = new List<XbmcFile>();
        }

        private string buildSqliteImportCommand()
        {
            StringBuilder commands = new StringBuilder();
            foreach (XbmcFile file in WatchedFiles)
            {
                //System.Windows.Forms.MessageBox.Show(file.FileName);
                string command = "UPDATE files SET playCount='" + file.WatchedCount + "', lastPlayed='" + file.LastWatchedDate + "' WHERE strFileName= '" + file.FileName + "'; " + Environment.NewLine;
                commands.Append(command);
            }

            return commands.ToString();
        }

        /// <summary>
        /// Build the SQLite Connection String.
        /// </summary>
        /// <returns>A connection string that will connect to a MySQL database</returns>
        private string buildConnectionString(string path)
        {
            string connectionString = @"data source=" + path + "; Version=3;";
            return connectionString;
        }

        /// <summary>
        /// Import the watched flags into a SQLite database file
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
        /// Export the watched flags from the SQLite database file into a .net collection
        /// </summary>
        /// <returns>A collection of XbmcFile objects, representing films/episodes in XBMC that have been watched</returns>
        public List<XbmcFile> ExportWatchedFlags()
        {
            List<XbmcFile> files = new List<XbmcFile>();

            SQLiteDataReader myReader;
            command.Connection.Open();
            myReader = command.ExecuteReader();
            try
            {
                //read the data from the SQLite file and create the XbmcFile objects
                while (myReader.Read())
                {
                    string name = myReader.GetString(0);
                    string date; 
                    try 
                    { 
                        date = myReader.GetString(1); 
                    }
                    catch (Exception) 
                    { 
                        date = ""; 
                    }
                    int count; 
                    try 
                    { 
                        count = myReader.GetInt32(2); 
                    }
                    catch (Exception) 
                    { 
                        count = 0; 
                    }

                    files.Add(new XbmcFile(name, count, date));

                    //System.Windows.Forms.MessageBox.Show(name + Environment.NewLine +
                    //                                     date + Environment.NewLine +
                    //                                     count.ToString());
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
            finally
            {
                myReader.Close();
                command.Connection.Close();
            }
            return files;
        }
    }






    }
