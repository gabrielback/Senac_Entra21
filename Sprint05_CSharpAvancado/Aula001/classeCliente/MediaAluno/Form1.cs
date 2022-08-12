namespace MediaAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Aluno novoAluno = new Aluno();

        private void button1_Click(object sender, EventArgs e)
        {
            lblCadastro.Text = $"Nome informado : {novoAluno.getNome()}";
            lblCadastro.Text += $"\n\nData de nascimento : {novoAluno.getDataNascimento()}";
            lblCadastro.Text += $"\n\nEndereço : {novoAluno.getEndereco()}";
            lblCadastro.Text += $"\n\nSua Média é : {novoAluno.CalcularMedia().ToString("n2")}";
            lblCadastro.Text += $"\n\nSua Situação é : {novoAluno.VerificarSituacao()}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            novoAluno.setNome(txtNome.Text);
            novoAluno.setNota1(double.Parse(txtNota1.Text));
            novoAluno.setNota2(double.Parse(txtNota2.Text));
            novoAluno.setNota3(double.Parse(txtNota3.Text));
            novoAluno.setEndereco(txtEndereco.Text);
            novoAluno.setDataNascimento(dateTimePicker1.Value);


            btnCadastrar.Enabled = true;

            MessageBox.Show("Calculo efetuado com sucesso!");

            }
            catch (Exception error)
            {
                MessageBox.Show($"Houve um erro : \n{error.Message}");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}