using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PContato0030482221017
{
    public partial class frmContato : Form
    {
        private BindingSource bnContato = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsCidade = new DataSet();
        private DataSet dsContato = new DataSet();
        public frmContato()
        {
            InitializeComponent();
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void FrmContato_Load(object sender, EventArgs e)
        {
            try
            {
                Contato Con = new Contato();
                dsContato.Tables.Add(Con.Listar());
                bnContato.DataSource = dsContato.Tables["Contato"];
                dgvContato.DataSource = bnContato;
                bnvContato.BindingSource = bnContato;


                txtIDContato.DataBindings.Add("TEXT", bnContato, "id_contato");
                txtNomeContato.DataBindings.Add("TEXT", bnContato, "nome_contato");
                txtEnderecoContato.DataBindings.Add("TEXT", bnContato, "end_contato");
                txtCelContato.DataBindings.Add("TEXT", bnContato, "cel_contato");
                txtEmailContato.DataBindings.Add("TEXT", bnContato, "email_contato");
                dtpDataCadastro.DataBindings.Add("TEXT", bnContato, "dtcadastro_contato");

                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                cbxCidadeContato.DataSource = dsCidade.Tables["Cidade"];

                cbxCidadeContato.DisplayMember = "nome_cidade";

                cbxCidadeContato.ValueMember = "id_cidade";

                cbxCidadeContato.DataBindings.Add("SelectedValue", bnContato, "cidade_id_cidade");
            }

            catch (Exception)
            {
                MessageBox.Show("Erro ao listar Contatos");
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (tbContato.SelectedIndex == 0)
            {
                tbContato.SelectTab(1);
            }
                bnContato.AddNew();

                txtIDContato.Enabled = false;
                txtNomeContato.Enabled = true;
                txtEnderecoContato.Enabled = true;
                txtCelContato.Enabled = true;
                txtEmailContato.Enabled = true;
                dtpDataCadastro.Enabled = true;
                cbxCidadeContato.Enabled = true;

                btnNovo.Enabled = false;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;

                bInclusao = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            double teste;
            if (txtNomeContato.Text == "" || txtNomeContato.Text.Length < 3)
            {
                MessageBox.Show("Contato inválido");
            }
            else if (txtIDContato.Text == "" || txtIDContato.Text.Length > 3)
            {
                MessageBox.Show("ID inválido");
            }
            else if (txtEnderecoContato.Text == "" || txtEnderecoContato.Text.Length < 3 || txtEnderecoContato.Text.Length > 100)
            {
                MessageBox.Show("Endereço Inválido");
            }
            else if (txtCelContato.Text == "" || txtCelContato.Text.Length < 11 || !long.TryParse(txtCelContato.Text, out _))
            {
                MessageBox.Show("Celular inválido");
            }
            else if (txtEmailContato.Text == "" || txtEmailContato.Text.Length < 3 || txtEmailContato.Text.Length > 100)
            {
                MessageBox.Show("E-mail inválido");
            }
            else if (dtpDataCadastro.Text == "" || dtpDataCadastro.Text.Length < 8)
            {
                MessageBox.Show("Data de cadastro inválida");
            }
            else if (cbxCidadeContato.Text == "")
            {
                MessageBox.Show("Cidade inválida");
            }
            else
            {
                Contato RegCon = new Contato();
                RegCon.Idcontato = Convert.ToInt32(txtIDContato.Text);
                RegCon.Nomecontato = txtNomeContato.Text;
                RegCon.Endcontato = txtEnderecoContato.Text;
                RegCon.Cidadeidcidade = Convert.ToInt32(cbxCidadeContato.SelectedValue.ToString());
                RegCon.Celcontato = txtCelContato.Text;
                RegCon.Emailcontato = txtEmailContato.Text;
                RegCon.Dtcadastrocontato = Convert.ToDateTime(dtpDataCadastro.Text);


                if (bInclusao)
                {
                    if (RegCon.Salvar() > 0)
                    {
                        MessageBox.Show("Contato adicionado com sucesso!", "SUCESSO");

                        txtNomeContato.Enabled = false;
                        txtIDContato.Enabled = false;
                        txtEnderecoContato.Enabled = false;
                        cbxCidadeContato.Enabled = false;
                        txtCelContato.Enabled = false;
                        txtEmailContato.Enabled = false;
                        dtpDataCadastro.Enabled = false;

                        btnNovo.Enabled = true;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;
                        bInclusao = false;

                        dsContato.Tables.Clear();
                        dsContato.Tables.Add(RegCon.Listar());
                        bnContato.DataSource = dsContato.Tables["Contato"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Contato!", "ERRO");
                    }
                }

                else
                {
                    if (RegCon.Alterar() > 0)
                    {
                        MessageBox.Show("Contato alterado com sucesso!");
                        dsContato.Tables.Clear();
                        dsContato.Tables.Add(RegCon.Listar());
                        txtIDContato.Enabled = false;
                        txtNomeContato.Enabled = false;
                        txtEnderecoContato.Enabled = false;
                        txtCelContato.Enabled = false;
                        txtEmailContato.Enabled = false;
                        cbxCidadeContato.Enabled = false;
                        dtpDataCadastro.Enabled = false;

                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnNovo.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar Contato!");
                    }
                }
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            // ID NOME ENDEREÇO CIDADE TELEFONE EMAIL DATA CADASTRO
            if (tbContato.SelectedIndex == 0)
            {
                tbContato.SelectTab(1);
            }
            txtNomeContato.Enabled = true;
            txtIDContato.Enabled = false;
            txtEnderecoContato.Enabled = true;
            cbxCidadeContato.Enabled = true;
            txtCelContato.Enabled = true;
            txtEmailContato.Enabled = true;
            dtpDataCadastro.Enabled = true;


            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (tbContato.SelectedIndex == 0)
            {
                tbContato.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
           == DialogResult.Yes)
            {
                Contato RegCon = new Contato();
                RegCon.Idcontato = Convert.ToInt16(txtIDContato.Text);
                if (RegCon.Excluir() > 0)
                {
                    MessageBox.Show("Contato excluído com sucesso!");
                    Contato C = new Contato();
                    dsContato.Tables.Clear();
                    dsContato.Tables.Add(C.Listar());
                    bnContato.DataSource = dsContato.Tables["Contato"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir contato!");
                }
            }
        }
        // ID NOME ENDEREÇO CIDADE TELEFONE EMAIL DATA CADASTRO
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            bnContato.CancelEdit();

            txtIDContato.Enabled = false;
            txtNomeContato.Enabled = false;
            txtEnderecoContato.Enabled = false;
            cbxCidadeContato.Enabled = false;
            txtCelContato.Enabled = false;
            txtEmailContato.Enabled = false;
            dtpDataCadastro.Enabled = false;


            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
