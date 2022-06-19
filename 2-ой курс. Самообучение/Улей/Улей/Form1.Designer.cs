namespace Улей
{
    partial class Улей
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
            this.label1 = new System.Windows.Forms.Label();
            this.Количество_пчёл_в_улье = new System.Windows.Forms.NumericUpDown();
            this.Варианты_работы = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Кол_Смен = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Распрелделить_пчёл = new System.Windows.Forms.Button();
            this.Смена_прошла = new System.Windows.Forms.Button();
            this.Отчёт_о_работающих = new System.Windows.Forms.TextBox();
            this.Отчёт_о_свободных = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Кол_пчёл_на_работу = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Мёд_Расход = new System.Windows.Forms.TextBox();
            this.Отмена_пчёл_работа = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Количество_пчёл_в_улье)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Кол_Смен)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Кол_пчёл_на_работу)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество пчёл в улье";
            // 
            // Количество_пчёл_в_улье
            // 
            this.Количество_пчёл_в_улье.Location = new System.Drawing.Point(13, 26);
            this.Количество_пчёл_в_улье.Maximum = new decimal(new int[] {
            -294967296,
            0,
            0,
            0});
            this.Количество_пчёл_в_улье.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Количество_пчёл_в_улье.Name = "Количество_пчёл_в_улье";
            this.Количество_пчёл_в_улье.Size = new System.Drawing.Size(126, 20);
            this.Количество_пчёл_в_улье.TabIndex = 1;
            this.Количество_пчёл_в_улье.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Количество_пчёл_в_улье.ValueChanged += new System.EventHandler(this.Количество_пчёл_в_улье_ValueChanged);
            // 
            // Варианты_работы
            // 
            this.Варианты_работы.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Варианты_работы.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Варианты_работы.FormattingEnabled = true;
            this.Варианты_работы.Items.AddRange(new object[] {
            "Собирать нектар",
            "Уход за яйцами",
            "Обслуживание улья",
            "Ухаживать за куколками",
            "Обслуживание мёда",
            "Охрана"});
            this.Варианты_работы.Location = new System.Drawing.Point(15, 106);
            this.Варианты_работы.Name = "Варианты_работы";
            this.Варианты_работы.Size = new System.Drawing.Size(185, 21);
            this.Варианты_работы.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выбрать задание";
            // 
            // Кол_Смен
            // 
            this.Кол_Смен.Location = new System.Drawing.Point(221, 106);
            this.Кол_Смен.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Кол_Смен.Name = "Кол_Смен";
            this.Кол_Смен.Size = new System.Drawing.Size(62, 20);
            this.Кол_Смен.TabIndex = 4;
            this.Кол_Смен.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(205, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество смен";
            // 
            // Распрелделить_пчёл
            // 
            this.Распрелделить_пчёл.BackColor = System.Drawing.Color.LightGreen;
            this.Распрелделить_пчёл.Location = new System.Drawing.Point(15, 133);
            this.Распрелделить_пчёл.Name = "Распрелделить_пчёл";
            this.Распрелделить_пчёл.Size = new System.Drawing.Size(187, 37);
            this.Распрелделить_пчёл.TabIndex = 6;
            this.Распрелделить_пчёл.Text = "Выдать это задание пчёлам";
            this.Распрелделить_пчёл.UseVisualStyleBackColor = false;
            this.Распрелделить_пчёл.Click += new System.EventHandler(this.Распрелделить_пчёл_Click);
            // 
            // Смена_прошла
            // 
            this.Смена_прошла.BackColor = System.Drawing.Color.Chartreuse;
            this.Смена_прошла.Location = new System.Drawing.Point(407, 26);
            this.Смена_прошла.Name = "Смена_прошла";
            this.Смена_прошла.Size = new System.Drawing.Size(246, 174);
            this.Смена_прошла.TabIndex = 7;
            this.Смена_прошла.Text = "Работать ( Одна смена прошла)";
            this.Смена_прошла.UseVisualStyleBackColor = false;
            this.Смена_прошла.Click += new System.EventHandler(this.Смена_прошла_Click);
            // 
            // Отчёт_о_работающих
            // 
            this.Отчёт_о_работающих.Location = new System.Drawing.Point(18, 241);
            this.Отчёт_о_работающих.Multiline = true;
            this.Отчёт_о_работающих.Name = "Отчёт_о_работающих";
            this.Отчёт_о_работающих.Size = new System.Drawing.Size(322, 196);
            this.Отчёт_о_работающих.TabIndex = 8;
            this.Отчёт_о_работающих.TextChanged += new System.EventHandler(this.Отчёт_о_работающих_TextChanged);
            // 
            // Отчёт_о_свободных
            // 
            this.Отчёт_о_свободных.Location = new System.Drawing.Point(358, 241);
            this.Отчёт_о_свободных.Multiline = true;
            this.Отчёт_о_свободных.Name = "Отчёт_о_свободных";
            this.Отчёт_о_свободных.Size = new System.Drawing.Size(321, 196);
            this.Отчёт_о_свободных.TabIndex = 9;
            this.Отчёт_о_свободных.TextChanged += new System.EventHandler(this.Отчёт_о_свободных_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(111, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Отчёт о работающих";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(464, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Отчёт о свободных";
            // 
            // Кол_пчёл_на_работу
            // 
            this.Кол_пчёл_на_работу.Location = new System.Drawing.Point(208, 149);
            this.Кол_пчёл_на_работу.Maximum = new decimal(new int[] {
            -294967296,
            0,
            0,
            0});
            this.Кол_пчёл_на_работу.Name = "Кол_пчёл_на_работу";
            this.Кол_пчёл_на_работу.Size = new System.Drawing.Size(120, 20);
            this.Кол_пчёл_на_работу.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(209, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Сколько пчёл на эту работу";
            // 
            // Мёд_Расход
            // 
            this.Мёд_Расход.Location = new System.Drawing.Point(18, 461);
            this.Мёд_Расход.Multiline = true;
            this.Мёд_Расход.Name = "Мёд_Расход";
            this.Мёд_Расход.Size = new System.Drawing.Size(661, 62);
            this.Мёд_Расход.TabIndex = 14;
            this.Мёд_Расход.TextChanged += new System.EventHandler(this.Мёд_Расход_TextChanged);
            // 
            // Отмена_пчёл_работа
            // 
            this.Отмена_пчёл_работа.BackColor = System.Drawing.Color.Tomato;
            this.Отмена_пчёл_работа.Location = new System.Drawing.Point(18, 177);
            this.Отмена_пчёл_работа.Name = "Отмена_пчёл_работа";
            this.Отмена_пчёл_работа.Size = new System.Drawing.Size(184, 36);
            this.Отмена_пчёл_работа.TabIndex = 15;
            this.Отмена_пчёл_работа.Text = "Отменить данное задание";
            this.Отмена_пчёл_работа.UseVisualStyleBackColor = false;
            this.Отмена_пчёл_работа.Click += new System.EventHandler(this.Отмена_пчёл_работа_Click);
            // 
            // Улей
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 535);
            this.Controls.Add(this.Отмена_пчёл_работа);
            this.Controls.Add(this.Мёд_Расход);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Кол_пчёл_на_работу);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Отчёт_о_свободных);
            this.Controls.Add(this.Отчёт_о_работающих);
            this.Controls.Add(this.Смена_прошла);
            this.Controls.Add(this.Распрелделить_пчёл);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Кол_Смен);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Варианты_работы);
            this.Controls.Add(this.Количество_пчёл_в_улье);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Улей";
            this.Text = "Улей";
            ((System.ComponentModel.ISupportInitialize)(this.Количество_пчёл_в_улье)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Кол_Смен)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Кол_пчёл_на_работу)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Количество_пчёл_в_улье;
        private System.Windows.Forms.ComboBox Варианты_работы;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Кол_Смен;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Распрелделить_пчёл;
        private System.Windows.Forms.Button Смена_прошла;
        private System.Windows.Forms.TextBox Отчёт_о_работающих;
        private System.Windows.Forms.TextBox Отчёт_о_свободных;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Кол_пчёл_на_работу;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Мёд_Расход;
        private System.Windows.Forms.Button Отмена_пчёл_работа;
    }
}

