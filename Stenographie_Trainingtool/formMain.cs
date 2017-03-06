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
        //GenerateOutput-Klasse initialisieren
        GenerateOutput genOut = new GenerateOutput();
        //Main-Method
        public formStenoTrainerMain()
        {
            InitializeComponent();
            //Tooltip-Texte
            tooltipInputWordletters.SetToolTip(labelInputWordletter, "Hier können Wörter und Zeichen eingegeben werden, die für die Übung genutzt werden sollen. Ein Wort/Zeichen pro Zeile.");
            tooltipInputAmount.SetToolTip(labelInputAmount, "Anzahl der zu generierenden Elemente aus linksstehender Liste.");
        }

        //Methode Element-Liste generieren (Button_Click)
        private void buttonGenerateRandoms_Click(object sender, EventArgs e)
        {
            //Prüfmethode aufrufen und Rückgbe speichern
            bool proofCorrect = genOut.proofTextBoxes(richboxInputWordletter.Lines);

            //Wenn Rückgabe erfolgreich, dann Element-Liste generieren
            if (proofCorrect == true)
            {
                textboxOutput.Text = genOut.generateOutput(textboxInputAmount.Value, richboxInputWordletter.Lines);
            }
        }

        //Methode In die Zwischenablage kopieren
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            //Methode outputElementList für Zwischenablage aufrufen
            genOut.outputElementList("clipboard", textboxOutput.Text);
        }

        //Methode Als Dialogbox anzeigen
        private void buttonOpenDialog_Click(object sender, EventArgs e)
        {
            //Methode outputElemetList für Dialog-Box aufrufen
            genOut.outputElementList("dialogBox", textboxOutput.Text);
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
            //GeneratePDF-Klasse initialisieren
            GeneratePDF genOutPDF = new GeneratePDF();
            //Button deaktivieren und Curse auf Sanduhr setzen
            buttonSavePDF.Enabled = false;
            buttonSavePDF.Cursor = Cursors.WaitCursor;

            //Methode PDF generieren aufrufen
            genOutPDF.generatePDF(textboxOutput.Text);

            //Button reaktivieren und Zeiger normalisieren
            buttonSavePDF.Cursor = Cursors.Default;
            buttonSavePDF.Enabled = true;
        }

        private void pictureToolInfo_Click(object sender, EventArgs e)
        {
            formToolInfo formToolInfoShow = new formToolInfo();
            formToolInfoShow.Show();
        }
    }
}
