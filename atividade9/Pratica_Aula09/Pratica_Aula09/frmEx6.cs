using System;
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
    public partial class frmEx6 : Form
    {
        public frmEx6()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int digito = 7;
            int N = digito;

            string[] nomes = new string[N];
            int[] tamanhos = new int[N];

            for (int i = 0; i < N; i++)
            {
                nomes[i] = Microsoft.VisualBasic.Interaction.InputBox("Digite o nome completo da pessoa " + (i + 1) + ":");
                tamanhos[i] = nomes[i].Replace(" ", "").Length;
            }

            for (int i = 0; i < N; i++)
            {
                lstbxNomes.Items.Add("O nome: " + nomes[i] + " tem " + tamanhos[i] + " caracteres");
            }
        }
        public ListBox ListaNomes
        {
            get { return lstbxNomes; }
            set { lstbxNomes = value; }
        }

        private void lstbxNomes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
