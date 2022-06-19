namespace Аварийная_угловая_характеристика
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation3 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation lineAnnotation4 = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Param = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Zapis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxf = new System.Windows.Forms.TextBox();
            this.labelTj = new System.Windows.Forms.Label();
            this.textBoxTj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxtk = new System.Windows.Forms.TextBox();
            this.solve = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxtfi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // Param
            // 
            this.Param.Location = new System.Drawing.Point(12, 65);
            this.Param.Multiline = true;
            this.Param.Name = "Param";
            this.Param.Size = new System.Drawing.Size(240, 406);
            this.Param.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "угловая характеристика \r\n(угол от 0 до 180 в порядке возрастания)";
            // 
            // Zapis
            // 
            this.Zapis.BackColor = System.Drawing.Color.Lime;
            this.Zapis.Location = new System.Drawing.Point(12, 489);
            this.Zapis.Name = "Zapis";
            this.Zapis.Size = new System.Drawing.Size(243, 70);
            this.Zapis.TabIndex = 2;
            this.Zapis.Text = "Считать значения";
            this.Zapis.UseVisualStyleBackColor = false;
            this.Zapis.Click += new System.EventHandler(this.Zapis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1262, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(393, 576);
            this.dataGridView1.TabIndex = 3;
            // 
            // chart1
            // 
            lineAnnotation3.IsInfinitive = true;
            lineAnnotation3.LineWidth = 3;
            lineAnnotation3.Name = "LineAnnotation1";
            lineAnnotation3.StartCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Arrow;
            this.chart1.Annotations.Add(lineAnnotation3);
            this.chart1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(492, 65);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.EmptyPointStyle.CustomProperties = "DrawingStyle=Wedge";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(745, 280);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "угловая аварийная характеристика";
            // 
            // chart2
            // 
            lineAnnotation4.IsInfinitive = true;
            lineAnnotation4.LineWidth = 3;
            lineAnnotation4.Name = "LineAnnotation1";
            lineAnnotation4.StartCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Arrow;
            this.chart2.Annotations.Add(lineAnnotation4);
            this.chart2.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(476, 370);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.EmptyPointStyle.CustomProperties = "DrawingStyle=Wedge";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(761, 463);
            this.chart2.TabIndex = 5;
            this.chart2.Text = "угловая аварийная характеристика";
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(297, 113);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(100, 22);
            this.textBoxP.TabIndex = 6;
            this.textBoxP.Text = "0,85";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "мощность турбины (Рг0)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "fн (Гц)";
            // 
            // textBoxf
            // 
            this.textBoxf.Location = new System.Drawing.Point(297, 173);
            this.textBoxf.Name = "textBoxf";
            this.textBoxf.Size = new System.Drawing.Size(100, 22);
            this.textBoxf.TabIndex = 8;
            this.textBoxf.Text = "50";
            // 
            // labelTj
            // 
            this.labelTj.AutoSize = true;
            this.labelTj.Location = new System.Drawing.Point(294, 210);
            this.labelTj.Name = "labelTj";
            this.labelTj.Size = new System.Drawing.Size(20, 17);
            this.labelTj.TabIndex = 11;
            this.labelTj.Text = "Tj";
            // 
            // textBoxTj
            // 
            this.textBoxTj.Location = new System.Drawing.Point(297, 236);
            this.textBoxTj.Name = "textBoxTj";
            this.textBoxTj.Size = new System.Drawing.Size(100, 22);
            this.textBoxTj.TabIndex = 10;
            this.textBoxTj.Text = "11";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Шаг-h  (c)";
            // 
            // textBoxh
            // 
            this.textBoxh.Location = new System.Drawing.Point(301, 301);
            this.textBoxh.Name = "textBoxh";
            this.textBoxh.Size = new System.Drawing.Size(100, 22);
            this.textBoxh.TabIndex = 12;
            this.textBoxh.Text = "0,001";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Время окончания расчёта";
            // 
            // textBoxtk
            // 
            this.textBoxtk.Location = new System.Drawing.Point(301, 449);
            this.textBoxtk.Name = "textBoxtk";
            this.textBoxtk.Size = new System.Drawing.Size(100, 22);
            this.textBoxtk.TabIndex = 14;
            this.textBoxtk.Text = "1";
            // 
            // solve
            // 
            this.solve.BackColor = System.Drawing.Color.Red;
            this.solve.Location = new System.Drawing.Point(12, 595);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(243, 70);
            this.solve.TabIndex = 16;
            this.solve.Text = "Расчёт";
            this.solve.UseVisualStyleBackColor = false;
            this.solve.Click += new System.EventHandler(this.solve_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "начальный угол";
            // 
            // textBoxtfi
            // 
            this.textBoxtfi.Location = new System.Drawing.Point(301, 370);
            this.textBoxtfi.Name = "textBoxtfi";
            this.textBoxtfi.Size = new System.Drawing.Size(100, 22);
            this.textBoxtfi.TabIndex = 17;
            this.textBoxtfi.Text = "9,3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 677);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 47);
            this.button1.TabIndex = 19;
            this.button1.Text = "Очистить график 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1667, 845);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxtfi);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxtk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxh);
            this.Controls.Add(this.labelTj);
            this.Controls.Add(this.textBoxTj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Zapis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Param);
            this.Name = "Form1";
            this.Text = "Расчёт аварийной угловой характеристики";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Param;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Zapis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxf;
        private System.Windows.Forms.Label labelTj;
        private System.Windows.Forms.TextBox textBoxTj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxtk;
        private System.Windows.Forms.Button solve;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxtfi;
        private System.Windows.Forms.Button button1;
    }
}

