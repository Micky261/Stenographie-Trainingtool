using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stenographie_Trainingtool
{
    public partial class formStenoTrainerMain : Form
    {
        //Klasse GenerateOutput initialisieren
        GenerateOutput generateOutput = new GenerateOutput();

        public formStenoTrainerMain()
        {
            InitializeComponent();
            tooltipInputWordletters.SetToolTip(labelInputWordletter, "Hier können Wörter und Zeichen eingegeben werden, die für die Übung genutzt werden sollen. Ein Wort/Zeichen pro Zeile.");
            tooltipInputAmount.SetToolTip(labelInputAmount, "Anzahl der zu generierenden Elemente aus linksstehender Liste.");
            tooltipOutput.SetToolTip(labelOutput, "Ausgabe in die Zwischenablage kopieren oder als Dialog anzeigen.");
        }

        private void buttonGenerateRandoms_Click(object sender, EventArgs e)
        {
            bool proofCorrect = GenerateOutput.proofTextBoxes(textboxInputAmount.Text, richboxInputWordletter.Lines);

            if (proofCorrect == true)
            {
                textboxOutput.Text = GenerateOutput.generateOutput(textboxInputAmount.Text, richboxInputWordletter.Lines);
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            GenerateOutput.outputElementList("clipboard", textboxOutput.Text);
        }

        private void buttonOpenDialog_Click(object sender, EventArgs e)
        {
            GenerateOutput.outputElementList("dialogBox", textboxOutput.Text);
        }

        private void textboxInputAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonGenerateRandoms.PerformClick();
            }
        }
    }
}
