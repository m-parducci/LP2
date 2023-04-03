using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSalario
{
    public partial class Form1 : Form
    {
        double SalBruto = 0;
        int NumFilhos = 0;
        double AliquotaINSS = 0;
        double AliquotaIRPF = 0;
        double SalFamilia = 0;
        double SalLiquido = 0;
        double DescontoINSS = 0;
        double DescontoIRPF = 0;
        string NomeFunc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void TxtNomeFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
                MessageBox.Show("Caracter inválido");
        }

        private void TxtNomeFunc_Validated(object sender, EventArgs e)
        {
            NomeFunc = txtNomeFunc.Text;
            if (txtNomeFunc.Text.Length < 10)
            {
                MessageBox.Show("Nome não pode ter menos do que 10 caracteres!");
                txtNomeFunc.Focus();
            }
        }

        private void mskbxSalarioBruto_Validated(object sender, EventArgs e)
        {
            if (!double.TryParse(mskbxSalarioBruto.Text, out SalBruto))
            {
                MessageBox.Show("Salário Inválido");
                mskbxSalarioBruto.Focus();
            }
            else if (SalBruto <= 0)
            {
                MessageBox.Show("Salário deve ser maior ou diferente de 0");
                mskbxSalarioBruto.Focus();
            }

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            NomeFunc = txtNomeFunc.Text;
            string saida;
            NumFilhos = Convert.ToInt32(cbxNumeroFilhos.SelectedItem);

            if (ckbxEstadoCivil.Checked & NumFilhos > 0 & rbtnFem.Checked)
            {

                saida = "Os descontos do salário da funcionária " + NomeFunc + " que é casada e tem " + NumFilhos + " filho(s)";
                lblSaida.Text = saida;
            }
            else if (ckbxEstadoCivil.Checked & NumFilhos == 0 & rbtnFem.Checked)
            {

                saida = "Os descontos do salário da funcionária " + NomeFunc + " que é casada e não tem filhos";
                lblSaida.Text = saida;
            }
            else if (!ckbxEstadoCivil.Checked & NumFilhos == 0 & rbtnFem.Checked)
            {

                saida = "Os descontos do salário da funcionária " + NomeFunc + " que é solteira e não tem filhos";
                lblSaida.Text = saida;
            }
            else if (!ckbxEstadoCivil.Checked & NumFilhos > 0 & rbtnFem.Checked)
            {

                saida = "Os descontos do salário da funcionária " + NomeFunc + " que é solteira e tem " + NumFilhos + " filho(s)";
                lblSaida.Text = saida;
            }
            else if (ckbxEstadoCivil.Checked & NumFilhos > 0 & rbtnMasc.Checked)
            {

                saida = "Os descontos do salário do funcionário " + NomeFunc + " que é casado e tem " + NumFilhos + " filho(s)";
                lblSaida.Text = saida;
            }
            else if (ckbxEstadoCivil.Checked & NumFilhos == 0 & rbtnMasc.Checked)
            {

                saida = "Os descontos do salário do funcionário " + NomeFunc + " que é casado e não tem filhos";
                lblSaida.Text = saida;
            }
            else if (!ckbxEstadoCivil.Checked & NumFilhos == 0 & rbtnMasc.Checked)
            {

                saida = "Os descontos do salário do funcionário " + NomeFunc + " que é solteiro e não tem filhos";
                lblSaida.Text = saida;
            }
            else if (!ckbxEstadoCivil.Checked & NumFilhos > 0 & rbtnMasc.Checked)
            {

                saida = "Os descontos do salário do funcionário " + NomeFunc + " que é solteiro e tem " + NumFilhos + " filho(s)";
                lblSaida.Text = saida;
            }
            if (SalBruto <= 800.47)
            {
                mskbxAliqINSS.Text = "7,65%";
                DescontoINSS = 0.0765 * SalBruto;
                mskbxDescINSS.Text = DescontoINSS.ToString("N2");
            }
            else if (SalBruto <= 1050)
            {
                mskbxAliqINSS.Text = "8,65%";
                DescontoINSS = 0.0865 * SalBruto;
                mskbxDescINSS.Text = DescontoINSS.ToString("N2");
            }
            else if (SalBruto <= 1400.77)
            {
                mskbxAliqINSS.Text = "9,00%";
                DescontoINSS = 0.09 * SalBruto;
                mskbxDescINSS.Text = DescontoINSS.ToString("N2");
            }
            else if (SalBruto <= 2801.56)
            {
                mskbxAliqINSS.Text = "11,00%";
                DescontoINSS = 0.11 * SalBruto;
                mskbxDescINSS.Text = DescontoINSS.ToString("N2");
            }
            else
            {
                DescontoINSS = 308.17;
                mskbxDescINSS.Text = DescontoINSS.ToString("N2");
            }
            if (SalBruto <= 1257.12)
            {
                mskbxAliqIRPF.Text = "Isento";
                mskbxDescIRPF.Text = "-";
            }
            else if (SalBruto <= 2512.08)
            {
                mskbxAliqIRPF.Text = "15,00%";
                DescontoIRPF = 0.15 * SalBruto;
                mskbxDescIRPF.Text = DescontoIRPF.ToString("N2");
            }
            else if (SalBruto > 2512.08)
            {
                mskbxAliqIRPF.Text = "27,50%";
                DescontoIRPF = 0.275 * SalBruto;
                mskbxDescIRPF.Text = DescontoIRPF.ToString("N2");
            }
            if (SalBruto < 435.52)
            {
                SalFamilia = 22.33 * NumFilhos;
                mskbxSalFam.Text = SalFamilia.ToString("N2");
            }
            else if (SalBruto <= 654.61)
            {
                SalFamilia = 15.74 * NumFilhos;
                mskbxSalFam.Text = SalFamilia.ToString("N2");
            }
            else
            {
                SalFamilia = 0;
                mskbxSalFam.Text = "0";
            }
            SalLiquido = SalBruto - DescontoINSS - DescontoIRPF + SalFamilia;
            mskbxSalLiq.Text = SalLiquido.ToString("N2");
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeFunc.Clear();
            mskbxSalarioBruto.Clear();
            cbxNumeroFilhos.Items.Clear();
        }
    }
}




