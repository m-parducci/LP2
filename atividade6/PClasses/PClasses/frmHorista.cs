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
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtData.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalarioHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumHoras.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtFaltas.Text);
            if (rbtnSim.Checked)
                objHorista.HomeOffice = 'S';
            else if (rbtnNao.Checked)
                objHorista.HomeOffice = 'N';

            MessageBox.Show("Matrícula: " + objHorista.Matricula + "\n" + "Nome: " + objHorista.NomeEmpregado + "\n" + "Data Entrada: " + objHorista.DataEntradaEmpresa.ToShortDateString() + "\n" + "Salário Bruto: " + objHorista.SalarioBruto().ToString("N2") + "\n" + "Tempo Empresa (Dias): " + objHorista.TempoTrabalho() + "\n" + objHorista.VerificaHome());
        }
    }
}
