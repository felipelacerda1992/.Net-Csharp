namespace Atividades
{
    partial class exPoo2
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
            this.txtn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtn
            // 
            this.txtn.Location = new System.Drawing.Point(76, 32);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(100, 20);
            this.txtn.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "Par ou impar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // exPoo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 182);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtn);
            this.Name = "exPoo2";
            this.Text = "exPoo2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Button button1;
    }
}