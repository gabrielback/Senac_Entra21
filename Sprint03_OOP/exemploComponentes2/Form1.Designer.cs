namespace exemploComponentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txbResultado = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcularIdade = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro Exemplo";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(63, 85);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(261, 23);
            this.txbNome.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Digite um Numero";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(129, 114);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(195, 23);
            this.txbNumero.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(192, 186);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(84, 40);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "&Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "C&onfirmar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 112);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(330, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(12, 151);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(62, 15);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Visible = false;
            this.lblResultado.Click += new System.EventHandler(this.label4_Click);
            // 
            // txbResultado
            // 
            this.txbResultado.Location = new System.Drawing.Point(80, 143);
            this.txbResultado.Name = "txbResultado";
            this.txbResultado.Size = new System.Drawing.Size(244, 23);
            this.txbResultado.TabIndex = 1;
            this.txbResultado.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(282, 186);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(84, 40);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcularIdade
            // 
            this.btnCalcularIdade.Location = new System.Drawing.Point(12, 237);
            this.btnCalcularIdade.Name = "btnCalcularIdade";
            this.btnCalcularIdade.Size = new System.Drawing.Size(174, 61);
            this.btnCalcularIdade.TabIndex = 5;
            this.btnCalcularIdade.Text = "Calcular Idade";
            this.btnCalcularIdade.UseVisualStyleBackColor = true;
            this.btnCalcularIdade.Click += new System.EventHandler(this.btnCalcularIdade_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(192, 232);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 61);
            this.button4.TabIndex = 6;
            this.button4.Text = "btn";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 310);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCalcularIdade);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txbNome;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Label label3;
        private TextBox txbNumero;
        private Button btnVerificar;
        private Button button3;
        private Label label2;
        private Button button2;
        private PictureBox pictureBox1;
        private Label lblResultado;
        private TextBox txbResultado;
        private Button btnLimpar;
        private Button btnCalcularIdade;
        private Button button4;
    }
}