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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetParameters = new System.Windows.Forms.Button();
            this.btnGetPosition = new System.Windows.Forms.Button();
            this.btnSetIMEI = new System.Windows.Forms.Button();
            this.cbIMEI = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSetMonitor = new System.Windows.Forms.Button();
            this.btnSetSOS3 = new System.Windows.Forms.Button();
            this.cbMonitor = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbSOS3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSetSOS2 = new System.Windows.Forms.Button();
            this.cbSOS2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSetSOS1 = new System.Windows.Forms.Button();
            this.cbSOS1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSetAPN = new System.Windows.Forms.Button();
            this.cbAPN = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnSetCenterNumber = new System.Windows.Forms.Button();
            this.btnSetAssistantCenterNumber = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbCenterNumber = new System.Windows.Forms.TextBox();
            this.tbAssistantCenterNumber = new System.Windows.Forms.TextBox();
            this.btnSetTimeInterval = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tbUploadTimeInterval = new System.Windows.Forms.TextBox();
            this.btnGetVersion = new System.Windows.Forms.Button();
            this.btnResetDevice = new System.Windows.Forms.Button();
            this.btnRestoreFactorySettings = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.btnSetIPandPort = new System.Windows.Forms.Button();
            this.btnSetLanguageAndTimezone = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.cbTimezone = new System.Windows.Forms.ComboBox();
            this.cbSOSNumberToDelete = new System.Windows.Forms.ComboBox();
            this.btnDeleteSOSNumber = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceList
            // 
            this.deviceList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deviceList.FormattingEnabled = true;
            this.deviceList.ItemHeight = 16;
            this.deviceList.Location = new System.Drawing.Point(3, 47);
            this.deviceList.Margin = new System.Windows.Forms.Padding(4);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(247, 484);
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
            this.panel1.Location = new System.Drawing.Point(3, 539);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 217);
            this.panel1.TabIndex = 1;
            // 
            // txtLastComunication
            // 
            this.txtLastComunication.AutoSize = true;
            this.txtLastComunication.Location = new System.Drawing.Point(15, 164);
            this.txtLastComunication.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtLastComunication.Name = "txtLastComunication";
            this.txtLastComunication.Size = new System.Drawing.Size(152, 17);
            this.txtLastComunication.TabIndex = 7;
            this.txtLastComunication.Text = "Last Comunication: ND";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(76, 128);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(168, 28);
            this.progressBar1.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 134);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "GSM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 108);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "GPS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telephone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMEI:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnGetParameters);
            this.groupBox1.Controls.Add(this.btnGetPosition);
            this.groupBox1.Controls.Add(this.btnSetIMEI);
            this.groupBox1.Controls.Add(this.cbIMEI);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnSetMonitor);
            this.groupBox1.Controls.Add(this.btnSetSOS3);
            this.groupBox1.Controls.Add(this.cbMonitor);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbSOS3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSetSOS2);
            this.groupBox1.Controls.Add(this.cbSOS2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnSetSOS1);
            this.groupBox1.Controls.Add(this.cbSOS1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSetAPN);
            this.groupBox1.Controls.Add(this.cbAPN);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(260, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(385, 580);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Programmazione";
            // 
            // btnGetParameters
            // 
            this.btnGetParameters.Location = new System.Drawing.Point(11, 277);
            this.btnGetParameters.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetParameters.Name = "btnGetParameters";
            this.btnGetParameters.Size = new System.Drawing.Size(100, 28);
            this.btnGetParameters.TabIndex = 16;
            this.btnGetParameters.Text = "Parameters";
            this.btnGetParameters.UseVisualStyleBackColor = true;
            this.btnGetParameters.Click += new System.EventHandler(this.BtnGetParameters_Click);
            // 
            // btnGetPosition
            // 
            this.btnGetPosition.Location = new System.Drawing.Point(276, 274);
            this.btnGetPosition.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetPosition.Name = "btnGetPosition";
            this.btnGetPosition.Size = new System.Drawing.Size(100, 28);
            this.btnGetPosition.TabIndex = 15;
            this.btnGetPosition.Text = "Position";
            this.btnGetPosition.UseVisualStyleBackColor = true;
            this.btnGetPosition.Click += new System.EventHandler(this.btnGetPosition_Click);
            // 
            // btnSetIMEI
            // 
            this.btnSetIMEI.Location = new System.Drawing.Point(301, 228);
            this.btnSetIMEI.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetIMEI.Name = "btnSetIMEI";
            this.btnSetIMEI.Size = new System.Drawing.Size(73, 28);
            this.btnSetIMEI.TabIndex = 14;
            this.btnSetIMEI.Text = "Set";
            this.btnSetIMEI.UseVisualStyleBackColor = true;
            this.btnSetIMEI.Click += new System.EventHandler(this.btnSetIMEINumber_Click);
            // 
            // cbIMEI
            // 
            this.cbIMEI.FormattingEnabled = true;
            this.cbIMEI.Location = new System.Drawing.Point(77, 231);
            this.cbIMEI.Margin = new System.Windows.Forms.Padding(4);
            this.cbIMEI.Name = "cbIMEI";
            this.cbIMEI.Size = new System.Drawing.Size(216, 24);
            this.cbIMEI.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 234);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "IMEI:";
            // 
            // btnSetMonitor
            // 
            this.btnSetMonitor.Location = new System.Drawing.Point(301, 193);
            this.btnSetMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetMonitor.Name = "btnSetMonitor";
            this.btnSetMonitor.Size = new System.Drawing.Size(73, 28);
            this.btnSetMonitor.TabIndex = 8;
            this.btnSetMonitor.Text = "Set";
            this.btnSetMonitor.UseVisualStyleBackColor = true;
            this.btnSetMonitor.Click += new System.EventHandler(this.btnSetMonitorNumber_Click);
            // 
            // btnSetSOS3
            // 
            this.btnSetSOS3.Location = new System.Drawing.Point(303, 130);
            this.btnSetSOS3.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetSOS3.Name = "btnSetSOS3";
            this.btnSetSOS3.Size = new System.Drawing.Size(73, 28);
            this.btnSetSOS3.TabIndex = 11;
            this.btnSetSOS3.Text = "Set";
            this.btnSetSOS3.UseVisualStyleBackColor = true;
            this.btnSetSOS3.Click += new System.EventHandler(this.btnSetSOS3_Click);
            // 
            // cbMonitor
            // 
            this.cbMonitor.FormattingEnabled = true;
            this.cbMonitor.Location = new System.Drawing.Point(77, 199);
            this.cbMonitor.Margin = new System.Windows.Forms.Padding(4);
            this.cbMonitor.Name = "cbMonitor";
            this.cbMonitor.Size = new System.Drawing.Size(216, 24);
            this.cbMonitor.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 199);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Monitor:";
            // 
            // cbSOS3
            // 
            this.cbSOS3.FormattingEnabled = true;
            this.cbSOS3.Location = new System.Drawing.Point(77, 133);
            this.cbSOS3.Margin = new System.Windows.Forms.Padding(4);
            this.cbSOS3.Name = "cbSOS3";
            this.cbSOS3.Size = new System.Drawing.Size(216, 24);
            this.cbSOS3.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 140);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "SOS3:";
            // 
            // btnSetSOS2
            // 
            this.btnSetSOS2.Location = new System.Drawing.Point(303, 95);
            this.btnSetSOS2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetSOS2.Name = "btnSetSOS2";
            this.btnSetSOS2.Size = new System.Drawing.Size(73, 28);
            this.btnSetSOS2.TabIndex = 8;
            this.btnSetSOS2.Text = "Set";
            this.btnSetSOS2.UseVisualStyleBackColor = true;
            this.btnSetSOS2.Click += new System.EventHandler(this.btnSetSOS2_Click);
            // 
            // cbSOS2
            // 
            this.cbSOS2.FormattingEnabled = true;
            this.cbSOS2.Location = new System.Drawing.Point(77, 97);
            this.cbSOS2.Margin = new System.Windows.Forms.Padding(4);
            this.cbSOS2.Name = "cbSOS2";
            this.cbSOS2.Size = new System.Drawing.Size(216, 24);
            this.cbSOS2.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "SOS2:";
            // 
            // btnSetSOS1
            // 
            this.btnSetSOS1.Location = new System.Drawing.Point(303, 59);
            this.btnSetSOS1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetSOS1.Name = "btnSetSOS1";
            this.btnSetSOS1.Size = new System.Drawing.Size(73, 28);
            this.btnSetSOS1.TabIndex = 5;
            this.btnSetSOS1.Text = "Set";
            this.btnSetSOS1.UseVisualStyleBackColor = true;
            this.btnSetSOS1.Click += new System.EventHandler(this.btnSetSOS1_Click);
            // 
            // cbSOS1
            // 
            this.cbSOS1.FormattingEnabled = true;
            this.cbSOS1.Location = new System.Drawing.Point(77, 62);
            this.cbSOS1.Margin = new System.Windows.Forms.Padding(4);
            this.cbSOS1.Name = "cbSOS1";
            this.cbSOS1.Size = new System.Drawing.Size(216, 24);
            this.cbSOS1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "SOS1:";
            // 
            // btnSetAPN
            // 
            this.btnSetAPN.Location = new System.Drawing.Point(303, 25);
            this.btnSetAPN.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetAPN.Name = "btnSetAPN";
            this.btnSetAPN.Size = new System.Drawing.Size(73, 28);
            this.btnSetAPN.TabIndex = 2;
            this.btnSetAPN.Text = "Set";
            this.btnSetAPN.UseVisualStyleBackColor = true;
            this.btnSetAPN.Click += new System.EventHandler(this.btnSetAPN_Click);
            // 
            // cbAPN
            // 
            this.cbAPN.FormattingEnabled = true;
            this.cbAPN.Items.AddRange(new object[] {
            "internet.wind",
            "web.omnitel.it",
            "ibox.tim.it"});
            this.cbAPN.Location = new System.Drawing.Point(77, 27);
            this.cbAPN.Margin = new System.Windows.Forms.Padding(4);
            this.cbAPN.Name = "cbAPN";
            this.cbAPN.Size = new System.Drawing.Size(216, 24);
            this.cbAPN.TabIndex = 1;
            this.cbAPN.Text = "internet.wind";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "APN: ";
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(677, 47);
            this.webBrowser.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(637, 580);
            this.webBrowser.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(260, 634);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(1053, 121);
            this.txtLog.TabIndex = 4;
            // 
            // btnSetCenterNumber
            // 
            this.btnSetCenterNumber.Location = new System.Drawing.Point(563, 356);
            this.btnSetCenterNumber.Name = "btnSetCenterNumber";
            this.btnSetCenterNumber.Size = new System.Drawing.Size(75, 23);
            this.btnSetCenterNumber.TabIndex = 5;
            this.btnSetCenterNumber.Text = "Set";
            this.btnSetCenterNumber.UseVisualStyleBackColor = true;
            this.btnSetCenterNumber.Click += new System.EventHandler(this.btnSetCenterNumber_Click);
            // 
            // btnSetAssistantCenterNumber
            // 
            this.btnSetAssistantCenterNumber.Location = new System.Drawing.Point(563, 391);
            this.btnSetAssistantCenterNumber.Name = "btnSetAssistantCenterNumber";
            this.btnSetAssistantCenterNumber.Size = new System.Drawing.Size(75, 23);
            this.btnSetAssistantCenterNumber.TabIndex = 6;
            this.btnSetAssistantCenterNumber.Text = "Set";
            this.btnSetAssistantCenterNumber.UseVisualStyleBackColor = true;
            this.btnSetAssistantCenterNumber.Click += new System.EventHandler(this.btnSetAssistantCenterNumber_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(265, 356);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Center Number:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(269, 391);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Assistant Center Number:";
            // 
            // tbCenterNumber
            // 
            this.tbCenterNumber.Location = new System.Drawing.Point(386, 356);
            this.tbCenterNumber.Name = "tbCenterNumber";
            this.tbCenterNumber.Size = new System.Drawing.Size(167, 22);
            this.tbCenterNumber.TabIndex = 9;
            // 
            // tbAssistantCenterNumber
            // 
            this.tbAssistantCenterNumber.Location = new System.Drawing.Point(445, 388);
            this.tbAssistantCenterNumber.Name = "tbAssistantCenterNumber";
            this.tbAssistantCenterNumber.Size = new System.Drawing.Size(108, 22);
            this.tbAssistantCenterNumber.TabIndex = 10;
            // 
            // btnSetTimeInterval
            // 
            this.btnSetTimeInterval.Location = new System.Drawing.Point(563, 423);
            this.btnSetTimeInterval.Name = "btnSetTimeInterval";
            this.btnSetTimeInterval.Size = new System.Drawing.Size(75, 23);
            this.btnSetTimeInterval.TabIndex = 11;
            this.btnSetTimeInterval.Text = "Set";
            this.btnSetTimeInterval.UseVisualStyleBackColor = true;
            this.btnSetTimeInterval.Click += new System.EventHandler(this.btnSetUploadTimeInterval_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(272, 427);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Upload Time interval:";
            // 
            // tbUploadTimeInterval
            // 
            this.tbUploadTimeInterval.Location = new System.Drawing.Point(445, 424);
            this.tbUploadTimeInterval.Name = "tbUploadTimeInterval";
            this.tbUploadTimeInterval.Size = new System.Drawing.Size(108, 22);
            this.tbUploadTimeInterval.TabIndex = 13;
            // 
            // btnGetVersion
            // 
            this.btnGetVersion.Location = new System.Drawing.Point(272, 596);
            this.btnGetVersion.Name = "btnGetVersion";
            this.btnGetVersion.Size = new System.Drawing.Size(75, 23);
            this.btnGetVersion.TabIndex = 14;
            this.btnGetVersion.Text = "Version";
            this.btnGetVersion.UseVisualStyleBackColor = true;
            this.btnGetVersion.Click += new System.EventHandler(this.btnGetVersion_Click);
            // 
            // btnResetDevice
            // 
            this.btnResetDevice.Location = new System.Drawing.Point(353, 596);
            this.btnResetDevice.Name = "btnResetDevice";
            this.btnResetDevice.Size = new System.Drawing.Size(75, 23);
            this.btnResetDevice.TabIndex = 15;
            this.btnResetDevice.Text = "Reset Device";
            this.btnResetDevice.UseVisualStyleBackColor = true;
            this.btnResetDevice.Click += new System.EventHandler(this.btnResetDevice_Click);
            // 
            // btnRestoreFactorySettings
            // 
            this.btnRestoreFactorySettings.Location = new System.Drawing.Point(440, 596);
            this.btnRestoreFactorySettings.Name = "btnRestoreFactorySettings";
            this.btnRestoreFactorySettings.Size = new System.Drawing.Size(198, 23);
            this.btnRestoreFactorySettings.TabIndex = 16;
            this.btnRestoreFactorySettings.Text = "Restore Factory Settings";
            this.btnRestoreFactorySettings.UseVisualStyleBackColor = true;
            this.btnRestoreFactorySettings.Click += new System.EventHandler(this.btnRestoreFactorySettings_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(272, 462);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 17);
            this.label16.TabIndex = 17;
            this.label16.Text = "IP:";
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(337, 459);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(216, 22);
            this.tbIP.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(270, 491);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 17);
            this.label17.TabIndex = 19;
            this.label17.Text = "Port:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(337, 491);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(216, 22);
            this.tbPort.TabIndex = 20;
            // 
            // btnSetIPandPort
            // 
            this.btnSetIPandPort.Location = new System.Drawing.Point(563, 485);
            this.btnSetIPandPort.Name = "btnSetIPandPort";
            this.btnSetIPandPort.Size = new System.Drawing.Size(75, 23);
            this.btnSetIPandPort.TabIndex = 21;
            this.btnSetIPandPort.Text = "Set";
            this.btnSetIPandPort.UseVisualStyleBackColor = true;
            this.btnSetIPandPort.Click += new System.EventHandler(this.btnSetIPandPort_Click);
            // 
            // btnSetLanguageAndTimezone
            // 
            this.btnSetLanguageAndTimezone.Location = new System.Drawing.Point(563, 520);
            this.btnSetLanguageAndTimezone.Name = "btnSetLanguageAndTimezone";
            this.btnSetLanguageAndTimezone.Size = new System.Drawing.Size(75, 23);
            this.btnSetLanguageAndTimezone.TabIndex = 22;
            this.btnSetLanguageAndTimezone.Text = "Set";
            this.btnSetLanguageAndTimezone.UseVisualStyleBackColor = true;
            this.btnSetLanguageAndTimezone.Click += new System.EventHandler(this.btnSetLanguageAndTimezone_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(272, 526);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 17);
            this.label18.TabIndex = 23;
            this.label18.Text = "Language:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(419, 526);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 17);
            this.label19.TabIndex = 24;
            this.label19.Text = "Timezone:";
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(353, 520);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(52, 24);
            this.cbLanguage.TabIndex = 25;
            // 
            // cbTimezone
            // 
            this.cbTimezone.FormattingEnabled = true;
            this.cbTimezone.Location = new System.Drawing.Point(499, 519);
            this.cbTimezone.Name = "cbTimezone";
            this.cbTimezone.Size = new System.Drawing.Size(56, 24);
            this.cbTimezone.TabIndex = 26;
            // 
            // cbSOSNumberToDelete
            // 
            this.cbSOSNumberToDelete.FormattingEnabled = true;
            this.cbSOSNumberToDelete.Location = new System.Drawing.Point(275, 557);
            this.cbSOSNumberToDelete.Name = "cbSOSNumberToDelete";
            this.cbSOSNumberToDelete.Size = new System.Drawing.Size(53, 24);
            this.cbSOSNumberToDelete.TabIndex = 27;
            // 
            // btnDeleteSOSNumber
            // 
            this.btnDeleteSOSNumber.Location = new System.Drawing.Point(337, 557);
            this.btnDeleteSOSNumber.Name = "btnDeleteSOSNumber";
            this.btnDeleteSOSNumber.Size = new System.Drawing.Size(156, 23);
            this.btnDeleteSOSNumber.TabIndex = 28;
            this.btnDeleteSOSNumber.Text = "Delete SOS Number";
            this.btnDeleteSOSNumber.UseVisualStyleBackColor = true;
            this.btnDeleteSOSNumber.Click += new System.EventHandler(this.DeleteSOSNumber_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Set all the 3 SOS Numbers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSetThreeSOSNumbers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 759);
            this.Controls.Add(this.btnDeleteSOSNumber);
            this.Controls.Add(this.cbSOSNumberToDelete);
            this.Controls.Add(this.cbTimezone);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnSetLanguageAndTimezone);
            this.Controls.Add(this.btnSetIPandPort);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnRestoreFactorySettings);
            this.Controls.Add(this.btnResetDevice);
            this.Controls.Add(this.btnGetVersion);
            this.Controls.Add(this.tbUploadTimeInterval);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnSetTimeInterval);
            this.Controls.Add(this.tbAssistantCenterNumber);
            this.Controls.Add(this.tbCenterNumber);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSetAssistantCenterNumber);
            this.Controls.Add(this.btnSetCenterNumber);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deviceList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
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
    }
}

