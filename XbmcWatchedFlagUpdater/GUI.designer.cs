namespace XbmcWatchedFlagUpdater
{
    partial class GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorkerImportRemote = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.backgroundWorkerExportRemote = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxExport = new System.Windows.Forms.GroupBox();
            this.textBoxExportPathRemote = new System.Windows.Forms.TextBox();
            this.buttonSelectFileExportRemote = new System.Windows.Forms.Button();
            this.buttonExportRemote = new System.Windows.Forms.Button();
            this.groupBoxImport = new System.Windows.Forms.GroupBox();
            this.buttonSelectFileImportRemote = new System.Windows.Forms.Button();
            this.labelImportPath = new System.Windows.Forms.Label();
            this.textBoxImportPathRemote = new System.Windows.Forms.TextBox();
            this.buttonImportRemote = new System.Windows.Forms.Button();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.labelDatabase = new System.Windows.Forms.Label();
            this.textBoxDatabaseName = new System.Windows.Forms.TextBox();
            this.labelServerIP = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxServerIP = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxExportPathLocal = new System.Windows.Forms.TextBox();
            this.buttonExportSelectFileLocal = new System.Windows.Forms.Button();
            this.buttonExportLocal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonImportSelectFileLocal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImportPathLocal = new System.Windows.Forms.TextBox();
            this.buttonImportLocal = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSelectLocalPath = new System.Windows.Forms.Button();
            this.labelLocalPath = new System.Windows.Forms.Label();
            this.textBoxLocalDBPath = new System.Windows.Forms.TextBox();
            this.backgroundWorkerImportLocal = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerExportLocal = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxExport.SuspendLayout();
            this.groupBoxImport.SuspendLayout();
            this.groupBoxConnection.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // backgroundWorkerImportRemote
            // 
            this.backgroundWorkerImportRemote.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerImportRemote_DoWork);
            this.backgroundWorkerImportRemote.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerImportRemote_RunWorkerCompleted);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 372);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(319, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // backgroundWorkerExportRemote
            // 
            this.backgroundWorkerExportRemote.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerExportRemote_DoWork);
            this.backgroundWorkerExportRemote.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerExportRemote_RunWorkerCompleted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(299, 353);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxExport);
            this.tabPage1.Controls.Add(this.groupBoxImport);
            this.tabPage1.Controls.Add(this.groupBoxConnection);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(291, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shared MySQL Library";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxExport
            // 
            this.groupBoxExport.Controls.Add(this.textBoxExportPathRemote);
            this.groupBoxExport.Controls.Add(this.buttonSelectFileExportRemote);
            this.groupBoxExport.Controls.Add(this.buttonExportRemote);
            this.groupBoxExport.Location = new System.Drawing.Point(6, 239);
            this.groupBoxExport.Name = "groupBoxExport";
            this.groupBoxExport.Size = new System.Drawing.Size(277, 80);
            this.groupBoxExport.TabIndex = 13;
            this.groupBoxExport.TabStop = false;
            this.groupBoxExport.Text = "Export";
            // 
            // textBoxExportPathRemote
            // 
            this.textBoxExportPathRemote.Location = new System.Drawing.Point(6, 19);
            this.textBoxExportPathRemote.Name = "textBoxExportPathRemote";
            this.textBoxExportPathRemote.Size = new System.Drawing.Size(260, 20);
            this.textBoxExportPathRemote.TabIndex = 8;
            // 
            // buttonSelectFileExportRemote
            // 
            this.buttonSelectFileExportRemote.Location = new System.Drawing.Point(110, 45);
            this.buttonSelectFileExportRemote.Name = "buttonSelectFileExportRemote";
            this.buttonSelectFileExportRemote.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFileExportRemote.TabIndex = 5;
            this.buttonSelectFileExportRemote.Text = "Select File";
            this.buttonSelectFileExportRemote.UseVisualStyleBackColor = true;
            this.buttonSelectFileExportRemote.Click += new System.EventHandler(this.buttonSelectFileExportRemote_Click);
            // 
            // buttonExportRemote
            // 
            this.buttonExportRemote.Location = new System.Drawing.Point(191, 45);
            this.buttonExportRemote.Name = "buttonExportRemote";
            this.buttonExportRemote.Size = new System.Drawing.Size(75, 23);
            this.buttonExportRemote.TabIndex = 6;
            this.buttonExportRemote.Text = "Export";
            this.buttonExportRemote.UseVisualStyleBackColor = true;
            this.buttonExportRemote.Click += new System.EventHandler(this.buttonExportRemote_Click);
            // 
            // groupBoxImport
            // 
            this.groupBoxImport.Controls.Add(this.buttonSelectFileImportRemote);
            this.groupBoxImport.Controls.Add(this.labelImportPath);
            this.groupBoxImport.Controls.Add(this.textBoxImportPathRemote);
            this.groupBoxImport.Controls.Add(this.buttonImportRemote);
            this.groupBoxImport.Location = new System.Drawing.Point(6, 136);
            this.groupBoxImport.Name = "groupBoxImport";
            this.groupBoxImport.Size = new System.Drawing.Size(277, 97);
            this.groupBoxImport.TabIndex = 12;
            this.groupBoxImport.TabStop = false;
            this.groupBoxImport.Text = "Import";
            // 
            // buttonSelectFileImportRemote
            // 
            this.buttonSelectFileImportRemote.Location = new System.Drawing.Point(113, 64);
            this.buttonSelectFileImportRemote.Name = "buttonSelectFileImportRemote";
            this.buttonSelectFileImportRemote.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectFileImportRemote.TabIndex = 3;
            this.buttonSelectFileImportRemote.Text = "Select File";
            this.buttonSelectFileImportRemote.UseVisualStyleBackColor = true;
            this.buttonSelectFileImportRemote.Click += new System.EventHandler(this.buttonSelectFileImportRemote_Click);
            // 
            // labelImportPath
            // 
            this.labelImportPath.AutoSize = true;
            this.labelImportPath.Location = new System.Drawing.Point(6, 22);
            this.labelImportPath.Name = "labelImportPath";
            this.labelImportPath.Size = new System.Drawing.Size(76, 13);
            this.labelImportPath.TabIndex = 6;
            this.labelImportPath.Text = "XML File Path:";
            // 
            // textBoxImportPathRemote
            // 
            this.textBoxImportPathRemote.Location = new System.Drawing.Point(6, 38);
            this.textBoxImportPathRemote.Name = "textBoxImportPathRemote";
            this.textBoxImportPathRemote.Size = new System.Drawing.Size(263, 20);
            this.textBoxImportPathRemote.TabIndex = 7;
            // 
            // buttonImportRemote
            // 
            this.buttonImportRemote.Location = new System.Drawing.Point(194, 64);
            this.buttonImportRemote.Name = "buttonImportRemote";
            this.buttonImportRemote.Size = new System.Drawing.Size(75, 23);
            this.buttonImportRemote.TabIndex = 4;
            this.buttonImportRemote.Text = "Import";
            this.buttonImportRemote.UseVisualStyleBackColor = true;
            this.buttonImportRemote.Click += new System.EventHandler(this.buttonImportRemote_Click);
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.labelDatabase);
            this.groupBoxConnection.Controls.Add(this.textBoxDatabaseName);
            this.groupBoxConnection.Controls.Add(this.labelServerIP);
            this.groupBoxConnection.Controls.Add(this.textBoxPassword);
            this.groupBoxConnection.Controls.Add(this.labelPassword);
            this.groupBoxConnection.Controls.Add(this.textBoxServerIP);
            this.groupBoxConnection.Controls.Add(this.labelUser);
            this.groupBoxConnection.Controls.Add(this.textBoxUsername);
            this.groupBoxConnection.Location = new System.Drawing.Point(6, 6);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(278, 124);
            this.groupBoxConnection.TabIndex = 11;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "MySQL Server Connection";
            // 
            // labelDatabase
            // 
            this.labelDatabase.AutoSize = true;
            this.labelDatabase.Location = new System.Drawing.Point(6, 94);
            this.labelDatabase.Name = "labelDatabase";
            this.labelDatabase.Size = new System.Drawing.Size(56, 13);
            this.labelDatabase.TabIndex = 8;
            this.labelDatabase.Text = "Database:";
            // 
            // textBoxDatabaseName
            // 
            this.textBoxDatabaseName.Location = new System.Drawing.Point(80, 94);
            this.textBoxDatabaseName.Name = "textBoxDatabaseName";
            this.textBoxDatabaseName.Size = new System.Drawing.Size(189, 20);
            this.textBoxDatabaseName.TabIndex = 7;
            // 
            // labelServerIP
            // 
            this.labelServerIP.AutoSize = true;
            this.labelServerIP.Location = new System.Drawing.Point(6, 22);
            this.labelServerIP.Name = "labelServerIP";
            this.labelServerIP.Size = new System.Drawing.Size(54, 13);
            this.labelServerIP.TabIndex = 3;
            this.labelServerIP.Text = "Server IP:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(80, 68);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(189, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 71);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxServerIP
            // 
            this.textBoxServerIP.Location = new System.Drawing.Point(80, 19);
            this.textBoxServerIP.Name = "textBoxServerIP";
            this.textBoxServerIP.Size = new System.Drawing.Size(189, 20);
            this.textBoxServerIP.TabIndex = 0;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(6, 45);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(58, 13);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(80, 42);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(189, 20);
            this.textBoxUsername.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(291, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Local SQLite Library";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxExportPathLocal);
            this.groupBox1.Controls.Add(this.buttonExportSelectFileLocal);
            this.groupBox1.Controls.Add(this.buttonExportLocal);
            this.groupBox1.Location = new System.Drawing.Point(6, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 80);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export";
            // 
            // textBoxExportPathLocal
            // 
            this.textBoxExportPathLocal.Location = new System.Drawing.Point(6, 19);
            this.textBoxExportPathLocal.Name = "textBoxExportPathLocal";
            this.textBoxExportPathLocal.Size = new System.Drawing.Size(260, 20);
            this.textBoxExportPathLocal.TabIndex = 8;
            // 
            // buttonExportSelectFileLocal
            // 
            this.buttonExportSelectFileLocal.Location = new System.Drawing.Point(110, 45);
            this.buttonExportSelectFileLocal.Name = "buttonExportSelectFileLocal";
            this.buttonExportSelectFileLocal.Size = new System.Drawing.Size(75, 23);
            this.buttonExportSelectFileLocal.TabIndex = 5;
            this.buttonExportSelectFileLocal.Text = "Select File";
            this.buttonExportSelectFileLocal.UseVisualStyleBackColor = true;
            this.buttonExportSelectFileLocal.Click += new System.EventHandler(this.buttonExportSelectFileLocal_Click);
            // 
            // buttonExportLocal
            // 
            this.buttonExportLocal.Location = new System.Drawing.Point(191, 45);
            this.buttonExportLocal.Name = "buttonExportLocal";
            this.buttonExportLocal.Size = new System.Drawing.Size(75, 23);
            this.buttonExportLocal.TabIndex = 6;
            this.buttonExportLocal.Text = "Export";
            this.buttonExportLocal.UseVisualStyleBackColor = true;
            this.buttonExportLocal.Click += new System.EventHandler(this.buttonExportLocal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonImportSelectFileLocal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxImportPathLocal);
            this.groupBox2.Controls.Add(this.buttonImportLocal);
            this.groupBox2.Location = new System.Drawing.Point(6, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 97);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Import";
            // 
            // buttonImportSelectFileLocal
            // 
            this.buttonImportSelectFileLocal.Location = new System.Drawing.Point(113, 64);
            this.buttonImportSelectFileLocal.Name = "buttonImportSelectFileLocal";
            this.buttonImportSelectFileLocal.Size = new System.Drawing.Size(75, 23);
            this.buttonImportSelectFileLocal.TabIndex = 3;
            this.buttonImportSelectFileLocal.Text = "Select File";
            this.buttonImportSelectFileLocal.UseVisualStyleBackColor = true;
            this.buttonImportSelectFileLocal.Click += new System.EventHandler(this.buttonImportSelectFileLocal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "XML File Path:";
            // 
            // textBoxImportPathLocal
            // 
            this.textBoxImportPathLocal.Location = new System.Drawing.Point(6, 38);
            this.textBoxImportPathLocal.Name = "textBoxImportPathLocal";
            this.textBoxImportPathLocal.Size = new System.Drawing.Size(263, 20);
            this.textBoxImportPathLocal.TabIndex = 7;
            // 
            // buttonImportLocal
            // 
            this.buttonImportLocal.Location = new System.Drawing.Point(194, 64);
            this.buttonImportLocal.Name = "buttonImportLocal";
            this.buttonImportLocal.Size = new System.Drawing.Size(75, 23);
            this.buttonImportLocal.TabIndex = 4;
            this.buttonImportLocal.Text = "Import";
            this.buttonImportLocal.UseVisualStyleBackColor = true;
            this.buttonImportLocal.Click += new System.EventHandler(this.buttonImportLocal_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSelectLocalPath);
            this.groupBox3.Controls.Add(this.labelLocalPath);
            this.groupBox3.Controls.Add(this.textBoxLocalDBPath);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 102);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "XBMC Movie Database File Location";
            // 
            // buttonSelectLocalPath
            // 
            this.buttonSelectLocalPath.Location = new System.Drawing.Point(194, 73);
            this.buttonSelectLocalPath.Name = "buttonSelectLocalPath";
            this.buttonSelectLocalPath.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectLocalPath.TabIndex = 4;
            this.buttonSelectLocalPath.Text = "Select File";
            this.buttonSelectLocalPath.UseVisualStyleBackColor = true;
            this.buttonSelectLocalPath.Click += new System.EventHandler(this.buttonSelectLocalDBPath_Click);
            // 
            // labelLocalPath
            // 
            this.labelLocalPath.AutoSize = true;
            this.labelLocalPath.Location = new System.Drawing.Point(3, 16);
            this.labelLocalPath.Name = "labelLocalPath";
            this.labelLocalPath.Size = new System.Drawing.Size(32, 13);
            this.labelLocalPath.TabIndex = 3;
            this.labelLocalPath.Text = "Path:";
            // 
            // textBoxLocalDBPath
            // 
            this.textBoxLocalDBPath.Location = new System.Drawing.Point(3, 32);
            this.textBoxLocalDBPath.Name = "textBoxLocalDBPath";
            this.textBoxLocalDBPath.Size = new System.Drawing.Size(266, 20);
            this.textBoxLocalDBPath.TabIndex = 0;
            // 
            // backgroundWorkerImportLocal
            // 
            this.backgroundWorkerImportLocal.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerImportLocal_DoWork);
            this.backgroundWorkerImportLocal.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerImportLocal_RunWorkerCompleted);
            // 
            // backgroundWorkerExportLocal
            // 
            this.backgroundWorkerExportLocal.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerExportLocal_DoWork);
            this.backgroundWorkerExportLocal.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerExportLocal_RunWorkerCompleted);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 394);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "XBMC Watched Flag Helper 2.2";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxExport.ResumeLayout(false);
            this.groupBoxExport.PerformLayout();
            this.groupBoxImport.ResumeLayout(false);
            this.groupBoxImport.PerformLayout();
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxConnection.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerImportRemote;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerExportRemote;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBoxExport;
        private System.Windows.Forms.TextBox textBoxExportPathRemote;
        private System.Windows.Forms.Button buttonSelectFileExportRemote;
        private System.Windows.Forms.Button buttonExportRemote;
        private System.Windows.Forms.GroupBox groupBoxImport;
        private System.Windows.Forms.Button buttonSelectFileImportRemote;
        private System.Windows.Forms.Label labelImportPath;
        private System.Windows.Forms.TextBox textBoxImportPathRemote;
        private System.Windows.Forms.Button buttonImportRemote;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.Label labelServerIP;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxServerIP;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxExportPathLocal;
        private System.Windows.Forms.Button buttonExportSelectFileLocal;
        private System.Windows.Forms.Button buttonExportLocal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonImportSelectFileLocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImportPathLocal;
        private System.Windows.Forms.Button buttonImportLocal;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelLocalPath;
        private System.Windows.Forms.TextBox textBoxLocalDBPath;
        private System.Windows.Forms.Button buttonSelectLocalPath;
        private System.ComponentModel.BackgroundWorker backgroundWorkerImportLocal;
        private System.ComponentModel.BackgroundWorker backgroundWorkerExportLocal;
        private System.Windows.Forms.Label labelDatabase;
        private System.Windows.Forms.TextBox textBoxDatabaseName;
    }
}

