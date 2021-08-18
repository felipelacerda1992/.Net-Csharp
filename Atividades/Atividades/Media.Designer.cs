namespace Atividades
{
    partial class Media
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
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.txtn4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMedia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(136, 38);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(35, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nota1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nota2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nota3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nota4";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(178, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(144, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(178, 66);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 20);
            this.txtn1.TabIndex = 1;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(178, 100);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 20);
            this.txtn2.TabIndex = 1;
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(178, 130);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(100, 20);
            this.txtn3.TabIndex = 1;
            // 
            // txtn4
            // 
            this.txtn4.Location = new System.Drawing.Point(178, 160);
            this.txtn4.Name = "txtn4";
            this.txtn4.Size = new System.Drawing.Size(100, 20);
            this.txtn4.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedia.Location = new System.Drawing.Point(186, 297);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(64, 25);
            this.lblMedia.TabIndex = 3;
            this.lblMedia.Text = "label1";
            this.lblMedia.Visible = false;
            // 
            // Media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 350);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtn4);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.Name = "Media";
            this.Text = "Media";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtn1;
        private System.Windows.Forms.TextBox txtn2;
        private System.Windows.Forms.TextBox txtn3;
        private System.Windows.Forms.TextBox txtn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMedia;
    }
}