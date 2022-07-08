namespace Meu_Primeiro_Programa
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bntForm3 = new System.Windows.Forms.Button();
            this.btnForm1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(232, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 89);
            this.label1.TabIndex = 8;
            this.label1.Text = "Form2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(547, 429);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 35);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // bntForm3
            // 
            this.bntForm3.Location = new System.Drawing.Point(164, 429);
            this.bntForm3.Name = "bntForm3";
            this.bntForm3.Size = new System.Drawing.Size(86, 35);
            this.bntForm3.TabIndex = 11;
            this.bntForm3.Text = "Form3";
            this.bntForm3.UseVisualStyleBackColor = true;
            this.bntForm3.Click += new System.EventHandler(this.bntForm3_Click);
            // 
            // btnForm1
            // 
            this.btnForm1.Location = new System.Drawing.Point(72, 429);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(86, 35);
            this.btnForm1.TabIndex = 10;
            this.btnForm1.Text = "Form1";
            this.btnForm1.UseVisualStyleBackColor = true;
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 476);
            this.Controls.Add(this.bntForm3);
            this.Controls.Add(this.btnForm1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnSair;
        private PictureBox pictureBox1;
        private Button bntForm3;
        private Button btnForm1;
    }
}