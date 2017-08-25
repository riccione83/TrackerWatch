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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lIMEI = new System.Windows.Forms.Label();
            this.tbSerial = new System.Windows.Forms.TextBox();
            this.tbTelephoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveDevice = new System.Windows.Forms.Button();
            this.lsos1 = new System.Windows.Forms.Label();
            this.lsos2 = new System.Windows.Forms.Label();
            this.lsos3 = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.lCenterNumber = new System.Windows.Forms.Label();
            this.lSlaveNumber = new System.Windows.Forms.Label();
            this.lIP = new System.Windows.Forms.Label();
            this.lPorta = new System.Windows.Forms.Label();
            this.lLevelBattery = new System.Windows.Forms.Label();
            this.btnGetParametersTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seriale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero di telefono";
            // 
            // lIMEI
            // 
            this.lIMEI.AutoSize = true;
            this.lIMEI.Location = new System.Drawing.Point(25, 192);
            this.lIMEI.Name = "lIMEI";
            this.lIMEI.Size = new System.Drawing.Size(29, 13);
            this.lIMEI.TabIndex = 2;
            this.lIMEI.Text = "IMEI";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Note";
            // 
            // btnSaveDevice
            // 
            this.btnSaveDevice.Location = new System.Drawing.Point(305, 411);
            this.btnSaveDevice.Name = "btnSaveDevice";
            this.btnSaveDevice.Size = new System.Drawing.Size(75, 23);
            this.btnSaveDevice.TabIndex = 9;
            this.btnSaveDevice.Text = "Salva";
            this.btnSaveDevice.UseVisualStyleBackColor = true;
            this.btnSaveDevice.Click += new System.EventHandler(this.btnSaveDevice_Click);
            // 
            // lsos1
            // 
            this.lsos1.AutoSize = true;
            this.lsos1.Location = new System.Drawing.Point(25, 215);
            this.lsos1.Name = "lsos1";
            this.lsos1.Size = new System.Drawing.Size(78, 13);
            this.lsos1.TabIndex = 10;
            this.lsos1.Text = "SOS Number 1";
            // 
            // lsos2
            // 
            this.lsos2.AutoSize = true;
            this.lsos2.Location = new System.Drawing.Point(25, 238);
            this.lsos2.Name = "lsos2";
            this.lsos2.Size = new System.Drawing.Size(78, 13);
            this.lsos2.TabIndex = 12;
            this.lsos2.Text = "SOS Number 2";
            // 
            // lsos3
            // 
            this.lsos3.AutoSize = true;
            this.lsos3.Location = new System.Drawing.Point(25, 262);
            this.lsos3.Name = "lsos3";
            this.lsos3.Size = new System.Drawing.Size(78, 13);
            this.lsos3.TabIndex = 13;
            this.lsos3.Text = "SOS Number 3";
            // 
            // tbUserID
            // 
            this.tbUserID.Location = new System.Drawing.Point(28, 149);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(100, 20);
            this.tbUserID.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID utente";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(192, 41);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(188, 128);
            this.tbNotes.TabIndex = 18;
            // 
            // lCenterNumber
            // 
            this.lCenterNumber.AutoSize = true;
            this.lCenterNumber.Location = new System.Drawing.Point(25, 285);
            this.lCenterNumber.Name = "lCenterNumber";
            this.lCenterNumber.Size = new System.Drawing.Size(85, 13);
            this.lCenterNumber.TabIndex = 19;
            this.lCenterNumber.Text = "Numero centrale";
            // 
            // lSlaveNumber
            // 
            this.lSlaveNumber.AutoSize = true;
            this.lSlaveNumber.Location = new System.Drawing.Point(25, 309);
            this.lSlaveNumber.Name = "lSlaveNumber";
            this.lSlaveNumber.Size = new System.Drawing.Size(72, 13);
            this.lSlaveNumber.TabIndex = 20;
            this.lSlaveNumber.Text = "Numero slave";
            // 
            // lIP
            // 
            this.lIP.AutoSize = true;
            this.lIP.Location = new System.Drawing.Point(25, 332);
            this.lIP.Name = "lIP";
            this.lIP.Size = new System.Drawing.Size(17, 13);
            this.lIP.TabIndex = 21;
            this.lIP.Text = "IP";
            // 
            // lPorta
            // 
            this.lPorta.AutoSize = true;
            this.lPorta.Location = new System.Drawing.Point(25, 354);
            this.lPorta.Name = "lPorta";
            this.lPorta.Size = new System.Drawing.Size(32, 13);
            this.lPorta.TabIndex = 22;
            this.lPorta.Text = "Porta";
            // 
            // lLevelBattery
            // 
            this.lLevelBattery.AutoSize = true;
            this.lLevelBattery.Location = new System.Drawing.Point(25, 376);
            this.lLevelBattery.Name = "lLevelBattery";
            this.lLevelBattery.Size = new System.Drawing.Size(76, 13);
            this.lLevelBattery.TabIndex = 23;
            this.lLevelBattery.Text = "Livello Batteria";
            // 
            // btnGetParametersTest
            // 
            this.btnGetParametersTest.Location = new System.Drawing.Point(148, 411);
            this.btnGetParametersTest.Name = "btnGetParametersTest";
            this.btnGetParametersTest.Size = new System.Drawing.Size(151, 23);
            this.btnGetParametersTest.TabIndex = 24;
            this.btnGetParametersTest.Text = "Test getParameter";
            this.btnGetParametersTest.UseVisualStyleBackColor = true;
            this.btnGetParametersTest.Click += new System.EventHandler(this.btnGetParametersTest_Click);
            // 
            // frmDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 446);
            this.Controls.Add(this.btnGetParametersTest);
            this.Controls.Add(this.lLevelBattery);
            this.Controls.Add(this.lPorta);
            this.Controls.Add(this.lIP);
            this.Controls.Add(this.lSlaveNumber);
            this.Controls.Add(this.lCenterNumber);
            this.Controls.Add(this.tbNotes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.lsos3);
            this.Controls.Add(this.lsos2);
            this.Controls.Add(this.lsos1);
            this.Controls.Add(this.btnSaveDevice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTelephoneNumber);
            this.Controls.Add(this.tbSerial);
            this.Controls.Add(this.lIMEI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDevice";
            this.Text = "frmDevice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lIMEI;
        private System.Windows.Forms.TextBox tbSerial;
        private System.Windows.Forms.TextBox tbTelephoneNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveDevice;
        private System.Windows.Forms.Label lsos1;
        private System.Windows.Forms.Label lsos2;
        private System.Windows.Forms.Label lsos3;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label lCenterNumber;
        private System.Windows.Forms.Label lSlaveNumber;
        private System.Windows.Forms.Label lIP;
        private System.Windows.Forms.Label lPorta;
        private System.Windows.Forms.Label lLevelBattery;
        private System.Windows.Forms.Button btnGetParametersTest;
    }
}