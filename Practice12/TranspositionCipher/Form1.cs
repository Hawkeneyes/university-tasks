using System;
using System.Windows.Forms;

namespace TranspositionCipher
{
    public partial class Form1 : Form
    {
        Transposition t;

        public Form1()
        {
            InitializeComponent();

            t = new Transposition();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            t.SetKey(keyTextBox.Text);

            if (encryptRadioButton.Checked)
                outputTextBox.Text = t.Encrypt(inputTextBox.Text);
            else
                outputTextBox.Text = t.Decrypt(inputTextBox.Text);
        }
    }
}