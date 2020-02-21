namespace PersonalizationStoreRemover
{
    partial class FrmFileList
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLblLastUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLblComputerName = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnComputerChoice = new System.Windows.Forms.Button();
            this.btnArchiveAll = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvFileList = new System.Windows.Forms.DataGridView();
            this.pnlFileInfo = new System.Windows.Forms.Panel();
            this.lblAccessTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLastModifTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCreationTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).BeginInit();
            this.pnlFileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsLblLastUpdate,
            this.toolStripStatusLabel2,
            this.tsLblComputerName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 437);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(584, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(70, 19);
            this.toolStripStatusLabel1.Text = "Last reload :";
            // 
            // tsLblLastUpdate
            // 
            this.tsLblLastUpdate.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsLblLastUpdate.Name = "tsLblLastUpdate";
            this.tsLblLastUpdate.Size = new System.Drawing.Size(99, 19);
            this.tsLblLastUpdate.Text = "Last update time";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(67, 19);
            this.toolStripStatusLabel2.Text = "Computer :";
            // 
            // tsLblComputerName
            // 
            this.tsLblComputerName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsLblComputerName.Name = "tsLblComputerName";
            this.tsLblComputerName.Size = new System.Drawing.Size(39, 19);
            this.tsLblComputerName.Text = "Local";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnComputerChoice);
            this.panel1.Controls.Add(this.btnArchiveAll);
            this.panel1.Controls.Add(this.btnDeleteAll);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 46);
            this.panel1.TabIndex = 1;
            // 
            // btnComputerChoice
            // 
            this.btnComputerChoice.Location = new System.Drawing.Point(130, 4);
            this.btnComputerChoice.Name = "btnComputerChoice";
            this.btnComputerChoice.Size = new System.Drawing.Size(130, 35);
            this.btnComputerChoice.TabIndex = 3;
            this.btnComputerChoice.Text = "Local / Remote";
            this.btnComputerChoice.UseVisualStyleBackColor = true;
            this.btnComputerChoice.Click += new System.EventHandler(this.btnComputerChoice_Click);
            // 
            // btnArchiveAll
            // 
            this.btnArchiveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArchiveAll.AutoSize = true;
            this.btnArchiveAll.Location = new System.Drawing.Point(343, 4);
            this.btnArchiveAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnArchiveAll.Name = "btnArchiveAll";
            this.btnArchiveAll.Size = new System.Drawing.Size(110, 36);
            this.btnArchiveAll.TabIndex = 2;
            this.btnArchiveAll.Text = "Archive All";
            this.btnArchiveAll.UseVisualStyleBackColor = true;
            this.btnArchiveAll.Click += new System.EventHandler(this.btnArchiveAll_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAll.AutoSize = true;
            this.btnDeleteAll.Location = new System.Drawing.Point(461, 4);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(110, 36);
            this.btnDeleteAll.TabIndex = 1;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(13, 4);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(110, 36);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 46);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvFileList);
            this.splitContainer1.Panel1.Controls.Add(this.pnlFileInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbLog);
            this.splitContainer1.Size = new System.Drawing.Size(584, 391);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 5;
            // 
            // dgvFileList
            // 
            this.dgvFileList.AllowUserToAddRows = false;
            this.dgvFileList.AllowUserToDeleteRows = false;
            this.dgvFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFileList.Location = new System.Drawing.Point(0, 0);
            this.dgvFileList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFileList.MultiSelect = false;
            this.dgvFileList.Name = "dgvFileList";
            this.dgvFileList.ReadOnly = true;
            this.dgvFileList.RowHeadersVisible = false;
            this.dgvFileList.RowTemplate.Height = 24;
            this.dgvFileList.Size = new System.Drawing.Size(584, 233);
            this.dgvFileList.TabIndex = 5;
            this.dgvFileList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFileList_CellContentClick);
            // 
            // pnlFileInfo
            // 
            this.pnlFileInfo.Controls.Add(this.lblAccessTime);
            this.pnlFileInfo.Controls.Add(this.label4);
            this.pnlFileInfo.Controls.Add(this.lblLastModifTime);
            this.pnlFileInfo.Controls.Add(this.label2);
            this.pnlFileInfo.Controls.Add(this.lblCreationTime);
            this.pnlFileInfo.Controls.Add(this.label1);
            this.pnlFileInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFileInfo.Location = new System.Drawing.Point(0, 233);
            this.pnlFileInfo.Name = "pnlFileInfo";
            this.pnlFileInfo.Size = new System.Drawing.Size(584, 38);
            this.pnlFileInfo.TabIndex = 6;
            // 
            // lblAccessTime
            // 
            this.lblAccessTime.AutoSize = true;
            this.lblAccessTime.Location = new System.Drawing.Point(110, 19);
            this.lblAccessTime.Name = "lblAccessTime";
            this.lblAccessTime.Size = new System.Drawing.Size(72, 15);
            this.lblAccessTime.TabIndex = 5;
            this.lblAccessTime.Text = "access time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last access time:";
            // 
            // lblLastModifTime
            // 
            this.lblLastModifTime.AutoSize = true;
            this.lblLastModifTime.Location = new System.Drawing.Point(408, 4);
            this.lblLastModifTime.Name = "lblLastModifTime";
            this.lblLastModifTime.Size = new System.Drawing.Size(65, 15);
            this.lblLastModifTime.TabIndex = 3;
            this.lblLastModifTime.Text = "modif time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last modification time:";
            // 
            // lblCreationTime
            // 
            this.lblCreationTime.AutoSize = true;
            this.lblCreationTime.Location = new System.Drawing.Point(110, 4);
            this.lblCreationTime.Name = "lblCreationTime";
            this.lblCreationTime.Size = new System.Drawing.Size(78, 15);
            this.lblCreationTime.TabIndex = 1;
            this.lblCreationTime.Text = "creation time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creation time:";
            // 
            // rtbLog
            // 
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Location = new System.Drawing.Point(0, 0);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(584, 116);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // FrmFileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "FrmFileList";
            this.Text = "NAV Personalization Store Remover";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).EndInit();
            this.pnlFileInfo.ResumeLayout(false);
            this.pnlFileInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsLblLastUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnArchiveAll;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvFileList;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsLblComputerName;
        private System.Windows.Forms.Button btnComputerChoice;
        private System.Windows.Forms.Panel pnlFileInfo;
        private System.Windows.Forms.Label lblLastModifTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCreationTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAccessTime;
        private System.Windows.Forms.Label label4;
    }
}

