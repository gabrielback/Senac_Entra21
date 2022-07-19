namespace Tabuada
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
            this.txbTabuada = new System.Windows.Forms.TextBox();
            this.ltbTabuada = new System.Windows.Forms.ListBox();
            this.btnTabuada = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rbtnFor = new System.Windows.Forms.RadioButton();
            this.rbtnWhileDo = new System.Windows.Forms.RadioButton();
            this.rbtnDoWhile = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe um número";
            // 
            // txbTabuada
            // 
            this.txbTabuada.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txbTabuada.Location = new System.Drawing.Point(204, 17);
            this.txbTabuada.Name = "txbTabuada";
            this.txbTabuada.Size = new System.Drawing.Size(82, 34);
            this.txbTabuada.TabIndex = 1;
            // 
            // ltbTabuada
            // 
            this.ltbTabuada.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ltbTabuada.FormattingEnabled = true;
            this.ltbTabuada.ItemHeight = 28;
            this.ltbTabuada.Location = new System.Drawing.Point(91, 57);
            this.ltbTabuada.Name = "ltbTabuada";
            this.ltbTabuada.Size = new System.Drawing.Size(195, 256);
            this.ltbTabuada.TabIndex = 3;
            // 
            // btnTabuada
            // 
            this.btnTabuada.Location = new System.Drawing.Point(292, 59);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(75, 23);
            this.btnTabuada.TabIndex = 4;
            this.btnTabuada.Text = "Tabuada";
            this.btnTabuada.UseVisualStyleBackColor = true;
            this.btnTabuada.Click += new System.EventHandler(this.btnTabuada_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(292, 97);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(292, 136);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // rbtnFor
            // 
            this.rbtnFor.AutoSize = true;
            this.rbtnFor.Location = new System.Drawing.Point(12, 81);
            this.rbtnFor.Name = "rbtnFor";
            this.rbtnFor.Size = new System.Drawing.Size(42, 19);
            this.rbtnFor.TabIndex = 5;
            this.rbtnFor.TabStop = true;
            this.rbtnFor.Text = "For";
            this.rbtnFor.UseVisualStyleBackColor = true;
            // 
            // rbtnWhileDo
            // 
            this.rbtnWhileDo.AutoSize = true;
            this.rbtnWhileDo.Location = new System.Drawing.Point(12, 106);
            this.rbtnWhileDo.Name = "rbtnWhileDo";
            this.rbtnWhileDo.Size = new System.Drawing.Size(73, 19);
            this.rbtnWhileDo.TabIndex = 5;
            this.rbtnWhileDo.TabStop = true;
            this.rbtnWhileDo.Text = "While Do";
            this.rbtnWhileDo.UseVisualStyleBackColor = true;
            // 
            // rbtnDoWhile
            // 
            this.rbtnDoWhile.AutoSize = true;
            this.rbtnDoWhile.Location = new System.Drawing.Point(12, 131);
            this.rbtnDoWhile.Name = "rbtnDoWhile";
            this.rbtnDoWhile.Size = new System.Drawing.Size(73, 19);
            this.rbtnDoWhile.TabIndex = 5;
            this.rbtnDoWhile.TabStop = true;
            this.rbtnDoWhile.Text = "Do While";
            this.rbtnDoWhile.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 342);
            this.Controls.Add(this.rbtnDoWhile);
            this.Controls.Add(this.rbtnWhileDo);
            this.Controls.Add(this.rbtnFor);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.ltbTabuada);
            this.Controls.Add(this.txbTabuada);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txbTabuada;
        private ListBox ltbTabuada;
        private Button btnTabuada;
        private Button btnLimpar;
        private Button BtnSair;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton rbtnFor;
        private RadioButton rbtnWhileDo;
        private RadioButton rbtnDoWhile;
    }
}