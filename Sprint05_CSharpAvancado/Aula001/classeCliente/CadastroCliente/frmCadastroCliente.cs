using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data;
using MySqlConnector;
namespace CadastroCliente
{
    public partial class frmCadastroCliente : Form
    {
        
        //string connectionString = @"Server=.\sqlexpress;Database=bdcadastro;Trusted_Connection=True;";
        
        string connectionString = "server=localhost;user=root;database=bdcadastro;password=";
        bool novo;
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        public void testaBanco() {
            MySqlConnection con = new MySqlConnection(connectionString);

           try
            {
                con.Open();
                MessageBox.Show("Conexao deu boa!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("deu ruim " + ex);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            mskCep.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUf.Enabled = false;
            mskTelefone.Enabled = false;
            //testaBanco();

        }

        private void tsbSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                string sql = "INSERT INTO CLIENTE(NOME,ENDERECO,CEP,BAIRRO,CIDADE,UF,TELEFONE) " + "VALUES ('" + txtNome.Text + "', '" + txtEndereco.Text + "', '" + mskCep.Text + "', '" + txtBairro.Text + "', '" + txtCidade.Text + "', '" + txtUf.Text + "', '" + mskTelefone.Text + "')";
                                                                                                             

                MySqlConnection con = new MySqlConnection(connectionString);

                MySqlCommand cmd = new MySqlCommand(sql, con); // passa string sql como primeiro parametro e depois passa a nova conexão como segundo parametro.
                cmd.CommandType = CommandType.Text;
                //cmd.Parameters.AddWithValue("@NOME", txtNome.Text);
                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());

                }
                finally
                {
                    con.Close();
                }

            }
            else
            {
                string sql = "UPDATE CLIENTE SET NOME='" + txtNome.Text + "',ENDERECO='" + txtEndereco.Text + "', " + "CEP='" + mskCep.Text + "', BAIRRO='" + txtBairro.Text + "',CIDADE='" + txtCidade.Text + "', " + "UF='" + txtUf.Text + "', TELEFONE='" + mskTelefone.Text + "' WHERE ID='" + txtId.Text + "'";
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                con.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro atualizado com sucesso!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally 
                {
                    con.Close(); 
                }
            }
            tsbNovo.Enabled = true;
            tsbSalvar.Enabled = false;
            tsbCancelar.Enabled = false;
            tsbExcluir.Enabled = false;
            tstId.Enabled = true;
            tsbBuscar.Enabled = true;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            mskCep.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtUf.Enabled = false;
            mskTelefone.Enabled = false;
            txtId.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            mskCep.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            mskTelefone.Text = "";
        }


        private void tsbNovo_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = false;
            tsbSalvar.Enabled = true;
            tsbCancelar.Enabled = true;
            tsbExcluir.Enabled = false;
            tstId.Enabled = false;
            tsbBuscar.Enabled = false;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            mskCep.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtUf.Enabled = true;
            mskTelefone.Enabled = true;
            txtNome.Focus();
            novo = true;
        }

        private void tsbCancelar_Click(object sender, EventArgs e)
        {
            tsbNovo.Enabled = true; tsbSalvar.Enabled = false; tsbCancelar.Enabled = false; tsbExcluir.Enabled = false; tstId.Enabled = true; tsbBuscar.Enabled = true; txtNome.Enabled = false; txtEndereco.Enabled = false; mskCep.Enabled = false; txtBairro.Enabled = false; txtCidade.Enabled = false; txtUf.Enabled = false; mskTelefone.Enabled = false; txtId.Text = ""; txtNome.Text = ""; txtEndereco.Text = ""; mskCep.Text = ""; txtBairro.Text = ""; txtCidade.Text = ""; txtUf.Text = ""; mskTelefone.Text = "";
        }

        private void tsbExcluir_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM CLIENTE WHERE ID=" + txtId.Text;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro excluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            tsbNovo.Enabled = true; tsbSalvar.Enabled = false; tsbCancelar.Enabled = false; tsbExcluir.Enabled = false; tstId.Enabled = true; tsbBuscar.Enabled = true; txtNome.Enabled = false; txtEndereco.Enabled = false; mskCep.Enabled = false; txtBairro.Enabled = false; txtCidade.Enabled = false; txtUf.Enabled = false; mskTelefone.Enabled = false; txtId.Text = ""; txtNome.Text = ""; txtEndereco.Text = ""; mskCep.Text = ""; txtBairro.Text = ""; txtCidade.Text = ""; txtUf.Text = ""; mskTelefone.Text = "";
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM CLIENTE WHERE ID=" + tstId.Text;
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tsbNovo.Enabled = false; tsbSalvar.Enabled = true; tsbCancelar.Enabled = true; tsbExcluir.Enabled = true; tstId.Enabled = false; tsbBuscar.Enabled = false; txtNome.Enabled = true; txtEndereco.Enabled = true; mskCep.Enabled = true; txtBairro.Enabled = true;txtCidade.Enabled = true; txtUf.Enabled = true; mskTelefone.Enabled = true; txtNome.Focus(); txtId.Text = reader[0].ToString(); txtNome.Text = reader[1].ToString(); txtEndereco.Text = reader[2].ToString(); mskCep.Text = reader[3].ToString(); txtBairro.Text = reader[4].ToString(); txtCidade.Text = reader[5].ToString(); txtUf.Text = reader[6].ToString(); mskTelefone.Text = reader[7].ToString(); novo = false;
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado com o Idinformado!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            tstId.Text = "";
        }
    }
}