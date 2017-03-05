namespace Stenographie_Trainingtool
{
    partial class formStenoTrainerMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formStenoTrainerMain));
            this.richboxInputWordletter = new System.Windows.Forms.RichTextBox();
            this.textboxOutput = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonGenerateRandoms = new System.Windows.Forms.Button();
            this.labelInputAmount = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.groupboxInputs = new System.Windows.Forms.GroupBox();
            this.textboxInputAmount = new System.Windows.Forms.NumericUpDown();
            this.labelInputWordletter = new System.Windows.Forms.Label();
            this.groupboxOutput = new System.Windows.Forms.GroupBox();
            this.buttonSavePDF = new System.Windows.Forms.Button();
            this.buttonOpenDialog = new System.Windows.Forms.Button();
            this.tooltipInputWordletters = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipOutput = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipInputAmount = new System.Windows.Forms.ToolTip(this.components);
            this.pictureToolInfo = new System.Windows.Forms.PictureBox();
            this.groupboxInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textboxInputAmount)).BeginInit();
            this.groupboxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureToolInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // richboxInputWordletter
            // 
            resources.ApplyResources(this.richboxInputWordletter, "richboxInputWordletter");
            this.richboxInputWordletter.Name = "richboxInputWordletter";
            // 
            // textboxOutput
            // 
            resources.ApplyResources(this.textboxOutput, "textboxOutput");
            this.textboxOutput.Name = "textboxOutput";
            this.textboxOutput.ReadOnly = true;
            // 
            // buttonCopy
            // 
            resources.ApplyResources(this.buttonCopy, "buttonCopy");
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonGenerateRandoms
            // 
            resources.ApplyResources(this.buttonGenerateRandoms, "buttonGenerateRandoms");
            this.buttonGenerateRandoms.Name = "buttonGenerateRandoms";
            this.buttonGenerateRandoms.UseVisualStyleBackColor = true;
            this.buttonGenerateRandoms.Click += new System.EventHandler(this.buttonGenerateRandoms_Click);
            // 
            // labelInputAmount
            // 
            resources.ApplyResources(this.labelInputAmount, "labelInputAmount");
            this.labelInputAmount.Name = "labelInputAmount";
            // 
            // labelOutput
            // 
            resources.ApplyResources(this.labelOutput, "labelOutput");
            this.labelOutput.Name = "labelOutput";
            // 
            // groupboxInputs
            // 
            this.groupboxInputs.Controls.Add(this.textboxInputAmount);
            this.groupboxInputs.Controls.Add(this.labelInputWordletter);
            this.groupboxInputs.Controls.Add(this.buttonGenerateRandoms);
            this.groupboxInputs.Controls.Add(this.labelInputAmount);
            this.groupboxInputs.Controls.Add(this.richboxInputWordletter);
            resources.ApplyResources(this.groupboxInputs, "groupboxInputs");
            this.groupboxInputs.Name = "groupboxInputs";
            this.groupboxInputs.TabStop = false;
            // 
            // textboxInputAmount
            // 
            resources.ApplyResources(this.textboxInputAmount, "textboxInputAmount");
            this.textboxInputAmount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.textboxInputAmount.Name = "textboxInputAmount";
            this.textboxInputAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.textboxInputAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxInputAmount_KeyDown);
            // 
            // labelInputWordletter
            // 
            resources.ApplyResources(this.labelInputWordletter, "labelInputWordletter");
            this.labelInputWordletter.Name = "labelInputWordletter";
            // 
            // groupboxOutput
            // 
            this.groupboxOutput.Controls.Add(this.buttonSavePDF);
            this.groupboxOutput.Controls.Add(this.buttonOpenDialog);
            this.groupboxOutput.Controls.Add(this.buttonCopy);
            this.groupboxOutput.Controls.Add(this.labelOutput);
            this.groupboxOutput.Controls.Add(this.textboxOutput);
            resources.ApplyResources(this.groupboxOutput, "groupboxOutput");
            this.groupboxOutput.Name = "groupboxOutput";
            this.groupboxOutput.TabStop = false;
            // 
            // buttonSavePDF
            // 
            resources.ApplyResources(this.buttonSavePDF, "buttonSavePDF");
            this.buttonSavePDF.Name = "buttonSavePDF";
            this.buttonSavePDF.UseVisualStyleBackColor = true;
            this.buttonSavePDF.Click += new System.EventHandler(this.buttonSavePDF_Click);
            // 
            // buttonOpenDialog
            // 
            resources.ApplyResources(this.buttonOpenDialog, "buttonOpenDialog");
            this.buttonOpenDialog.Name = "buttonOpenDialog";
            this.buttonOpenDialog.UseVisualStyleBackColor = true;
            this.buttonOpenDialog.Click += new System.EventHandler(this.buttonOpenDialog_Click);
            // 
            // pictureToolInfo
            // 
            this.pictureToolInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureToolInfo.Image = global::Stenographie_Trainingtool.Properties.Resources.stenographie_trainingtool_info_16;
            resources.ApplyResources(this.pictureToolInfo, "pictureToolInfo");
            this.pictureToolInfo.Name = "pictureToolInfo";
            this.pictureToolInfo.TabStop = false;
            this.pictureToolInfo.Click += new System.EventHandler(this.pictureToolInfo_Click);
            // 
            // formStenoTrainerMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureToolInfo);
            this.Controls.Add(this.groupboxOutput);
            this.Controls.Add(this.groupboxInputs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formStenoTrainerMain";
            this.groupboxInputs.ResumeLayout(false);
            this.groupboxInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textboxInputAmount)).EndInit();
            this.groupboxOutput.ResumeLayout(false);
            this.groupboxOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureToolInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richboxInputWordletter;
        private System.Windows.Forms.TextBox textboxOutput;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonGenerateRandoms;
        private System.Windows.Forms.Label labelInputAmount;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.GroupBox groupboxInputs;
        private System.Windows.Forms.GroupBox groupboxOutput;
        private System.Windows.Forms.Label labelInputWordletter;
        private System.Windows.Forms.Button buttonOpenDialog;
        private System.Windows.Forms.ToolTip tooltipInputWordletters;
        private System.Windows.Forms.ToolTip tooltipOutput;
        private System.Windows.Forms.ToolTip tooltipInputAmount;
        private System.Windows.Forms.Button buttonSavePDF;
        private System.Windows.Forms.NumericUpDown textboxInputAmount;
        private System.Windows.Forms.PictureBox pictureToolInfo;
    }
}

