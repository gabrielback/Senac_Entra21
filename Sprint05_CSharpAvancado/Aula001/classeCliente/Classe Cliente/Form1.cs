namespace Classe_Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cliente novoCliente = new Cliente();
        private void button1_Click(object sender, EventArgs e)
        {
            try 
            { 
                novoCliente.setNome(txbNome.Text);
                novoCliente.setEndereco(txbEndereco.Text); 
                novoCliente.setContato(txbContato.Text); 
                novoCliente.setLimiteCredito(double.Parse(txbLimiteCredito.Text)); 
                novoCliente.setDataNasc(dateTimePicker1.Value); 
                novoCliente.setNumeroCartao(double.Parse(txbNroCartao.Text)); 
                
//                MessageBox.Show("Cliente Cadastrado com Sucesso", "Aviso");

                novoCliente.verificaLimite();
                lblStatusCadastro.Text = "Ok";
                lblStatusLimite.Text = novoCliente.getStatus();
                
//                MessageBox.Show("Sua situação atual é: " + novoCliente.getStatus(), "Aviso"); 
                
                lblNome.Text = (novoCliente.getNome()); 
                lblEndereco.Text = (novoCliente.getEndereco()); 
                lblContato.Text = (novoCliente.getContato()); 
                lblLimiteCredito.Text = (novoCliente.getLimiteCredito()).ToString(); 
                lblDt_Nasc.Text = (novoCliente.getDataNasc()).ToString(); 
                lblNroCartao.Text = (novoCliente.getNumeroCartao()).ToString();


                
                DialogResult result = MessageBox.Show("Confirmar cadastro do cliente?","Confirmar Clientes", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    MessageBox.Show("Cadastrado com sucesso!");
                    this.Close();
                }
                else
                {
                //    this.Close();
                }

            } 
            catch (FormatException) 
            { 
                MessageBox.Show("Erro de Conversão", "Falha no Cadastro"); 
            }
        }
    }
}