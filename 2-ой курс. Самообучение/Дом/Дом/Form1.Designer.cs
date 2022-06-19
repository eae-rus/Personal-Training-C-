namespace Дом
{
    partial class Описание_помещения
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
            this.components = new System.ComponentModel.Container();
            this.Описание_помещ_ = new System.Windows.Forms.Label();
            this.Перем_в_ук_помещ = new System.Windows.Forms.Button();
            this.Зайти_выйти = new System.Windows.Forms.Button();
            this.Соседние_помещ = new System.Windows.Forms.ComboBox();
            this.Укромные_места = new System.Windows.Forms.Label();
            this.Места = new System.Windows.Forms.ComboBox();
            this.Проверить = new System.Windows.Forms.Button();
            this.Начать_игру = new System.Windows.Forms.Button();
            this.таймер = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Описание_помещ_
            // 
            this.Описание_помещ_.AutoSize = true;
            this.Описание_помещ_.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Описание_помещ_.Location = new System.Drawing.Point(41, 19);
            this.Описание_помещ_.MaximumSize = new System.Drawing.Size(460, 250);
            this.Описание_помещ_.MinimumSize = new System.Drawing.Size(460, 250);
            this.Описание_помещ_.Name = "Описание_помещ_";
            this.Описание_помещ_.Size = new System.Drawing.Size(460, 250);
            this.Описание_помещ_.TabIndex = 0;
            this.Описание_помещ_.Text = " ";
            this.Описание_помещ_.Click += new System.EventHandler(this.Описание_помещ__Click);
            // 
            // Перем_в_ук_помещ
            // 
            this.Перем_в_ук_помещ.Location = new System.Drawing.Point(44, 307);
            this.Перем_в_ук_помещ.Name = "Перем_в_ук_помещ";
            this.Перем_в_ук_помещ.Size = new System.Drawing.Size(75, 23);
            this.Перем_в_ук_помещ.TabIndex = 1;
            this.Перем_в_ук_помещ.Text = "Идти сюда";
            this.Перем_в_ук_помещ.UseVisualStyleBackColor = true;
            this.Перем_в_ук_помещ.Click += new System.EventHandler(this.Перем_в_ук_помещ_Click);
            // 
            // Зайти_выйти
            // 
            this.Зайти_выйти.Location = new System.Drawing.Point(44, 359);
            this.Зайти_выйти.Name = "Зайти_выйти";
            this.Зайти_выйти.Size = new System.Drawing.Size(457, 47);
            this.Зайти_выйти.TabIndex = 2;
            this.Зайти_выйти.UseVisualStyleBackColor = true;
            this.Зайти_выйти.Click += new System.EventHandler(this.Зайти_выйти_Click);
            // 
            // Соседние_помещ
            // 
            this.Соседние_помещ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Соседние_помещ.FormattingEnabled = true;
            this.Соседние_помещ.Location = new System.Drawing.Point(147, 307);
            this.Соседние_помещ.Name = "Соседние_помещ";
            this.Соседние_помещ.Size = new System.Drawing.Size(354, 21);
            this.Соседние_помещ.TabIndex = 3;
            this.Соседние_помещ.SelectedIndexChanged += new System.EventHandler(this.Соседние_помещ_SelectedIndexChanged);
            // 
            // Укромные_места
            // 
            this.Укромные_места.AutoSize = true;
            this.Укромные_места.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Укромные_места.Location = new System.Drawing.Point(536, 19);
            this.Укромные_места.MaximumSize = new System.Drawing.Size(180, 250);
            this.Укромные_места.MinimumSize = new System.Drawing.Size(180, 250);
            this.Укромные_места.Name = "Укромные_места";
            this.Укромные_места.Size = new System.Drawing.Size(180, 250);
            this.Укромные_места.TabIndex = 4;
            // 
            // Места
            // 
            this.Места.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Места.FormattingEnabled = true;
            this.Места.Location = new System.Drawing.Point(539, 307);
            this.Места.Name = "Места";
            this.Места.Size = new System.Drawing.Size(177, 21);
            this.Места.TabIndex = 5;
            // 
            // Проверить
            // 
            this.Проверить.BackColor = System.Drawing.Color.Lime;
            this.Проверить.Location = new System.Drawing.Point(539, 350);
            this.Проверить.Name = "Проверить";
            this.Проверить.Size = new System.Drawing.Size(177, 23);
            this.Проверить.TabIndex = 6;
            this.Проверить.Text = "Проверить";
            this.Проверить.UseVisualStyleBackColor = false;
            this.Проверить.Click += new System.EventHandler(this.Проверить_Click);
            // 
            // Начать_игру
            // 
            this.Начать_игру.BackColor = System.Drawing.Color.Fuchsia;
            this.Начать_игру.Location = new System.Drawing.Point(539, 382);
            this.Начать_игру.Name = "Начать_игру";
            this.Начать_игру.Size = new System.Drawing.Size(177, 23);
            this.Начать_игру.TabIndex = 7;
            this.Начать_игру.Text = "Начать игру \"прятки\"";
            this.Начать_игру.UseVisualStyleBackColor = false;
            this.Начать_игру.Click += new System.EventHandler(this.Начать_игру_Click);
            // 
            // таймер
            // 
            this.таймер.Enabled = true;
            // 
            // Описание_помещения
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 439);
            this.Controls.Add(this.Начать_игру);
            this.Controls.Add(this.Проверить);
            this.Controls.Add(this.Места);
            this.Controls.Add(this.Укромные_места);
            this.Controls.Add(this.Соседние_помещ);
            this.Controls.Add(this.Зайти_выйти);
            this.Controls.Add(this.Перем_в_ук_помещ);
            this.Controls.Add(this.Описание_помещ_);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Описание_помещения";
            this.Text = "Дом";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Описание_помещ_;
        private System.Windows.Forms.Button Перем_в_ук_помещ;
        private System.Windows.Forms.Button Зайти_выйти;
        private System.Windows.Forms.ComboBox Соседние_помещ;
        private System.Windows.Forms.Label Укромные_места;
        private System.Windows.Forms.ComboBox Места;
        private System.Windows.Forms.Button Проверить;
        private System.Windows.Forms.Button Начать_игру;
        public System.Windows.Forms.Timer таймер;
    }
}

