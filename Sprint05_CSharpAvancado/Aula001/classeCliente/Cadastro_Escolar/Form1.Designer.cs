namespace Cadastro_Escolar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnAluno = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbnProfessor = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.gpbDadosCadastrados = new System.Windows.Forms.GroupBox();
            this.lblDadosCadastrados = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gpbDadosCadastrados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(75, 123);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(143, 23);
            this.txtMatricula.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnAluno);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rbnProfessor);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar?";
            // 
            // rbnAluno
            // 
            this.rbnAluno.AutoSize = true;
            this.rbnAluno.Location = new System.Drawing.Point(38, 41);
            this.rbnAluno.Name = "rbnAluno";
            this.rbnAluno.Size = new System.Drawing.Size(39, 15);
            this.rbnAluno.TabIndex = 9;
            this.rbnAluno.Text = "Aluno";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbnProfessor
            // 
            this.rbnProfessor.AutoSize = true;
            this.rbnProfessor.Location = new System.Drawing.Point(38, 21);
            this.rbnProfessor.Name = "rbnProfessor";
            this.rbnProfessor.Size = new System.Drawing.Size(56, 15);
            this.rbnProfessor.TabIndex = 9;
            this.rbnProfessor.Text = "Professor";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(10, 210);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(206, 55);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 152);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(160, 23);
            this.txtNome.TabIndex = 2;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(10, 189);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 15);
            this.lblSalario.TabIndex = 0;
            this.lblSalario.Text = "Salário";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(58, 181);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(160, 23);
            this.txtSalario.TabIndex = 4;
            // 
            // gpbDadosCadastrados
            // 
            this.gpbDadosCadastrados.Controls.Add(this.lblDadosCadastrados);
            this.gpbDadosCadastrados.Location = new System.Drawing.Point(224, 10);
            this.gpbDadosCadastrados.Name = "gpbDadosCadastrados";
            this.gpbDadosCadastrados.Size = new System.Drawing.Size(230, 255);
            this.gpbDadosCadastrados.TabIndex = 6;
            this.gpbDadosCadastrados.TabStop = false;
            this.gpbDadosCadastrados.Text = "Dados Cadastrados";
            // 
            // lblDadosCadastrados
            // 
            this.lblDadosCadastrados.AutoSize = true;
            this.lblDadosCadastrados.Location = new System.Drawing.Point(27, 30);
            this.lblDadosCadastrados.Name = "lblDadosCadastrados";
            this.lblDadosCadastrados.Size = new System.Drawing.Size(0, 15);
            this.lblDadosCadastrados.TabIndex = 0;
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(58, 181);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.Size = new System.Drawing.Size(160, 23);
            this.txtMedia.TabIndex = 5;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(12, 189);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(40, 15);
            this.lblMedia.TabIndex = 0;
            this.lblMedia.Text = "Média";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 279);
            this.Controls.Add(this.gpbDadosCadastrados);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbDadosCadastrados.ResumeLayout(false);
            this.gpbDadosCadastrados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtMatricula;
        private GroupBox groupBox1;
        private Label rbnAluno;
        private RadioButton radioButton2;
        private Label rbnProfessor;
        private RadioButton radioButton1;
        private Button btnCadastrar;
        private Label label4;
        private TextBox txtNome;
        private Label lblSalario;
        private TextBox txtSalario;
        private GroupBox gpbDadosCadastrados;
        private Label lblDadosCadastrados;
        private TextBox txtMedia;
        private Label lblMedia;
    }
}