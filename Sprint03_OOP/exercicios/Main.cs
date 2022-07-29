using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listaDeExercicios
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ex3 formExercicio4 = new Ex3();
            formExercicio4.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            Ex1 formExercicio1 = new Ex1();
            formExercicio1.Show();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            Ex2 formExercicio2 = new Ex2();
            formExercicio2.Show();
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            Ex3 formExercicio3 = new Ex3();
            formExercicio3.Show();
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            Ex5 formExercicio5 = new Ex5();
            formExercicio5.Show();
        }

        private void btnEx6_Click(object sender, EventArgs e)
        {
            Ex6 formExercicio6 = new Ex6();
            formExercicio6.Show();
        }

        private void btnEx7_Click(object sender, EventArgs e)
        {
            Ex7 formExercicio7 = new Ex7();
            formExercicio7.Show();
        }
    }
}
