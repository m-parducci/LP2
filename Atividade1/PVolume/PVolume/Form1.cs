using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double raio;
            if (!double.TryParse(textBox1.Text, out raio))
            {
                MessageBox.Show("Raio inválido");
                textBox1.Focus(); //volta para o componente textbox1
            }

            else if (raio <= 0)
            {
                MessageBox.Show("Raio precisa ser maior do que 0");
                textBox1.Focus();
            }

            double altura;
            if (!double.TryParse(textBox2.Text, out altura))
            {
                MessageBox.Show("Altura inválida");
                textBox2.Focus();
            }

            else if (altura <= 0)
            {
                MessageBox.Show("Altura precisa ser maior do que 0");
                textBox2.Focus();
            }
            double volume;
            volume = Math.PI * Math.Pow(raio, 2) * altura;
            textBox3.Text = volume.ToString("N2");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_Validated(object sender, EventArgs e)
        {
            double raio;
            if (!double.TryParse(textBox1.Text, out raio))
                MessageBox.Show("Raio inválido");
            else if (raio <= 0)
                MessageBox.Show("Raio precisa ser maior do que 0");
        }

        private void TextBox2_Validated(object sender, EventArgs e)
        {
            double altura;
            if (!double.TryParse(textBox2.Text, out altura))
                MessageBox.Show("Altura inválida");
            else if (altura <= 0)
                MessageBox.Show("Altura precisa ser maior do que 0");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
