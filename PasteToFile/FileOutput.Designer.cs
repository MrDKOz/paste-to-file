namespace PasteToFile
{
    partial class FileOutput
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tboxFilename = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.cboxExtension = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInformation = new System.Windows.Forms.Label();
            this.chkSetAsDefault = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(88, 19);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "<File Type>";
            // 
            // tboxFilename
            // 
            this.tboxFilename.Location = new System.Drawing.Point(12, 68);
            this.tboxFilename.Name = "tboxFilename";
            this.tboxFilename.Size = new System.Drawing.Size(202, 22);
            this.tboxFilename.TabIndex = 1;
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.Location = new System.Drawing.Point(9, 52);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(54, 13);
            this.lblFilename.TabIndex = 2;
            this.lblFilename.Text = "Filename";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtension.Location = new System.Drawing.Point(221, 52);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(58, 13);
            this.lblExtension.TabIndex = 3;
            this.lblExtension.Text = "Extension";
            // 
            // cboxExtension
            // 
            this.cboxExtension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxExtension.FormattingEnabled = true;
            this.cboxExtension.Location = new System.Drawing.Point(224, 69);
            this.cboxExtension.Name = "cboxExtension";
            this.cboxExtension.Size = new System.Drawing.Size(75, 21);
            this.cboxExtension.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 119);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Create File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(224, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(9, 28);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(65, 13);
            this.lblInformation.TabIndex = 7;
            this.lblInformation.Text = "<SubTitle>";
            // 
            // chkSetAsDefault
            // 
            this.chkSetAsDefault.AutoSize = true;
            this.chkSetAsDefault.Location = new System.Drawing.Point(12, 96);
            this.chkSetAsDefault.Name = "chkSetAsDefault";
            this.chkSetAsDefault.Size = new System.Drawing.Size(250, 17);
            this.chkSetAsDefault.TabIndex = 8;
            this.chkSetAsDefault.Text = "Don\'t ask, and use these settings next time.";
            this.chkSetAsDefault.UseVisualStyleBackColor = true;
            // 
            // FileOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 151);
            this.Controls.Add(this.chkSetAsDefault);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboxExtension);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.tboxFilename);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(325, 190);
            this.MinimumSize = new System.Drawing.Size(325, 190);
            this.Name = "FileOutput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tboxFilename;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.ComboBox cboxExtension;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.CheckBox chkSetAsDefault;
    }
}