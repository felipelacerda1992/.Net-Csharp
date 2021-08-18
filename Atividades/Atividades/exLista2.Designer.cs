namespace Atividades
{
    partial class exLista2
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ltbIMC = new System.Windows.Forms.ListBox();
            this.ltbPeso = new System.Windows.Forms.ListBox();
            this.ltbAltura = new System.Windows.Forms.ListBox();
            this.ltbNome = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(99, 76);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(320, 76);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 20);
            this.txtPeso.TabIndex = 0;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(600, 76);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PESO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(650, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ALTURA";
            // 
            // ltbIMC
            // 
            this.ltbIMC.FormattingEnabled = true;
            this.ltbIMC.Location = new System.Drawing.Point(452, 191);
            this.ltbIMC.Name = "ltbIMC";
            this.ltbIMC.Size = new System.Drawing.Size(120, 95);
            this.ltbIMC.TabIndex = 4;
            // 
            // ltbPeso
            // 
            this.ltbPeso.FormattingEnabled = true;
            this.ltbPeso.Location = new System.Drawing.Point(298, 191);
            this.ltbPeso.Name = "ltbPeso";
            this.ltbPeso.Size = new System.Drawing.Size(120, 95);
            this.ltbPeso.TabIndex = 5;
            // 
            // ltbAltura
            // 
            this.ltbAltura.FormattingEnabled = true;
            this.ltbAltura.Location = new System.Drawing.Point(600, 191);
            this.ltbAltura.Name = "ltbAltura";
            this.ltbAltura.Size = new System.Drawing.Size(120, 95);
            this.ltbAltura.TabIndex = 6;
            // 
            // ltbNome
            // 
            this.ltbNome.FormattingEnabled = true;
            this.ltbNome.Location = new System.Drawing.Point(77, 191);
            this.ltbNome.Name = "ltbNome";
            this.ltbNome.Size = new System.Drawing.Size(120, 95);
            this.ltbNome.TabIndex = 7;
            // 
            // exLista2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 367);
            this.Controls.Add(this.ltbNome);
            this.Controls.Add(this.ltbAltura);
            this.Controls.Add(this.ltbPeso);
            this.Controls.Add(this.ltbIMC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtNome);
            this.Name = "exLista2";
            this.Text = "exLista2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox ltbIMC;
        private System.Windows.Forms.ListBox ltbPeso;
        private System.Windows.Forms.ListBox ltbAltura;
        private System.Windows.Forms.ListBox ltbNome;
    }
}