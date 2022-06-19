namespace Мат
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
            this.Строка = new System.Windows.Forms.NumericUpDown();
            this.Столбец = new System.Windows.Forms.NumericUpDown();
            this.лайбл = new System.Windows.Forms.Label();
            this.лайбл1 = new System.Windows.Forms.Label();
            this.Число = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Строка)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Столбец)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Число)).BeginInit();
            this.SuspendLayout();
            // 
            // Строка
            // 
            this.Строка.Location = new System.Drawing.Point(67, 43);
            this.Строка.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Строка.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Строка.Name = "Строка";
            this.Строка.Size = new System.Drawing.Size(120, 20);
            this.Строка.TabIndex = 1;
            this.Строка.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Столбец
            // 
            this.Столбец.Location = new System.Drawing.Point(226, 43);
            this.Столбец.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Столбец.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Столбец.Name = "Столбец";
            this.Столбец.Size = new System.Drawing.Size(120, 20);
            this.Столбец.TabIndex = 1;
            this.Столбец.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // лайбл
            // 
            this.лайбл.AutoSize = true;
            this.лайбл.Location = new System.Drawing.Point(67, 24);
            this.лайбл.Name = "лайбл";
            this.лайбл.Size = new System.Drawing.Size(61, 13);
            this.лайбл.TabIndex = 2;
            this.лайбл.Text = "Кол. строк";
            // 
            // лайбл1
            // 
            this.лайбл1.AutoSize = true;
            this.лайбл1.Location = new System.Drawing.Point(226, 23);
            this.лайбл1.Name = "лайбл1";
            this.лайбл1.Size = new System.Drawing.Size(82, 13);
            this.лайбл1.TabIndex = 3;
            this.лайбл1.Text = "Кол.  столбцов";
            // 
            // Число
            // 
            this.Число.Location = new System.Drawing.Point(131, 108);
            this.Число.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Число.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.Число.Name = "Число";
            this.Число.Size = new System.Drawing.Size(120, 20);
            this.Число.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ведите А1.1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Вести";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Число);
            this.Controls.Add(this.лайбл1);
            this.Controls.Add(this.лайбл);
            this.Controls.Add(this.Столбец);
            this.Controls.Add(this.Строка);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Строка)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Столбец)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Число)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Строка;
        private System.Windows.Forms.NumericUpDown Столбец;
        private System.Windows.Forms.Label лайбл;
        private System.Windows.Forms.Label лайбл1;
        private System.Windows.Forms.NumericUpDown Число;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

