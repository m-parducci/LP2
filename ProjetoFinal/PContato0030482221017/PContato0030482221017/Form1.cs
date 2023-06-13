using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PContato0030482221017
{
    public partial class Form1 : Form
    {
        public static SqlConnection conexao;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=Apolo;Initial Catalog=LP2; USER ID=BD2221017; PASSWORD=FMayla@2019");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro de banco de dados =/" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Outros erros =/" + ex.Message);
            }
        }

        private void CadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCidade>().Count() > 0)
            {
                MessageBox.Show("Formulário já existe!");
                Application.OpenForms["frmCidade"].BringToFront();
            }
            else
            {
                frmCidade objCidade = new frmCidade();
                objCidade.MdiParent = this;
                objCidade.WindowState = FormWindowState.Maximized;
                objCidade.Show();
            }
        }

        private void ContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmContato>().Count() > 0)
            {
                MessageBox.Show("Formulário já existe!");
                Application.OpenForms["frmContato"].BringToFront();
            }
            else
            {
                frmContato objContato = new frmContato();
                objContato.MdiParent = this;
                objContato.WindowState = FormWindowState.Maximized;
                objContato.Show();
            }
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abxSobre objSobre = new abxSobre();
            objSobre.Show();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
