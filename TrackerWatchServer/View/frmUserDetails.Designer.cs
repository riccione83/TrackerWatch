namespace TrackerWatchServer
{
    partial class frmUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.cbProvinces = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCAP = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.rtbContacts = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.boldToolStripMenuItemContacts = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItemContacts = new System.Windows.Forms.ToolStripMenuItem();
            this.leftAlignTextToolStripMenuItemContacts = new System.Windows.Forms.ToolStripMenuItem();
            this.centerAlignTextToolStripMenuItemContacts = new System.Windows.Forms.ToolStripMenuItem();
            this.formatListBullettedToolStripMenuItemContacts = new System.Windows.Forms.ToolStripMenuItem();
            this.characterDimensionToolStripComboBoxContacts = new System.Windows.Forms.ToolStripComboBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.boldToolStripMenuItemNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItemNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.leftAlignTextToolStripMenuItemNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.centerAlignTextToolStripMenuItemNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.formatListBullettedToolStripMenuItemNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.characterDimensionToolStripComboBoxNotes = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominativo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Indirizzo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Città";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contatti";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(678, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Note";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(33, 36);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(274, 20);
            this.tbName.TabIndex = 5;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(33, 91);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(274, 20);
            this.tbAddress.TabIndex = 6;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(33, 148);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(274, 20);
            this.tbCity.TabIndex = 7;
            // 
            // cbProvinces
            // 
            this.cbProvinces.FormattingEnabled = true;
            this.cbProvinces.Items.AddRange(new object[] {
            "AG",
            "AL",
            "AN",
            "AO",
            "AQ",
            "AR",
            "AP",
            "AT",
            "AV",
            "BA",
            "BT",
            "BL",
            "BN",
            "BG",
            "BI",
            "BO",
            "BZ",
            "BS",
            "BR",
            "CA",
            "CL",
            "CB",
            "CI",
            "CE",
            "CT",
            "CZ",
            "CH",
            "CO",
            "CS",
            "CR",
            "KR",
            "CN",
            "EN",
            "FM",
            "FE",
            "FI",
            "FG",
            "FC",
            "FR",
            "GE",
            "GO",
            "GR",
            "IM",
            "IS",
            "SP",
            "LT",
            "LE",
            "LC",
            "LI",
            "LO",
            "LU",
            "MC",
            "MN",
            "MS",
            "MT",
            "VS",
            "ME",
            "MI",
            "MO",
            "MB",
            "NA",
            "NO",
            "NU",
            "OG",
            "OT",
            "OR",
            "PD",
            "PA",
            "PR",
            "PV",
            "PG",
            "PU",
            "PE",
            "PC",
            "PI",
            "PT",
            "PN",
            "PZ",
            "PO",
            "RG",
            "RA",
            "RC",
            "RE",
            "RI",
            "RN",
            "RM",
            "RO",
            "SA",
            "SSW",
            "SV",
            "SI",
            "SR",
            "SO",
            "TA",
            "TE",
            "TR",
            "TO",
            "TP",
            "TN",
            "TV",
            "TS",
            "UD",
            "AO",
            "VA",
            "VE",
            "VB",
            "VC",
            "VR",
            "VV",
            "VI",
            "VT"});
            this.cbProvinces.Location = new System.Drawing.Point(33, 202);
            this.cbProvinces.Name = "cbProvinces";
            this.cbProvinces.Size = new System.Drawing.Size(62, 21);
            this.cbProvinces.TabIndex = 10;
            this.cbProvinces.Text = "CT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Provincia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "CAP";
            // 
            // tbCAP
            // 
            this.tbCAP.Location = new System.Drawing.Point(112, 203);
            this.tbCAP.Name = "tbCAP";
            this.tbCAP.Size = new System.Drawing.Size(76, 20);
            this.tbCAP.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(33, 464);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Salva";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Location = new System.Drawing.Point(136, 464);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(131, 23);
            this.btnAddDevice.TabIndex = 15;
            this.btnAddDevice.Text = "Associa dispositivo";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.rtbContacts);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(306, 388);
            this.toolStripContainer1.Location = new System.Drawing.Point(343, 36);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(306, 415);
            this.toolStripContainer1.TabIndex = 16;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            // 
            // rtbContacts
            // 
            this.rtbContacts.Location = new System.Drawing.Point(51, 0);
            this.rtbContacts.Name = "rtbContacts";
            this.rtbContacts.Size = new System.Drawing.Size(255, 388);
            this.rtbContacts.TabIndex = 0;
            this.rtbContacts.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripMenuItemContacts,
            this.italicToolStripMenuItemContacts,
            this.leftAlignTextToolStripMenuItemContacts,
            this.centerAlignTextToolStripMenuItemContacts,
            this.formatListBullettedToolStripMenuItemContacts,
            this.characterDimensionToolStripComboBoxContacts});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(306, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // boldToolStripMenuItemContacts
            // 
            this.boldToolStripMenuItemContacts.Image = ((System.Drawing.Image)(resources.GetObject("boldToolStripMenuItemContacts.Image")));
            this.boldToolStripMenuItemContacts.ImageTransparentColor = System.Drawing.Color.White;
            this.boldToolStripMenuItemContacts.Name = "boldToolStripMenuItemContacts";
            this.boldToolStripMenuItemContacts.Size = new System.Drawing.Size(28, 23);
            this.boldToolStripMenuItemContacts.ToolTipText = "Grassetto";
            this.boldToolStripMenuItemContacts.Click += new System.EventHandler(this.boldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItemContacts
            // 
            this.italicToolStripMenuItemContacts.Image = ((System.Drawing.Image)(resources.GetObject("italicToolStripMenuItemContacts.Image")));
            this.italicToolStripMenuItemContacts.Name = "italicToolStripMenuItemContacts";
            this.italicToolStripMenuItemContacts.Size = new System.Drawing.Size(28, 23);
            this.italicToolStripMenuItemContacts.ToolTipText = "Corsivo";
            this.italicToolStripMenuItemContacts.Click += new System.EventHandler(this.italicToolStripMenuItemContacts_Click);
            // 
            // leftAlignTextToolStripMenuItemContacts
            // 
            this.leftAlignTextToolStripMenuItemContacts.Image = ((System.Drawing.Image)(resources.GetObject("leftAlignTextToolStripMenuItemContacts.Image")));
            this.leftAlignTextToolStripMenuItemContacts.Name = "leftAlignTextToolStripMenuItemContacts";
            this.leftAlignTextToolStripMenuItemContacts.Size = new System.Drawing.Size(28, 23);
            this.leftAlignTextToolStripMenuItemContacts.Click += new System.EventHandler(this.leftAlignTextToolStripMenuItem_Click);
            // 
            // centerAlignTextToolStripMenuItemContacts
            // 
            this.centerAlignTextToolStripMenuItemContacts.Image = ((System.Drawing.Image)(resources.GetObject("centerAlignTextToolStripMenuItemContacts.Image")));
            this.centerAlignTextToolStripMenuItemContacts.Name = "centerAlignTextToolStripMenuItemContacts";
            this.centerAlignTextToolStripMenuItemContacts.Size = new System.Drawing.Size(28, 23);
            this.centerAlignTextToolStripMenuItemContacts.Click += new System.EventHandler(this.centerAlignTextToolStripMenuItem_Click);
            // 
            // formatListBullettedToolStripMenuItemContacts
            // 
            this.formatListBullettedToolStripMenuItemContacts.Image = ((System.Drawing.Image)(resources.GetObject("formatListBullettedToolStripMenuItemContacts.Image")));
            this.formatListBullettedToolStripMenuItemContacts.Name = "formatListBullettedToolStripMenuItemContacts";
            this.formatListBullettedToolStripMenuItemContacts.Size = new System.Drawing.Size(28, 23);
            this.formatListBullettedToolStripMenuItemContacts.Click += new System.EventHandler(this.formatListBullettedToolStripMenuItem_Click);
            // 
            // characterDimensionToolStripComboBoxContacts
            // 
            this.characterDimensionToolStripComboBoxContacts.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "32",
            "40",
            "48"});
            this.characterDimensionToolStripComboBoxContacts.Name = "characterDimensionToolStripComboBoxContacts";
            this.characterDimensionToolStripComboBoxContacts.Size = new System.Drawing.Size(121, 23);
            this.characterDimensionToolStripComboBoxContacts.Text = "12";
            this.characterDimensionToolStripComboBoxContacts.SelectedIndexChanged += new System.EventHandler(this.characterDimensionToolStripComboBoxContacts_SelectedIndexChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripMenuItemNotes,
            this.italicToolStripMenuItemNotes,
            this.leftAlignTextToolStripMenuItemNotes,
            this.centerAlignTextToolStripMenuItemNotes,
            this.formatListBullettedToolStripMenuItemNotes,
            this.characterDimensionToolStripComboBoxNotes});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip2.Size = new System.Drawing.Size(307, 27);
            this.menuStrip2.TabIndex = 18;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // boldToolStripMenuItemNotes
            // 
            this.boldToolStripMenuItemNotes.Image = ((System.Drawing.Image)(resources.GetObject("boldToolStripMenuItemNotes.Image")));
            this.boldToolStripMenuItemNotes.ImageTransparentColor = System.Drawing.Color.White;
            this.boldToolStripMenuItemNotes.Name = "boldToolStripMenuItemNotes";
            this.boldToolStripMenuItemNotes.Size = new System.Drawing.Size(28, 23);
            this.boldToolStripMenuItemNotes.ToolTipText = "Grassetto";
            this.boldToolStripMenuItemNotes.Click += new System.EventHandler(this.boldToolStripMenuItemNotes_Click);
            // 
            // italicToolStripMenuItemNotes
            // 
            this.italicToolStripMenuItemNotes.Image = ((System.Drawing.Image)(resources.GetObject("italicToolStripMenuItemNotes.Image")));
            this.italicToolStripMenuItemNotes.Name = "italicToolStripMenuItemNotes";
            this.italicToolStripMenuItemNotes.Size = new System.Drawing.Size(28, 23);
            this.italicToolStripMenuItemNotes.ToolTipText = "Corsivo";
            this.italicToolStripMenuItemNotes.Click += new System.EventHandler(this.italicToolStripMenuItemNotes_Click);
            // 
            // leftAlignTextToolStripMenuItemNotes
            // 
            this.leftAlignTextToolStripMenuItemNotes.Image = ((System.Drawing.Image)(resources.GetObject("leftAlignTextToolStripMenuItemNotes.Image")));
            this.leftAlignTextToolStripMenuItemNotes.Name = "leftAlignTextToolStripMenuItemNotes";
            this.leftAlignTextToolStripMenuItemNotes.Size = new System.Drawing.Size(28, 23);
            this.leftAlignTextToolStripMenuItemNotes.Click += new System.EventHandler(this.leftAlignTextToolStripMenuItemNotes_Click);
            // 
            // centerAlignTextToolStripMenuItemNotes
            // 
            this.centerAlignTextToolStripMenuItemNotes.Image = ((System.Drawing.Image)(resources.GetObject("centerAlignTextToolStripMenuItemNotes.Image")));
            this.centerAlignTextToolStripMenuItemNotes.Name = "centerAlignTextToolStripMenuItemNotes";
            this.centerAlignTextToolStripMenuItemNotes.Size = new System.Drawing.Size(28, 23);
            this.centerAlignTextToolStripMenuItemNotes.Click += new System.EventHandler(this.centerAlignTextToolStripMenuItemNotes_Click);
            // 
            // formatListBullettedToolStripMenuItemNotes
            // 
            this.formatListBullettedToolStripMenuItemNotes.Image = ((System.Drawing.Image)(resources.GetObject("formatListBullettedToolStripMenuItemNotes.Image")));
            this.formatListBullettedToolStripMenuItemNotes.Name = "formatListBullettedToolStripMenuItemNotes";
            this.formatListBullettedToolStripMenuItemNotes.Size = new System.Drawing.Size(28, 23);
            this.formatListBullettedToolStripMenuItemNotes.Click += new System.EventHandler(this.formatListBullettedToolStripMenuItemNotes_Click);
            // 
            // characterDimensionToolStripComboBoxNotes
            // 
            this.characterDimensionToolStripComboBoxNotes.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "32",
            "40",
            "48"});
            this.characterDimensionToolStripComboBoxNotes.Name = "characterDimensionToolStripComboBoxNotes";
            this.characterDimensionToolStripComboBoxNotes.Size = new System.Drawing.Size(121, 23);
            this.characterDimensionToolStripComboBoxNotes.Text = "12";
            this.characterDimensionToolStripComboBoxNotes.SelectedIndexChanged += new System.EventHandler(this.characterDimensionToolStripComboBoxNotes_SelectedIndexChanged);
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.toolStripContainer2.ContentPanel.Controls.Add(this.rtbNotes);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(307, 388);
            this.toolStripContainer2.Location = new System.Drawing.Point(681, 36);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(307, 415);
            this.toolStripContainer2.TabIndex = 19;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.menuStrip2);
            // 
            // rtbNotes
            // 
            this.rtbNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotes.Location = new System.Drawing.Point(0, 0);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(307, 388);
            this.rtbNotes.TabIndex = 0;
            this.rtbNotes.Text = "";
            // 
            // frmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 518);
            this.Controls.Add(this.toolStripContainer2);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.btnAddDevice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbCAP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbProvinces);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUserDetails";
            this.Text = "Dettagli Utente";
            this.Load += new System.EventHandler(this.frmUserDetails_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.ComboBox cbProvinces;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCAP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.RichTextBox rtbContacts;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItemContacts;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItemContacts;
        private System.Windows.Forms.ToolStripMenuItem leftAlignTextToolStripMenuItemContacts;
        private System.Windows.Forms.ToolStripMenuItem centerAlignTextToolStripMenuItemContacts;
        private System.Windows.Forms.ToolStripComboBox characterDimensionToolStripComboBoxContacts;
        private System.Windows.Forms.ToolStripMenuItem formatListBullettedToolStripMenuItemContacts;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItemNotes;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItemNotes;
        private System.Windows.Forms.ToolStripMenuItem leftAlignTextToolStripMenuItemNotes;
        private System.Windows.Forms.ToolStripMenuItem centerAlignTextToolStripMenuItemNotes;
        private System.Windows.Forms.ToolStripMenuItem formatListBullettedToolStripMenuItemNotes;
        private System.Windows.Forms.ToolStripComboBox characterDimensionToolStripComboBoxNotes;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.RichTextBox rtbNotes;
    }
}