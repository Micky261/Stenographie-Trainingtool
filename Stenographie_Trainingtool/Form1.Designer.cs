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
            this.textboxInputAmount = new System.Windows.Forms.TextBox();
            this.textboxOutput = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonGenerateRandoms = new System.Windows.Forms.Button();
            this.labelInputAmount = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.groupboxInputs = new System.Windows.Forms.GroupBox();
            this.labelInputWordletter = new System.Windows.Forms.Label();
            this.groupboxOutput = new System.Windows.Forms.GroupBox();
            this.buttonOpenDialog = new System.Windows.Forms.Button();
            this.tooltipInputWordletters = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipOutput = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipInputAmount = new System.Windows.Forms.ToolTip(this.components);
            this.groupboxInputs.SuspendLayout();
            this.groupboxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // richboxInputWordletter
            // 
            resources.ApplyResources(this.richboxInputWordletter, "richboxInputWordletter");
            this.richboxInputWordletter.Name = "richboxInputWordletter";
            // 
            // textboxInputAmount
            // 
            resources.ApplyResources(this.textboxInputAmount, "textboxInputAmount");
            this.textboxInputAmount.Name = "textboxInputAmount";
            // 
            // textboxOutput
            // 
            resources.ApplyResources(this.textboxOutput, "textboxOutput");
            this.textboxOutput.Name = "textboxOutput";
            // 
            // buttonCopy
            // 
            resources.ApplyResources(this.buttonCopy, "buttonCopy");
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateRandoms
            // 
            resources.ApplyResources(this.buttonGenerateRandoms, "buttonGenerateRandoms");
            this.buttonGenerateRandoms.Name = "buttonGenerateRandoms";
            this.buttonGenerateRandoms.UseVisualStyleBackColor = true;
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
            this.groupboxInputs.Controls.Add(this.labelInputWordletter);
            this.groupboxInputs.Controls.Add(this.buttonGenerateRandoms);
            this.groupboxInputs.Controls.Add(this.labelInputAmount);
            this.groupboxInputs.Controls.Add(this.richboxInputWordletter);
            this.groupboxInputs.Controls.Add(this.textboxInputAmount);
            resources.ApplyResources(this.groupboxInputs, "groupboxInputs");
            this.groupboxInputs.Name = "groupboxInputs";
            this.groupboxInputs.TabStop = false;
            // 
            // labelInputWordletter
            // 
            resources.ApplyResources(this.labelInputWordletter, "labelInputWordletter");
            this.labelInputWordletter.Name = "labelInputWordletter";
            // 
            // groupboxOutput
            // 
            this.groupboxOutput.Controls.Add(this.buttonOpenDialog);
            this.groupboxOutput.Controls.Add(this.buttonCopy);
            this.groupboxOutput.Controls.Add(this.labelOutput);
            this.groupboxOutput.Controls.Add(this.textboxOutput);
            resources.ApplyResources(this.groupboxOutput, "groupboxOutput");
            this.groupboxOutput.Name = "groupboxOutput";
            this.groupboxOutput.TabStop = false;
            // 
            // buttonOpenDialog
            // 
            resources.ApplyResources(this.buttonOpenDialog, "buttonOpenDialog");
            this.buttonOpenDialog.Name = "buttonOpenDialog";
            this.buttonOpenDialog.UseVisualStyleBackColor = true;
            // 
            // formStenoTrainerMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupboxOutput);
            this.Controls.Add(this.groupboxInputs);
            this.MaximizeBox = false;
            this.Name = "formStenoTrainerMain";
            this.groupboxInputs.ResumeLayout(false);
            this.groupboxInputs.PerformLayout();
            this.groupboxOutput.ResumeLayout(false);
            this.groupboxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richboxInputWordletter;
        private System.Windows.Forms.TextBox textboxInputAmount;
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
    }
}

