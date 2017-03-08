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
    public partial class formICan : Form
    {
        ICanSearchWords iCanSW = new ICanSearchWords();

        public formICan()
        {
            InitializeComponent();
        }

        //Methode beim Ändern der TrackBar
        private void trackbarElementAmount_Scroll(object sender, EventArgs e)
        {
            //Aktuellen Wert in Label ausgeben
            labelElementAmountSelectedValue.Text = trackbarElementAmount.Value.ToString();
        }

        private void listboxSelectHelpItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            textboxShowHelpItem.Text = iCanSW.getHelpText(listboxSelectHelpItem.SelectedItem.ToString());
        }

        //Methode beim Ändern der TrackBar
        private void trackbarElementLength_Scroll(object sender, EventArgs e)
        {
            //Aktuellen Wert in Label ausgeben
            labelElementLengthSelectedValue.Text = trackbarElementLength.Value.ToString();
        }

        private void buttonSearchWords_Click(object sender, EventArgs e)
        {
            buttonSearchWords.Enabled = false;
            buttonSearchWords.Cursor = Cursors.WaitCursor;

            textboxOutputWords.Text = iCanSW.searchWords(textboxElementLetters.Text, trackbarElementAmount.Value, trackbarElementLength.Value, textboxDictionarySource.Text);

            buttonSearchWords.Cursor = Cursors.Default;
            buttonSearchWords.Enabled = true;
        }

        private void buttonOpenDictionary_Click(object sender, EventArgs e)
        {
            if (openFileDialogDictionary.ShowDialog() == DialogResult.OK)
            {
                textboxDictionarySource.Text = iCanSW.openDictionary(openFileDialogDictionary.FileName);
            }
        }

        private void textboxElementLetters_TextChanged(object sender, EventArgs e)
        {
            if (textboxElementLetters.Text.Trim() != "" && textboxDictionarySource.Text.Trim() != "")
            {
                buttonSearchWords.Enabled = true;
            }
            else
            {
                buttonSearchWords.Enabled = false;
            }
        }

        private void textboxDictionarySource_TextChanged(object sender, EventArgs e)
        {
            if (textboxElementLetters.Text.Trim() != "" && textboxDictionarySource.Text.Trim() != "")
            {
                buttonSearchWords.Enabled = true;
            }
            else
            {
                buttonSearchWords.Enabled = false;
            }
        }

        private void textboxOutputWords_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if (e.Control && e.KeyValue == 65)
                textboxOutputWords.SelectAll();
        }
    }
}
