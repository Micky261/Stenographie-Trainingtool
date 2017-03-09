namespace Stenographie_Trainingtool
{
    partial class formToolInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formToolInfo));
            this.pictureToolInfoIcon = new System.Windows.Forms.PictureBox();
            this.labelToolName = new System.Windows.Forms.Label();
            this.labelLinkToolSource = new System.Windows.Forms.LinkLabel();
            this.kabelToolAuthor = new System.Windows.Forms.Label();
            this.labelToolVersion = new System.Windows.Forms.Label();
            this.labelToolInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureToolInfoIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureToolInfoIcon
            // 
            this.pictureToolInfoIcon.ErrorImage = null;
            this.pictureToolInfoIcon.Image = global::Stenographie_Trainingtool.Properties.Resources.stenographie_trainingtool_icon_64;
            this.pictureToolInfoIcon.InitialImage = null;
            this.pictureToolInfoIcon.Location = new System.Drawing.Point(13, 13);
            this.pictureToolInfoIcon.Name = "pictureToolInfoIcon";
            this.pictureToolInfoIcon.Size = new System.Drawing.Size(64, 64);
            this.pictureToolInfoIcon.TabIndex = 0;
            this.pictureToolInfoIcon.TabStop = false;
            // 
            // labelToolName
            // 
            this.labelToolName.AutoSize = true;
            this.labelToolName.Location = new System.Drawing.Point(83, 13);
            this.labelToolName.Name = "labelToolName";
            this.labelToolName.Size = new System.Drawing.Size(135, 13);
            this.labelToolName.TabIndex = 1;
            this.labelToolName.Text = "Stenographie Training-Tool";
            // 
            // labelLinkToolSource
            // 
            this.labelLinkToolSource.AutoSize = true;
            this.labelLinkToolSource.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
            this.labelLinkToolSource.Location = new System.Drawing.Point(83, 28);
            this.labelLinkToolSource.Name = "labelLinkToolSource";
            this.labelLinkToolSource.Size = new System.Drawing.Size(468, 13);
            this.labelLinkToolSource.TabIndex = 2;
            this.labelLinkToolSource.Text = "https://bitbucket.org/Micky261/stenographie_trainingtool/downloads/ - Download fr" +
    "om Bitbucket";
            // 
            // kabelToolAuthor
            // 
            this.kabelToolAuthor.AutoSize = true;
            this.kabelToolAuthor.Location = new System.Drawing.Point(83, 43);
            this.kabelToolAuthor.Name = "kabelToolAuthor";
            this.kabelToolAuthor.Size = new System.Drawing.Size(72, 13);
            this.kabelToolAuthor.TabIndex = 3;
            this.kabelToolAuthor.Text = "Version: 1.2.0";
            // 
            // labelToolVersion
            // 
            this.labelToolVersion.AutoSize = true;
            this.labelToolVersion.Location = new System.Drawing.Point(83, 58);
            this.labelToolVersion.Name = "labelToolVersion";
            this.labelToolVersion.Size = new System.Drawing.Size(97, 13);
            this.labelToolVersion.TabIndex = 4;
            this.labelToolVersion.Text = "Autor: Frank Nelles";
            // 
            // labelToolInfo
            // 
            this.labelToolInfo.AutoSize = true;
            this.labelToolInfo.Location = new System.Drawing.Point(13, 84);
            this.labelToolInfo.Name = "labelToolInfo";
            this.labelToolInfo.Size = new System.Drawing.Size(657, 91);
            this.labelToolInfo.TabIndex = 5;
            this.labelToolInfo.Text = resources.GetString("labelToolInfo.Text");
            // 
            // formToolInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 205);
            this.Controls.Add(this.labelToolInfo);
            this.Controls.Add(this.labelToolVersion);
            this.Controls.Add(this.kabelToolAuthor);
            this.Controls.Add(this.labelLinkToolSource);
            this.Controls.Add(this.labelToolName);
            this.Controls.Add(this.pictureToolInfoIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formToolInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stenographie Trainingtool Info";
            ((System.ComponentModel.ISupportInitialize)(this.pictureToolInfoIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureToolInfoIcon;
        private System.Windows.Forms.Label labelToolName;
        private System.Windows.Forms.LinkLabel labelLinkToolSource;
        private System.Windows.Forms.Label kabelToolAuthor;
        private System.Windows.Forms.Label labelToolVersion;
        private System.Windows.Forms.Label labelToolInfo;
    }
}