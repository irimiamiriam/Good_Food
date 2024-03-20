namespace Good_Food
{
    partial class Optiuni
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.CalculatorKcal = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.greutate_textBox = new System.Windows.Forms.TextBox();
            this.inaltime_textBox = new System.Windows.Forms.TextBox();
            this.varsta_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Comanda = new System.Windows.Forms.TabPage();
            this.comand = new System.Windows.Forms.Button();
            this.totalPret = new System.Windows.Forms.TextBox();
            this.totalKcal = new System.Windows.Forms.TextBox();
            this.necesarKcal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GenerareMeniu = new System.Windows.Forms.TabPage();
            this.GraficKcal = new System.Windows.Forms.TabPage();
            this.grafic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buget = new System.Windows.Forms.TextBox();
            this.necKcal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.CalculatorKcal.SuspendLayout();
            this.Comanda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GenerareMeniu.SuspendLayout();
            this.GraficKcal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.CalculatorKcal);
            this.tabControl.Controls.Add(this.Comanda);
            this.tabControl.Controls.Add(this.GenerareMeniu);
            this.tabControl.Controls.Add(this.GraficKcal);
            this.tabControl.Location = new System.Drawing.Point(2, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1252, 930);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // CalculatorKcal
            // 
            this.CalculatorKcal.Controls.Add(this.textBox1);
            this.CalculatorKcal.Controls.Add(this.label4);
            this.CalculatorKcal.Controls.Add(this.calculate);
            this.CalculatorKcal.Controls.Add(this.greutate_textBox);
            this.CalculatorKcal.Controls.Add(this.inaltime_textBox);
            this.CalculatorKcal.Controls.Add(this.varsta_textBox);
            this.CalculatorKcal.Controls.Add(this.label3);
            this.CalculatorKcal.Controls.Add(this.label2);
            this.CalculatorKcal.Controls.Add(this.label1);
            this.CalculatorKcal.Location = new System.Drawing.Point(8, 39);
            this.CalculatorKcal.Name = "CalculatorKcal";
            this.CalculatorKcal.Padding = new System.Windows.Forms.Padding(3);
            this.CalculatorKcal.Size = new System.Drawing.Size(1236, 883);
            this.CalculatorKcal.TabIndex = 0;
            this.CalculatorKcal.Text = "CalculatorKcal";
            this.CalculatorKcal.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(769, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Necesar zilnic:";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(341, 466);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(161, 55);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Calculeaza ";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // greutate_textBox
            // 
            this.greutate_textBox.Location = new System.Drawing.Point(450, 392);
            this.greutate_textBox.Name = "greutate_textBox";
            this.greutate_textBox.Size = new System.Drawing.Size(100, 31);
            this.greutate_textBox.TabIndex = 5;
            // 
            // inaltime_textBox
            // 
            this.inaltime_textBox.Location = new System.Drawing.Point(450, 316);
            this.inaltime_textBox.Name = "inaltime_textBox";
            this.inaltime_textBox.Size = new System.Drawing.Size(100, 31);
            this.inaltime_textBox.TabIndex = 4;
            // 
            // varsta_textBox
            // 
            this.varsta_textBox.Location = new System.Drawing.Point(450, 250);
            this.varsta_textBox.Name = "varsta_textBox";
            this.varsta_textBox.Size = new System.Drawing.Size(100, 31);
            this.varsta_textBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Greutate(kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inaltime(cm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varsta(ani)";
            // 
            // Comanda
            // 
            this.Comanda.Controls.Add(this.comand);
            this.Comanda.Controls.Add(this.totalPret);
            this.Comanda.Controls.Add(this.totalKcal);
            this.Comanda.Controls.Add(this.necesarKcal);
            this.Comanda.Controls.Add(this.label7);
            this.Comanda.Controls.Add(this.label6);
            this.Comanda.Controls.Add(this.label5);
            this.Comanda.Controls.Add(this.dataGridView1);
            this.Comanda.Location = new System.Drawing.Point(8, 39);
            this.Comanda.Name = "Comanda";
            this.Comanda.Padding = new System.Windows.Forms.Padding(3);
            this.Comanda.Size = new System.Drawing.Size(1236, 883);
            this.Comanda.TabIndex = 1;
            this.Comanda.Text = "Comanda";
            this.Comanda.UseVisualStyleBackColor = true;
            // 
            // comand
            // 
            this.comand.Location = new System.Drawing.Point(891, 642);
            this.comand.Name = "comand";
            this.comand.Size = new System.Drawing.Size(148, 63);
            this.comand.TabIndex = 7;
            this.comand.Text = "Comanda";
            this.comand.UseVisualStyleBackColor = true;
            this.comand.Click += new System.EventHandler(this.comand_Click);
            // 
            // totalPret
            // 
            this.totalPret.Location = new System.Drawing.Point(325, 702);
            this.totalPret.Name = "totalPret";
            this.totalPret.ReadOnly = true;
            this.totalPret.Size = new System.Drawing.Size(100, 31);
            this.totalPret.TabIndex = 6;
            // 
            // totalKcal
            // 
            this.totalKcal.Location = new System.Drawing.Point(325, 648);
            this.totalKcal.Name = "totalKcal";
            this.totalKcal.ReadOnly = true;
            this.totalKcal.Size = new System.Drawing.Size(100, 31);
            this.totalKcal.TabIndex = 5;
            // 
            // necesarKcal
            // 
            this.necesarKcal.Location = new System.Drawing.Point(433, 607);
            this.necesarKcal.Name = "necesarKcal";
            this.necesarKcal.ReadOnly = true;
            this.necesarKcal.Size = new System.Drawing.Size(100, 31);
            this.necesarKcal.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 702);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Pret total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 654);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total kcal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 607);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Necesar calorii zilnice";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-8, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1238, 573);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // GenerareMeniu
            // 
            this.GenerareMeniu.Controls.Add(this.dataGridView2);
            this.GenerareMeniu.Controls.Add(this.generate);
            this.GenerareMeniu.Controls.Add(this.buget);
            this.GenerareMeniu.Controls.Add(this.necKcal);
            this.GenerareMeniu.Controls.Add(this.label8);
            this.GenerareMeniu.Controls.Add(this.label9);
            this.GenerareMeniu.Location = new System.Drawing.Point(8, 39);
            this.GenerareMeniu.Name = "GenerareMeniu";
            this.GenerareMeniu.Padding = new System.Windows.Forms.Padding(3);
            this.GenerareMeniu.Size = new System.Drawing.Size(1236, 883);
            this.GenerareMeniu.TabIndex = 2;
            this.GenerareMeniu.Text = "Generare Meniu";
            this.GenerareMeniu.UseVisualStyleBackColor = true;
            // 
            // GraficKcal
            // 
            this.GraficKcal.Controls.Add(this.grafic);
            this.GraficKcal.Location = new System.Drawing.Point(8, 39);
            this.GraficKcal.Name = "GraficKcal";
            this.GraficKcal.Padding = new System.Windows.Forms.Padding(3);
            this.GraficKcal.Size = new System.Drawing.Size(1236, 883);
            this.GraficKcal.TabIndex = 3;
            this.GraficKcal.Text = "GraficKcal";
            this.GraficKcal.UseVisualStyleBackColor = true;
            // 
            // grafic
            // 
            chartArea6.Name = "ChartArea1";
            this.grafic.ChartAreas.Add(chartArea6);
            this.grafic.Location = new System.Drawing.Point(67, 43);
            this.grafic.Name = "grafic";
            this.grafic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.grafic.Size = new System.Drawing.Size(1099, 503);
            this.grafic.TabIndex = 0;
            this.grafic.Text = "chart1";
            // 
            // buget
            // 
            this.buget.Location = new System.Drawing.Point(197, 73);
            this.buget.Name = "buget";
            this.buget.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.buget.Size = new System.Drawing.Size(100, 31);
            this.buget.TabIndex = 9;
            // 
            // necKcal
            // 
            this.necKcal.Location = new System.Drawing.Point(305, 32);
            this.necKcal.Name = "necKcal";
            this.necKcal.ReadOnly = true;
            this.necKcal.Size = new System.Drawing.Size(100, 31);
            this.necKcal.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Buget";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(66, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "Necesar calorii zilnice";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(82, 125);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(138, 38);
            this.generate.TabIndex = 10;
            this.generate.Text = "Genereaza";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 193);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1229, 684);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Optiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 943);
            this.Controls.Add(this.tabControl);
            this.Name = "Optiuni";
            this.Text = "Optiuni";
            this.Load += new System.EventHandler(this.Optiuni_Load);
            this.tabControl.ResumeLayout(false);
            this.CalculatorKcal.ResumeLayout(false);
            this.CalculatorKcal.PerformLayout();
            this.Comanda.ResumeLayout(false);
            this.Comanda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GenerareMeniu.ResumeLayout(false);
            this.GenerareMeniu.PerformLayout();
            this.GraficKcal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grafic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage CalculatorKcal;
        private System.Windows.Forms.TabPage Comanda;
        private System.Windows.Forms.TabPage GenerareMeniu;
        private System.Windows.Forms.TextBox greutate_textBox;
        private System.Windows.Forms.TextBox inaltime_textBox;
        private System.Windows.Forms.TextBox varsta_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage GraficKcal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button comand;
        private System.Windows.Forms.TextBox totalPret;
        private System.Windows.Forms.TextBox totalKcal;
        private System.Windows.Forms.TextBox necesarKcal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafic;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.TextBox buget;
        private System.Windows.Forms.TextBox necKcal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}