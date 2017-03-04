using System;
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

            // Create a new PDF document
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            // Create an empty page
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            //// Create rectangle
            XPen pen = new XPen(XColors.Gray, 3);
            XPoint[] points = new XPoint[] { new XPoint(40, 39), new XPoint(40, 789), new XPoint(555, 789), new XPoint(555, 40), new XPoint(39, 40) };
            gfx.DrawLines(pen, points);

            //// Create lines
            int i = 51;
            int j = 2;
            int k = 1;
            while (i <= 778)
            {
                int lineHeight = 1;
                if ((j%4) == 0) lineHeight = 2;

                int lineWidthXStart = 120;
                if ((k % 4) == 0) lineWidthXStart = 40;

                pen = new XPen(XColors.Black, lineHeight);
                gfx.DrawLine(pen, lineWidthXStart, i, 554, i);

                i += 11; j++; k++;
            }

            // Draw the text
            XFont font = new XFont("Verdana", 10);

            int l = 0;
            string[] wordOrLetter = elementList.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string outputWordOrLetter in wordOrLetter)
            {
                gfx.DrawString(outputWordOrLetter, font, XBrushes.Black, new XRect(45, (70 + (44*l)), page.Width, page.Height), XStringFormats.TopLeft);
                l++;
                if (l > 16) break;
            }

            //Timestamp generieren
            TimeSpan t = (DateTime.UtcNow - new DateTime(1970, 1, 1));
            int timestamp = (int)t.TotalSeconds;

            // Save the document
            string filename = "Übung_" + timestamp.ToString() + ".pdf";
            document.Save(filename);

            MessageBox.Show("Die PDF wurde generiert und als " + filename + " abgespeichert.\nDie PDF-Datei kann bis zu 17 Buchstaben oder Wörter aufnehmen. Fehlende wurden durch Leerzeichen ersetzt und überschüssige entfernt.");
        }
    }
}