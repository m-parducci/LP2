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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            int i;
            string palavra = null;
            for (i = 0; i<txtFrase.Text.Length; i++)
            {
                if (!char.IsWhiteSpace(txtFrase.Text[i]))
                    palavra += txtFrase.Text[i];
            }
            string palavraInvertida = new string(palavra.Reverse().ToArray());
            if (palavraInvertida == palavra)
                MessageBox.Show("Palíndromo");
            else MessageBox.Show("Não é palíndromo");
        }
    }
}
