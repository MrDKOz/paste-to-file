namespace PasteToFile
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.btnResetToSaved = new System.Windows.Forms.Button();
            this.btnCancelAndClose = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.chkAskForOptionsEverytime = new System.Windows.Forms.CheckBox();
            this.lblFileExtension = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.lblFilenameMaskPreview = new System.Windows.Forms.Label();
            this.tboxFilenameMask = new System.Windows.Forms.TextBox();
            this.lblFilenameMask = new System.Windows.Forms.Label();
            this.cboxFileTypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lnkTwitter = new System.Windows.Forms.LinkLabel();
            this.lnkGitHub = new System.Windows.Forms.LinkLabel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.cboxExtension = new System.Windows.Forms.ComboBox();
            this.btnContextMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResetToSaved
            // 
            this.btnResetToSaved.Location = new System.Drawing.Point(104, 125);
            this.btnResetToSaved.Name = "btnResetToSaved";
            this.btnResetToSaved.Size = new System.Drawing.Size(75, 23);
            this.btnResetToSaved.TabIndex = 21;
            this.btnResetToSaved.Text = "&Reset";
            this.btnResetToSaved.UseVisualStyleBackColor = true;
            this.btnResetToSaved.Click += new System.EventHandler(this.btnResetToSaved_Click);
            // 
            // btnCancelAndClose
            // 
            this.btnCancelAndClose.Location = new System.Drawing.Point(328, 125);
            this.btnCancelAndClose.Name = "btnCancelAndClose";
            this.btnCancelAndClose.Size = new System.Drawing.Size(92, 23);
            this.btnCancelAndClose.TabIndex = 20;
            this.btnCancelAndClose.Text = "&Cancel && Close";
            this.btnCancelAndClose.UseVisualStyleBackColor = true;
            this.btnCancelAndClose.Click += new System.EventHandler(this.btnCancelAndClose_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(5, 125);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChanges.TabIndex = 19;
            this.btnSaveChanges.Text = "&Save";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // chkAskForOptionsEverytime
            // 
            this.chkAskForOptionsEverytime.AutoSize = true;
            this.chkAskForOptionsEverytime.Location = new System.Drawing.Point(145, 96);
            this.chkAskForOptionsEverytime.Name = "chkAskForOptionsEverytime";
            this.chkAskForOptionsEverytime.Size = new System.Drawing.Size(275, 17);
            this.chkAskForOptionsEverytime.TabIndex = 29;
            this.chkAskForOptionsEverytime.Text = "Always ask for settings on paste for this file type";
            this.chkAskForOptionsEverytime.UseVisualStyleBackColor = true;
            // 
            // lblFileExtension
            // 
            this.lblFileExtension.AutoSize = true;
            this.lblFileExtension.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileExtension.Location = new System.Drawing.Point(247, 56);
            this.lblFileExtension.Name = "lblFileExtension";
            this.lblFileExtension.Size = new System.Drawing.Size(120, 13);
            this.lblFileExtension.TabIndex = 27;
            this.lblFileExtension.Text = "Default File Extension";
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(2, 32);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(394, 13);
            this.lblInformation.TabIndex = 26;
            this.lblInformation.Text = "Settings related to the output when text data is detected in your clipboard.";
            // 
            // lblFilenameMaskPreview
            // 
            this.lblFilenameMaskPreview.AutoSize = true;
            this.lblFilenameMaskPreview.Location = new System.Drawing.Point(2, 97);
            this.lblFilenameMaskPreview.Name = "lblFilenameMaskPreview";
            this.lblFilenameMaskPreview.Size = new System.Drawing.Size(62, 13);
            this.lblFilenameMaskPreview.TabIndex = 24;
            this.lblFilenameMaskPreview.Text = "<Preview>";
            // 
            // tboxFilenameMask
            // 
            this.tboxFilenameMask.Location = new System.Drawing.Point(5, 72);
            this.tboxFilenameMask.Name = "tboxFilenameMask";
            this.tboxFilenameMask.Size = new System.Drawing.Size(239, 22);
            this.tboxFilenameMask.TabIndex = 23;
            this.tboxFilenameMask.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tboxFilenameMask_KeyUp);
            // 
            // lblFilenameMask
            // 
            this.lblFilenameMask.AutoSize = true;
            this.lblFilenameMask.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilenameMask.Location = new System.Drawing.Point(2, 56);
            this.lblFilenameMask.Name = "lblFilenameMask";
            this.lblFilenameMask.Size = new System.Drawing.Size(85, 13);
            this.lblFilenameMask.TabIndex = 22;
            this.lblFilenameMask.Text = "Filename Mask";
            // 
            // cboxFileTypes
            // 
            this.cboxFileTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFileTypes.FormattingEnabled = true;
            this.cboxFileTypes.Location = new System.Drawing.Point(77, 8);
            this.cboxFileTypes.Name = "cboxFileTypes";
            this.cboxFileTypes.Size = new System.Drawing.Size(121, 21);
            this.cboxFileTypes.TabIndex = 30;
            this.cboxFileTypes.SelectedIndexChanged += new System.EventHandler(this.cboxFileTypes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "File Type";
            // 
            // lnkTwitter
            // 
            this.lnkTwitter.AutoSize = true;
            this.lnkTwitter.Location = new System.Drawing.Point(2, 151);
            this.lnkTwitter.Name = "lnkTwitter";
            this.lnkTwitter.Size = new System.Drawing.Size(60, 13);
            this.lnkTwitter.TabIndex = 32;
            this.lnkTwitter.TabStop = true;
            this.lnkTwitter.Text = "@MrDKOz";
            this.lnkTwitter.Click += new System.EventHandler(this.Link_Clicked);
            // 
            // lnkGitHub
            // 
            this.lnkGitHub.AutoSize = true;
            this.lnkGitHub.Location = new System.Drawing.Point(68, 151);
            this.lnkGitHub.Name = "lnkGitHub";
            this.lnkGitHub.Size = new System.Drawing.Size(44, 13);
            this.lnkGitHub.TabIndex = 33;
            this.lnkGitHub.TabStop = true;
            this.lnkGitHub.Text = "GitHub";
            this.lnkGitHub.Click += new System.EventHandler(this.Link_Clicked);
            // 
            // lblVersion
            // 
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblVersion.Location = new System.Drawing.Point(331, 151);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblVersion.Size = new System.Drawing.Size(92, 13);
            this.lblVersion.TabIndex = 34;
            this.lblVersion.Text = "<Version>";
            // 
            // cboxExtension
            // 
            this.cboxExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxExtension.FormattingEnabled = true;
            this.cboxExtension.Location = new System.Drawing.Point(250, 72);
            this.cboxExtension.Name = "cboxExtension";
            this.cboxExtension.Size = new System.Drawing.Size(121, 21);
            this.cboxExtension.TabIndex = 35;
            // 
            // btnContextMenu
            // 
            this.btnContextMenu.Location = new System.Drawing.Point(242, 6);
            this.btnContextMenu.Name = "btnContextMenu";
            this.btnContextMenu.Size = new System.Drawing.Size(178, 23);
            this.btnContextMenu.TabIndex = 36;
            this.btnContextMenu.Text = "Install Right Click Context Entry";
            this.btnContextMenu.UseVisualStyleBackColor = true;
            this.btnContextMenu.Click += new System.EventHandler(this.btnContextMenu_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 171);
            this.Controls.Add(this.btnContextMenu);
            this.Controls.Add(this.cboxExtension);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lnkGitHub);
            this.Controls.Add(this.lnkTwitter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxFileTypes);
            this.Controls.Add(this.chkAskForOptionsEverytime);
            this.Controls.Add(this.lblFileExtension);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblFilenameMaskPreview);
            this.Controls.Add(this.tboxFilenameMask);
            this.Controls.Add(this.lblFilenameMask);
            this.Controls.Add(this.btnResetToSaved);
            this.Controls.Add(this.btnCancelAndClose);
            this.Controls.Add(this.btnSaveChanges);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(440, 210);
            this.MinimumSize = new System.Drawing.Size(440, 210);
            this.Name = "Config";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paste to File Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResetToSaved;
        private System.Windows.Forms.Button btnCancelAndClose;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.CheckBox chkAskForOptionsEverytime;
        private System.Windows.Forms.Label lblFileExtension;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label lblFilenameMaskPreview;
        private System.Windows.Forms.TextBox tboxFilenameMask;
        private System.Windows.Forms.Label lblFilenameMask;
        private System.Windows.Forms.ComboBox cboxFileTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lnkTwitter;
        private System.Windows.Forms.LinkLabel lnkGitHub;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.ComboBox cboxExtension;
        private System.Windows.Forms.Button btnContextMenu;
    }
}

