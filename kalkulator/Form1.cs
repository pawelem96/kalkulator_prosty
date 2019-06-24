using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        double liczba1;
        double liczba2;
        string kal;
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kalkulator stworzony przez Pawła Mońko 2019");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            liczba1 = 0;
            liczba2 = 0;
            kal = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = button1.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = button2.Text;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = button3.Text;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = button4.Text;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = button5.Text;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = button6.Text;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = button7.Text;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = button8.Text;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = button9.Text;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = button10.Text;
        }
        public void wynik()
        {
            liczba2 = System.Double.Parse(textBox1.Text);
            switch (kal)
            {
                case "+":
                    liczba1 = liczba1 + liczba2;
                    break;
                case "-":
                    liczba1 = liczba1 - liczba2;
                    break;
                case "*":
                    liczba1 = liczba1 * liczba2;
                    break;
                case "/":
                    liczba1 = liczba1 / liczba2;
                    if(liczba2==0)
                    { MessageBox.Show("Nie można dzielić przez zero!"); }

                    break;
            }
            textBox1.Text = liczba1.ToString();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            wynik();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            liczba1 = System.Double.Parse(textBox1.Text);
            kal = "+";
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            liczba1 = System.Double.Parse(textBox1.Text);
            kal = "-";
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            liczba1 = System.Double.Parse(textBox1.Text);
            kal = "*";
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            liczba1 = System.Double.Parse(textBox1.Text);
            kal = "/";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
                    } 

        }

        private void Button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = button18.Text;
        }
    }
}
