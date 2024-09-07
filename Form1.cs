using System;
using System.Windows.Forms;

namespace WorldGuessApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            const string WORD = "Programming";
            string namesGuess = txtGuess.Text.Trim();

            if (namesGuess.Equals(WORD, StringComparison.OrdinalIgnoreCase))
            {

                lblWordToGuess.Text = $"The correct word is '{WORD}'.";
            }
            else
            {
                if (!WrongGuess.Items.Contains(namesGuess))
                {
                    WrongGuess.Items.Add(namesGuess);
                }
                WrongGuess.Text = "Try again!";
            }

            txtGuess.Clear();
            txtGuess.Focus();
        }

        private void lblWordToGuess_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WrongGuess.Items.Clear();
            WrongGuess.Text = "";
            lblWordToGuess.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

