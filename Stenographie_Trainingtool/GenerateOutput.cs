using System;
using System.Windows.Forms;

namespace Stenographie_Trainingtool
{
    //Klasse für die Generierung des Outputs zuständig ist
    class GenerateOutput
    {
        //Methode zur Prüfung der Eingabe
        public static bool proofTextBoxes(string inputAmount, string[] inputWords)
        {
            //Bool'sche Variable: Rückgabewert der Funktion erstellen
            bool boolReturn = false;

            //textboxAmount auf leere oder falsche Eingabe prüfen
            if (inputAmount != "")
            {
                UInt64 number = 0;
                try
                {
                    number = Convert.ToUInt64(inputAmount);
                    boolReturn = true;
                }
                catch
                {
                    MessageBox.Show("Die Eingabe ist ungültig.");
                    boolReturn = false;
                }
            }
            else
            {
                MessageBox.Show("Die Eingabe enthält keinen Inhalt.");
                boolReturn = false;
            }

            //richboxInputWordletters auf leere Eingabe prüfen, wenn leer die deutschen Artikel ausgeben
            if (boolReturn == true)
            {
                if (inputWords.Length == 0)
                {
                    MessageBox.Show("Die Eingabe enthält keinen Inhalt.");
                    boolReturn = false;
                }

            }

            return boolReturn;
        }
    }
}
