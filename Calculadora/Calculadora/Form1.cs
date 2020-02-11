using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            float n1, n2;

            n1 = float.Parse(textBox1.Text);
            n2 = float.Parse(textBox2.Text);

            label1.Text = (n1 - n2).ToString();
        }

        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            float n1, n2;

            n1 = float.Parse(textBox1.Text);
            n2 = float.Parse(textBox2.Text);

            label1.Text = (n1 + n2).ToString();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            float n1, n2;

            n1 = float.Parse(textBox1.Text);
            n2 = float.Parse(textBox2.Text);

            label1.Text = (n1 * n2).ToString();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            float n1, n2;

            n1 = float.Parse(textBox1.Text);
            n2 = float.Parse(textBox2.Text);

            label1.Text = (n1 / n2).ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
