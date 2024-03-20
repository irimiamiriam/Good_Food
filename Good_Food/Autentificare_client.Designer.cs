namespace Good_Food
{
    partial class Autentificare_client
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adresa_textBox = new System.Windows.Forms.TextBox();
            this.parola_textBox = new System.Windows.Forms.TextBox();
            this.enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresa email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // adresa_textBox
            // 
            this.adresa_textBox.Location = new System.Drawing.Point(359, 101);
            this.adresa_textBox.Name = "adresa_textBox";
            this.adresa_textBox.Size = new System.Drawing.Size(231, 31);
            this.adresa_textBox.TabIndex = 2;
            // 
            // parola_textBox
            // 
            this.parola_textBox.Location = new System.Drawing.Point(359, 171);
            this.parola_textBox.Name = "parola_textBox";
            this.parola_textBox.Size = new System.Drawing.Size(231, 31);
            this.parola_textBox.TabIndex = 3;
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(326, 277);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(179, 61);
            this.enter.TabIndex = 4;
            this.enter.Text = "Intra";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // Autentificare_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 417);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.parola_textBox);
            this.Controls.Add(this.adresa_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Autentificare_client";
            this.Text = "Autentificare_client";
            this.Load += new System.EventHandler(this.Autentificare_client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adresa_textBox;
        private System.Windows.Forms.TextBox parola_textBox;
        private System.Windows.Forms.Button enter;
    }
}