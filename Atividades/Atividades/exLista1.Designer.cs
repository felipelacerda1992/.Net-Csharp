namespace Atividades
{
    partial class exLista1
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
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.lsbPar = new System.Windows.Forms.ListBox();
            this.lsbImpar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(170, 86);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(184, 20);
            this.txtN.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(170, 136);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(279, 136);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 2;
            this.btnlimpar.Text = "limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.Btnlimpar_Click);
            // 
            // lsbPar
            // 
            this.lsbPar.FormattingEnabled = true;
            this.lsbPar.Location = new System.Drawing.Point(170, 179);
            this.lsbPar.Name = "lsbPar";
            this.lsbPar.Size = new System.Drawing.Size(75, 95);
            this.lsbPar.TabIndex = 3;
            // 
            // lsbImpar
            // 
            this.lsbImpar.FormattingEnabled = true;
            this.lsbImpar.Location = new System.Drawing.Point(279, 179);
            this.lsbImpar.Name = "lsbImpar";
            this.lsbImpar.Size = new System.Drawing.Size(75, 95);
            this.lsbImpar.TabIndex = 4;
            // 
            // exLista1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 349);
            this.Controls.Add(this.lsbImpar);
            this.Controls.Add(this.lsbPar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtN);
            this.Name = "exLista1";
            this.Text = "exLista1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.ListBox lsbPar;
        private System.Windows.Forms.ListBox lsbImpar;
    }
}