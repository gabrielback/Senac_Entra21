namespace listaDeExercicios
{
    partial class Ex5
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
            this.txbCaracteres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ltbPrint = new System.Windows.Forms.ListBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txbQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbCaracteres
            // 
            this.txbCaracteres.Location = new System.Drawing.Point(33, 54);
            this.txbCaracteres.Name = "txbCaracteres";
            this.txbCaracteres.Size = new System.Drawing.Size(157, 23);
            this.txbCaracteres.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caracteres de Concatenação";
            // 
            // ltbPrint
            // 
            this.ltbPrint.FormattingEnabled = true;
            this.ltbPrint.ItemHeight = 15;
            this.ltbPrint.Location = new System.Drawing.Point(33, 83);
            this.ltbPrint.Name = "ltbPrint";
            this.ltbPrint.Size = new System.Drawing.Size(755, 349);
            this.ltbPrint.TabIndex = 2;
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(359, 53);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 23);
            this.btnExec.TabIndex = 3;
            this.btnExec.Text = "Executar";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 456);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txbQuantidade
            // 
            this.txbQuantidade.Location = new System.Drawing.Point(196, 54);
            this.txbQuantidade.Name = "txbQuantidade";
            this.txbQuantidade.Size = new System.Drawing.Size(157, 23);
            this.txbQuantidade.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(440, 54);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Ex5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.ltbPrint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbQuantidade);
            this.Controls.Add(this.txbCaracteres);
            this.Name = "Ex5";
            this.Text = "Ex5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbCaracteres;
        private Label label1;
        private ListBox ltbPrint;
        private Button btnExec;
        private Button btnExit;
        private TextBox txbQuantidade;
        private Label label2;
        private Button btnLimpar;
    }
}