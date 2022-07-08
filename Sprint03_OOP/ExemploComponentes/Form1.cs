namespace ExemploComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            string nome;
            
            nome = txbNome.Text.ToUpper();
            // label1.Text = nome;
                MessageBox.Show("Olá " + nome);

            if (nome == "GABRIEL")
            {
                pictureBox1.Hide();
                pictureBox2.Show();

            }
            else
            {
            pictureBox2.Hide();
            pictureBox1.Show();
            }

        }

        private void Verifica_Click(object sender, EventArgs e)
        {
            int num;
            num = Convert.ToInt16(txbNumero.Text);
            if (num < 0)
                MessageBox.Show("INFORMOU NEGATIVO");
            else
                MessageBox.Show("INFORMOU POSITIVO");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        string pictureBoxStatus = "false";

        private void btn_changePhoto_Click(object sender, EventArgs e)
        {
            if(pictureBoxStatus == "false")
            {
                pictureBoxStatus = "true";
                pictureBox1.Hide();
                pictureBox2.Show();

            }
            else
            {
                pictureBoxStatus = "false";
                pictureBox2.Hide();
                pictureBox1.Show();

            }
//            MessageBox.Show(pictureBoxStatus);
        }
    }
}