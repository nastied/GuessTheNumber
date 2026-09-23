using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Guess : Form
    {
        int n =0;
        WitchCraft formainitiala = null;
        int nr1 = 0;
        int c = 0;
        public Guess()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Guess a number from 1 to " + n;
            Random random = new Random();
            nr1 = random.Next(1, n);
        }

        public Guess(int numar, WitchCraft form1)
        {
            InitializeComponent ();
            n = numar;
            formainitiala = form1;
        }

        private void renunta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The number was " + nr1);
            this.Hide();
            formainitiala.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void verifica_Click(object sender, EventArgs e)
        {
            
            int numar1 = 0;
            if (int.TryParse(textBox1.Text, out numar1) && (numar1 > 0 && numar1 <= n))
            {
                c += 1;
                if (numar1 < nr1)
                {
                    MessageBox.Show("Guess a bigger number.");
                    textBox1.Clear();
                }
                else if (numar1 > nr1)
                {
                    MessageBox.Show("Guess a smaller number");
                    textBox1.Clear();
                }
                else if (numar1 == nr1)
                {
                    MessageBox.Show("You found it! Took you " + c + " tries!");
                    textBox1.Clear();

                    this.Hide();
                    formainitiala.Show();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number! \nNumber needs to be positive and smaller than " + numar1.ToString() + ".");
                textBox1.Clear();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                //MessageBox.Show("Please enter numbers only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                verifica.PerformClick();
            }
        }
    }
}
