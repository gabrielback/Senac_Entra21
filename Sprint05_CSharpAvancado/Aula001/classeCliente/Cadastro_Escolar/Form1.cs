namespace Cadastro_Escolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSalario.Visible = false;
            txtMedia.Visible = false;
            lblMedia.Visible = false;
            lblSalario.Visible = false;
        }

        Aluno aluno = new Aluno();
        Professor professor = new Professor();
        
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                if (radioButton1.Checked)
                {
                professor.setMatricula(Convert.ToInt32(txtMatricula.Text));
                professor.setNome(txtNome.Text);
                professor.Salario = Convert.ToInt32(txtSalario.Text);

                lblDadosCadastrados.Text += professor.ToString();

                }
                else if (radioButton2.Checked)
                {
                    aluno.setMatricula(Convert.ToInt32(txtMatricula.Text));
                    aluno.setNome(txtNome.Text);
                    aluno.Media1 = Convert.ToInt32(txtSalario.Text);

                    lblDadosCadastrados.Text += aluno.ToString();

                }
                else
                {
                    MessageBox.Show("Por favor.\nSelecione Aluno ou Professor.");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error. {ex.Message.ToUpper()}");
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtMedia.Visible = false;
            lblMedia.Visible = false;
            lblSalario.Visible = true;
            txtSalario.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtMedia.Visible = true;
            lblMedia.Visible = true;
            lblSalario.Visible = false;
            txtSalario.Visible = false;
        }
    }
}