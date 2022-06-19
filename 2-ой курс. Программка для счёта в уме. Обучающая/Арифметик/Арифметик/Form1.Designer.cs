namespace Арифметик
{
    partial class Арифметик
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Арифметик));
            this.label1 = new System.Windows.Forms.Label();
            this.Сложность = new System.Windows.Forms.NumericUpDown();
            this.Числа = new System.Windows.Forms.TextBox();
            this.Ответ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Сложность)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Уровень сложности";
            // 
            // Сложность
            // 
            this.Сложность.Location = new System.Drawing.Point(13, 30);
            this.Сложность.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Сложность.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Сложность.Name = "Сложность";
            this.Сложность.Size = new System.Drawing.Size(109, 20);
            this.Сложность.TabIndex = 5;
            this.Сложность.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Сложность.ValueChanged += new System.EventHandler(this.Сложность_ValueChanged);
            // 
            // Числа
            // 
            this.Числа.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Числа.Location = new System.Drawing.Point(258, 201);
            this.Числа.Multiline = true;
            this.Числа.Name = "Числа";
            this.Числа.Size = new System.Drawing.Size(303, 90);
            this.Числа.TabIndex = 6;
            this.Числа.Text = " ";
            this.Числа.TextChanged += new System.EventHandler(this.Ответ_TextChanged);
            // 
            // Ответ
            // 
            this.Ответ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ответ.Location = new System.Drawing.Point(258, 299);
            this.Ответ.Name = "Ответ";
            this.Ответ.Size = new System.Drawing.Size(303, 26);
            this.Ответ.TabIndex = 7;
            this.Ответ.TextChanged += new System.EventHandler(this.Ответ_TextChanged_1);
            // 
            // Арифметик
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(883, 623);
            this.Controls.Add(this.Ответ);
            this.Controls.Add(this.Числа);
            this.Controls.Add(this.Сложность);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Арифметик";
            this.Tag = "1";
            this.Text = "Арифметик";
            this.Load += new System.EventHandler(this.Арифметик_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Сложность)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Сложность;
        private System.Windows.Forms.TextBox Числа;
        private System.Windows.Forms.TextBox Ответ;
    }
}

