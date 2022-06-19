namespace Карты_1
{
    partial class Рандом_карт
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
            this.Случайная_карта = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Случайная_карта
            // 
            this.Случайная_карта.Location = new System.Drawing.Point(54, 97);
            this.Случайная_карта.Name = "Случайная_карта";
            this.Случайная_карта.Size = new System.Drawing.Size(173, 63);
            this.Случайная_карта.TabIndex = 0;
            this.Случайная_карта.Text = "Выдать случайную карту";
            this.Случайная_карта.UseVisualStyleBackColor = true;
            this.Случайная_карта.Click += new System.EventHandler(this.Случайная_карта_Click);
            // 
            // Рандом_карт
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Случайная_карта);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Рандом_карт";
            this.Text = "Рандом карт";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Случайная_карта;
    }
}

