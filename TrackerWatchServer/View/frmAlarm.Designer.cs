namespace TrackerWatchServer
{
    partial class frmAlarm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.eventGrid = new System.Windows.Forms.DataGridView();
            this.Arrivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gestito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gestisciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.chiudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.checkAllarmTimer = new System.Windows.Forms.Timer(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventGrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1016, 514);
            this.toolStripContainer1.Location = new System.Drawing.Point(1, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1016, 567);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 18);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1015, 464);
            this.splitContainer1.SplitterDistance = 225;
            this.splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.eventGrid);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer2.Size = new System.Drawing.Size(786, 464);
            this.splitContainer2.SplitterDistance = 244;
            this.splitContainer2.TabIndex = 0;
            // 
            // eventGrid
            // 
            this.eventGrid.AllowUserToAddRows = false;
            this.eventGrid.AllowUserToDeleteRows = false;
            this.eventGrid.AllowUserToResizeRows = false;
            this.eventGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.eventGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.eventGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.eventGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Arrivo,
            this.Codice,
            this.Evento,
            this.Utente,
            this.Gestito,
            this.ID,
            this.Latitude,
            this.Longitude});
            this.eventGrid.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.eventGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.eventGrid.Location = new System.Drawing.Point(3, 6);
            this.eventGrid.MultiSelect = false;
            this.eventGrid.Name = "eventGrid";
            this.eventGrid.RowHeadersVisible = false;
            this.eventGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.eventGrid.Size = new System.Drawing.Size(780, 202);
            this.eventGrid.TabIndex = 1;
            this.eventGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventGrid_CellClick);
            this.eventGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.eventGrid_CellDoubleClick);
            this.eventGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eventGrid_KeyDown);
            this.eventGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eventGrid_KeyPress);
            // 
            // Arrivo
            // 
            this.Arrivo.HeaderText = "Arrivo";
            this.Arrivo.Name = "Arrivo";
            this.Arrivo.ReadOnly = true;
            // 
            // Codice
            // 
            this.Codice.HeaderText = "Codice";
            this.Codice.Name = "Codice";
            this.Codice.ReadOnly = true;
            // 
            // Evento
            // 
            this.Evento.HeaderText = "Evento";
            this.Evento.Name = "Evento";
            this.Evento.ReadOnly = true;
            // 
            // Utente
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Utente.DefaultCellStyle = dataGridViewCellStyle1;
            this.Utente.HeaderText = "Utente";
            this.Utente.Name = "Utente";
            this.Utente.ReadOnly = true;
            // 
            // Gestito
            // 
            this.Gestito.HeaderText = "Gestito";
            this.Gestito.Name = "Gestito";
            this.Gestito.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Latitude
            // 
            this.Latitude.HeaderText = "Latitude";
            this.Latitude.Name = "Latitude";
            this.Latitude.ReadOnly = true;
            this.Latitude.Visible = false;
            // 
            // Longitude
            // 
            this.Longitude.HeaderText = "Longitude";
            this.Longitude.Name = "Longitude";
            this.Longitude.ReadOnly = true;
            this.Longitude.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestisciToolStripMenuItem,
            this.toolStripMenuItem1,
            this.chiudiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // gestisciToolStripMenuItem
            // 
            this.gestisciToolStripMenuItem.Name = "gestisciToolStripMenuItem";
            this.gestisciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gestisciToolStripMenuItem.Text = "Gestisci";
            this.gestisciToolStripMenuItem.Click += new System.EventHandler(this.gestisciToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // chiudiToolStripMenuItem
            // 
            this.chiudiToolStripMenuItem.Name = "chiudiToolStripMenuItem";
            this.chiudiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chiudiToolStripMenuItem.Text = "Chiudi";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(786, 216);
            this.webBrowser1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowItemReorder = true;
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 60);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnUser,
            this.toolStripSeparator1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator2,
            this.toolStripBtnSearch,
            this.toolStripSeparator3,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(280, 53);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripBtnUser
            // 
            this.toolStripBtnUser.AutoSize = false;
            this.toolStripBtnUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnUser.Image = global::TrackerWatchServer.Properties.Resources.user;
            this.toolStripBtnUser.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripBtnUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnUser.Name = "toolStripBtnUser";
            this.toolStripBtnUser.Size = new System.Drawing.Size(50, 50);
            this.toolStripBtnUser.Text = "Utenti";
            this.toolStripBtnUser.Click += new System.EventHandler(this.toolStripBtnUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::TrackerWatchServer.Properties.Resources.watch;
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(50, 50);
            this.toolStripButton2.Text = "Dispositivi";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::TrackerWatchServer.Properties.Resources.tracking;
            this.toolStripButton3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(50, 50);
            this.toolStripButton3.Text = "Storico";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 53);
            // 
            // toolStripBtnSearch
            // 
            this.toolStripBtnSearch.AutoSize = false;
            this.toolStripBtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSearch.Image = global::TrackerWatchServer.Properties.Resources.find;
            this.toolStripBtnSearch.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripBtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSearch.Name = "toolStripBtnSearch";
            this.toolStripBtnSearch.Size = new System.Drawing.Size(50, 50);
            this.toolStripBtnSearch.Text = "Ricerca";
            this.toolStripBtnSearch.Click += new System.EventHandler(this.toolStripBtnSearch_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 53);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::TrackerWatchServer.Properties.Resources.exit;
            this.toolStripButton5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(50, 50);
            this.toolStripButton5.Text = "Esci";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // checkAllarmTimer
            // 
            this.checkAllarmTimer.Enabled = true;
            this.checkAllarmTimer.Interval = 2000;
            this.checkAllarmTimer.Tick += new System.EventHandler(this.checkAllarmTimer_Tick);
            // 
            // frmAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 569);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "frmAlarm";
            this.Text = "SereSitter - Alarm Center";
            this.Load += new System.EventHandler(this.frmAlarm_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventGrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView eventGrid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        public System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gestito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn Longitude;
        private System.Windows.Forms.Timer checkAllarmTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestisciToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chiudiToolStripMenuItem;
    }
}