namespace Деовой_калькулятор
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
            this.Посчитать = new System.Windows.Forms.Button();
            this.Сумма = new System.Windows.Forms.Label();
            this.Начальный_км = new System.Windows.Forms.Label();
            this.Конечный_км = new System.Windows.Forms.Label();
            this.Вернут = new System.Windows.Forms.Label();
            this.Конечный_км_цифра = new System.Windows.Forms.NumericUpDown();
            this.Начальный_км_цифра = new System.Windows.Forms.NumericUpDown();
            this.Пройдено_км = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Конечный_км_цифра)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Начальный_км_цифра)).BeginInit();
            this.SuspendLayout();
            // 
            // Посчитать
            // 
            this.Посчитать.Location = new System.Drawing.Point(61, 263);
            this.Посчитать.Name = "Посчитать";
            this.Посчитать.Size = new System.Drawing.Size(113, 38);
            this.Посчитать.TabIndex = 0;
            this.Посчитать.Text = "Посчитать";
            this.Посчитать.UseVisualStyleBackColor = true;
            this.Посчитать.Click += new System.EventHandler(this.Посчитать_Click);
            // 
            // Сумма
            // 
            this.Сумма.AutoSize = true;
            this.Сумма.Location = new System.Drawing.Point(163, 200);
            this.Сумма.Name = "Сумма";
            this.Сумма.Size = new System.Drawing.Size(76, 13);
            this.Сумма.TabIndex = 1;
            this.Сумма.Text = "Не посчитано";
            // 
            // Начальный_км
            // 
            this.Начальный_км.AutoSize = true;
            this.Начальный_км.Location = new System.Drawing.Point(58, 63);
            this.Начальный_км.Name = "Начальный_км";
            this.Начальный_км.Size = new System.Drawing.Size(84, 13);
            this.Начальный_км.TabIndex = 2;
            this.Начальный_км.Text = "Начальный_км";
            // 
            // Конечный_км
            // 
            this.Конечный_км.AutoSize = true;
            this.Конечный_км.Location = new System.Drawing.Point(58, 126);
            this.Конечный_км.Name = "Конечный_км";
            this.Конечный_км.Size = new System.Drawing.Size(77, 13);
            this.Конечный_км.TabIndex = 3;
            this.Конечный_км.Text = "Конечный_км";
            // 
            // Вернут
            // 
            this.Вернут.AutoSize = true;
            this.Вернут.Location = new System.Drawing.Point(58, 200);
            this.Вернут.Name = "Вернут";
            this.Вернут.Size = new System.Drawing.Size(45, 13);
            this.Вернут.TabIndex = 4;
            this.Вернут.Text = "Вернут:";
            // 
            // Конечный_км_цифра
            // 
            this.Конечный_км_цифра.Location = new System.Drawing.Point(166, 126);
            this.Конечный_км_цифра.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Конечный_км_цифра.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Конечный_км_цифра.Name = "Конечный_км_цифра";
            this.Конечный_км_цифра.Size = new System.Drawing.Size(120, 20);
            this.Конечный_км_цифра.TabIndex = 5;
            this.Конечный_км_цифра.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Начальный_км_цифра
            // 
            this.Начальный_км_цифра.Location = new System.Drawing.Point(166, 63);
            this.Начальный_км_цифра.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.Начальный_км_цифра.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Начальный_км_цифра.Name = "Начальный_км_цифра";
            this.Начальный_км_цифра.Size = new System.Drawing.Size(120, 20);
            this.Начальный_км_цифра.TabIndex = 6;
            this.Начальный_км_цифра.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Пройдено_км
            // 
            this.Пройдено_км.Location = new System.Drawing.Point(284, 263);
            this.Пройдено_км.Name = "Пройдено_км";
            this.Пройдено_км.Size = new System.Drawing.Size(125, 38);
            this.Пройдено_км.TabIndex = 7;
            this.Пройдено_км.Text = "Пройдено км";
            this.Пройдено_км.UseVisualStyleBackColor = true;
            this.Пройдено_км.Click += new System.EventHandler(this.Пройдено_км_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 322);
            this.Controls.Add(this.Пройдено_км);
            this.Controls.Add(this.Начальный_км_цифра);
            this.Controls.Add(this.Конечный_км_цифра);
            this.Controls.Add(this.Вернут);
            this.Controls.Add(this.Конечный_км);
            this.Controls.Add(this.Начальный_км);
            this.Controls.Add(this.Сумма);
            this.Controls.Add(this.Посчитать);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Деловой Калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.Конечный_км_цифра)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Начальный_км_цифра)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Посчитать;
        private System.Windows.Forms.Label Сумма;
        private System.Windows.Forms.Label Начальный_км;
        private System.Windows.Forms.Label Конечный_км;
        private System.Windows.Forms.Label Вернут;
        private System.Windows.Forms.NumericUpDown Конечный_км_цифра;
        private System.Windows.Forms.NumericUpDown Начальный_км_цифра;
        private System.Windows.Forms.Button Пройдено_км;
    }
}

