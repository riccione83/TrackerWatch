namespace TrackerWatchServer
{
    partial class Form1
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
            this.deviceList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLastComunication = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlProgrammazione = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteSOSNumber = new System.Windows.Forms.Button();
            this.btnGetParameters = new System.Windows.Forms.Button();
            this.cbSOSNumberToDelete = new System.Windows.Forms.ComboBox();
            this.btnGetPosition = new System.Windows.Forms.Button();
            this.cbTimezone = new System.Windows.Forms.ComboBox();
            this.btnSetIMEI = new System.Windows.Forms.Button();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.cbIMEI = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSetMonitor = new System.Windows.Forms.Button();
            this.btnSetLanguageAndTimezone = new System.Windows.Forms.Button();
            this.btnSetSOS3 = new System.Windows.Forms.Button();
            this.btnSetIPandPort = new System.Windows.Forms.Button();
            this.cbMonitor = new System.Windows.Forms.ComboBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbSOS3 = new System.Windows.Forms.ComboBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnSetSOS2 = new System.Windows.Forms.Button();
            this.btnRestoreFactorySettings = new System.Windows.Forms.Button();
            this.btnResetDevice = new System.Windows.Forms.Button();
            this.cbSOS2 = new System.Windows.Forms.ComboBox();
            this.btnGetVersion = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbUploadTimeInterval = new System.Windows.Forms.TextBox();
            this.btnSetSOS1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cbSOS1 = new System.Windows.Forms.ComboBox();
            this.btnSetTimeInterval = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSetAPN = new System.Windows.Forms.Button();
            this.btnSetAssistantCenterNumber = new System.Windows.Forms.Button();
            this.tbAssistantCenterNumber = new System.Windows.Forms.TextBox();
            this.cbAPN = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbCenterNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSetCenterNumber = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comunicazioneùToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPRSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlServer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.pnlProgrammazione.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceList
            // 
            this.deviceList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deviceList.FormattingEnabled = true;
            this.deviceList.Location = new System.Drawing.Point(2, 38);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(186, 394);
            this.deviceList.TabIndex = 0;
            this.deviceList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deviceList_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.txtLastComunication);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 438);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 176);
            this.panel1.TabIndex = 1;
            // 
            // txtLastComunication
            // 
            this.txtLastComunication.AutoSize = true;
            this.txtLastComunication.Location = new System.Drawing.Point(11, 133);
            this.txtLastComunication.Name = "txtLastComunication";
            this.txtLastComunication.Size = new System.Drawing.Size(116, 13);
            this.txtLastComunication.TabIndex = 7;
            this.txtLastComunication.Text = "Last Comunication: ND";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(57, 104);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(126, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "GSM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "GPS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telephone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMEI:";
            // 
            // pnlProgrammazione
            // 
            this.pnlProgrammazione.Controls.Add(this.button1);
            this.pnlProgrammazione.Controls.Add(this.btnDeleteSOSNumber);
            this.pnlProgrammazione.Controls.Add(this.btnGetParameters);
            this.pnlProgrammazione.Controls.Add(this.cbSOSNumberToDelete);
            this.pnlProgrammazione.Controls.Add(this.btnGetPosition);
            this.pnlProgrammazione.Controls.Add(this.cbTimezone);
            this.pnlProgrammazione.Controls.Add(this.btnSetIMEI);
            this.pnlProgrammazione.Controls.Add(this.cbLanguage);
            this.pnlProgrammazione.Controls.Add(this.cbIMEI);
            this.pnlProgrammazione.Controls.Add(this.label19);
            this.pnlProgrammazione.Controls.Add(this.label10);
            this.pnlProgrammazione.Controls.Add(this.label18);
            this.pnlProgrammazione.Controls.Add(this.btnSetMonitor);
            this.pnlProgrammazione.Controls.Add(this.btnSetLanguageAndTimezone);
            this.pnlProgrammazione.Controls.Add(this.btnSetSOS3);
            this.pnlProgrammazione.Controls.Add(this.btnSetIPandPort);
            this.pnlProgrammazione.Controls.Add(this.cbMonitor);
            this.pnlProgrammazione.Controls.Add(this.tbPort);
            this.pnlProgrammazione.Controls.Add(this.label9);
            this.pnlProgrammazione.Controls.Add(this.label17);
            this.pnlProgrammazione.Controls.Add(this.cbSOS3);
            this.pnlProgrammazione.Controls.Add(this.tbIP);
            this.pnlProgrammazione.Controls.Add(this.label8);
            this.pnlProgrammazione.Controls.Add(this.label16);
            this.pnlProgrammazione.Controls.Add(this.btnSetSOS2);
            this.pnlProgrammazione.Controls.Add(this.btnRestoreFactorySettings);
            this.pnlProgrammazione.Controls.Add(this.btnResetDevice);
            this.pnlProgrammazione.Controls.Add(this.cbSOS2);
            this.pnlProgrammazione.Controls.Add(this.btnGetVersion);
            this.pnlProgrammazione.Controls.Add(this.label7);
            this.pnlProgrammazione.Controls.Add(this.tbUploadTimeInterval);
            this.pnlProgrammazione.Controls.Add(this.btnSetSOS1);
            this.pnlProgrammazione.Controls.Add(this.label15);
            this.pnlProgrammazione.Controls.Add(this.cbSOS1);
            this.pnlProgrammazione.Controls.Add(this.btnSetTimeInterval);
            this.pnlProgrammazione.Controls.Add(this.label6);
            this.pnlProgrammazione.Controls.Add(this.btnSetAPN);
            this.pnlProgrammazione.Controls.Add(this.btnSetAssistantCenterNumber);
            this.pnlProgrammazione.Controls.Add(this.tbAssistantCenterNumber);
            this.pnlProgrammazione.Controls.Add(this.cbAPN);
            this.pnlProgrammazione.Controls.Add(this.label14);
            this.pnlProgrammazione.Controls.Add(this.tbCenterNumber);
            this.pnlProgrammazione.Controls.Add(this.label13);
            this.pnlProgrammazione.Controls.Add(this.btnSetCenterNumber);
            this.pnlProgrammazione.Controls.Add(this.label5);
            this.pnlProgrammazione.Location = new System.Drawing.Point(195, 38);
            this.pnlProgrammazione.Name = "pnlProgrammazione";
            this.pnlProgrammazione.Size = new System.Drawing.Size(289, 471);
            this.pnlProgrammazione.TabIndex = 2;
            this.pnlProgrammazione.TabStop = false;
            this.pnlProgrammazione.Text = "Programmazione";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 133);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 19);
            this.button1.TabIndex = 17;
            this.button1.Text = "Set all the 3 SOS Numbers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSetThreeSOSNumbers_Click);
            // 
            // btnDeleteSOSNumber
            // 
            this.btnDeleteSOSNumber.Location = new System.Drawing.Point(61, 415);
            this.btnDeleteSOSNumber.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSOSNumber.Name = "btnDeleteSOSNumber";
            this.btnDeleteSOSNumber.Size = new System.Drawing.Size(117, 19);
            this.btnDeleteSOSNumber.TabIndex = 28;
            this.btnDeleteSOSNumber.Text = "Delete SOS Number";
            this.btnDeleteSOSNumber.UseVisualStyleBackColor = true;
            this.btnDeleteSOSNumber.Click += new System.EventHandler(this.DeleteSOSNumber_Click);
            // 
            // btnGetParameters
            // 
            this.btnGetParameters.Location = new System.Drawing.Point(11, 225);
            this.btnGetParameters.Name = "btnGetParameters";
            this.btnGetParameters.Size = new System.Drawing.Size(75, 23);
            this.btnGetParameters.TabIndex = 16;
            this.btnGetParameters.Text = "Parameters";
            this.btnGetParameters.UseVisualStyleBackColor = true;
            this.btnGetParameters.Click += new System.EventHandler(this.BtnGetParameters_Click);
            // 
            // cbSOSNumberToDelete
            // 
            this.cbSOSNumberToDelete.FormattingEnabled = true;
            this.cbSOSNumberToDelete.Location = new System.Drawing.Point(14, 415);
            this.cbSOSNumberToDelete.Margin = new System.Windows.Forms.Padding(2);
            this.cbSOSNumberToDelete.Name = "cbSOSNumberToDelete";
            this.cbSOSNumberToDelete.Size = new System.Drawing.Size(41, 21);
            this.cbSOSNumberToDelete.TabIndex = 27;
            // 
            // btnGetPosition
            // 
            this.btnGetPosition.Location = new System.Drawing.Point(206, 223);
            this.btnGetPosition.Name = "btnGetPosition";
            this.btnGetPosition.Size = new System.Drawing.Size(75, 23);
            this.btnGetPosition.TabIndex = 15;
            this.btnGetPosition.Text = "Position";
            this.btnGetPosition.UseVisualStyleBackColor = true;
            this.btnGetPosition.Click += new System.EventHandler(this.btnGetPosition_Click);
            // 
            // cbTimezone
            // 
            this.cbTimezone.FormattingEnabled = true;
            this.cbTimezone.Location = new System.Drawing.Point(182, 384);
            this.cbTimezone.Margin = new System.Windows.Forms.Padding(2);
            this.cbTimezone.Name = "cbTimezone";
            this.cbTimezone.Size = new System.Drawing.Size(43, 21);
            this.cbTimezone.TabIndex = 26;
            // 
            // btnSetIMEI
            // 
            this.btnSetIMEI.Location = new System.Drawing.Point(226, 185);
            this.btnSetIMEI.Name = "btnSetIMEI";
            this.btnSetIMEI.Size = new System.Drawing.Size(55, 23);
            this.btnSetIMEI.TabIndex = 14;
            this.btnSetIMEI.Text = "Set";
            this.btnSetIMEI.UseVisualStyleBackColor = true;
            this.btnSetIMEI.Click += new System.EventHandler(this.btnSetIMEINumber_Click);
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(73, 384);
            this.cbLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(40, 21);
            this.cbLanguage.TabIndex = 25;
            // 
            // cbIMEI
            // 
            this.cbIMEI.FormattingEnabled = true;
            this.cbIMEI.Location = new System.Drawing.Point(58, 188);
            this.cbIMEI.Name = "cbIMEI";
            this.cbIMEI.Size = new System.Drawing.Size(163, 21);
            this.cbIMEI.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(122, 389);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Timezone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "IMEI:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 389);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Language:";
            // 
            // btnSetMonitor
            // 
            this.btnSetMonitor.Location = new System.Drawing.Point(226, 157);
            this.btnSetMonitor.Name = "btnSetMonitor";
            this.btnSetMonitor.Size = new System.Drawing.Size(55, 23);
            this.btnSetMonitor.TabIndex = 8;
            this.btnSetMonitor.Text = "Set";
            this.btnSetMonitor.UseVisualStyleBackColor = true;
            this.btnSetMonitor.Click += new System.EventHandler(this.btnSetMonitorNumber_Click);
            // 
            // btnSetLanguageAndTimezone
            // 
            this.btnSetLanguageAndTimezone.Location = new System.Drawing.Point(230, 384);
            this.btnSetLanguageAndTimezone.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetLanguageAndTimezone.Name = "btnSetLanguageAndTimezone";
            this.btnSetLanguageAndTimezone.Size = new System.Drawing.Size(56, 19);
            this.btnSetLanguageAndTimezone.TabIndex = 22;
            this.btnSetLanguageAndTimezone.Text = "Set";
            this.btnSetLanguageAndTimezone.UseVisualStyleBackColor = true;
            this.btnSetLanguageAndTimezone.Click += new System.EventHandler(this.btnSetLanguageAndTimezone_Click);
            // 
            // btnSetSOS3
            // 
            this.btnSetSOS3.Location = new System.Drawing.Point(227, 106);
            this.btnSetSOS3.Name = "btnSetSOS3";
            this.btnSetSOS3.Size = new System.Drawing.Size(55, 23);
            this.btnSetSOS3.TabIndex = 11;
            this.btnSetSOS3.Text = "Set";
            this.btnSetSOS3.UseVisualStyleBackColor = true;
            this.btnSetSOS3.Click += new System.EventHandler(this.btnSetSOS3_Click);
            // 
            // btnSetIPandPort
            // 
            this.btnSetIPandPort.Location = new System.Drawing.Point(230, 356);
            this.btnSetIPandPort.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetIPandPort.Name = "btnSetIPandPort";
            this.btnSetIPandPort.Size = new System.Drawing.Size(56, 19);
            this.btnSetIPandPort.TabIndex = 21;
            this.btnSetIPandPort.Text = "Set";
            this.btnSetIPandPort.UseVisualStyleBackColor = true;
            this.btnSetIPandPort.Click += new System.EventHandler(this.btnSetIPandPort_Click);
            // 
            // cbMonitor
            // 
            this.cbMonitor.FormattingEnabled = true;
            this.cbMonitor.Location = new System.Drawing.Point(58, 162);
            this.cbMonitor.Name = "cbMonitor";
            this.cbMonitor.Size = new System.Drawing.Size(163, 21);
            this.cbMonitor.TabIndex = 7;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(61, 361);
            this.tbPort.Margin = new System.Windows.Forms.Padding(2);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(163, 20);
            this.tbPort.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Monitor:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 361);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Port:";
            // 
            // cbSOS3
            // 
            this.cbSOS3.FormattingEnabled = true;
            this.cbSOS3.Location = new System.Drawing.Point(58, 108);
            this.cbSOS3.Name = "cbSOS3";
            this.cbSOS3.Size = new System.Drawing.Size(163, 21);
            this.cbSOS3.TabIndex = 10;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(61, 335);
            this.tbIP.Margin = new System.Windows.Forms.Padding(2);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(163, 20);
            this.tbIP.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "SOS3:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 337);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "IP:";
            // 
            // btnSetSOS2
            // 
            this.btnSetSOS2.Location = new System.Drawing.Point(227, 77);
            this.btnSetSOS2.Name = "btnSetSOS2";
            this.btnSetSOS2.Size = new System.Drawing.Size(55, 23);
            this.btnSetSOS2.TabIndex = 8;
            this.btnSetSOS2.Text = "Set";
            this.btnSetSOS2.UseVisualStyleBackColor = true;
            this.btnSetSOS2.Click += new System.EventHandler(this.btnSetSOS2_Click);
            // 
            // btnRestoreFactorySettings
            // 
            this.btnRestoreFactorySettings.Location = new System.Drawing.Point(138, 446);
            this.btnRestoreFactorySettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestoreFactorySettings.Name = "btnRestoreFactorySettings";
            this.btnRestoreFactorySettings.Size = new System.Drawing.Size(148, 19);
            this.btnRestoreFactorySettings.TabIndex = 16;
            this.btnRestoreFactorySettings.Text = "Restore Factory Settings";
            this.btnRestoreFactorySettings.UseVisualStyleBackColor = true;
            this.btnRestoreFactorySettings.Click += new System.EventHandler(this.btnRestoreFactorySettings_Click);
            // 
            // btnResetDevice
            // 
            this.btnResetDevice.Location = new System.Drawing.Point(73, 446);
            this.btnResetDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetDevice.Name = "btnResetDevice";
            this.btnResetDevice.Size = new System.Drawing.Size(56, 19);
            this.btnResetDevice.TabIndex = 15;
            this.btnResetDevice.Text = "Reset Device";
            this.btnResetDevice.UseVisualStyleBackColor = true;
            this.btnResetDevice.Click += new System.EventHandler(this.btnResetDevice_Click);
            // 
            // cbSOS2
            // 
            this.cbSOS2.FormattingEnabled = true;
            this.cbSOS2.Location = new System.Drawing.Point(58, 79);
            this.cbSOS2.Name = "cbSOS2";
            this.cbSOS2.Size = new System.Drawing.Size(163, 21);
            this.cbSOS2.TabIndex = 7;
            // 
            // btnGetVersion
            // 
            this.btnGetVersion.Location = new System.Drawing.Point(12, 446);
            this.btnGetVersion.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetVersion.Name = "btnGetVersion";
            this.btnGetVersion.Size = new System.Drawing.Size(56, 19);
            this.btnGetVersion.TabIndex = 14;
            this.btnGetVersion.Text = "Version";
            this.btnGetVersion.UseVisualStyleBackColor = true;
            this.btnGetVersion.Click += new System.EventHandler(this.btnGetVersion_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "SOS2:";
            // 
            // tbUploadTimeInterval
            // 
            this.tbUploadTimeInterval.Location = new System.Drawing.Point(142, 306);
            this.tbUploadTimeInterval.Margin = new System.Windows.Forms.Padding(2);
            this.tbUploadTimeInterval.Name = "tbUploadTimeInterval";
            this.tbUploadTimeInterval.Size = new System.Drawing.Size(82, 20);
            this.tbUploadTimeInterval.TabIndex = 13;
            // 
            // btnSetSOS1
            // 
            this.btnSetSOS1.Location = new System.Drawing.Point(227, 48);
            this.btnSetSOS1.Name = "btnSetSOS1";
            this.btnSetSOS1.Size = new System.Drawing.Size(55, 23);
            this.btnSetSOS1.TabIndex = 5;
            this.btnSetSOS1.Text = "Set";
            this.btnSetSOS1.UseVisualStyleBackColor = true;
            this.btnSetSOS1.Click += new System.EventHandler(this.btnSetSOS1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 309);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Upload Time interval:";
            // 
            // cbSOS1
            // 
            this.cbSOS1.FormattingEnabled = true;
            this.cbSOS1.Location = new System.Drawing.Point(58, 50);
            this.cbSOS1.Name = "cbSOS1";
            this.cbSOS1.Size = new System.Drawing.Size(163, 21);
            this.cbSOS1.TabIndex = 4;
            // 
            // btnSetTimeInterval
            // 
            this.btnSetTimeInterval.Location = new System.Drawing.Point(230, 306);
            this.btnSetTimeInterval.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetTimeInterval.Name = "btnSetTimeInterval";
            this.btnSetTimeInterval.Size = new System.Drawing.Size(56, 19);
            this.btnSetTimeInterval.TabIndex = 11;
            this.btnSetTimeInterval.Text = "Set";
            this.btnSetTimeInterval.UseVisualStyleBackColor = true;
            this.btnSetTimeInterval.Click += new System.EventHandler(this.btnSetUploadTimeInterval_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "SOS1:";
            // 
            // btnSetAPN
            // 
            this.btnSetAPN.Location = new System.Drawing.Point(227, 20);
            this.btnSetAPN.Name = "btnSetAPN";
            this.btnSetAPN.Size = new System.Drawing.Size(55, 23);
            this.btnSetAPN.TabIndex = 2;
            this.btnSetAPN.Text = "Set";
            this.btnSetAPN.UseVisualStyleBackColor = true;
            this.btnSetAPN.Click += new System.EventHandler(this.btnSetAPN_Click);
            // 
            // btnSetAssistantCenterNumber
            // 
            this.btnSetAssistantCenterNumber.Location = new System.Drawing.Point(228, 280);
            this.btnSetAssistantCenterNumber.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetAssistantCenterNumber.Name = "btnSetAssistantCenterNumber";
            this.btnSetAssistantCenterNumber.Size = new System.Drawing.Size(56, 19);
            this.btnSetAssistantCenterNumber.TabIndex = 6;
            this.btnSetAssistantCenterNumber.Text = "Set";
            this.btnSetAssistantCenterNumber.UseVisualStyleBackColor = true;
            this.btnSetAssistantCenterNumber.Click += new System.EventHandler(this.btnSetAssistantCenterNumber_Click);
            // 
            // tbAssistantCenterNumber
            // 
            this.tbAssistantCenterNumber.Location = new System.Drawing.Point(138, 277);
            this.tbAssistantCenterNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbAssistantCenterNumber.Name = "tbAssistantCenterNumber";
            this.tbAssistantCenterNumber.Size = new System.Drawing.Size(82, 20);
            this.tbAssistantCenterNumber.TabIndex = 10;
            // 
            // cbAPN
            // 
            this.cbAPN.FormattingEnabled = true;
            this.cbAPN.Items.AddRange(new object[] {
            "internet.wind",
            "web.omnitel.it",
            "ibox.tim.it"});
            this.cbAPN.Location = new System.Drawing.Point(58, 22);
            this.cbAPN.Name = "cbAPN";
            this.cbAPN.Size = new System.Drawing.Size(163, 21);
            this.cbAPN.TabIndex = 1;
            this.cbAPN.Text = "internet.wind";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 280);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Assistant Center Number:";
            // 
            // tbCenterNumber
            // 
            this.tbCenterNumber.Location = new System.Drawing.Point(96, 250);
            this.tbCenterNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbCenterNumber.Name = "tbCenterNumber";
            this.tbCenterNumber.Size = new System.Drawing.Size(126, 20);
            this.tbCenterNumber.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 251);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Center Number:";
            // 
            // btnSetCenterNumber
            // 
            this.btnSetCenterNumber.Location = new System.Drawing.Point(227, 251);
            this.btnSetCenterNumber.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetCenterNumber.Name = "btnSetCenterNumber";
            this.btnSetCenterNumber.Size = new System.Drawing.Size(56, 19);
            this.btnSetCenterNumber.TabIndex = 5;
            this.btnSetCenterNumber.Text = "Set";
            this.btnSetCenterNumber.UseVisualStyleBackColor = true;
            this.btnSetCenterNumber.Click += new System.EventHandler(this.btnSetCenterNumber_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "APN: ";
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(508, 38);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(478, 471);
            this.webBrowser.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(195, 515);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(791, 99);
            this.txtLog.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comunicazioneùToolStripMenuItem,
            this.azioniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // comunicazioneùToolStripMenuItem
            // 
            this.comunicazioneùToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gPRSToolStripMenuItem,
            this.sMSToolStripMenuItem});
            this.comunicazioneùToolStripMenuItem.Name = "comunicazioneùToolStripMenuItem";
            this.comunicazioneùToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.comunicazioneùToolStripMenuItem.Text = "&Comunicazione";
            this.comunicazioneùToolStripMenuItem.Click += new System.EventHandler(this.comunicazioneToolStripMenuItem_Click);
            // 
            // gPRSToolStripMenuItem
            // 
            this.gPRSToolStripMenuItem.Checked = true;
            this.gPRSToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gPRSToolStripMenuItem.Name = "gPRSToolStripMenuItem";
            this.gPRSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.gPRSToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.gPRSToolStripMenuItem.Text = "&GPRS";
            this.gPRSToolStripMenuItem.Click += new System.EventHandler(this.gPRSToolStripMenuItem_Click);
            // 
            // sMSToolStripMenuItem
            // 
            this.sMSToolStripMenuItem.Name = "sMSToolStripMenuItem";
            this.sMSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.sMSToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.sMSToolStripMenuItem.Text = "&SMS";
            this.sMSToolStripMenuItem.Click += new System.EventHandler(this.sMSToolStripMenuItem_Click);
            // 
            // azioniToolStripMenuItem
            // 
            this.azioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmazioneToolStripMenuItem,
            this.serverToolStripMenuItem});
            this.azioniToolStripMenuItem.Name = "azioniToolStripMenuItem";
            this.azioniToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.azioniToolStripMenuItem.Text = "Visualizza";
            this.azioniToolStripMenuItem.Click += new System.EventHandler(this.azioniToolStripMenuItem_Click);
            // 
            // programmazioneToolStripMenuItem
            // 
            this.programmazioneToolStripMenuItem.Name = "programmazioneToolStripMenuItem";
            this.programmazioneToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.programmazioneToolStripMenuItem.Text = "Programmazione";
            this.programmazioneToolStripMenuItem.Click += new System.EventHandler(this.programmazioneToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.serverToolStripMenuItem.Text = "Server";
            this.serverToolStripMenuItem.Click += new System.EventHandler(this.serverToolStripMenuItem_Click);
            // 
            // pnlServer
            // 
            this.pnlServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlServer.Controls.Add(this.flowLayoutPanel1);
            this.pnlServer.Location = new System.Drawing.Point(195, 38);
            this.pnlServer.Name = "pnlServer";
            this.pnlServer.Size = new System.Drawing.Size(791, 471);
            this.pnlServer.TabIndex = 30;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(769, 442);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 617);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.pnlProgrammazione);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deviceList);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlServer);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SereSitter - 2858 Security";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlProgrammazione.ResumeLayout(false);
            this.pnlProgrammazione.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlServer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox deviceList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox pnlProgrammazione;
        private System.Windows.Forms.Button btnSetAPN;
        private System.Windows.Forms.ComboBox cbAPN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSetSOS3;
        private System.Windows.Forms.ComboBox cbSOS3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSetSOS2;
        private System.Windows.Forms.ComboBox cbSOS2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSetSOS1;
        private System.Windows.Forms.ComboBox cbSOS1;
        private System.Windows.Forms.Button btnSetMonitor;
        private System.Windows.Forms.ComboBox cbMonitor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSetIMEI;
        private System.Windows.Forms.ComboBox cbIMEI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGetPosition;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnGetParameters;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txtLastComunication;
        private System.Windows.Forms.Button btnSetCenterNumber;
        private System.Windows.Forms.Button btnSetAssistantCenterNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbCenterNumber;
        private System.Windows.Forms.TextBox tbAssistantCenterNumber;
        private System.Windows.Forms.Button btnSetTimeInterval;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbUploadTimeInterval;
        private System.Windows.Forms.Button btnGetVersion;
        private System.Windows.Forms.Button btnResetDevice;
        private System.Windows.Forms.Button btnRestoreFactorySettings;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button btnSetIPandPort;
        private System.Windows.Forms.Button btnSetLanguageAndTimezone;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.ComboBox cbTimezone;
        private System.Windows.Forms.ComboBox cbSOSNumberToDelete;
        private System.Windows.Forms.Button btnDeleteSOSNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem comunicazioneùToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gPRSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sMSToolStripMenuItem;
        private System.Windows.Forms.Panel pnlServer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem azioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programmazioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
    }
}

