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
            this.components = new System.ComponentModel.Container();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnGetParameters = new System.Windows.Forms.Button();
            this.cbSOS3 = new System.Windows.Forms.ComboBox();
            this.btnGetPosition = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.btnDeleteSOSNumber = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbSOSNumberToDelete = new System.Windows.Forms.ComboBox();
            this.cbAPN = new System.Windows.Forms.ComboBox();
            this.btnSetIPandPort = new System.Windows.Forms.Button();
            this.btnSetAPN = new System.Windows.Forms.Button();
            this.cbTimezone = new System.Windows.Forms.ComboBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSOS1 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.btnSetSOS1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cbSOS2 = new System.Windows.Forms.ComboBox();
            this.btnSetSOS2 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSetSOS3 = new System.Windows.Forms.Button();
            this.btnSetLanguageAndTimezone = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRestoreFactorySettings = new System.Windows.Forms.Button();
            this.btnResetDevice = new System.Windows.Forms.Button();
            this.btnSetIMEI = new System.Windows.Forms.Button();
            this.btnGetVersion = new System.Windows.Forms.Button();
            this.btnSetCenterNumber = new System.Windows.Forms.Button();
            this.cbIMEI = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCenterNumber = new System.Windows.Forms.TextBox();
            this.btnSetMonitor = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cbMonitor = new System.Windows.Forms.ComboBox();
            this.tbAssistantCenterNumber = new System.Windows.Forms.TextBox();
            this.btnSetAssistantCenterNumber = new System.Windows.Forms.Button();
            this.btnSetTimeInterval = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tbUploadTimeInterval = new System.Windows.Forms.TextBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.comunicazioneùToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPRSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sMSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetModemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.azioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programmazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.alarmCenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlServer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.qualitàSegnaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancellaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.pnlProgrammazione.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlServer.SuspendLayout();
            this.logMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // deviceList
            // 
            this.deviceList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deviceList.FormattingEnabled = true;
            this.deviceList.Location = new System.Drawing.Point(2, 38);
            this.deviceList.Name = "deviceList";
            this.deviceList.Size = new System.Drawing.Size(222, 394);
            this.deviceList.TabIndex = 0;
            this.deviceList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deviceList_MouseClick);
            this.deviceList.SelectedIndexChanged += new System.EventHandler(this.deviceList_SelectedIndexChanged);
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
            this.panel1.Size = new System.Drawing.Size(222, 176);
            this.panel1.TabIndex = 1;
            // 
            // txtLastComunication
            // 
            this.txtLastComunication.AutoSize = true;
            this.txtLastComunication.Location = new System.Drawing.Point(11, 142);
            this.txtLastComunication.Name = "txtLastComunication";
            this.txtLastComunication.Size = new System.Drawing.Size(116, 13);
            this.txtLastComunication.TabIndex = 7;
            this.txtLastComunication.Text = "Last Comunication: ND";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(57, 116);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(151, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "GSM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "GPS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telephone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Serial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IMEI:";
            // 
            // pnlProgrammazione
            // 
            this.pnlProgrammazione.Controls.Add(this.tabControl1);
            this.pnlProgrammazione.Location = new System.Drawing.Point(234, 38);
            this.pnlProgrammazione.Name = "pnlProgrammazione";
            this.pnlProgrammazione.Size = new System.Drawing.Size(293, 471);
            this.pnlProgrammazione.TabIndex = 2;
            this.pnlProgrammazione.TabStop = false;
            this.pnlProgrammazione.Text = "Programmazione";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(290, 449);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage1.Controls.Add(this.btnGetParameters);
            this.tabPage1.Controls.Add(this.cbSOS3);
            this.tabPage1.Controls.Add(this.btnGetPosition);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.btnDeleteSOSNumber);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cbSOSNumberToDelete);
            this.tabPage1.Controls.Add(this.cbAPN);
            this.tabPage1.Controls.Add(this.btnSetIPandPort);
            this.tabPage1.Controls.Add(this.btnSetAPN);
            this.tabPage1.Controls.Add(this.cbTimezone);
            this.tabPage1.Controls.Add(this.tbPort);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cbSOS1);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.cbLanguage);
            this.tabPage1.Controls.Add(this.tbIP);
            this.tabPage1.Controls.Add(this.btnSetSOS1);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.cbSOS2);
            this.tabPage1.Controls.Add(this.btnSetSOS2);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnSetSOS3);
            this.tabPage1.Controls.Add(this.btnSetLanguageAndTimezone);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(282, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Config";
            // 
            // btnGetParameters
            // 
            this.btnGetParameters.Location = new System.Drawing.Point(6, 383);
            this.btnGetParameters.Name = "btnGetParameters";
            this.btnGetParameters.Size = new System.Drawing.Size(75, 34);
            this.btnGetParameters.TabIndex = 16;
            this.btnGetParameters.Text = "Get Parameters";
            this.btnGetParameters.UseVisualStyleBackColor = true;
            this.btnGetParameters.Click += new System.EventHandler(this.BtnGetParameters_Click);
            // 
            // cbSOS3
            // 
            this.cbSOS3.FormattingEnabled = true;
            this.cbSOS3.Location = new System.Drawing.Point(50, 106);
            this.cbSOS3.Name = "cbSOS3";
            this.cbSOS3.Size = new System.Drawing.Size(163, 21);
            this.cbSOS3.TabIndex = 10;
            // 
            // btnGetPosition
            // 
            this.btnGetPosition.Location = new System.Drawing.Point(199, 383);
            this.btnGetPosition.Name = "btnGetPosition";
            this.btnGetPosition.Size = new System.Drawing.Size(75, 34);
            this.btnGetPosition.TabIndex = 15;
            this.btnGetPosition.Text = "Get Position";
            this.btnGetPosition.UseVisualStyleBackColor = true;
            this.btnGetPosition.Click += new System.EventHandler(this.btnGetPosition_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(3, 192);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(116, 13);
            this.label20.TabIndex = 29;
            this.label20.Text = "SOS Position to delete:";
            // 
            // btnDeleteSOSNumber
            // 
            this.btnDeleteSOSNumber.Location = new System.Drawing.Point(221, 189);
            this.btnDeleteSOSNumber.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteSOSNumber.Name = "btnDeleteSOSNumber";
            this.btnDeleteSOSNumber.Size = new System.Drawing.Size(55, 21);
            this.btnDeleteSOSNumber.TabIndex = 28;
            this.btnDeleteSOSNumber.Text = "Delete";
            this.btnDeleteSOSNumber.UseVisualStyleBackColor = true;
            this.btnDeleteSOSNumber.Click += new System.EventHandler(this.DeleteSOSNumber_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "APN: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 141);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Set All SOS Numbers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSetThreeSOSNumbers_Click);
            // 
            // cbSOSNumberToDelete
            // 
            this.cbSOSNumberToDelete.FormattingEnabled = true;
            this.cbSOSNumberToDelete.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbSOSNumberToDelete.Location = new System.Drawing.Point(125, 189);
            this.cbSOSNumberToDelete.Margin = new System.Windows.Forms.Padding(2);
            this.cbSOSNumberToDelete.Name = "cbSOSNumberToDelete";
            this.cbSOSNumberToDelete.Size = new System.Drawing.Size(90, 21);
            this.cbSOSNumberToDelete.TabIndex = 27;
            // 
            // cbAPN
            // 
            this.cbAPN.FormattingEnabled = true;
            this.cbAPN.Items.AddRange(new object[] {
            "internet.wind",
            "web.omnitel.it",
            "ibox.tim.it"});
            this.cbAPN.Location = new System.Drawing.Point(50, 22);
            this.cbAPN.Name = "cbAPN";
            this.cbAPN.Size = new System.Drawing.Size(163, 21);
            this.cbAPN.TabIndex = 1;
            this.cbAPN.Text = "internet.wind";
            // 
            // btnSetIPandPort
            // 
            this.btnSetIPandPort.Location = new System.Drawing.Point(220, 275);
            this.btnSetIPandPort.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetIPandPort.Name = "btnSetIPandPort";
            this.btnSetIPandPort.Size = new System.Drawing.Size(56, 20);
            this.btnSetIPandPort.TabIndex = 21;
            this.btnSetIPandPort.Text = "Set";
            this.btnSetIPandPort.UseVisualStyleBackColor = true;
            this.btnSetIPandPort.Click += new System.EventHandler(this.btnSetIPandPort_Click);
            // 
            // btnSetAPN
            // 
            this.btnSetAPN.Location = new System.Drawing.Point(221, 20);
            this.btnSetAPN.Name = "btnSetAPN";
            this.btnSetAPN.Size = new System.Drawing.Size(55, 23);
            this.btnSetAPN.TabIndex = 2;
            this.btnSetAPN.Text = "Set";
            this.btnSetAPN.UseVisualStyleBackColor = true;
            this.btnSetAPN.Click += new System.EventHandler(this.btnSetAPN_Click);
            // 
            // cbTimezone
            // 
            this.cbTimezone.FormattingEnabled = true;
            this.cbTimezone.Items.AddRange(new object[] {
            "-12",
            "-11",
            "-10",
            "-9",
            "-8",
            "-7",
            "-6",
            "-5",
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbTimezone.Location = new System.Drawing.Point(172, 228);
            this.cbTimezone.Margin = new System.Windows.Forms.Padding(2);
            this.cbTimezone.Name = "cbTimezone";
            this.cbTimezone.Size = new System.Drawing.Size(43, 21);
            this.cbTimezone.TabIndex = 26;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(176, 275);
            this.tbPort.Margin = new System.Windows.Forms.Padding(2);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(39, 20);
            this.tbPort.TabIndex = 20;
            this.tbPort.Text = "8001";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "SOS1:";
            // 
            // cbSOS1
            // 
            this.cbSOS1.FormattingEnabled = true;
            this.cbSOS1.Location = new System.Drawing.Point(50, 50);
            this.cbSOS1.Name = "cbSOS1";
            this.cbSOS1.Size = new System.Drawing.Size(163, 21);
            this.cbSOS1.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(149, 278);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "Port:";
            // 
            // cbLanguage
            // 
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbLanguage.Location = new System.Drawing.Point(67, 228);
            this.cbLanguage.Margin = new System.Windows.Forms.Padding(2);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(48, 21);
            this.cbLanguage.TabIndex = 25;
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(48, 275);
            this.tbIP.Margin = new System.Windows.Forms.Padding(2);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(97, 20);
            this.tbIP.TabIndex = 18;
            // 
            // btnSetSOS1
            // 
            this.btnSetSOS1.Location = new System.Drawing.Point(221, 48);
            this.btnSetSOS1.Name = "btnSetSOS1";
            this.btnSetSOS1.Size = new System.Drawing.Size(55, 23);
            this.btnSetSOS1.TabIndex = 5;
            this.btnSetSOS1.Text = "Set";
            this.btnSetSOS1.UseVisualStyleBackColor = true;
            this.btnSetSOS1.Click += new System.EventHandler(this.btnSetSOS1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 278);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "IP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "SOS2:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(119, 233);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 24;
            this.label19.Text = "Timezone:";
            // 
            // cbSOS2
            // 
            this.cbSOS2.FormattingEnabled = true;
            this.cbSOS2.Location = new System.Drawing.Point(50, 78);
            this.cbSOS2.Name = "cbSOS2";
            this.cbSOS2.Size = new System.Drawing.Size(163, 21);
            this.cbSOS2.TabIndex = 7;
            // 
            // btnSetSOS2
            // 
            this.btnSetSOS2.Location = new System.Drawing.Point(221, 76);
            this.btnSetSOS2.Name = "btnSetSOS2";
            this.btnSetSOS2.Size = new System.Drawing.Size(55, 23);
            this.btnSetSOS2.TabIndex = 8;
            this.btnSetSOS2.Text = "Set";
            this.btnSetSOS2.UseVisualStyleBackColor = true;
            this.btnSetSOS2.Click += new System.EventHandler(this.btnSetSOS2_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 231);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Language:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "SOS3:";
            // 
            // btnSetSOS3
            // 
            this.btnSetSOS3.Location = new System.Drawing.Point(221, 104);
            this.btnSetSOS3.Name = "btnSetSOS3";
            this.btnSetSOS3.Size = new System.Drawing.Size(55, 23);
            this.btnSetSOS3.TabIndex = 11;
            this.btnSetSOS3.Text = "Set";
            this.btnSetSOS3.UseVisualStyleBackColor = true;
            this.btnSetSOS3.Click += new System.EventHandler(this.btnSetSOS3_Click);
            // 
            // btnSetLanguageAndTimezone
            // 
            this.btnSetLanguageAndTimezone.Location = new System.Drawing.Point(220, 228);
            this.btnSetLanguageAndTimezone.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetLanguageAndTimezone.Name = "btnSetLanguageAndTimezone";
            this.btnSetLanguageAndTimezone.Size = new System.Drawing.Size(56, 21);
            this.btnSetLanguageAndTimezone.TabIndex = 22;
            this.btnSetLanguageAndTimezone.Text = "Set";
            this.btnSetLanguageAndTimezone.UseVisualStyleBackColor = true;
            this.btnSetLanguageAndTimezone.Click += new System.EventHandler(this.btnSetLanguageAndTimezone_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.btnRestoreFactorySettings);
            this.tabPage2.Controls.Add(this.btnResetDevice);
            this.tabPage2.Controls.Add(this.btnSetIMEI);
            this.tabPage2.Controls.Add(this.btnGetVersion);
            this.tabPage2.Controls.Add(this.btnSetCenterNumber);
            this.tabPage2.Controls.Add(this.cbIMEI);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbCenterNumber);
            this.tabPage2.Controls.Add(this.btnSetMonitor);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.cbMonitor);
            this.tabPage2.Controls.Add(this.tbAssistantCenterNumber);
            this.tabPage2.Controls.Add(this.btnSetAssistantCenterNumber);
            this.tabPage2.Controls.Add(this.btnSetTimeInterval);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.tbUploadTimeInterval);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(282, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced Config";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Monitor:";
            // 
            // btnRestoreFactorySettings
            // 
            this.btnRestoreFactorySettings.Location = new System.Drawing.Point(169, 384);
            this.btnRestoreFactorySettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestoreFactorySettings.Name = "btnRestoreFactorySettings";
            this.btnRestoreFactorySettings.Size = new System.Drawing.Size(107, 34);
            this.btnRestoreFactorySettings.TabIndex = 16;
            this.btnRestoreFactorySettings.Text = "Restore Factory Settings";
            this.btnRestoreFactorySettings.UseVisualStyleBackColor = true;
            this.btnRestoreFactorySettings.Click += new System.EventHandler(this.btnRestoreFactorySettings_Click);
            // 
            // btnResetDevice
            // 
            this.btnResetDevice.Location = new System.Drawing.Point(85, 384);
            this.btnResetDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetDevice.Name = "btnResetDevice";
            this.btnResetDevice.Size = new System.Drawing.Size(80, 34);
            this.btnResetDevice.TabIndex = 15;
            this.btnResetDevice.Text = "Reset Device";
            this.btnResetDevice.UseVisualStyleBackColor = true;
            this.btnResetDevice.Click += new System.EventHandler(this.btnResetDevice_Click);
            // 
            // btnSetIMEI
            // 
            this.btnSetIMEI.Location = new System.Drawing.Point(223, 54);
            this.btnSetIMEI.Name = "btnSetIMEI";
            this.btnSetIMEI.Size = new System.Drawing.Size(55, 23);
            this.btnSetIMEI.TabIndex = 14;
            this.btnSetIMEI.Text = "Set";
            this.btnSetIMEI.UseVisualStyleBackColor = true;
            this.btnSetIMEI.Click += new System.EventHandler(this.btnSetIMEINumber_Click);
            // 
            // btnGetVersion
            // 
            this.btnGetVersion.Location = new System.Drawing.Point(5, 384);
            this.btnGetVersion.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetVersion.Name = "btnGetVersion";
            this.btnGetVersion.Size = new System.Drawing.Size(76, 33);
            this.btnGetVersion.TabIndex = 14;
            this.btnGetVersion.Text = "Version";
            this.btnGetVersion.UseVisualStyleBackColor = true;
            this.btnGetVersion.Click += new System.EventHandler(this.btnGetVersion_Click);
            // 
            // btnSetCenterNumber
            // 
            this.btnSetCenterNumber.Location = new System.Drawing.Point(222, 92);
            this.btnSetCenterNumber.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetCenterNumber.Name = "btnSetCenterNumber";
            this.btnSetCenterNumber.Size = new System.Drawing.Size(56, 23);
            this.btnSetCenterNumber.TabIndex = 5;
            this.btnSetCenterNumber.Text = "Set";
            this.btnSetCenterNumber.UseVisualStyleBackColor = true;
            this.btnSetCenterNumber.Click += new System.EventHandler(this.btnSetCenterNumber_Click);
            // 
            // cbIMEI
            // 
            this.cbIMEI.FormattingEnabled = true;
            this.cbIMEI.Location = new System.Drawing.Point(52, 56);
            this.cbIMEI.Name = "cbIMEI";
            this.cbIMEI.Size = new System.Drawing.Size(166, 21);
            this.cbIMEI.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 94);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Center Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "IMEI:";
            // 
            // tbCenterNumber
            // 
            this.tbCenterNumber.Location = new System.Drawing.Point(133, 94);
            this.tbCenterNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbCenterNumber.Name = "tbCenterNumber";
            this.tbCenterNumber.Size = new System.Drawing.Size(85, 20);
            this.tbCenterNumber.TabIndex = 9;
            // 
            // btnSetMonitor
            // 
            this.btnSetMonitor.Location = new System.Drawing.Point(223, 16);
            this.btnSetMonitor.Name = "btnSetMonitor";
            this.btnSetMonitor.Size = new System.Drawing.Size(55, 23);
            this.btnSetMonitor.TabIndex = 8;
            this.btnSetMonitor.Text = "Set";
            this.btnSetMonitor.UseVisualStyleBackColor = true;
            this.btnSetMonitor.Click += new System.EventHandler(this.btnSetMonitorNumber_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 132);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Assistant Center Number:";
            // 
            // cbMonitor
            // 
            this.cbMonitor.FormattingEnabled = true;
            this.cbMonitor.Location = new System.Drawing.Point(52, 18);
            this.cbMonitor.Name = "cbMonitor";
            this.cbMonitor.Size = new System.Drawing.Size(166, 21);
            this.cbMonitor.TabIndex = 7;
            // 
            // tbAssistantCenterNumber
            // 
            this.tbAssistantCenterNumber.Location = new System.Drawing.Point(133, 132);
            this.tbAssistantCenterNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbAssistantCenterNumber.Name = "tbAssistantCenterNumber";
            this.tbAssistantCenterNumber.Size = new System.Drawing.Size(85, 20);
            this.tbAssistantCenterNumber.TabIndex = 10;
            // 
            // btnSetAssistantCenterNumber
            // 
            this.btnSetAssistantCenterNumber.Location = new System.Drawing.Point(222, 130);
            this.btnSetAssistantCenterNumber.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetAssistantCenterNumber.Name = "btnSetAssistantCenterNumber";
            this.btnSetAssistantCenterNumber.Size = new System.Drawing.Size(56, 23);
            this.btnSetAssistantCenterNumber.TabIndex = 6;
            this.btnSetAssistantCenterNumber.Text = "Set";
            this.btnSetAssistantCenterNumber.UseVisualStyleBackColor = true;
            this.btnSetAssistantCenterNumber.Click += new System.EventHandler(this.btnSetAssistantCenterNumber_Click);
            // 
            // btnSetTimeInterval
            // 
            this.btnSetTimeInterval.Location = new System.Drawing.Point(222, 168);
            this.btnSetTimeInterval.Margin = new System.Windows.Forms.Padding(2);
            this.btnSetTimeInterval.Name = "btnSetTimeInterval";
            this.btnSetTimeInterval.Size = new System.Drawing.Size(56, 23);
            this.btnSetTimeInterval.TabIndex = 11;
            this.btnSetTimeInterval.Text = "Set";
            this.btnSetTimeInterval.UseVisualStyleBackColor = true;
            this.btnSetTimeInterval.Click += new System.EventHandler(this.btnSetUploadTimeInterval_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 173);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Upload Time interval:";
            // 
            // tbUploadTimeInterval
            // 
            this.tbUploadTimeInterval.Location = new System.Drawing.Point(133, 170);
            this.tbUploadTimeInterval.Margin = new System.Windows.Forms.Padding(2);
            this.tbUploadTimeInterval.Name = "tbUploadTimeInterval";
            this.tbUploadTimeInterval.Size = new System.Drawing.Size(85, 20);
            this.tbUploadTimeInterval.TabIndex = 13;
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(530, 41);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(456, 468);
            this.webBrowser.TabIndex = 3;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.ContextMenuStrip = this.logMenuStrip;
            this.txtLog.Location = new System.Drawing.Point(230, 515);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(756, 99);
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
            this.sMSToolStripMenuItem,
            this.toolStripMenuItem2,
            this.resetModemToolStripMenuItem,
            this.qualitàSegnaleToolStripMenuItem});
            this.comunicazioneùToolStripMenuItem.Name = "comunicazioneùToolStripMenuItem";
            this.comunicazioneùToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.comunicazioneùToolStripMenuItem.Text = "&Comunicazione";
            this.comunicazioneùToolStripMenuItem.Click += new System.EventHandler(this.comunicazioneToolStripMenuItem_Click);
            // 
            // gPRSToolStripMenuItem
            // 
            this.gPRSToolStripMenuItem.Name = "gPRSToolStripMenuItem";
            this.gPRSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.gPRSToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.gPRSToolStripMenuItem.Text = "&GPRS";
            this.gPRSToolStripMenuItem.Click += new System.EventHandler(this.gPRSToolStripMenuItem_Click);
            // 
            // sMSToolStripMenuItem
            // 
            this.sMSToolStripMenuItem.Checked = true;
            this.sMSToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sMSToolStripMenuItem.Name = "sMSToolStripMenuItem";
            this.sMSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.sMSToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.sMSToolStripMenuItem.Text = "&SMS";
            this.sMSToolStripMenuItem.Click += new System.EventHandler(this.sMSToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(153, 6);
            // 
            // resetModemToolStripMenuItem
            // 
            this.resetModemToolStripMenuItem.Name = "resetModemToolStripMenuItem";
            this.resetModemToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.resetModemToolStripMenuItem.Text = "Reset Modem";
            this.resetModemToolStripMenuItem.Click += new System.EventHandler(this.resetModemToolStripMenuItem_Click);
            // 
            // azioniToolStripMenuItem
            // 
            this.azioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmazioneToolStripMenuItem,
            this.serverToolStripMenuItem,
            this.toolStripMenuItem1,
            this.alarmCenterToolStripMenuItem});
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 6);
            // 
            // alarmCenterToolStripMenuItem
            // 
            this.alarmCenterToolStripMenuItem.Name = "alarmCenterToolStripMenuItem";
            this.alarmCenterToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.alarmCenterToolStripMenuItem.Text = "Alarm Center";
            this.alarmCenterToolStripMenuItem.Click += new System.EventHandler(this.alarmCenterToolStripMenuItem_Click);
            // 
            // pnlServer
            // 
            this.pnlServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlServer.Controls.Add(this.flowLayoutPanel1);
            this.pnlServer.Location = new System.Drawing.Point(230, 38);
            this.pnlServer.Name = "pnlServer";
            this.pnlServer.Size = new System.Drawing.Size(756, 471);
            this.pnlServer.TabIndex = 30;
            this.pnlServer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlServer_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(734, 442);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // qualitàSegnaleToolStripMenuItem
            // 
            this.qualitàSegnaleToolStripMenuItem.Name = "qualitàSegnaleToolStripMenuItem";
            this.qualitàSegnaleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.qualitàSegnaleToolStripMenuItem.Text = "Qualità Segnale";
            this.qualitàSegnaleToolStripMenuItem.Click += new System.EventHandler(this.qualitàSegnaleToolStripMenuItem_Click);
            // 
            // logMenuStrip
            // 
            this.logMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancellaToolStripMenuItem});
            this.logMenuStrip.Name = "logMenuStrip";
            this.logMenuStrip.Size = new System.Drawing.Size(153, 48);
            // 
            // cancellaToolStripMenuItem
            // 
            this.cancellaToolStripMenuItem.Name = "cancellaToolStripMenuItem";
            this.cancellaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancellaToolStripMenuItem.Text = "Cancella";
            this.cancellaToolStripMenuItem.Click += new System.EventHandler(this.cancellaToolStripMenuItem_Click);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlServer.ResumeLayout(false);
            this.logMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alarmCenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem resetModemToolStripMenuItem;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem qualitàSegnaleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip logMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cancellaToolStripMenuItem;
    }
}

