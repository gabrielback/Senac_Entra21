using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meu_Primeiro_Programa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();  
        }

        private void bntForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); 
            form3.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Close();
        }
    }
}
