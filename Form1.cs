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
    public partial class WitchCraft : Form
    {
        public WitchCraft()
        {
            InitializeComponent();
        }

        private void joaca_Click(object sender, EventArgs e)
        {
            int numar = 0;
            if (int.TryParse(textBox1.Text, out numar) && numar > 0 && numar < 9999)
            {
                textBox1.Clear();
                Guess form2 = new Guess(numar, this);
                this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Please enter a valid number! \nNumber needs to be positive and smaller than 9999.");
                textBox1.Clear();
            }
        }

        public void WitchCraft_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                joaca.PerformClick();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
