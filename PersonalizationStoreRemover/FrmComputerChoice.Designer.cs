namespace PersonalizationStoreRemover
{
    partial class FrmComputerChoice
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
            this.radLocal = new System.Windows.Forms.RadioButton();
            this.radRemote = new System.Windows.Forms.RadioButton();
            this.lblRemoteName = new System.Windows.Forms.Label();
            this.txtComputerName = new System.Windows.Forms.TextBox();
            this.btnValidation = new System.Windows.Forms.Button();
            this.lblMessageCShare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radLocal
            // 
            this.radLocal.AutoSize = true;
            this.radLocal.Location = new System.Drawing.Point(13, 13);
            this.radLocal.Margin = new System.Windows.Forms.Padding(4);
            this.radLocal.Name = "radLocal";
            this.radLocal.Size = new System.Drawing.Size(112, 19);
            this.radLocal.TabIndex = 0;
            this.radLocal.TabStop = true;
            this.radLocal.Text = "Local Computer";
            this.radLocal.UseVisualStyleBackColor = true;
            this.radLocal.CheckedChanged += new System.EventHandler(this.radLocal_CheckedChanged);
            // 
            // radRemote
            // 
            this.radRemote.AutoSize = true;
            this.radRemote.Location = new System.Drawing.Point(13, 40);
            this.radRemote.Margin = new System.Windows.Forms.Padding(4);
            this.radRemote.Name = "radRemote";
            this.radRemote.Size = new System.Drawing.Size(126, 19);
            this.radRemote.TabIndex = 1;
            this.radRemote.TabStop = true;
            this.radRemote.Text = "Remote Computer";
            this.radRemote.UseVisualStyleBackColor = true;
            // 
            // lblRemoteName
            // 
            this.lblRemoteName.AutoSize = true;
            this.lblRemoteName.Location = new System.Drawing.Point(31, 69);
            this.lblRemoteName.Name = "lblRemoteName";
            this.lblRemoteName.Size = new System.Drawing.Size(41, 15);
            this.lblRemoteName.TabIndex = 2;
            this.lblRemoteName.Text = "Name";
            // 
            // txtComputerName
            // 
            this.txtComputerName.Location = new System.Drawing.Point(78, 66);
            this.txtComputerName.Name = "txtComputerName";
            this.txtComputerName.Size = new System.Drawing.Size(167, 21);
            this.txtComputerName.TabIndex = 3;
            this.txtComputerName.TextChanged += new System.EventHandler(this.txtComputerName_TextChanged);
            // 
            // btnValidation
            // 
            this.btnValidation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValidation.Location = new System.Drawing.Point(197, 146);
            this.btnValidation.Name = "btnValidation";
            this.btnValidation.Size = new System.Drawing.Size(75, 23);
            this.btnValidation.TabIndex = 4;
            this.btnValidation.Text = "Validate";
            this.btnValidation.UseVisualStyleBackColor = true;
            this.btnValidation.Click += new System.EventHandler(this.btnValidation_Click);
            // 
            // lblMessageCShare
            // 
            this.lblMessageCShare.Location = new System.Drawing.Point(31, 90);
            this.lblMessageCShare.Name = "lblMessageCShare";
            this.lblMessageCShare.Size = new System.Drawing.Size(214, 49);
            this.lblMessageCShare.TabIndex = 5;
            this.lblMessageCShare.Text = "You must have access to the C$ share of the remote computer.";
            // 
            // FrmComputerChoice
            // 
            this.AcceptButton = this.btnValidation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.lblMessageCShare);
            this.Controls.Add(this.btnValidation);
            this.Controls.Add(this.txtComputerName);
            this.Controls.Add(this.lblRemoteName);
            this.Controls.Add(this.radRemote);
            this.Controls.Add(this.radLocal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 220);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 220);
            this.Name = "FrmComputerChoice";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Computer Choice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radLocal;
        private System.Windows.Forms.RadioButton radRemote;
        private System.Windows.Forms.Label lblRemoteName;
        private System.Windows.Forms.TextBox txtComputerName;
        private System.Windows.Forms.Button btnValidation;
        private System.Windows.Forms.Label lblMessageCShare;
    }
}