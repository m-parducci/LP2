using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLacos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int B = 0, C = 0, D = 0, producao;
            double A, gratificacao, salarioBruto;
            if (double.TryParse(txtSalario.Text, out A) &&
                int.TryParse(txtProducao.Text, out producao))
            {
                if (string.IsNullOrEmpty(txtGratificacao.Text))
                {
                    MessageBox.Show("Campo de gratificação não pode ficar vazio");
                }
                else
                {
                    gratificacao = Convert.ToDouble(txtGratificacao.Text);
                    if (producao >= 100)
                        B = 1;
                    if (producao >= 120)
                        C = 1;
                    if (producao >= 150)
                        D = 1;
                    salarioBruto = A + A * (0.05 * B + 0.1 * C + 0.1 * D) + gratificacao;
                    if (salarioBruto > 7000 && producao < 150 || gratificacao == 0)
                        MessageBox.Show("Condições inválidas para salário bruto maior que 7.000,00:\nProdução deve ser maior do que 150\nNecessário ter gratificação");
                    else MessageBox.Show("Salário bruto é de: " + salarioBruto);
                }
            }

        }
    }
}
