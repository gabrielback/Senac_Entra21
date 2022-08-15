namespace Classe_Cliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNroCartao = new System.Windows.Forms.TextBox();
            this.txbLimiteCredito = new System.Windows.Forms.TextBox();
            this.txbContato = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gpbStatus = new System.Windows.Forms.GroupBox();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblStatusLimite = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblStatusCadastro = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblDt_Nasc = new System.Windows.Forms.Label();
            this.lblLimiteCredito = new System.Windows.Forms.Label();
            this.lblNroCartao = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gpbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbNroCartao);
            this.groupBox1.Controls.Add(this.txbLimiteCredito);
            this.groupBox1.Controls.Add(this.txbContato);
            this.groupBox1.Controls.Add(this.txbEndereco);
            this.groupBox1.Controls.Add(this.txbNome);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nº do cartão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Limite de crédito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // txbNroCartao
            // 
            this.txbNroCartao.Location = new System.Drawing.Point(124, 183);
            this.txbNroCartao.Name = "txbNroCartao";
            this.txbNroCartao.Size = new System.Drawing.Size(200, 23);
            this.txbNroCartao.TabIndex = 6;
            // 
            // txbLimiteCredito
            // 
            this.txbLimiteCredito.Location = new System.Drawing.Point(124, 154);
            this.txbLimiteCredito.Name = "txbLimiteCredito";
            this.txbLimiteCredito.Size = new System.Drawing.Size(200, 23);
            this.txbLimiteCredito.TabIndex = 5;
            // 
            // txbContato
            // 
            this.txbContato.Location = new System.Drawing.Point(82, 96);
            this.txbContato.Name = "txbContato";
            this.txbContato.Size = new System.Drawing.Size(242, 23);
            this.txbContato.TabIndex = 3;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(82, 67);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(242, 23);
            this.txbEndereco.TabIndex = 2;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(82, 38);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(242, 23);
            this.txbNome.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpbStatus
            // 
            this.gpbStatus.Controls.Add(this.lblLimite);
            this.gpbStatus.Controls.Add(this.lblCadastro);
            this.gpbStatus.Controls.Add(this.lblStatusLimite);
            this.gpbStatus.Controls.Add(this.lblNome);
            this.gpbStatus.Controls.Add(this.lblStatusCadastro);
            this.gpbStatus.Controls.Add(this.lblEndereco);
            this.gpbStatus.Controls.Add(this.lblContato);
            this.gpbStatus.Controls.Add(this.lblDt_Nasc);
            this.gpbStatus.Controls.Add(this.lblLimiteCredito);
            this.gpbStatus.Controls.Add(this.lblNroCartao);
            this.gpbStatus.Location = new System.Drawing.Point(16, 326);
            this.gpbStatus.Name = "gpbStatus";
            this.gpbStatus.Size = new System.Drawing.Size(343, 174);
            this.gpbStatus.TabIndex = 14;
            this.gpbStatus.TabStop = false;
            this.gpbStatus.Visible = false;
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(194, 19);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(75, 15);
            this.lblLimite.TabIndex = 13;
            this.lblLimite.Text = "Status Limite";
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.Location = new System.Drawing.Point(99, 19);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(89, 15);
            this.lblCadastro.TabIndex = 12;
            this.lblCadastro.Text = "Status Cadastro";
            // 
            // lblStatusLimite
            // 
            this.lblStatusLimite.AutoSize = true;
            this.lblStatusLimite.Location = new System.Drawing.Point(205, 34);
            this.lblStatusLimite.Name = "lblStatusLimite";
            this.lblStatusLimite.Size = new System.Drawing.Size(59, 15);
            this.lblStatusLimite.TabIndex = 11;
            this.lblStatusLimite.Text = "Resultado";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 15);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "label7";
            // 
            // lblStatusCadastro
            // 
            this.lblStatusCadastro.AutoSize = true;
            this.lblStatusCadastro.Location = new System.Drawing.Point(120, 34);
            this.lblStatusCadastro.Name = "lblStatusCadastro";
            this.lblStatusCadastro.Size = new System.Drawing.Size(59, 15);
            this.lblStatusCadastro.TabIndex = 10;
            this.lblStatusCadastro.Text = "Resultado";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(5, 44);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(38, 15);
            this.lblEndereco.TabIndex = 3;
            this.lblEndereco.Text = "label8";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.Location = new System.Drawing.Point(5, 68);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(38, 15);
            this.lblContato.TabIndex = 4;
            this.lblContato.Text = "label9";
            // 
            // lblDt_Nasc
            // 
            this.lblDt_Nasc.AutoSize = true;
            this.lblDt_Nasc.Location = new System.Drawing.Point(6, 93);
            this.lblDt_Nasc.Name = "lblDt_Nasc";
            this.lblDt_Nasc.Size = new System.Drawing.Size(44, 15);
            this.lblDt_Nasc.TabIndex = 5;
            this.lblDt_Nasc.Text = "label10";
            // 
            // lblLimiteCredito
            // 
            this.lblLimiteCredito.AutoSize = true;
            this.lblLimiteCredito.Location = new System.Drawing.Point(6, 120);
            this.lblLimiteCredito.Name = "lblLimiteCredito";
            this.lblLimiteCredito.Size = new System.Drawing.Size(44, 15);
            this.lblLimiteCredito.TabIndex = 6;
            this.lblLimiteCredito.Text = "label11";
            // 
            // lblNroCartao
            // 
            this.lblNroCartao.AutoSize = true;
            this.lblNroCartao.Location = new System.Drawing.Point(6, 145);
            this.lblNroCartao.Name = "lblNroCartao";
            this.lblNroCartao.Size = new System.Drawing.Size(44, 15);
            this.lblNroCartao.TabIndex = 7;
            this.lblNroCartao.Text = "label12";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(368, 523);
            this.Controls.Add(this.gpbStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbStatus.ResumeLayout(false);
            this.gpbStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txbNroCartao;
        private TextBox txbLimiteCredito;
        private TextBox txbContato;
        private TextBox txbEndereco;
        private TextBox txbNome;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private GroupBox gpbStatus;
        private Label lblLimite;
        private Label lblCadastro;
        private Label lblStatusLimite;
        private Label lblNome;
        private Label lblStatusCadastro;
        private Label lblEndereco;
        private Label lblContato;
        private Label lblDt_Nasc;
        private Label lblLimiteCredito;
        private Label lblNroCartao;
    }
}