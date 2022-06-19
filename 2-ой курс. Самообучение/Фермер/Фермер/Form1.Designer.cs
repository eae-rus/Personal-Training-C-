namespace Фермер
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
            this.КолКоров = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.ИтогТекст = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.КолКоров)).BeginInit();
            this.SuspendLayout();
            // 
            // Посчитать
            // 
            this.Посчитать.Location = new System.Drawing.Point(51, 148);
            this.Посчитать.Name = "Посчитать";
            this.Посчитать.Size = new System.Drawing.Size(161, 56);
            this.Посчитать.TabIndex = 0;
            this.Посчитать.Text = "Посчитать";
            this.Посчитать.UseVisualStyleBackColor = true;
            this.Посчитать.Click += new System.EventHandler(this.Посчитать_Click);
            // 
            // КолКоров
            // 
            this.КолКоров.Location = new System.Drawing.Point(51, 103);
            this.КолКоров.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.КолКоров.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.КолКоров.Name = "КолКоров";
            this.КолКоров.Size = new System.Drawing.Size(161, 20);
            this.КолКоров.TabIndex = 1;
            this.КолКоров.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Колличество коров";
            // 
            // ИтогТекст
            // 
            this.ИтогТекст.AutoSize = true;
            this.ИтогТекст.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ИтогТекст.Location = new System.Drawing.Point(12, 224);
            this.ИтогТекст.Name = "ИтогТекст";
            this.ИтогТекст.Size = new System.Drawing.Size(2, 15);
            this.ИтогТекст.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ИтогТекст);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.КолКоров);
            this.Controls.Add(this.Посчитать);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Фермер";
            ((System.ComponentModel.ISupportInitialize)(this.КолКоров)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Посчитать;
        private System.Windows.Forms.NumericUpDown КолКоров;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ИтогТекст;
    }
}

