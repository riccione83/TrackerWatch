namespace TrackerWatchServer
{
    partial class frmStorico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDevice = new System.Windows.Forms.ListBox();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFinish = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.eventGrid = new System.Windows.Forms.DataGridView();
            this.DataEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitudine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitudine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialogTXT = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogCSV = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lstDevice);
            this.groupBox1.Controls.Add(this.txtSearchText);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 600);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleziona Dispositivo";
            // 
            // lstDevice
            // 
            this.lstDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDevice.FormattingEnabled = true;
            this.lstDevice.Location = new System.Drawing.Point(8, 55);
            this.lstDevice.Name = "lstDevice";
            this.lstDevice.Size = new System.Drawing.Size(243, 537);
            this.lstDevice.TabIndex = 1;
            this.lstDevice.SelectedIndexChanged += new System.EventHandler(this.lstDevice_SelectedIndexChanged);
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(8, 20);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(195, 20);
            this.txtSearchText.TabIndex = 0;
            this.txtSearchText.TextChanged += new System.EventHandler(this.txtSearchText_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtFinish);
            this.groupBox2.Controls.Add(this.dtStart);
            this.groupBox2.Location = new System.Drawing.Point(276, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(585, 111);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleziona Inizio/Fine";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(203, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 55);
            this.button4.TabIndex = 7;
            this.button4.Text = "Vedi su Mappa";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(462, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 55);
            this.button3.TabIndex = 6;
            this.button3.Text = "Esporta TXT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(523, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 55);
            this.button2.TabIndex = 5;
            this.button2.Text = "Esporta CSV";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fine:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inizio:";
            // 
            // dtFinish
            // 
            this.dtFinish.Location = new System.Drawing.Point(378, 20);
            this.dtFinish.Name = "dtFinish";
            this.dtFinish.Size = new System.Drawing.Size(200, 20);
            this.dtFinish.TabIndex = 1;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(67, 20);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(191, 20);
            this.dtStart.TabIndex = 0;
            // 
            // eventGrid
            // 
            this.eventGrid.AllowUserToAddRows = false;
            this.eventGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eventGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataEvento,
            this.ID,
            this.Evento,
            this.Latitudine,
            this.Longitudine});
            this.eventGrid.Location = new System.Drawing.Point(276, 120);
            this.eventGrid.Name = "eventGrid";
            this.eventGrid.RowHeadersVisible = false;
            this.eventGrid.Size = new System.Drawing.Size(585, 475);
            this.eventGrid.TabIndex = 2;
            // 
            // DataEvento
            // 
            this.DataEvento.HeaderText = "Data Evento";
            this.DataEvento.Name = "DataEvento";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Dispositivo";
            this.ID.Name = "ID";
            // 
            // Evento
            // 
            this.Evento.HeaderText = "Evento";
            this.Evento.Name = "Evento";
            // 
            // Latitudine
            // 
            this.Latitudine.HeaderText = "Latitudine";
            this.Latitudine.Name = "Latitudine";
            // 
            // Longitudine
            // 
            this.Longitudine.HeaderText = "Longitudine";
            this.Longitudine.Name = "Longitudine";
            // 
            // saveFileDialogTXT
            // 
            this.saveFileDialogTXT.DefaultExt = "*.txt";
            this.saveFileDialogTXT.Filter = "Text Files|*.txt";
            this.saveFileDialogTXT.Title = "Esporta in File Testo";
            // 
            // saveFileDialogCSV
            // 
            this.saveFileDialogCSV.DefaultExt = "*.csv";
            this.saveFileDialogCSV.Filter = "File CSV|*.csv";
            this.saveFileDialogCSV.Title = "Esporta in file CSV";
            // 
            // frmStorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 604);
            this.Controls.Add(this.eventGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmStorico";
            this.Text = "Visualizza Storico";
            this.Load += new System.EventHandler(this.frmStorico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstDevice;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFinish;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView eventGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitudine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitudine;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTXT;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCSV;
    }
}