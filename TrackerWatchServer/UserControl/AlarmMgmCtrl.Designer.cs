namespace TrackerWatchServer
{
    partial class AlarmMgmCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbNote = new System.Windows.Forms.ComboBox();
            this.txtAlarmNote = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbNote
            // 
            this.cbNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNote.FormattingEnabled = true;
            this.cbNote.Items.AddRange(new object[] {
            "Tutto regolare",
            "Contattato il responsabile",
            "Non si riesce a contattare",
            "Prova tecnica",
            "Gestito da"});
            this.cbNote.Location = new System.Drawing.Point(3, 3);
            this.cbNote.Name = "cbNote";
            this.cbNote.Size = new System.Drawing.Size(218, 21);
            this.cbNote.TabIndex = 1;
            this.cbNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNote_KeyPress);
            // 
            // txtAlarmNote
            // 
            this.txtAlarmNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlarmNote.Location = new System.Drawing.Point(3, 60);
            this.txtAlarmNote.Multiline = true;
            this.txtAlarmNote.Name = "txtAlarmNote";
            this.txtAlarmNote.Size = new System.Drawing.Size(218, 302);
            this.txtAlarmNote.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(146, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aggiungi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AlarmMgmCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAlarmNote);
            this.Controls.Add(this.cbNote);
            this.Name = "AlarmMgmCtrl";
            this.Size = new System.Drawing.Size(224, 365);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNote;
        private System.Windows.Forms.TextBox txtAlarmNote;
        private System.Windows.Forms.Button button1;
    }
}
