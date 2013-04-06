using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;

namespace XbmcWatchedFlagUpdater
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            //Retrieve previous settings
            textBoxServerIP.Text = Properties.Settings.Default.ServerIP;
            textBoxUsername.Text = Properties.Settings.Default.Username;
            textBoxPassword.Text = Properties.Settings.Default.Password;
            textBoxImportPathRemote.Text = Properties.Settings.Default.ImportPathRemote;
            textBoxExportPathRemote.Text = Properties.Settings.Default.ExportPathRemote;
            textBoxLocalDBPath.Text = Properties.Settings.Default.LocalDBFile;
            if (textBoxLocalDBPath.Text.Length < 1)
                textBoxLocalDBPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\XBMC\userdata\Database\MyVideos75.db";

        }

        #region Remote Buttons and Background Workers

        private void buttonSelectFileImportRemote_Click(object sender, EventArgs e)
        {
            //select an xml file to import from
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "xml files (*.xml)|*.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxImportPathRemote.Text = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonImportRemote_Click(object sender, EventArgs e)
        {
            if (textBoxImportPathRemote.Text != "")
            {
                //save settings
                Properties.Settings.Default.ServerIP = textBoxServerIP.Text;
                Properties.Settings.Default.Username = textBoxUsername.Text;
                Properties.Settings.Default.Password = textBoxPassword.Text;
                Properties.Settings.Default.ImportPathRemote = textBoxImportPathRemote.Text;
                Properties.Settings.Default.Save();

                //read files
                List<XbmcFile> files = XMLConnector.ReadFiles(textBoxImportPathRemote.Text);

                //run import in different thread
                XbmcMySqlConnector sql = new XbmcMySqlConnector(textBoxServerIP.Text, textBoxUsername.Text, textBoxPassword.Text, files);
                toolStripProgressBar1.Style = ProgressBarStyle.Marquee; //turn on the progress bar
                backgroundWorkerImportRemote.RunWorkerAsync(sql);
            }
            else
            {
                MessageBox.Show("Please select a file.");
            }
        }

        private void buttonSelectFileExportRemote_Click(object sender, EventArgs e)
        {
            //select an xml file to export to
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "xml files (*.xml)|*.xml";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxExportPathRemote.Text = saveFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonExportRemote_Click(object sender, EventArgs e)
        {
            if (textBoxExportPathRemote.Text != "")
            {
                //save settings
                Properties.Settings.Default.ServerIP = textBoxServerIP.Text;
                Properties.Settings.Default.Username = textBoxUsername.Text;
                Properties.Settings.Default.Password = textBoxPassword.Text;
                Properties.Settings.Default.ExportPathRemote = textBoxExportPathRemote.Text;
                Properties.Settings.Default.Save();

                //run export in different thread
                XbmcMySqlConnector sql = new XbmcMySqlConnector(textBoxServerIP.Text, textBoxUsername.Text, textBoxPassword.Text);
                toolStripProgressBar1.Style = ProgressBarStyle.Marquee; //turn on the progress bar
                backgroundWorkerExportRemote.RunWorkerAsync(sql);
            }
            else
            {
                MessageBox.Show("Please select a file.");
            }
        }

        private void backgroundWorkerImportRemote_DoWork(object sender, DoWorkEventArgs e)
        {
            //cast the connector then execute import command
            XbmcMySqlConnector sql = (XbmcMySqlConnector)e.Argument;
            MessageBox.Show("Import complete. " + sql.ImportWatchedFlags().ToString() + " rows updated.");
        }

        private void backgroundWorkerExportRemote_DoWork(object sender, DoWorkEventArgs e)
        {
            //cast the connector then execute export command
            XbmcMySqlConnector sql = (XbmcMySqlConnector)e.Argument;
            List<XbmcFile> files = sql.ExportWatchedFlags();
            XMLConnector.WriteFiles(textBoxExportPathRemote.Text, files);
            MessageBox.Show("Export complete. " + files.Count + " files found.");
        }

        private void backgroundWorkerImportRemote_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar1.Style = ProgressBarStyle.Blocks; //disable progress bar when finished
        }

        private void backgroundWorkerExportRemote_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar1.Style = ProgressBarStyle.Blocks;  //disable progress bar when finished
        }

        #endregion


        #region Local Buttons and Background Workers

        private void buttonSelectLocalDBPath_Click(object sender, EventArgs e)
        {
            //select the local XBMC .db file 
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "data base files (*.db)|*.db";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxLocalDBPath.Text = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonImportSelectFileLocal_Click(object sender, EventArgs e)
        {
            //select an xml file to import from
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "xml files (*.xml)|*.xml";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxImportPathLocal.Text = openFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonImportLocal_Click(object sender, EventArgs e)
        {
            if (textBoxImportPathLocal.Text != "")
            {
                //save settings
                Properties.Settings.Default.LocalDBFile = textBoxLocalDBPath.Text;
                Properties.Settings.Default.ImportPathLocal = textBoxImportPathLocal.Text;
                Properties.Settings.Default.Save();

                //read files
                List<XbmcFile> files = XMLConnector.ReadFiles(textBoxImportPathLocal.Text);

                //run import in different thread
                XbmcSqlLiteConnector sql = new XbmcSqlLiteConnector(textBoxLocalDBPath.Text, files);
                toolStripProgressBar1.Style = ProgressBarStyle.Marquee; //turn on the progress bar
                backgroundWorkerImportLocal.RunWorkerAsync(sql);
            }
            else
            {
                MessageBox.Show("Please select a file.");
            }
        }

        private void buttonExportSelectFileLocal_Click(object sender, EventArgs e)
        {
            //select an xml file to export to
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "xml files (*.xml)|*.xml";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBoxExportPathLocal.Text = saveFileDialog1.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonExportLocal_Click(object sender, EventArgs e)
        {
            if (textBoxExportPathLocal.Text != "")
            {
                //save settings
                Properties.Settings.Default.LocalDBFile = textBoxLocalDBPath.Text;
                Properties.Settings.Default.ExportPathLocal = textBoxExportPathLocal.Text;
                Properties.Settings.Default.Save();

                //run export in different thread
                XbmcSqlLiteConnector sql = new XbmcSqlLiteConnector(textBoxLocalDBPath.Text);
                toolStripProgressBar1.Style = ProgressBarStyle.Marquee; //turn on the progress bar
                backgroundWorkerExportLocal.RunWorkerAsync(sql);
            }
            else
            {
                MessageBox.Show("Please select a file.");
            }
        }

        private void backgroundWorkerImportLocal_DoWork(object sender, DoWorkEventArgs e)
        {
            //cast the connector then execute import command
            XbmcSqlLiteConnector sql = (XbmcSqlLiteConnector)e.Argument;
            MessageBox.Show("Import complete. " + sql.ImportWatchedFlags().ToString() + " rows updated.");
        }

        private void backgroundWorkerImportLocal_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar1.Style = ProgressBarStyle.Blocks; //disable progress bar when finished
        }

        private void backgroundWorkerExportLocal_DoWork(object sender, DoWorkEventArgs e)
        {
            //cast the connector then execute export command
            XbmcSqlLiteConnector sql = (XbmcSqlLiteConnector)e.Argument;
            List<XbmcFile> files = sql.ExportWatchedFlags();
            XMLConnector.WriteFiles(textBoxExportPathLocal.Text, files);
            MessageBox.Show("Export complete. " + files.Count + " files found.");
        }

        private void backgroundWorkerExportLocal_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBar1.Style = ProgressBarStyle.Blocks; //disable progress bar when finished
        }
        #endregion
    }
}
