namespace Stenographie_Trainingtool
{
    partial class formICan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formICan));
            this.labelICanExplanation = new System.Windows.Forms.Label();
            this.groupboxICanHelp = new System.Windows.Forms.GroupBox();
            this.listboxSelectHelpItem = new System.Windows.Forms.ListBox();
            this.textboxShowHelpItem = new System.Windows.Forms.TextBox();
            this.groupboxICanConfiguration = new System.Windows.Forms.GroupBox();
            this.labelOpenUserDictionary = new System.Windows.Forms.Label();
            this.textboxDictionarySource = new System.Windows.Forms.TextBox();
            this.buttonOpenDictionary = new System.Windows.Forms.Button();
            this.labelElementLengthSelectedValue = new System.Windows.Forms.Label();
            this.labelElementLength = new System.Windows.Forms.Label();
            this.trackbarElementLength = new System.Windows.Forms.TrackBar();
            this.labelElementAmountSelectedValue = new System.Windows.Forms.Label();
            this.trackbarElementAmount = new System.Windows.Forms.TrackBar();
            this.labelElementAmount = new System.Windows.Forms.Label();
            this.labelElementLetters = new System.Windows.Forms.Label();
            this.textboxElementLetters = new System.Windows.Forms.TextBox();
            this.buttonSearchWords = new System.Windows.Forms.Button();
            this.labelICanDescription = new System.Windows.Forms.Label();
            this.groupboxICanOutput = new System.Windows.Forms.GroupBox();
            this.textboxOutputWords = new System.Windows.Forms.TextBox();
            this.openFileDialogDictionary = new System.Windows.Forms.OpenFileDialog();
            this.groupboxICanHelp.SuspendLayout();
            this.groupboxICanConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarElementLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarElementAmount)).BeginInit();
            this.groupboxICanOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelICanExplanation
            // 
            this.labelICanExplanation.AutoSize = true;
            this.labelICanExplanation.Location = new System.Drawing.Point(160, 19);
            this.labelICanExplanation.Name = "labelICanExplanation";
            this.labelICanExplanation.Size = new System.Drawing.Size(0, 13);
            this.labelICanExplanation.TabIndex = 0;
            // 
            // groupboxICanHelp
            // 
            this.groupboxICanHelp.Controls.Add(this.listboxSelectHelpItem);
            this.groupboxICanHelp.Controls.Add(this.textboxShowHelpItem);
            this.groupboxICanHelp.Controls.Add(this.labelICanExplanation);
            this.groupboxICanHelp.Location = new System.Drawing.Point(12, 29);
            this.groupboxICanHelp.Name = "groupboxICanHelp";
            this.groupboxICanHelp.Size = new System.Drawing.Size(899, 151);
            this.groupboxICanHelp.TabIndex = 2;
            this.groupboxICanHelp.TabStop = false;
            this.groupboxICanHelp.Text = "Bedienungshinweise";
            // 
            // listboxSelectHelpItem
            // 
            this.listboxSelectHelpItem.Items.AddRange(new object[] {
            "Mein Programm friert ein...",
            "Umlaute & Akzente",
            "Wörter suchen",
            "Wörterbuch suchen"});
            this.listboxSelectHelpItem.Location = new System.Drawing.Point(5, 19);
            this.listboxSelectHelpItem.Name = "listboxSelectHelpItem";
            this.listboxSelectHelpItem.Size = new System.Drawing.Size(154, 121);
            this.listboxSelectHelpItem.Sorted = true;
            this.listboxSelectHelpItem.TabIndex = 1;
            this.listboxSelectHelpItem.SelectedIndexChanged += new System.EventHandler(this.listboxSelectHelpItem_SelectedIndexChanged);
            // 
            // textboxShowHelpItem
            // 
            this.textboxShowHelpItem.Location = new System.Drawing.Point(163, 19);
            this.textboxShowHelpItem.Multiline = true;
            this.textboxShowHelpItem.Name = "textboxShowHelpItem";
            this.textboxShowHelpItem.ReadOnly = true;
            this.textboxShowHelpItem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxShowHelpItem.Size = new System.Drawing.Size(726, 121);
            this.textboxShowHelpItem.TabIndex = 2;
            // 
            // groupboxICanConfiguration
            // 
            this.groupboxICanConfiguration.Controls.Add(this.labelOpenUserDictionary);
            this.groupboxICanConfiguration.Controls.Add(this.textboxDictionarySource);
            this.groupboxICanConfiguration.Controls.Add(this.buttonOpenDictionary);
            this.groupboxICanConfiguration.Controls.Add(this.labelElementLengthSelectedValue);
            this.groupboxICanConfiguration.Controls.Add(this.labelElementLength);
            this.groupboxICanConfiguration.Controls.Add(this.trackbarElementLength);
            this.groupboxICanConfiguration.Controls.Add(this.labelElementAmountSelectedValue);
            this.groupboxICanConfiguration.Controls.Add(this.trackbarElementAmount);
            this.groupboxICanConfiguration.Controls.Add(this.labelElementAmount);
            this.groupboxICanConfiguration.Controls.Add(this.labelElementLetters);
            this.groupboxICanConfiguration.Controls.Add(this.textboxElementLetters);
            this.groupboxICanConfiguration.Controls.Add(this.buttonSearchWords);
            this.groupboxICanConfiguration.Location = new System.Drawing.Point(12, 186);
            this.groupboxICanConfiguration.Name = "groupboxICanConfiguration";
            this.groupboxICanConfiguration.Size = new System.Drawing.Size(607, 246);
            this.groupboxICanConfiguration.TabIndex = 3;
            this.groupboxICanConfiguration.TabStop = false;
            this.groupboxICanConfiguration.Text = "Konfiguration der Ausgabeliste";
            // 
            // labelOpenUserDictionary
            // 
            this.labelOpenUserDictionary.AutoSize = true;
            this.labelOpenUserDictionary.Location = new System.Drawing.Point(5, 188);
            this.labelOpenUserDictionary.Name = "labelOpenUserDictionary";
            this.labelOpenUserDictionary.Size = new System.Drawing.Size(91, 13);
            this.labelOpenUserDictionary.TabIndex = 11;
            this.labelOpenUserDictionary.Text = "Nutzerwörterbuch";
            // 
            // textboxDictionarySource
            // 
            this.textboxDictionarySource.Location = new System.Drawing.Point(102, 185);
            this.textboxDictionarySource.Name = "textboxDictionarySource";
            this.textboxDictionarySource.Size = new System.Drawing.Size(382, 20);
            this.textboxDictionarySource.TabIndex = 10;
            this.textboxDictionarySource.TextChanged += new System.EventHandler(this.textboxDictionarySource_TextChanged);
            // 
            // buttonOpenDictionary
            // 
            this.buttonOpenDictionary.Location = new System.Drawing.Point(492, 185);
            this.buttonOpenDictionary.Name = "buttonOpenDictionary";
            this.buttonOpenDictionary.Size = new System.Drawing.Size(108, 20);
            this.buttonOpenDictionary.TabIndex = 9;
            this.buttonOpenDictionary.Text = "Datei öffnen";
            this.buttonOpenDictionary.UseVisualStyleBackColor = true;
            this.buttonOpenDictionary.Click += new System.EventHandler(this.buttonOpenDictionary_Click);
            // 
            // labelElementLengthSelectedValue
            // 
            this.labelElementLengthSelectedValue.AutoSize = true;
            this.labelElementLengthSelectedValue.Location = new System.Drawing.Point(50, 166);
            this.labelElementLengthSelectedValue.Name = "labelElementLengthSelectedValue";
            this.labelElementLengthSelectedValue.Size = new System.Drawing.Size(13, 13);
            this.labelElementLengthSelectedValue.TabIndex = 8;
            this.labelElementLengthSelectedValue.Text = "4";
            // 
            // labelElementLength
            // 
            this.labelElementLength.AutoSize = true;
            this.labelElementLength.Location = new System.Drawing.Point(5, 134);
            this.labelElementLength.Name = "labelElementLength";
            this.labelElementLength.Size = new System.Drawing.Size(56, 26);
            this.labelElementLength.TabIndex = 7;
            this.labelElementLength.Text = "Mindest-\r\nWortlänge";
            // 
            // trackbarElementLength
            // 
            this.trackbarElementLength.LargeChange = 3;
            this.trackbarElementLength.Location = new System.Drawing.Point(69, 134);
            this.trackbarElementLength.Maximum = 20;
            this.trackbarElementLength.Minimum = 1;
            this.trackbarElementLength.Name = "trackbarElementLength";
            this.trackbarElementLength.Size = new System.Drawing.Size(532, 45);
            this.trackbarElementLength.TabIndex = 5;
            this.trackbarElementLength.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackbarElementLength.Value = 4;
            this.trackbarElementLength.Scroll += new System.EventHandler(this.trackbarElementLength_Scroll);
            // 
            // labelElementAmountSelectedValue
            // 
            this.labelElementAmountSelectedValue.AutoSize = true;
            this.labelElementAmountSelectedValue.Location = new System.Drawing.Point(44, 114);
            this.labelElementAmountSelectedValue.Name = "labelElementAmountSelectedValue";
            this.labelElementAmountSelectedValue.Size = new System.Drawing.Size(19, 13);
            this.labelElementAmountSelectedValue.TabIndex = 5;
            this.labelElementAmountSelectedValue.Text = "50";
            // 
            // trackbarElementAmount
            // 
            this.trackbarElementAmount.Location = new System.Drawing.Point(69, 82);
            this.trackbarElementAmount.Maximum = 1000;
            this.trackbarElementAmount.Minimum = 1;
            this.trackbarElementAmount.Name = "trackbarElementAmount";
            this.trackbarElementAmount.Size = new System.Drawing.Size(532, 45);
            this.trackbarElementAmount.TabIndex = 4;
            this.trackbarElementAmount.TickFrequency = 50;
            this.trackbarElementAmount.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackbarElementAmount.Value = 50;
            this.trackbarElementAmount.Scroll += new System.EventHandler(this.trackbarElementAmount_Scroll);
            // 
            // labelElementAmount
            // 
            this.labelElementAmount.AutoSize = true;
            this.labelElementAmount.Location = new System.Drawing.Point(5, 82);
            this.labelElementAmount.Name = "labelElementAmount";
            this.labelElementAmount.Size = new System.Drawing.Size(61, 26);
            this.labelElementAmount.TabIndex = 3;
            this.labelElementAmount.Text = "Wortanzahl\r\n(max.)";
            // 
            // labelElementLetters
            // 
            this.labelElementLetters.AutoSize = true;
            this.labelElementLetters.Location = new System.Drawing.Point(5, 20);
            this.labelElementLetters.Name = "labelElementLetters";
            this.labelElementLetters.Size = new System.Drawing.Size(160, 13);
            this.labelElementLetters.TabIndex = 2;
            this.labelElementLetters.Text = "Zu durchsuchende Buchstaben:";
            // 
            // textboxElementLetters
            // 
            this.textboxElementLetters.Location = new System.Drawing.Point(5, 36);
            this.textboxElementLetters.Name = "textboxElementLetters";
            this.textboxElementLetters.Size = new System.Drawing.Size(595, 20);
            this.textboxElementLetters.TabIndex = 3;
            this.textboxElementLetters.TextChanged += new System.EventHandler(this.textboxElementLetters_TextChanged);
            // 
            // buttonSearchWords
            // 
            this.buttonSearchWords.Enabled = false;
            this.buttonSearchWords.Location = new System.Drawing.Point(491, 211);
            this.buttonSearchWords.Name = "buttonSearchWords";
            this.buttonSearchWords.Size = new System.Drawing.Size(109, 23);
            this.buttonSearchWords.TabIndex = 6;
            this.buttonSearchWords.Text = "Wörter suchen";
            this.buttonSearchWords.UseVisualStyleBackColor = true;
            this.buttonSearchWords.Click += new System.EventHandler(this.buttonSearchWords_Click);
            // 
            // labelICanDescription
            // 
            this.labelICanDescription.AutoSize = true;
            this.labelICanDescription.Location = new System.Drawing.Point(9, 13);
            this.labelICanDescription.Name = "labelICanDescription";
            this.labelICanDescription.Size = new System.Drawing.Size(470, 13);
            this.labelICanDescription.TabIndex = 4;
            this.labelICanDescription.Text = "Das Hilfsprogramm Ich kann... dient zur Auffindung von bereits erlernbaren Wörter" +
    "n einer Sprache.";
            // 
            // groupboxICanOutput
            // 
            this.groupboxICanOutput.Controls.Add(this.textboxOutputWords);
            this.groupboxICanOutput.Location = new System.Drawing.Point(625, 186);
            this.groupboxICanOutput.Name = "groupboxICanOutput";
            this.groupboxICanOutput.Size = new System.Drawing.Size(286, 246);
            this.groupboxICanOutput.TabIndex = 5;
            this.groupboxICanOutput.TabStop = false;
            this.groupboxICanOutput.Text = "Ausgabe";
            // 
            // textboxOutputWords
            // 
            this.textboxOutputWords.Location = new System.Drawing.Point(6, 17);
            this.textboxOutputWords.MaxLength = 65534;
            this.textboxOutputWords.Multiline = true;
            this.textboxOutputWords.Name = "textboxOutputWords";
            this.textboxOutputWords.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textboxOutputWords.Size = new System.Drawing.Size(270, 217);
            this.textboxOutputWords.TabIndex = 0;
            this.textboxOutputWords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxOutputWords_KeyDown);
            // 
            // openFileDialogDictionary
            // 
            this.openFileDialogDictionary.DefaultExt = "txt";
            this.openFileDialogDictionary.FileName = "german.txt";
            this.openFileDialogDictionary.Filter = "Text-Datei|*.txt";
            this.openFileDialogDictionary.SupportMultiDottedExtensions = true;
            this.openFileDialogDictionary.Title = "Nutzerwörterbuch auswählen";
            // 
            // formICan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 439);
            this.Controls.Add(this.groupboxICanOutput);
            this.Controls.Add(this.labelICanDescription);
            this.Controls.Add(this.groupboxICanConfiguration);
            this.Controls.Add(this.groupboxICanHelp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formICan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ich kann...";
            this.groupboxICanHelp.ResumeLayout(false);
            this.groupboxICanHelp.PerformLayout();
            this.groupboxICanConfiguration.ResumeLayout(false);
            this.groupboxICanConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarElementLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarElementAmount)).EndInit();
            this.groupboxICanOutput.ResumeLayout(false);
            this.groupboxICanOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelICanExplanation;
        private System.Windows.Forms.GroupBox groupboxICanHelp;
        private System.Windows.Forms.GroupBox groupboxICanConfiguration;
        private System.Windows.Forms.TextBox textboxShowHelpItem;
        private System.Windows.Forms.ListBox listboxSelectHelpItem;
        private System.Windows.Forms.Label labelICanDescription;
        private System.Windows.Forms.GroupBox groupboxICanOutput;
        private System.Windows.Forms.TrackBar trackbarElementAmount;
        private System.Windows.Forms.Label labelElementAmount;
        private System.Windows.Forms.Label labelElementLetters;
        private System.Windows.Forms.TextBox textboxElementLetters;
        private System.Windows.Forms.Button buttonSearchWords;
        private System.Windows.Forms.Label labelElementAmountSelectedValue;
        private System.Windows.Forms.Label labelElementLengthSelectedValue;
        private System.Windows.Forms.Label labelElementLength;
        private System.Windows.Forms.TrackBar trackbarElementLength;
        private System.Windows.Forms.TextBox textboxDictionarySource;
        private System.Windows.Forms.Button buttonOpenDictionary;
        private System.Windows.Forms.OpenFileDialog openFileDialogDictionary;
        private System.Windows.Forms.TextBox textboxOutputWords;
        private System.Windows.Forms.Label labelOpenUserDictionary;
    }
}