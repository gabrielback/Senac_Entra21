namespace listaDeExercicios
{
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            /*
                EX1
            */
            
            try
            {
                int[] numbers = new int[3];
                numbers[0] = Convert.ToInt16(txbNumero1.Text);
                numbers[1] = Convert.ToInt16(txbNumero2.Text);
                numbers[2] = Convert.ToInt16(txbNumero3.Text);

                int maxValue = numbers.Max();
                int minValue = numbers.Min();

                lblResult.Text = $"Número maior: {maxValue}\nNúmero menor: {minValue}";
                lblResult.Visible = true;
            }
            catch(Exception error)
            {
                MessageBox.Show($"Houve um erro:\n" + error.Message);

            }
        }
    }
}