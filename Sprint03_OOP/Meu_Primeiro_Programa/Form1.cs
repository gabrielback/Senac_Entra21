using System.Diagnostics;

namespace Meu_Primeiro_Programa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void bntForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }

        private void form3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("explorer");

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("calc");
        }

        private void btn_Calc_Img_Click(object sender, EventArgs e)
        {
            Process.Start("calc");

        }

        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}