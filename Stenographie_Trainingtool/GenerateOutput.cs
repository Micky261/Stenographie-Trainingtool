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
                Int32 number = 0;
                try
                {
                    number = Convert.ToInt32(inputAmount);
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

        //Methode zur Generierung der Zeichenkette
        public static string generateOutput(string amountElements, string[] elements)
        {
            string elementOutput = "";
            Int32 elementAmount = Convert.ToInt32(amountElements);
            Random randomNumber = new Random();
            int randomInElements;

            for (Int32 i = 1; i <= elementAmount; i++)
            {
                randomInElements = randomNumber.Next(0, elements.Length);
            
                if (i != elementAmount)
                {
                    elementOutput += elements[randomInElements];
                    elementOutput += " - ";
                }
                else
                {
                    elementOutput += elements[randomInElements];
                }
            }
            return elementOutput;
        }

        public static void outputElementList(string outputType, string outputContent)
        {
            switch (outputType)
            {
                case "clipboard":
                    System.Windows.Forms.Clipboard.SetDataObject(outputContent, true);
                    MessageBox.Show("Ausgabe kopiert.");
                    break;
                case "dialogBox":
                    MessageBox.Show(outputContent);
                    break;
                default:
                    MessageBox.Show("Issue #000001\nKeine Output-Zuweisung - Bitte melden sie sich beim Entwickler!", Environment.NewLine);
                    break;
            }
        }
    }
}
