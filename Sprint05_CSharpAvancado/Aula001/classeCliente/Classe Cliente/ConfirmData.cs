using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_Cliente
{
    public partial class ConfirmData : Form
    {
        public ConfirmData()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dados adicionados com sucesso!");
        }

        private void ConfirmData_Load(object sender, EventArgs e)
        {

        }
    }
}
