using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMenu
{
    public partial class frmExercicio4 : Form
    {
        int caracNum, caracAlfa, espacoBr, i;
        string texto;

        private void btnCaractAlfa_Click(object sender, EventArgs e)
        {
            texto = rtxTexto1.Text;
            i = 0;
            foreach  (char i in texto)
            {
                if (char.IsLetter(i))
                caracAlfa++;
             }
            MessageBox.Show($"O texto possui {caracAlfa} caracteres alfabéticos.");
        }

        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnPrimeiroBr_Click(object sender, EventArgs e)
        {
            texto = rtxTexto1.Text;
            espacoBr = 0;
            while (espacoBr < texto.Length && !char.IsWhiteSpace(texto[espacoBr]))
                {   
                espacoBr++;
                }
            if (espacoBr < texto.Length)
            {
                MessageBox.Show("O primeiro espaço em branco está na posição: " + (espacoBr));
            }
            else
            {
                MessageBox.Show("Nenhum espaço em branco encontrado.");
            }
        }

        private void btnCaracterNum_Click(object sender, EventArgs e)
        {
            texto = rtxTexto1.Text;
            for (i = 0; i < texto.Length; i++)
            {
                if (char.IsNumber(texto[i]))
                    caracNum++;
            }
            MessageBox.Show("O número de caracteres numéricos é de: " + caracNum);
        }
    }
}
