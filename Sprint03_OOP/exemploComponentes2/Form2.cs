using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemploComponentes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnExibirIdade_Click(object sender, EventArgs e)
        {
            int idade;


            try
            {
                
                idade = Convert.ToInt16(txbIdade.Text);

            switch (idade)
            {
                case < 5:
                        MessageBox.Show("Idade Inválida!!");
                    lblIdade.Text = $"";
                    break;

                case > 120:
                        MessageBox.Show("Idade Inválida!!");
                        lblIdade.Text = $"";
                    break;

                case >= 5:
                    lblIdade.Text = $"Você tem {idade} anos!";
                    break;

                default:
                        MessageBox.Show("Idade Inválida");
                        lblIdade.Text = "";
                        break;
            }

            lblIdade.Visible = true;

            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro :" + exception.Message);
                MessageBox.Show("Erro de entrada de valores", "Tela de Erro",MessageBoxButtons.OK );
            }
        }
    }
}
