namespace exemploComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string nome;
            nome = txbNome.Text;
            MessageBox.Show("Boa noite "+ nome);
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int numero;
            numero = Convert.ToInt16(txbNumero.Text);
            MessageBox.Show("Você informou o número "+ numero);
            lblResultado.Visible = true;
            txbResultado.Visible = true;
            txbResultado.Text = numero.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbNome.Text = "";
            txbNumero.Text = "";
            txbResultado.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcularIdade_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); 
            form2.ShowDialog();
            
        }
    }
}