namespace ValidarCPF
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
            this.txtValidarCpf = new System.Windows.Forms.TextBox();
            this.btnValidarCpf = new System.Windows.Forms.Button();
            this.lbl_IsValidCpf = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF: ";
            // 
            // txtValidarCpf
            // 
            this.txtValidarCpf.Location = new System.Drawing.Point(44, 15);
            this.txtValidarCpf.Name = "txtValidarCpf";
            this.txtValidarCpf.Size = new System.Drawing.Size(100, 23);
            this.txtValidarCpf.TabIndex = 1;
            // 
            // btnValidarCpf
            // 
            this.btnValidarCpf.Location = new System.Drawing.Point(150, 12);
            this.btnValidarCpf.Name = "btnValidarCpf";
            this.btnValidarCpf.Size = new System.Drawing.Size(90, 89);
            this.btnValidarCpf.TabIndex = 2;
            this.btnValidarCpf.Text = "Validar CPF";
            this.btnValidarCpf.UseVisualStyleBackColor = true;
            this.btnValidarCpf.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_IsValidCpf
            // 
            this.lbl_IsValidCpf.AutoSize = true;
            this.lbl_IsValidCpf.Location = new System.Drawing.Point(59, 61);
            this.lbl_IsValidCpf.Name = "lbl_IsValidCpf";
            this.lbl_IsValidCpf.Size = new System.Drawing.Size(0, 15);
            this.lbl_IsValidCpf.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 113);
            this.Controls.Add(this.lbl_IsValidCpf);
            this.Controls.Add(this.btnValidarCpf);
            this.Controls.Add(this.txtValidarCpf);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtValidarCpf;
        private Button btnValidarCpf;
        private Label lbl_IsValidCpf;
    }
}