namespace TrackerWatchServer
{
    partial class UserControl1
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
            this.txtID = new System.Windows.Forms.Label();
            this.txtGprsComm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(3, 0);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(35, 13);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "label1";
            // 
            // txtGprsComm
            // 
            this.txtGprsComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGprsComm.Location = new System.Drawing.Point(3, 16);
            this.txtGprsComm.Multiline = true;
            this.txtGprsComm.Name = "txtGprsComm";
            this.txtGprsComm.Size = new System.Drawing.Size(104, 91);
            this.txtGprsComm.TabIndex = 1;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtGprsComm);
            this.Controls.Add(this.txtID);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(110, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label txtID;
        public System.Windows.Forms.TextBox txtGprsComm;
    }
}
