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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void BtnEspBran_Click(object sender, EventArgs e)
        {
            int numBrancos = 0;
            for (var i = 0; i < rchtxtFrase.Text.Length; i++)
            {
                if (char.IsWhiteSpace(rchtxtFrase.Text[i]))
                    numBrancos += 1;
            }
            if (numBrancos == 0)
                MessageBox.Show("Não há espaços em branco");
            else
                MessageBox.Show("O número de espaços em branco é de: " + numBrancos.ToString());
        }

        private void BtnPares_Click(object sender, EventArgs e)
        {
            /*char letraAnterior = '\0';
            int numPares = 0;
            for (var i = 0; i < rchtxtFrase.Text.Length; i++)
            {
                if (rchtxtFrase.Text[i] == letraAnterior) 
                numPares += 1;
                letraAnterior = rchtxtFrase.Text[i];
            }
            MessageBox.Show("N° de pares de letras: "+numPares.ToString());*/

            int numPares = 0;
            for (var i = 0; i < rchtxtFrase.Text.Length - 1; i++)
            {
                if (rchtxtFrase.Text[i] == rchtxtFrase.Text[i + 1])
                    numPares += 1;
            }
            MessageBox.Show("N° de pares de letras: " + numPares.ToString());
        }

        private void BtnR_Click(object sender, EventArgs e)
        {
            int numR = 0;
            for (var i = 0; i < rchtxtFrase.Text.Length; i++)
            {
                if (char.ToUpper(rchtxtFrase.Text[i]) == 'R')
                    numR += 1;
            }
            if (numR == 0)
                MessageBox.Show("Não há letras R na frase");
            else
            MessageBox.Show("O número de letras R é de: " + numR.ToString());
        }
    }
}
