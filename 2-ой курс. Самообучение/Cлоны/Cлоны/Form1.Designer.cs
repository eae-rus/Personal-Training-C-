namespace Cлоны
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
            this.Линда = new System.Windows.Forms.Button();
            this.Лойд = new System.Windows.Forms.Button();
            this.Смена = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Линда
            // 
            this.Линда.Location = new System.Drawing.Point(58, 47);
            this.Линда.Name = "Линда";
            this.Линда.Size = new System.Drawing.Size(118, 41);
            this.Линда.TabIndex = 0;
            this.Линда.Text = "Линда";
            this.Линда.UseVisualStyleBackColor = true;
            this.Линда.Click += new System.EventHandler(this.Линда_Click);
            // 
            // Лойд
            // 
            this.Лойд.Location = new System.Drawing.Point(58, 116);
            this.Лойд.Name = "Лойд";
            this.Лойд.Size = new System.Drawing.Size(118, 40);
            this.Лойд.TabIndex = 1;
            this.Лойд.Text = "Лойд";
            this.Лойд.UseVisualStyleBackColor = true;
            this.Лойд.Click += new System.EventHandler(this.Лойд_Click);
            // 
            // Смена
            // 
            this.Смена.Location = new System.Drawing.Point(58, 188);
            this.Смена.Name = "Смена";
            this.Смена.Size = new System.Drawing.Size(118, 38);
            this.Смена.TabIndex = 2;
            this.Смена.Text = "Смена";
            this.Смена.UseVisualStyleBackColor = true;
            this.Смена.Click += new System.EventHandler(this.Смена_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 262);
            this.Controls.Add(this.Смена);
            this.Controls.Add(this.Лойд);
            this.Controls.Add(this.Линда);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Линда;
        private System.Windows.Forms.Button Лойд;
        private System.Windows.Forms.Button Смена;
    }
}

