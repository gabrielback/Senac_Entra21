namespace exemploComponentes
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
            this.btnExibirIdade = new System.Windows.Forms.Button();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExibirIdade
            // 
            this.btnExibirIdade.Location = new System.Drawing.Point(114, 50);
            this.btnExibirIdade.Name = "btnExibirIdade";
            this.btnExibirIdade.Size = new System.Drawing.Size(195, 50);
            this.btnExibirIdade.TabIndex = 5;
            this.btnExibirIdade.Text = "Exibir &Idade";
            this.btnExibirIdade.UseVisualStyleBackColor = true;
            this.btnExibirIdade.Click += new System.EventHandler(this.btnExibirIdade_Click);
            // 
            // txbIdade
            // 
            this.txbIdade.Location = new System.Drawing.Point(114, 21);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(195, 23);
            this.txbIdade.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Digite sua Idade";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdade.Location = new System.Drawing.Point(45, 139);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(250, 37);
            this.lblIdade.TabIndex = 6;
            this.lblIdade.Text = "Você tem \"  \" anos";
            this.lblIdade.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 269);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.btnExibirIdade);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.label3);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExibirIdade;
        private TextBox txbIdade;
        private Label label3;
        private Label lblIdade;
    }
}