using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void frmMensalista_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInstMensal_Click(object sender, EventArgs e)
        {
            // criar ou instanciar o objeto da classe mensalista
            // não eh possivel fazer empregado obj1 = new empregado();

            Mensalista objMensalista = new Mensalista();
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalMensal.Text);

            if (rbtnSim.Checked)
                objMensalista.HomeOffice = 'S';
            else objMensalista.HomeOffice = 'N';

            
            MessageBox.Show("Matricula: " + objMensalista.Matricula + "\n" +
                "Nome: " + objMensalista.NomeEmpregado + "\n" + "Data de Entrada: " +
                objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                "Salário Bruto: " + objMensalista.SalarioBruto().ToString("N2") +
                "\n" + "Tempo Empresa (dias): " + objMensalista.TempoTrabalho() +
                "\n" + objMensalista.VerificaHome());
                 
        }
    }
}
