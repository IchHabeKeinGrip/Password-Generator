using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passwort_Generator
{

    public partial class MainForm : Form
    {

        static bool English = false, Deutsch = true;


        public MainForm()
        {
            InitializeComponent();
        }

        private static string CreateRandomPasswordNoNumbers(int length)
        {
            string ValidChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!?=/<>";

            Random rnd = new Random();

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = ValidChars[rnd.Next(0, ValidChars.Length)];
            }

            return new string(chars);
        }

        private static string CreateRandomPasswordNoSpecialChars(int length)
        {
            string ValidChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";

            Random rnd = new Random();

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = ValidChars[rnd.Next(0, ValidChars.Length)];
            }

            return new string(chars);
        }

        private static string CreateRandomPasswordOnlyChars(int length)
        {
            string ValidChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            Random rnd = new Random();

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = ValidChars[rnd.Next(0, ValidChars.Length)];
            }

            return new string(chars);
        }

        private static string CreateRandomPasswordNumbersAndSpecialChars(int length)
        {
            string ValidChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890!?=/<>";

            Random rnd = new Random();

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = ValidChars[rnd.Next(0, ValidChars.Length)];
            }

            return new string(chars);
        }

        private void deutschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deutsch = true;
            English = false;
            MainForm mainform = new MainForm();
            mainform.Text = "Passwort Generator";
            btGeneratePassword.Text = "Generiere Passwort!";
            helpToolStripMenuItem.Text = "Hilfe";
            languageToolStripMenuItem.Text = "Sprache";
            btClose.Text = "Schließe";
            aboutToolStripMenuItem.Text = "Über den Passwort Generator";
            btCopy.Text = "Kopiere";
            cbNumers.Text = "Zahlen";
            cbSpecialChars.Text = "Sonderzeichen";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deutsch = false;
            English = true;
            MainForm mainform = new MainForm();
            mainform.Text = "Password Generator";
            btGeneratePassword.Text = "Generate Password!";
            helpToolStripMenuItem.Text = "Help";
            languageToolStripMenuItem.Text = "Language";
            btClose.Text = "Close";
            aboutToolStripMenuItem.Text = "About";
            btCopy.Text = "Copy";
            cbNumers.Text = "Numbers";
            cbSpecialChars.Text = "Special Chars";
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tBPasswordLenght_ValueChanged(object sender, EventArgs e)
        {
            lbPasswordLenght.Text = tBPasswordLenght.Value.ToString();
        }

        private void ToClipboard(string text)
        {
            System.Windows.Forms.Clipboard.SetDataObject(text);
        }

        private void btGeneratePassword_Click(object sender, EventArgs e)
        {
            if (cbNumers.Checked == true && cbSpecialChars.Checked == true)
            {
                tbPassword.Text = CreateRandomPasswordNumbersAndSpecialChars
                (
                tBPasswordLenght.Value
                );
            }
            else if (cbSpecialChars.Checked == true && cbNumers.Checked == false)
            {
                tbPassword.Text = CreateRandomPasswordNoNumbers
                (
                tBPasswordLenght.Value
                );
            }
            else if (cbSpecialChars.Checked == false && cbNumers.Checked == true)
            {
                tbPassword.Text = CreateRandomPasswordNoSpecialChars
                (
                tBPasswordLenght.Value
                );
            }
            else if (cbSpecialChars.Checked == false && cbNumers.Checked == false)
            {
                tbPassword.Text = CreateRandomPasswordOnlyChars
                (
                tBPasswordLenght.Value
                );
            }
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            if (Deutsch == false && English == true)
            {
                if (tbPassword.Text == "")
                {
                    MessageBox.Show("Please generate Password first!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ToClipboard(tbPassword.Text);
                }
            }
            else if (Deutsch == true && English == false)
            {
                if (tbPassword.Text == "")
                {
                    MessageBox.Show("Bitte generiere erst ein Passwort!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ToClipboard(tbPassword.Text);
                }
            }
        }

        private void ClickValueToTrackBarLocation(TrackBar a_tBar, int a_mouseX)
        {
            //Jump to the clicked Location

            double dblValue;
            dblValue = ((double)a_mouseX /
                (double)a_tBar.Width *
                (a_tBar.Maximum - a_tBar.Minimum));
            a_tBar.Value = Convert.ToInt32(dblValue);
        }

        private void tBPasswordLenght_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Deutsch == true && English == false)
            {
                MessageBox.Show("Von IchHabeKeinGrip.", "Passwort Generator | Hilfe", MessageBoxButtons.OK);
            }
            else if (English == true && Deutsch == false)
            {
                MessageBox.Show("By IchHabeKeinGrip.", "Password Generator | Hilfe", MessageBoxButtons.OK);
            }
        }
    }
}