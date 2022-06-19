namespace Стоимость_Пати
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.КолГостей = new System.Windows.Forms.NumericUpDown();
            this.оформление = new System.Windows.Forms.CheckBox();
            this.ЗдоровыйВариант = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Цена = new System.Windows.Forms.Label();
            this.Праздники = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Надпись = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Цена_ДР = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Оформление_ДР = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Кол_гостей_ДР = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.КолГостей)).BeginInit();
            this.Праздники.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Кол_гостей_ДР)).BeginInit();
            this.SuspendLayout();
            // 
            // КолГостей
            // 
            this.КолГостей.Location = new System.Drawing.Point(28, 54);
            this.КолГостей.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.КолГостей.Name = "КолГостей";
            this.КолГостей.Size = new System.Drawing.Size(163, 20);
            this.КолГостей.TabIndex = 0;
            this.КолГостей.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.КолГостей.ValueChanged += new System.EventHandler(this.КолГостей_ValueChanged);
            // 
            // оформление
            // 
            this.оформление.AutoSize = true;
            this.оформление.Checked = true;
            this.оформление.CheckState = System.Windows.Forms.CheckState.Checked;
            this.оформление.Location = new System.Drawing.Point(60, 95);
            this.оформление.Name = "оформление";
            this.оформление.Size = new System.Drawing.Size(131, 17);
            this.оформление.TabIndex = 1;
            this.оформление.Text = "Особое оформление";
            this.оформление.UseVisualStyleBackColor = true;
            this.оформление.CheckedChanged += new System.EventHandler(this.оформление_CheckedChanged);
            // 
            // ЗдоровыйВариант
            // 
            this.ЗдоровыйВариант.AutoSize = true;
            this.ЗдоровыйВариант.Location = new System.Drawing.Point(70, 140);
            this.ЗдоровыйВариант.Name = "ЗдоровыйВариант";
            this.ЗдоровыйВариант.Size = new System.Drawing.Size(121, 17);
            this.ЗдоровыйВариант.TabIndex = 2;
            this.ЗдоровыйВариант.Text = "Здоровый вариант";
            this.ЗдоровыйВариант.UseVisualStyleBackColor = true;
            this.ЗдоровыйВариант.CheckedChanged += new System.EventHandler(this.ЗдоровыйВариант_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Колличество гостей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена";
            // 
            // Цена
            // 
            this.Цена.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Цена.Location = new System.Drawing.Point(91, 195);
            this.Цена.Name = "Цена";
            this.Цена.Size = new System.Drawing.Size(100, 23);
            this.Цена.TabIndex = 5;
            this.Цена.Text = " ";
            // 
            // Праздники
            // 
            this.Праздники.Controls.Add(this.tabPage1);
            this.Праздники.Controls.Add(this.tabPage2);
            this.Праздники.Location = new System.Drawing.Point(2, -2);
            this.Праздники.Name = "Праздники";
            this.Праздники.SelectedIndex = 0;
            this.Праздники.Size = new System.Drawing.Size(284, 265);
            this.Праздники.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Цена);
            this.tabPage1.Controls.Add(this.КолГостей);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.оформление);
            this.tabPage1.Controls.Add(this.ЗдоровыйВариант);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(276, 239);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Вечеринки";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Надпись);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.Цена_ДР);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.Оформление_ДР);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Кол_гостей_ДР);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(276, 239);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "День Рождения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Надпись
            // 
            this.Надпись.Location = new System.Drawing.Point(46, 156);
            this.Надпись.Name = "Надпись";
            this.Надпись.Size = new System.Drawing.Size(163, 20);
            this.Надпись.TabIndex = 9;
            this.Надпись.Text = "С Днём Рождения";
            this.Надпись.TextChanged += new System.EventHandler(this.Надпись_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Надпись на троте";
            // 
            // Цена_ДР
            // 
            this.Цена_ДР.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Цена_ДР.Location = new System.Drawing.Point(109, 190);
            this.Цена_ДР.Name = "Цена_ДР";
            this.Цена_ДР.Size = new System.Drawing.Size(100, 23);
            this.Цена_ДР.TabIndex = 7;
            this.Цена_ДР.Text = " ";
            this.Цена_ДР.Click += new System.EventHandler(this.Цена_ДР_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена";
            // 
            // Оформление_ДР
            // 
            this.Оформление_ДР.AutoSize = true;
            this.Оформление_ДР.Checked = true;
            this.Оформление_ДР.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Оформление_ДР.Location = new System.Drawing.Point(78, 92);
            this.Оформление_ДР.Name = "Оформление_ДР";
            this.Оформление_ДР.Size = new System.Drawing.Size(131, 17);
            this.Оформление_ДР.TabIndex = 5;
            this.Оформление_ДР.Text = "Особое оформление";
            this.Оформление_ДР.UseVisualStyleBackColor = true;
            this.Оформление_ДР.CheckedChanged += new System.EventHandler(this.Оформление_ДР_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Колличество гостей";
            // 
            // Кол_гостей_ДР
            // 
            this.Кол_гостей_ДР.Location = new System.Drawing.Point(46, 55);
            this.Кол_гостей_ДР.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Кол_гостей_ДР.Name = "Кол_гостей_ДР";
            this.Кол_гостей_ДР.Size = new System.Drawing.Size(163, 20);
            this.Кол_гостей_ДР.TabIndex = 1;
            this.Кол_гостей_ДР.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Кол_гостей_ДР.ValueChanged += new System.EventHandler(this.Кол_гостей_ДР_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Праздники);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Cтоимость пати";
            ((System.ComponentModel.ISupportInitialize)(this.КолГостей)).EndInit();
            this.Праздники.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Кол_гостей_ДР)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown КолГостей;
        private System.Windows.Forms.CheckBox оформление;
        private System.Windows.Forms.CheckBox ЗдоровыйВариант;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Цена;
        private System.Windows.Forms.TabControl Праздники;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Цена_ДР;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox Оформление_ДР;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Кол_гостей_ДР;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Надпись;
    }
}

