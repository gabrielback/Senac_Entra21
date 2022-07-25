namespace Triangulos
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double lado1, lado2, lado3;
                lado1 = Convert.ToDouble(txbLado1);
                lado2 = Convert.ToDouble(txbLado2);
                lado3 = Convert.ToDouble(txbLado3);

                if ((lado1 > lado2) && (lado1 < lado3)) ;
            }
            catch
            {

            }
        }
    }
}