namespace Meu_Primeiro_Programa
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnForm1 = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-mail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 188);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Senha";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(22, 247);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(330, 23);
            this.textBox2.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(174, 293);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 35);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Entrar";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnForm1
            // 
            this.btnForm1.Location = new System.Drawing.Point(101, 101);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(86, 35);
            this.btnForm1.TabIndex = 7;
            this.btnForm1.Text = "Form1";
            this.btnForm1.UseVisualStyleBackColor = true;
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.Location = new System.Drawing.Point(193, 101);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(86, 35);
            this.btnForm2.TabIndex = 7;
            this.btnForm2.Text = "Form2";
            this.btnForm2.UseVisualStyleBackColor = true;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(81, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 89);
            this.label3.TabIndex = 9;
            this.label3.Text = "Form3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnForm1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button btnSair;
        private Button button1;
        private Button btnForm1;
        private Button btnForm2;
        private Label label3;
    }
}