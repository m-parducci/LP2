using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_IMC
{
    public partial class Form1 : Form
    {
        double altura, peso, IMC;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPeso_Validating(object sender, CancelEventArgs e)
        {
            if (double.TryParse(txtPeso.Text, out peso))
            {
                if (double.Parse(txtPeso.Text) <= 0)
                {
                    MessageBox.Show("Inserir um número maior do que 0");
                    txtPeso.Focus();
                }

            }
            else
            {
                MessageBox.Show("Inserir um número válido");
                txtPeso.Focus();
            }
        }

        private void txtAltura_Validating(object sender, CancelEventArgs e)
        {
            if (double.TryParse(txtAltura.Text, out altura))
            {
                if (double.Parse(txtAltura.Text) <= 0)
                {
                    MessageBox.Show("Inserir uma altura maior do que 0");
                    txtPeso.Focus();
                }

            }
            else
            {
                MessageBox.Show("Inserir uma altura válida");
                txtPeso.Focus();
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            IMC = peso / (Math.Pow(altura, 2));
            IMC = Math.Round(IMC, 1);
            txtIMC.Text = IMC.ToString();

            if (IMC < 18.5)
                MessageBox.Show("Classificação: Magreza \nObesidade grau 0");
            else if (IMC < 24.9)
            {
                MessageBox.Show("Classificação: Normal \nObesidade grau 0");
            }
            else if (IMC < 29.9)
                MessageBox.Show("Classificação: Sobrepeso \nObesidade grau 1");
            else if (IMC < 39.9)
                MessageBox.Show("Classificação: Obesidade \nObesidade grau 2");
            else if (IMC > 40)
                MessageBox.Show("Classificação: Obesidade Grave \nObesidade grau 3");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            txtIMC.Clear();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();

        }

        private void btnSair_Click(object sender, EventArgs e)
            {
               
            }

            private void txtPeso_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }
