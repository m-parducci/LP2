using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalc
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado; //declarando variaveis globais
        public Form1()
        {
            InitializeComponent();
        }

        private void Botao_limpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResult.Clear();
        }

        private void TxtNum2_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum2.Text, out numero2))
            {
                MessageBox.Show("Número 2 inválido!"); //txtNum1.Focus();
            }
        }

        private void TxtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Botao_soma_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) && (double.TryParse(txtNum2.Text, out numero2)))
            {
                resultado = numero1 + numero2;
                txtResult.Text = resultado.ToString();
            }
            else MessageBox.Show("Números inválidos!");
        }

        private void Botao_sub_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) && (double.TryParse(txtNum2.Text, out numero2)))
            {
                resultado = numero1 - numero2;
                txtResult.Text = resultado.ToString();
            }
            else MessageBox.Show("Números inválidos!");
        }

        private void Botao_mult_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) && (double.TryParse(txtNum2.Text, out numero2)))
            {
                resultado = numero1 * numero2;
                txtResult.Text = resultado.ToString();
            }
            else MessageBox.Show("Números inválidos!");
        }

        private void Botao_div_Click(object sender, EventArgs e)
        {
            if ((double.TryParse(txtNum1.Text, out numero1)) && (double.TryParse(txtNum2.Text, out numero2)))
            {
                if (numero2 == 0)
                    MessageBox.Show("Não pode dividir número por zero!");
                else
                    resultado = numero1 / numero2;
                txtResult.Text = resultado.ToString();
            }
            else MessageBox.Show("Números inválidos!");
        }

        private void Botao_sair_Click_1(object sender, EventArgs e)
        {
            Close();
        }


        private void TxtNum1_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out numero1))
            {
                MessageBox.Show("Número 1 inválido!"); //txtNum1.Focus();
            }
        }
    }
}
