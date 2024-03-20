namespace Good_Food
{
    partial class VizualizareComanda
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.totalPret = new System.Windows.Forms.TextBox();
            this.totalKcal = new System.Windows.Forms.TextBox();
            this.necesarKcal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonFinal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 533);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // totalPret
            // 
            this.totalPret.Location = new System.Drawing.Point(226, 671);
            this.totalPret.Name = "totalPret";
            this.totalPret.ReadOnly = true;
            this.totalPret.Size = new System.Drawing.Size(100, 31);
            this.totalPret.TabIndex = 12;
            // 
            // totalKcal
            // 
            this.totalKcal.Location = new System.Drawing.Point(226, 617);
            this.totalKcal.Name = "totalKcal";
            this.totalKcal.ReadOnly = true;
            this.totalKcal.Size = new System.Drawing.Size(100, 31);
            this.totalKcal.TabIndex = 11;
            // 
            // necesarKcal
            // 
            this.necesarKcal.Location = new System.Drawing.Point(334, 576);
            this.necesarKcal.Name = "necesarKcal";
            this.necesarKcal.ReadOnly = true;
            this.necesarKcal.Size = new System.Drawing.Size(100, 31);
            this.necesarKcal.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 671);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pret total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 623);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total kcal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 576);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Necesar calorii zilnice";
            // 
            // buttonFinal
            // 
            this.buttonFinal.Location = new System.Drawing.Point(612, 600);
            this.buttonFinal.Name = "buttonFinal";
            this.buttonFinal.Size = new System.Drawing.Size(252, 70);
            this.buttonFinal.TabIndex = 13;
            this.buttonFinal.Text = "Finalizeaza";
            this.buttonFinal.UseVisualStyleBackColor = true;
            this.buttonFinal.Click += new System.EventHandler(this.buttonFinal_Click);
            // 
            // VizualizareComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 729);
            this.Controls.Add(this.buttonFinal);
            this.Controls.Add(this.totalPret);
            this.Controls.Add(this.totalKcal);
            this.Controls.Add(this.necesarKcal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VizualizareComanda";
            this.Text = "Vizualizare Comanda";
            this.Load += new System.EventHandler(this.VizualizareComanda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox totalPret;
        private System.Windows.Forms.TextBox totalKcal;
        private System.Windows.Forms.TextBox necesarKcal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonFinal;
    }
}