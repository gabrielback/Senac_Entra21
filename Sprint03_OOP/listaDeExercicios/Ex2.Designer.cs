namespace listaDeExercicios
{
    partial class Ex2
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnChecar = new System.Windows.Forms.Button();
            this.txbNumero1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Text";
            // 
            // btnChecar
            // 
            this.btnChecar.Location = new System.Drawing.Point(102, 106);
            this.btnChecar.Name = "btnChecar";
            this.btnChecar.Size = new System.Drawing.Size(75, 23);
            this.btnChecar.TabIndex = 9;
            this.btnChecar.Text = "Checar";
            this.btnChecar.UseVisualStyleBackColor = true;
            // 
            // txbNumero1
            // 
            this.txbNumero1.Location = new System.Drawing.Point(86, 57);
            this.txbNumero1.Name = "txbNumero1";
            this.txbNumero1.Size = new System.Drawing.Size(91, 23);
            this.txbNumero1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero1";
            // 
            // Ex2_ParOuImpar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 239);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChecar);
            this.Controls.Add(this.txbNumero1);
            this.Controls.Add(this.label1);
            this.Name = "Ex2_ParOuImpar";
            this.Text = "Ex1_ParOuImpar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Button btnChecar;
        private TextBox txbNumero1;
        private Label label1;
    }
}