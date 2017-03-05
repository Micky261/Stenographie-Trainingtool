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

            //richboxInputWordletters auf leere Eingabe prüfen
            {
                if (inputWords.Length == 0)
                {
                    MessageBox.Show("Die 'Wörter und Zeichen'-Eingabe enthält keinen Inhalt.");
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
            //Instanz für zufällige Zahl inistialisieren
            Random randomNumber = new Random();
            int randomInElements;

            //Element sooft generieren, wie eingegeben
            for (decimal i = 1; i <= elementAmount; i++)
            {
                //Zufallszahl generieren
                randomInElements = randomNumber.Next(0, elements.Length);

                //Ausgabe weiterfüllen - Wenn letztes Element, dann keinen Trenner einfügen
                elementOutput += elements[randomInElements];
                if (i != elementAmount) elementOutput += " - ";
            }
            //Element-Liste zurückgeben
            return elementOutput;
        }

        //Methode zur Ausgabe der Output-Liste
        public static void outputElementList(string outputType, string outputContent)
        {
            //Ausgabetyp abrufen
            switch (outputType)
            {
                //Ausgabe in Zwischenablage
                case "clipboard":
                    System.Windows.Forms.Clipboard.SetDataObject(outputContent, true);
                    MessageBox.Show("Ausgabe kopiert.");
                    break;
                //Ausgabe in Dialog-Box
                case "dialogBox":
                    MessageBox.Show(outputContent);
                    break;
                //Kein Parameter -> Fehlermeldung
                default:
                    MessageBox.Show("Issue #000001\nKeine Output-Zuweisung - Bitte melden sie sich beim Entwickler!");
                    break;
            }
        }
    }
}
