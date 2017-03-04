using System;
using System.Windows.Forms;

namespace Stenographie_Trainingtool
{
    //Klasse für die Generierung des Outputs zuständig ist
    class GenerateOutput
    {
        //Methode zur Prüfung der Eingabe
        public static bool proofTextBoxes(string[] inputWords)
        {
            //Bool'sche Variable: Rückgabewert der Funktion erstellen
            bool boolReturn = true;

            //richboxInputWordletters auf leere Eingabe prüfen, wenn leer die deutschen Artikel ausgeben
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
        public static string generateOutput(decimal amountElements, string[] elements)
        {
            string elementOutput = "";
            decimal elementAmount = amountElements;
            Random randomNumber = new Random();
            int randomInElements;

            for (decimal i = 1; i <= elementAmount; i++)
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
