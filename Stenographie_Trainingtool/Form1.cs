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
            bool proofCorrect;
            proofCorrect = GenerateOutput.proofTextBoxes(textboxInputAmount.Text, richboxInputWordletter.Lines);
            if (proofCorrect == true)
            {

            }
        }
    }
}
