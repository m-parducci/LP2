using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratica_Aula09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEx1_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[20];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite o {i + 1}º número:", "Digite um número"));
            }

            numeros = numeros.Reverse().ToArray();

            string resultado = string.Join(Environment.NewLine, numeros);

            MessageBox.Show(resultado, "Números invertidos");
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            int[] quantidades = new int[10];
            double[] precos = new double[10];

            double faturamentoMensal = 0;

            for (int i = 0; i < quantidades.Length; i++)
            {
                quantidades[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Digite a quantidade vendida da mercadoria {i + 1}:"));
                precos[i] = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox($"Digite o preço unitário da mercadoria {i + 1}:"));

                faturamentoMensal += quantidades[i] * precos[i];
            }

            MessageBox.Show($"O faturamento mensal é R${faturamentoMensal.ToString("0.00")}", "Faturamento Mensal");
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList() { "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais" };

            alunos.Remove("Otávio");

            string alunosRestantes = string.Join("\n", alunos.ToArray());
            MessageBox.Show(alunosRestantes, "Alunos Restantes");
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" }; Int32 I, Total = 0; Int32 N = Alunos.Length; for (I = 0; I < N - 1; I++) { Total += Alunos[I].Length; }
            MessageBox.Show(Total.ToString());
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];

            for (int i = 0; i < 20; i++)
            {
                notas[i, 0] = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite a nota 1 do aluno " + (i + 1)));
                notas[i, 1] = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite a nota 2 do aluno " + (i + 1)));
                notas[i, 2] = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite a nota 3 do aluno " + (i + 1)));
            }

            string resultado = "";
            for (int i = 0; i < 20; i++)
            {
                double media = (notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3;
                resultado += "Aluno " + (i + 1) + ": média = " + media.ToString("0.0") + "\n";
            }

            MessageBox.Show(resultado, "Médias dos Alunos");
        }

        private void btnEx6_Click(object sender, EventArgs e)
        {
            frmEx6 frmEx6 = new frmEx6();
            frmEx6.Show();
        }
    }
}
