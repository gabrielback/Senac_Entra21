namespace ExemploComponentes
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Verifica = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_changePhoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(307, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(19, 174);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(126, 50);
            this.Calcular.TabIndex = 3;
            this.Calcular.Text = "&Confirmar";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNome.Location = new System.Drawing.Point(91, 78);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(205, 29);
            this.txbNome.TabIndex = 1;
            this.txbNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // txbNumero
            // 
            this.txbNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbNumero.Location = new System.Drawing.Point(177, 129);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(119, 29);
            this.txbNumero.TabIndex = 2;
            this.txbNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite Um Número:";
            // 
            // Verifica
            // 
            this.Verifica.Location = new System.Drawing.Point(158, 174);
            this.Verifica.Name = "Verifica";
            this.Verifica.Size = new System.Drawing.Size(126, 50);
            this.Verifica.TabIndex = 4;
            this.Verifica.Text = "&Verificar";
            this.Verifica.UseVisualStyleBackColor = true;
            this.Verifica.Click += new System.EventHandler(this.Verifica_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(302, 230);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(126, 50);
            this.btn_sair.TabIndex = 6;
            this.btn_sair.Text = "&Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(419, 62);
            this.label3.TabIndex = 3;
            this.label3.Text = "Priemiro Exemplo";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(307, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btn_changePhoto
            // 
            this.btn_changePhoto.Location = new System.Drawing.Point(302, 174);
            this.btn_changePhoto.Name = "btn_changePhoto";
            this.btn_changePhoto.Size = new System.Drawing.Size(126, 50);
            this.btn_changePhoto.TabIndex = 5;
            this.btn_changePhoto.Text = "Alterar &Foto";
            this.btn_changePhoto.UseVisualStyleBackColor = true;
            this.btn_changePhoto.Click += new System.EventHandler(this.btn_changePhoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 311);
            this.Controls.Add(this.btn_changePhoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNumero);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.Verifica);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Exemplo Componentes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button Calcular;
        private TextBox txbNome;
        private Label label1;
        private TextBox txbNumero;
        private Label label2;
        private Button Verifica;
        private Button btn_sair;
        private Label label3;
        private PictureBox pictureBox2;
        private Button btn_changePhoto;
    }
}