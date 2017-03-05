﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace Stenographie_Trainingtool
{
    class GeneratePDF
    {
        public static void generatePDF(string elementList)
        {

            // PDF-Dokument initialisieren und Eigenschaften hinzufügen
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Stenographie Training-Tool";
            document.Info.Author = "Frank Nelles";
            document.Info.Creator = "Frank Nelles";
            document.Info.Subject = "Stenographie Übungen";

            // Seite und Grafikfläche hinzufügen
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            // Umschließende Linie hinzufügen (Rechteck)
            XPen pen = new XPen(XColors.Gray, 3);
            XPoint[] points = new XPoint[] { new XPoint(40, 39), new XPoint(40, 789), new XPoint(555, 789), new XPoint(555, 40), new XPoint(39, 40) };
            gfx.DrawLines(pen, points);

            // Alle Linien hinzufügen
            ///Zählervariablen erstellen: i=Punkte; j=Dicke Linie; k=Lange Linie/Stenozeilenende
            int i = 51; int j = 2; int k = 1;
            //Linien einfügen
            while (i <= 778)
            {
                //Liniendicke einstellen
                int lineHeight = 1;
                //Jede vierte Linie (beginnend ab 3.) dicker
                if ((j%4) == 0) lineHeight = 2;

                //Linienbreite einstellen
                int lineWidthXStart = 120;
                //Jede vierte Linie (beginnend ab 4.) breiter
                if ((k % 4) == 0) lineWidthXStart = 40;

                //Stifteigenschaften festlegen
                pen = new XPen(XColors.Black, lineHeight);
                //Linie zeichnen
                gfx.DrawLine(pen, lineWidthXStart, i, 554, i);

                //Linie 11 Punkte weiter unten erstellen (i), Zeilenanzahl erhöhe
                i += 11; j++; k++;
            }

            //Texteigenschaften
            XFont font = new XFont("Verdana", 10);

            //Arraydurchlauf-Variable
            int l = 0;
            //Text-Ausgabe in Array zerlegen
            string[] wordOrLetter = elementList.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

            //Bis zu 17 Buchstaben/Wort -Ketten ausgeben
            foreach (string outputWordOrLetter in wordOrLetter)
            {
                //Text ausgeben
                gfx.DrawString(outputWordOrLetter, font, XBrushes.Black, new XRect(45, (70 + (44*l)), page.Width, page.Height), XStringFormats.TopLeft);
                //Zähler-Variable erhöhen
                l++;
                //Nach 17 Elementen abbrechen
                if (l > 16) break;
            }

            //Timestamp generieren
            TimeSpan t = (DateTime.UtcNow - new DateTime(1970, 1, 1));
            int timestamp = (int)t.TotalSeconds;

            // Dokument speichern
            string filename = "Übung_" + timestamp.ToString() + ".pdf";
            document.Save(filename);

            //Erfolgsmeldung
            MessageBox.Show("Die PDF wurde generiert und als " + filename + " abgespeichert.\nDie PDF-Datei kann bis zu 17 Buchstaben oder Wörter aufnehmen. Fehlende wurden durch Leerzeichen ersetzt und überschüssige entfernt.");
        }
    }
}