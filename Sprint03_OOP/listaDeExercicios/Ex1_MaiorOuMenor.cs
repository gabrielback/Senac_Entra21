namespace listaDeExercicios
{
    public partial class Ex1_MaiorOuMenor : Form
    {
        public Ex1_MaiorOuMenor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1, numero2, numero3, maior, menor;
            try
            {
               
            numero1 = Convert.ToInt16(txbNumero1.Text);
            numero2 = Convert.ToInt16(txbNumero2.Text);
            numero3 = Convert.ToInt16(txbNumero3.Text);
                if(numero1 > numero2 && numero1 > numero3)
                {
                    maior = numero1;
                    if(numero2 < numero3)
                    {
                        menor = numero2;
                    }
                    else
                    {
                        menor = numero3;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show($"Houve um erro:\n"+ error.Message);
            }
        }
    }
}