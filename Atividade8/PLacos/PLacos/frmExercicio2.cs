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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void BtnH_Click(object sender, EventArgs e)
        {
            int numero = 0;
            if (int.TryParse(txtNumero.Text, out numero))
            {
                if (numero <=0 )
                    MessageBox.Show("Número deve ser maior do que 0");
                else
                {
                    double h = 0;
                    for (var i = 1; i <= numero; i++)
                        h += 1 / (double)i;
                    MessageBox.Show("Valor de H: " + h.ToString());
                }
            }
        }
    }
}
