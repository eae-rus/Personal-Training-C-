namespace Vichmat
{
    partial class Forma_int
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_int));
            this.Vibor_metod_prymougol = new System.Windows.Forms.CheckBox();
            this.Текст1 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.NumericUpDown();
            this.b = new System.Windows.Forms.NumericUpDown();
            this.Текст2 = new System.Windows.Forms.Label();
            this.Текст3 = new System.Windows.Forms.Label();
            this.Текст4 = new System.Windows.Forms.Label();
            this.Выводимый_текст = new System.Windows.Forms.TextBox();
            this.Значение = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Погрешность = new System.Windows.Forms.TextBox();
            this.Погрешность_Л = new System.Windows.Forms.Label();
            this.Vibor_metod_trap = new System.Windows.Forms.CheckBox();
            this.Vibor_metod_Simpson = new System.Windows.Forms.CheckBox();
            this.Vibor_metod_simpsina3_8 = new System.Windows.Forms.CheckBox();
            this.Gausa_legandra_nagat = new System.Windows.Forms.CheckBox();
            this.P = new System.Windows.Forms.NumericUpDown();
            this.Текст_Р = new System.Windows.Forms.Label();
            this.Vibor_metod_Monte_Karlo = new System.Windows.Forms.CheckBox();
            this.Vernutsa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P)).BeginInit();
            this.SuspendLayout();
            // 
            // Vibor_metod_prymougol
            // 
            this.Vibor_metod_prymougol.AutoSize = true;
            this.Vibor_metod_prymougol.Location = new System.Drawing.Point(726, 174);
            this.Vibor_metod_prymougol.Name = "Vibor_metod_prymougol";
            this.Vibor_metod_prymougol.Size = new System.Drawing.Size(146, 21);
            this.Vibor_metod_prymougol.TabIndex = 0;
            this.Vibor_metod_prymougol.Text = "Прямоугольников";
            this.Vibor_metod_prymougol.UseVisualStyleBackColor = true;
            this.Vibor_metod_prymougol.CheckedChanged += new System.EventHandler(this.Vibor_Metoda_prymougol);
            // 
            // Текст1
            // 
            this.Текст1.AutoSize = true;
            this.Текст1.Location = new System.Drawing.Point(726, 138);
            this.Текст1.Name = "Текст1";
            this.Текст1.Size = new System.Drawing.Size(128, 17);
            this.Текст1.TabIndex = 1;
            this.Текст1.Text = "Выберите методы";
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(96, 175);
            this.N.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.N.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(120, 22);
            this.N.TabIndex = 2;
            this.N.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.N.ValueChanged += new System.EventHandler(this.KoL_rabienii);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество разбиений";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(434, 161);
            this.a.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(120, 22);
            this.a.TabIndex = 1;
            this.a.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.a.ValueChanged += new System.EventHandler(this.a_ValueChanged);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(434, 189);
            this.b.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(120, 22);
            this.b.TabIndex = 5;
            this.b.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.b.ValueChanged += new System.EventHandler(this.b_ValueChanged);
            // 
            // Текст2
            // 
            this.Текст2.AutoSize = true;
            this.Текст2.Location = new System.Drawing.Point(401, 138);
            this.Текст2.Name = "Текст2";
            this.Текст2.Size = new System.Drawing.Size(179, 17);
            this.Текст2.TabIndex = 6;
            this.Текст2.Text = "Пределы интегрирования";
            // 
            // Текст3
            // 
            this.Текст3.AutoSize = true;
            this.Текст3.Location = new System.Drawing.Point(390, 161);
            this.Текст3.Name = "Текст3";
            this.Текст3.Size = new System.Drawing.Size(16, 17);
            this.Текст3.TabIndex = 8;
            this.Текст3.Text = "а";
            // 
            // Текст4
            // 
            this.Текст4.AutoSize = true;
            this.Текст4.Location = new System.Drawing.Point(390, 194);
            this.Текст4.Name = "Текст4";
            this.Текст4.Size = new System.Drawing.Size(16, 17);
            this.Текст4.TabIndex = 9;
            this.Текст4.Text = "b";
            // 
            // Выводимый_текст
            // 
            this.Выводимый_текст.Location = new System.Drawing.Point(99, 311);
            this.Выводимый_текст.Multiline = true;
            this.Выводимый_текст.Name = "Выводимый_текст";
            this.Выводимый_текст.ReadOnly = true;
            this.Выводимый_текст.Size = new System.Drawing.Size(279, 265);
            this.Выводимый_текст.TabIndex = 10;
            this.Выводимый_текст.Text = "Здесь будет отображаться результат счёт";
            this.Выводимый_текст.TextChanged += new System.EventHandler(this.Text_okno);
            // 
            // Значение
            // 
            this.Значение.AutoSize = true;
            this.Значение.Location = new System.Drawing.Point(96, 282);
            this.Значение.Name = "Значение";
            this.Значение.Size = new System.Drawing.Size(73, 17);
            this.Значение.TabIndex = 12;
            this.Значение.Text = "Значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Реальное значение = 0.80845744785";
            // 
            // Погрешность
            // 
            this.Погрешность.Location = new System.Drawing.Point(411, 311);
            this.Погрешность.Multiline = true;
            this.Погрешность.Name = "Погрешность";
            this.Погрешность.ReadOnly = true;
            this.Погрешность.Size = new System.Drawing.Size(279, 265);
            this.Погрешность.TabIndex = 14;
            this.Погрешность.Text = "Здесь будет отображаться погрешность";
            this.Погрешность.TextChanged += new System.EventHandler(this.Text_pogresh_okno);
            // 
            // Погрешность_Л
            // 
            this.Погрешность_Л.AutoSize = true;
            this.Погрешность_Л.Location = new System.Drawing.Point(408, 282);
            this.Погрешность_Л.Name = "Погрешность_Л";
            this.Погрешность_Л.Size = new System.Drawing.Size(95, 17);
            this.Погрешность_Л.TabIndex = 15;
            this.Погрешность_Л.Text = "Погрешность";
            // 
            // Vibor_metod_trap
            // 
            this.Vibor_metod_trap.AutoSize = true;
            this.Vibor_metod_trap.Location = new System.Drawing.Point(726, 218);
            this.Vibor_metod_trap.Name = "Vibor_metod_trap";
            this.Vibor_metod_trap.Size = new System.Drawing.Size(95, 21);
            this.Vibor_metod_trap.TabIndex = 16;
            this.Vibor_metod_trap.Text = "Трапеций";
            this.Vibor_metod_trap.UseVisualStyleBackColor = true;
            this.Vibor_metod_trap.CheckedChanged += new System.EventHandler(this.Vibor_metoda_trapec);
            // 
            // Vibor_metod_Simpson
            // 
            this.Vibor_metod_Simpson.AutoSize = true;
            this.Vibor_metod_Simpson.Location = new System.Drawing.Point(726, 261);
            this.Vibor_metod_Simpson.Name = "Vibor_metod_Simpson";
            this.Vibor_metod_Simpson.Size = new System.Drawing.Size(95, 21);
            this.Vibor_metod_Simpson.TabIndex = 17;
            this.Vibor_metod_Simpson.Text = "Симпсона";
            this.Vibor_metod_Simpson.UseVisualStyleBackColor = true;
            this.Vibor_metod_Simpson.CheckedChanged += new System.EventHandler(this.Vibor_Metoda_Simpsona);
            // 
            // Vibor_metod_simpsina3_8
            // 
            this.Vibor_metod_simpsina3_8.AutoSize = true;
            this.Vibor_metod_simpsina3_8.Location = new System.Drawing.Point(726, 305);
            this.Vibor_metod_simpsina3_8.Name = "Vibor_metod_simpsina3_8";
            this.Vibor_metod_simpsina3_8.Size = new System.Drawing.Size(119, 21);
            this.Vibor_metod_simpsina3_8.TabIndex = 18;
            this.Vibor_metod_simpsina3_8.Text = "Симпсона 3/8";
            this.Vibor_metod_simpsina3_8.UseVisualStyleBackColor = true;
            this.Vibor_metod_simpsina3_8.CheckedChanged += new System.EventHandler(this.Vibor_Metoda_Simpsona3_8);
            // 
            // Gausa_legandra_nagat
            // 
            this.Gausa_legandra_nagat.AutoSize = true;
            this.Gausa_legandra_nagat.Location = new System.Drawing.Point(726, 350);
            this.Gausa_legandra_nagat.Name = "Gausa_legandra_nagat";
            this.Gausa_legandra_nagat.Size = new System.Drawing.Size(139, 21);
            this.Gausa_legandra_nagat.TabIndex = 19;
            this.Gausa_legandra_nagat.Text = "Гауса Лежандра";
            this.Gausa_legandra_nagat.UseVisualStyleBackColor = true;
            this.Gausa_legandra_nagat.CheckedChanged += new System.EventHandler(this.Vibor_Metoda_Gausa_Legandra);
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(927, 350);
            this.P.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.P.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(61, 22);
            this.P.TabIndex = 20;
            this.P.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.P.Visible = false;
            this.P.ValueChanged += new System.EventHandler(this.P_ValueChanged);
            // 
            // Текст_Р
            // 
            this.Текст_Р.AutoSize = true;
            this.Текст_Р.Location = new System.Drawing.Point(886, 352);
            this.Текст_Р.Name = "Текст_Р";
            this.Текст_Р.Size = new System.Drawing.Size(29, 17);
            this.Текст_Р.TabIndex = 21;
            this.Текст_Р.Text = "P =";
            this.Текст_Р.Visible = false;
            this.Текст_Р.Click += new System.EventHandler(this.Текст_Р_Click);
            // 
            // Vibor_metod_Monte_Karlo
            // 
            this.Vibor_metod_Monte_Karlo.AutoSize = true;
            this.Vibor_metod_Monte_Karlo.Location = new System.Drawing.Point(729, 394);
            this.Vibor_metod_Monte_Karlo.Name = "Vibor_metod_Monte_Karlo";
            this.Vibor_metod_Monte_Karlo.Size = new System.Drawing.Size(117, 21);
            this.Vibor_metod_Monte_Karlo.TabIndex = 22;
            this.Vibor_metod_Monte_Karlo.Text = "Монте Карло";
            this.Vibor_metod_Monte_Karlo.UseVisualStyleBackColor = true;
            this.Vibor_metod_Monte_Karlo.CheckedChanged += new System.EventHandler(this.Vibor_Metoda_Monte_Karlo);
            // 
            // Vernutsa
            // 
            this.Vernutsa.Location = new System.Drawing.Point(1, -1);
            this.Vernutsa.Name = "Vernutsa";
            this.Vernutsa.Size = new System.Drawing.Size(177, 40);
            this.Vernutsa.TabIndex = 23;
            this.Vernutsa.TabStop = false;
            this.Vernutsa.Text = "Назад";
            this.Vernutsa.UseVisualStyleBackColor = true;
            this.Vernutsa.Click += new System.EventHandler(this.Vernutsa_Click);
            // 
            // Forma_int
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1008, 594);
            this.Controls.Add(this.Vernutsa);
            this.Controls.Add(this.Vibor_metod_Monte_Karlo);
            this.Controls.Add(this.Текст_Р);
            this.Controls.Add(this.P);
            this.Controls.Add(this.Gausa_legandra_nagat);
            this.Controls.Add(this.Vibor_metod_simpsina3_8);
            this.Controls.Add(this.Vibor_metod_Simpson);
            this.Controls.Add(this.Vibor_metod_trap);
            this.Controls.Add(this.Погрешность_Л);
            this.Controls.Add(this.Погрешность);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Значение);
            this.Controls.Add(this.Выводимый_текст);
            this.Controls.Add(this.Текст4);
            this.Controls.Add(this.Текст3);
            this.Controls.Add(this.Текст2);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.N);
            this.Controls.Add(this.Текст1);
            this.Controls.Add(this.Vibor_metod_prymougol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Forma_int";
            this.Text = "Решение интегралов";
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Vibor_metod_prymougol;
        private System.Windows.Forms.Label Текст1;
        private System.Windows.Forms.NumericUpDown N;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown a;
        private System.Windows.Forms.NumericUpDown b;
        private System.Windows.Forms.Label Текст2;
        private System.Windows.Forms.Label Текст3;
        private System.Windows.Forms.Label Текст4;
        private System.Windows.Forms.TextBox Выводимый_текст;
        private System.Windows.Forms.Label Значение;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Погрешность;
        private System.Windows.Forms.Label Погрешность_Л;
        private System.Windows.Forms.CheckBox Vibor_metod_trap;
        private System.Windows.Forms.CheckBox Vibor_metod_Simpson;
        private System.Windows.Forms.CheckBox Vibor_metod_simpsina3_8;
        private System.Windows.Forms.CheckBox Gausa_legandra_nagat;
        private System.Windows.Forms.NumericUpDown P;
        private System.Windows.Forms.Label Текст_Р;
        private System.Windows.Forms.CheckBox Vibor_metod_Monte_Karlo;
        private System.Windows.Forms.Button Vernutsa;
    }
}

