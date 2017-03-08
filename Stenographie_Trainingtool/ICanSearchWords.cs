using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Stenographie_Trainingtool
{
    class ICanSearchWords
    {
        public string getHelpText(string helpTitle)
        {
            switch (helpTitle)
            {
                case "Wörterbuch suchen":
                    return "Wörterbuch suchen\r\n\r\nFür jede Suche muss ein Wörterbuch vorliegen.\r\n\r\nDas Nutzerwörterbuch muss im folgenden Format vorliegen:\r\n- Pro Zeile ein Wort\r\n- Dateiendung '.txt'\r\n\r\nEine Liste deutscher Worte kann über eine Suche im Internet gefunden werden, ein Beispiel ist unter https://sourceforge.net/projects/germandict/ zu finden (german.7z) (Herunterladen, entpacken (7-Zip), die german.dic in german.txt umbenennen und auswählen.).";
                case "Wörter suchen":
                    return "Wörter suchen\r\n\r\nWas gebe ich in 'Zu durchsuchende Buchstaben' ein?\r\nEine Liste aller Buchstaben, die kommasepariert sein kann (aber nicht sein muss), die bereits erlernt worden sind. Die Groß-/Kleinschreibung spielt keine Rolle.\r\nEs werden nur Wörter gesuht, die aus den gegebenen Buchtsaben bestehen.\r\n\r\nWas gebe ich in 'Nutzerwörterbuch' ein?\r\nSiehe dazu 'Wörterbuch suchen' in der Hilfe-Liste (links).";
                case "Umlaute & Akzente":
                    return "Umlaute & Akzente\r\n\r\nEine Suche nach Umlauten und Akzenten jeglicher Art ist leider nicht möglich - ein solches Feature ist (aktuell) auch nicht eingeplant.";
                case "Mein Programm friert ein...":
                    return "Mein Programm friert ein...\r\n\r\nWenn das Programm während der Suche einfriert, wurde anscheinend eine komplizierte Suche gestartet, sodass das gesamte Wörterbuch durchsucht werden muss. Bei sehr allgemeinen Suchen wird nur der Anfang der Datei durhsucht.";
                default:
                    MessageBox.Show("Issue #000002\r\nKeine Hilfe-Zuweisung - Bitte melden sie sich beim Entwickler!");
                    return "Es ist ein Fehler aufgetreten.";
            }
        }

        public string openDictionary(string userDictionary)
        {
            return userDictionary;
        }

        public string searchWords(string letters, int elementAmount, int elementLength, string userDictionary)
        {
            int counter = 0;
            string line;
            string lines = "";
            
            System.IO.StreamReader file = new System.IO.StreamReader(@userDictionary, System.Text.Encoding.Default, true);
            Regex letterValidator = new Regex(@"^[" + letters.ToLower() + "]+$");

            while ((line = file.ReadLine()) != null)
            {
                if (line.Length >= elementLength && letterValidator.IsMatch(line.ToLower())) {
                    lines += line;
                    if (counter < (elementAmount-1)) {
                        lines += System.Environment.NewLine;
                        counter++;
                    } else {
                        break;
                    }
                }
            }

            file.Close();
            return lines;
        }
    }
}
