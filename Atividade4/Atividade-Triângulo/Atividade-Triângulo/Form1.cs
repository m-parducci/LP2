using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Triângulo
{
    public partial class Form1 : Form
    {
        double ladoA, ladoB, ladoC;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtLadoA_TextChanged(object sender, EventArgs e)
        {
                        
        }

        private void txtLadoA_Validating(object sender, CancelEventArgs e)
        {
            if (txtLadoA.Text != string.Empty)
            {
                if (!double.TryParse(txtLadoA.Text, out ladoA))
                    MessageBox.Show("Inserir um número válido");
            }
            else
                MessageBox.Show("Inserir valor");

        }

        private void txtLadoB_Validating(object sender, CancelEventArgs e)
        {
            if (txtLadoB.Text != string.Empty)
            {
                if (!double.TryParse(txtLadoB.Text, out ladoB))
                    MessageBox.Show("Inserir um número válido");
            }
            else
                MessageBox.Show("Inserir valor");

        }

        private void txtLadoC_Validating(object sender, CancelEventArgs e)
        {
            if (txtLadoC.Text != string.Empty)
            {
                if (!double.TryParse(txtLadoC.Text, out ladoC))
                    MessageBox.Show("Inserir um número válido");
            }
            else
                MessageBox.Show("Inserir valor");

        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            if (ladoA < (ladoB+ladoC) && ladoA > Math.Abs(ladoB-ladoC) && ladoB < ladoA + ladoC && ladoB > Math.Abs (ladoA - ladoC) && ladoC < ladoA + ladoB && ladoC > Math.Abs (ladoA-ladoB))
                {
                if (ladoA == ladoB && ladoA == ladoC)
                    MessageBox.Show("Triângulo equilátero");
                else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                    MessageBox.Show("Triângulo isóceles");
                else MessageBox.Show("Triângulo escaleno");
            }
            else MessageBox.Show("Valores inválidos para um triângulo");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
        }
    }
}
