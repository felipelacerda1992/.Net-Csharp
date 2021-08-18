namespace Financeiro
{
    partial class frmTransferencia
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
            this.cbbSaida = new System.Windows.Forms.ComboBox();
            this.cbbEntrada = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbSaida
            // 
            this.cbbSaida.DisplayMember = "agencia_conta";
            this.cbbSaida.FormattingEnabled = true;
            this.cbbSaida.Location = new System.Drawing.Point(144, 80);
            this.cbbSaida.Name = "cbbSaida";
            this.cbbSaida.Size = new System.Drawing.Size(121, 21);
            this.cbbSaida.TabIndex = 0;
            this.cbbSaida.ValueMember = "id_conta";
            // 
            // cbbEntrada
            // 
            this.cbbEntrada.DisplayMember = "agencia_conta";
            this.cbbEntrada.FormattingEnabled = true;
            this.cbbEntrada.Location = new System.Drawing.Point(144, 119);
            this.cbbEntrada.Name = "cbbEntrada";
            this.cbbEntrada.Size = new System.Drawing.Size(121, 21);
            this.cbbEntrada.TabIndex = 1;
            this.cbbEntrada.ValueMember = "id_conta";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(144, 163);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Conta Saída";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Conta Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor";
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(144, 251);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(100, 31);
            this.btnTransferir.TabIndex = 6;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.BtnTransferir_Click);
            // 
            // frmTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 365);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.cbbEntrada);
            this.Controls.Add(this.cbbSaida);
            this.Name = "frmTransferencia";
            this.Text = "frmTransferencia";
            this.Load += new System.EventHandler(this.FrmTransferencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbSaida;
        private System.Windows.Forms.ComboBox cbbEntrada;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTransferir;
    }
}