namespace TrackerWatchServer
{
    partial class frmDevice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDevice));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSerial = new System.Windows.Forms.TextBox();
            this.tbTelephoneNumber = new System.Windows.Forms.TextBox();
            this.tbIMEI = new System.Windows.Forms.TextBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.rtbDeviceNotes = new System.Windows.Forms.RichTextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.boldToolStripMenuItemNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItemNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.leftAlignTextToolStripMenuItemNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.centerAlignTextToolStripMenuItemNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.formatListBullettedToolStripMenuItemNotes = new System.Windows.Forms.ToolStripMenuItem();
            this.characterDimensionToolStripComboBoxNotes = new System.Windows.Forms.ToolStripComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveDevice = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSOSNumber1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSOSNumber2 = new System.Windows.Forms.TextBox();
            this.tbSOSNumber3 = new System.Windows.Forms.TextBox();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thelephone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IMEI";
            // 
            // tbSerial
            // 
            this.tbSerial.Location = new System.Drawing.Point(28, 41);
            this.tbSerial.Name = "tbSerial";
            this.tbSerial.Size = new System.Drawing.Size(100, 20);
            this.tbSerial.TabIndex = 3;
            // 
            // tbTelephoneNumber
            // 
            this.tbTelephoneNumber.Location = new System.Drawing.Point(28, 96);
            this.tbTelephoneNumber.Name = "tbTelephoneNumber";
            this.tbTelephoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tbTelephoneNumber.TabIndex = 4;
            // 
            // tbIMEI
            // 
            this.tbIMEI.Location = new System.Drawing.Point(29, 145);
            this.tbIMEI.Name = "tbIMEI";
            this.tbIMEI.Size = new System.Drawing.Size(100, 20);
            this.tbIMEI.TabIndex = 5;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.rtbDeviceNotes);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(300, 360);
            this.toolStripContainer1.Location = new System.Drawing.Point(464, 41);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(300, 387);
            this.toolStripContainer1.TabIndex = 7;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip2);
            // 
            // rtbDeviceNotes
            // 
            this.rtbDeviceNotes.Location = new System.Drawing.Point(51, 124);
            this.rtbDeviceNotes.Name = "rtbDeviceNotes";
            this.rtbDeviceNotes.Size = new System.Drawing.Size(100, 96);
            this.rtbDeviceNotes.TabIndex = 0;
            this.rtbDeviceNotes.Text = "";
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
            this.menuStrip2.Size = new System.Drawing.Size(300, 27);
            this.menuStrip2.TabIndex = 19;
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Note";
            // 
            // btnSaveDevice
            // 
            this.btnSaveDevice.Location = new System.Drawing.Point(28, 405);
            this.btnSaveDevice.Name = "btnSaveDevice";
            this.btnSaveDevice.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDevice.TabIndex = 9;
            this.btnSaveDevice.Text = "Salva";
            this.btnSaveDevice.UseVisualStyleBackColor = true;
            this.btnSaveDevice.Click += new System.EventHandler(this.btnSaveDevice_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "SOS Number 1";
            // 
            // tbSOSNumber1
            // 
            this.tbSOSNumber1.Location = new System.Drawing.Point(28, 209);
            this.tbSOSNumber1.Name = "tbSOSNumber1";
            this.tbSOSNumber1.Size = new System.Drawing.Size(100, 20);
            this.tbSOSNumber1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "SOS Number 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "SOS Number 3";
            // 
            // tbSOSNumber2
            // 
            this.tbSOSNumber2.Location = new System.Drawing.Point(28, 258);
            this.tbSOSNumber2.Name = "tbSOSNumber2";
            this.tbSOSNumber2.Size = new System.Drawing.Size(100, 20);
            this.tbSOSNumber2.TabIndex = 14;
            // 
            // tbSOSNumber3
            // 
            this.tbSOSNumber3.Location = new System.Drawing.Point(28, 314);
            this.tbSOSNumber3.Name = "tbSOSNumber3";
            this.tbSOSNumber3.Size = new System.Drawing.Size(100, 20);
            this.tbSOSNumber3.TabIndex = 15;
            // 
            // frmDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 446);
            this.Controls.Add(this.tbSOSNumber3);
            this.Controls.Add(this.tbSOSNumber2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSOSNumber1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSaveDevice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.tbIMEI);
            this.Controls.Add(this.tbTelephoneNumber);
            this.Controls.Add(this.tbSerial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDevice";
            this.Text = "frmDevice";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSerial;
        private System.Windows.Forms.TextBox tbTelephoneNumber;
        private System.Windows.Forms.TextBox tbIMEI;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbDeviceNotes;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItemNotes;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItemNotes;
        private System.Windows.Forms.ToolStripMenuItem leftAlignTextToolStripMenuItemNotes;
        private System.Windows.Forms.ToolStripMenuItem centerAlignTextToolStripMenuItemNotes;
        private System.Windows.Forms.ToolStripMenuItem formatListBullettedToolStripMenuItemNotes;
        private System.Windows.Forms.ToolStripComboBox characterDimensionToolStripComboBoxNotes;
        private System.Windows.Forms.Button btnSaveDevice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSOSNumber1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSOSNumber2;
        private System.Windows.Forms.TextBox tbSOSNumber3;
    }
}