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
        //Main-Method
        public formStenoTrainerMain()
        {
            InitializeComponent();
            //Tooltip-Texte
            tooltipInputWordletters.SetToolTip(labelInputWordletter, "Hier können Wörter und Zeichen eingegeben werden, die für die Übung genutzt werden sollen. Ein Wort/Zeichen pro Zeile.");
            tooltipInputAmount.SetToolTip(labelInputAmount, "Anzahl der zu generierenden Elemente aus linksstehender Liste.");
            tooltipOutput.SetToolTip(labelOutput, "Ausgabe in die Zwischenablage kopieren oder als Dialog anzeigen.");
        }

        //Methode Element-Liste generieren (Button_Click)
        private void buttonGenerateRandoms_Click(object sender, EventArgs e)
        {
            //Prüfmethode aufrufen und Rückgbe speichern
            bool proofCorrect = GenerateOutput.proofTextBoxes(richboxInputWordletter.Lines);

            //Wenn Rückgabe erfolgreich, dann Element-Liste generieren
            if (proofCorrect == true)
            {
                textboxOutput.Text = GenerateOutput.generateOutput(textboxInputAmount.Value, richboxInputWordletter.Lines);
            }
        }

        //Methode In die Zwischenablage kopieren
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            //Methode outputElementList für Zwischenablage aufrufen
            GenerateOutput.outputElementList("clipboard", textboxOutput.Text);
        }

        //Methode Als Dialogbox anzeigen
        private void buttonOpenDialog_Click(object sender, EventArgs e)
        {
            //Methode outputElemetList für Dialog-Box aufrufen
            GenerateOutput.outputElementList("dialogBox", textboxOutput.Text);
        }

        //Methode Enter abfangen in Amount-Textbox
        private void textboxInputAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Click auf Element-Liste generieren simulieren
                buttonGenerateRandoms.PerformClick();
            }
        }

        //Methode Als PDF speichern
        private void buttonSavePDF_Click(object sender, EventArgs e)
        {
            //Methode PDF generieren aufrufen
            GeneratePDF.generatePDF(textboxOutput.Text);
        }

        private void pictureToolInfo_Click(object sender, EventArgs e)
        {
            formToolInfo formToolInfoShow = new formToolInfo();
            formToolInfoShow.Show();
        }
    }
}
