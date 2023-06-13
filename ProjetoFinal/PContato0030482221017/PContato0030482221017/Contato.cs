using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;

namespace PContato0030482221017
{
    class Contato
    {
        private int idcontato;
        private string nomecontato;
        private string endcontato;
        private int cidadeidcidade;
        private string celcontato;
        private string emailcontato;
        private DateTime dtcadastrocontato;

        public int Idcontato { get => idcontato; set => idcontato = value; }
        public string Nomecontato { get => nomecontato; set => nomecontato = value; }
        public string Endcontato { get => endcontato; set => endcontato = value; }
        public int Cidadeidcidade { get => cidadeidcidade; set => cidadeidcidade = value; }
        public string Celcontato { get => celcontato; set => celcontato = value; }
        public string Emailcontato { get => emailcontato; set => emailcontato = value; }
        public DateTime Dtcadastrocontato { get => dtcadastrocontato; set => dtcadastrocontato = value; }


        public DataTable Listar()
        {
            SqlDataAdapter daContato;
            DataTable dtContato = new DataTable();

            try
            {
                daContato = new SqlDataAdapter("select * from CONTATO", Form1.conexao);
                daContato.Fill(dtContato);
                daContato.FillSchema(dtContato, SchemaType.Source);
            }
            catch (Exception)
            {
                throw;
            }
            return dtContato;
        }

        public int Salvar()
        {
            int nReg = 0;
            try
            {
                SqlCommand mycommand;

                mycommand = new SqlCommand("INSERT INTO CONTATO VALUES (@nomecontato ,@endcontato, @cidadeidcidade, @celcontato, @emailcontato, @dtcadastrocontato)", Form1.conexao);
                mycommand.Parameters.Add(new SqlParameter("@nomecontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@endcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidadeidcidade", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@celcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@emailcontato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dtcadastrocontato", SqlDbType.VarChar));
                mycommand.Parameters["@nomecontato"].Value = Nomecontato;
                mycommand.Parameters["@endcontato"].Value = Endcontato;
                mycommand.Parameters["@cidadeidcidade"].Value = Cidadeidcidade;
                mycommand.Parameters["@celcontato"].Value = Celcontato;
                mycommand.Parameters["@emailcontato"].Value = Emailcontato;
                mycommand.Parameters["@dtcadastrocontato"].Value = Dtcadastrocontato;

                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }
        public int Excluir()
        {
            int nReg = 0;

            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("DELETE FROM CONTATO WHERE (id_contato=@id_contato)", Form1.conexao);
                mycommand.Parameters.Add(new SqlParameter("@id_contato", SqlDbType.Int));
                mycommand.Parameters["@id_contato"].Value = Idcontato;
                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return nReg;
        }
        public int Alterar()
        {
            int nReg = 0;
            try
            {
                SqlCommand mycommand;
                mycommand = new SqlCommand("UPDATE CONTATO SET nome_contato = @nome_contato, end_contato = @end_contato, cidade_id_cidade= @cidade_id_cidade, cel_contato = @cel_contato, email_contato = @email_contato, dtcadastro_contato = @dtcadastro_contato WHERE id_contato = @id_contato", Form1.conexao);
                mycommand.Parameters.Add(new SqlParameter("@id_contato", SqlDbType.Int));
                mycommand.Parameters.Add(new SqlParameter("@end_contato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@nome_contato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cidade_id_cidade", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@cel_contato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@email_contato", SqlDbType.VarChar));
                mycommand.Parameters.Add(new SqlParameter("@dtcadastro_contato", SqlDbType.Date));


                mycommand.Parameters["@id_contato"].Value = idcontato;
                mycommand.Parameters["@nome_contato"].Value = nomecontato;
                mycommand.Parameters["@end_contato"].Value = endcontato;
                mycommand.Parameters["@cidade_id_cidade"].Value = cidadeidcidade;
                mycommand.Parameters["@cel_contato"].Value = celcontato;
                mycommand.Parameters["@email_contato"].Value = emailcontato;
                mycommand.Parameters["@dtcadastro_contato"].Value = dtcadastrocontato;

                nReg = mycommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return nReg;
        }
    }
}
