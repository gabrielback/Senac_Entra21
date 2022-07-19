namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            try
            {
                int num,cont, tab;
            num = Convert.ToInt32(txbTabuada.Text);
            {
                    if (rbtnFor.Checked)
                    {
                    for (cont = 0; cont <= 10; cont++)
                        {
                         tab = num * cont;
                         ltbTabuada.Items.Add(num.ToString() + " * "+ cont + " = " + tab);
                        }
                    }
                     else if (rbtnDoWhile.Checked)
                    {
                            cont = 0;
                        do
                        {
                            tab = num * cont;
                            ltbTabuada.Items.Add(num.ToString() + " * " + cont + " = " + tab);
                            cont++;
                        } while (cont <= 10);

                    }
                    else if (rbtnWhileDo.Checked)
                    {
                        cont = 0;
                        while (cont <= 10)
                        {
                            tab = num * cont;
                            ltbTabuada.Items.Add(num.ToString() + " * " + cont + " = " + tab);
                            cont++;
                        }

                    }

                }

            }
            catch(Exception error)
            {
                MessageBox.Show("Algo deu errado:\n" + error.Message);
            }
        }

        private void ckbFor_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbTabuada.Text = "";
            ltbTabuada.Items.Clear();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}