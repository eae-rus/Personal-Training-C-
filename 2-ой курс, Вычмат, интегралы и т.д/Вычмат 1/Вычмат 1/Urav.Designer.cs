namespace Vichmat_Prokt
{
    partial class Urav
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urav));
            this.Bisec_Checet = new System.Windows.Forms.CheckBox();
            this.A_text = new System.Windows.Forms.Label();
            this.b_text = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.NumericUpDown();
            this.b = new System.Windows.Forms.NumericUpDown();
            this.text_okno = new System.Windows.Forms.TextBox();
            this.Log = new System.Windows.Forms.CheckBox();
            this.Kasat_Chekt = new System.Windows.Forms.CheckBox();
            this.W_ND = new System.Windows.Forms.NumericUpDown();
            this.w_text = new System.Windows.Forms.Label();
            this.Metod_Rid_Chect = new System.Windows.Forms.CheckBox();
            this.fraz = new System.Windows.Forms.Label();
            this.zapisat = new System.Windows.Forms.Button();
            this.Bisec_RB = new System.Windows.Forms.RadioButton();
            this.Log_RB = new System.Windows.Forms.RadioButton();
            this.Metod_Rid_RB = new System.Windows.Forms.RadioButton();
            this.Kasat_RB = new System.Windows.Forms.RadioButton();
            this.Iskl_GB = new System.Windows.Forms.GroupBox();
            this.dop_GB = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Bibor_Sposoba_TSMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Iskl_TS_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Dop_TS_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.дополнительноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RITM = new System.Windows.Forms.ToolStripMenuItem();
            this.zagruzka = new System.Windows.Forms.Button();
            this.Vernet_UravTM = new System.Windows.Forms.ToolStripMenuItem();
            this.RnovText = new System.Windows.Forms.Label();
            this.Rnov = new System.Windows.Forms.NumericUpDown();
            this.m_NU = new System.Windows.Forms.NumericUpDown();
            this.MLabel = new System.Windows.Forms.Label();
            this.S_NU = new System.Windows.Forms.NumericUpDown();
            this.SLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_ND)).BeginInit();
            this.Iskl_GB.SuspendLayout();
            this.dop_GB.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rnov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_NU)).BeginInit();
            this.SuspendLayout();
            // 
            // Bisec_Checet
            // 
            this.Bisec_Checet.AutoSize = true;
            this.Bisec_Checet.Location = new System.Drawing.Point(5, 22);
            this.Bisec_Checet.Margin = new System.Windows.Forms.Padding(2);
            this.Bisec_Checet.Name = "Bisec_Checet";
            this.Bisec_Checet.Size = new System.Drawing.Size(110, 17);
            this.Bisec_Checet.TabIndex = 1;
            this.Bisec_Checet.Text = "Метод Бисекции";
            this.Bisec_Checet.UseVisualStyleBackColor = true;
            this.Bisec_Checet.CheckedChanged += new System.EventHandler(this.Bisec_Checet_CheckedChanged);
            // 
            // A_text
            // 
            this.A_text.AutoSize = true;
            this.A_text.Location = new System.Drawing.Point(21, 107);
            this.A_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.A_text.Name = "A_text";
            this.A_text.Size = new System.Drawing.Size(13, 13);
            this.A_text.TabIndex = 5;
            this.A_text.Text = "a";
            this.A_text.Visible = false;
            // 
            // b_text
            // 
            this.b_text.AutoSize = true;
            this.b_text.Location = new System.Drawing.Point(21, 150);
            this.b_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.b_text.Name = "b_text";
            this.b_text.Size = new System.Drawing.Size(13, 13);
            this.b_text.TabIndex = 6;
            this.b_text.Text = "b";
            this.b_text.Visible = false;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(38, 105);
            this.a.Margin = new System.Windows.Forms.Padding(2);
            this.a.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.a.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(90, 20);
            this.a.TabIndex = 7;
            this.a.Value = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.a.Visible = false;
            this.a.ValueChanged += new System.EventHandler(this.a_ValueChanged);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(38, 149);
            this.b.Margin = new System.Windows.Forms.Padding(2);
            this.b.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.b.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(90, 20);
            this.b.TabIndex = 8;
            this.b.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.b.Visible = false;
            this.b.ValueChanged += new System.EventHandler(this.b_ValueChanged);
            // 
            // text_okno
            // 
            this.text_okno.Location = new System.Drawing.Point(164, 52);
            this.text_okno.Margin = new System.Windows.Forms.Padding(2);
            this.text_okno.Multiline = true;
            this.text_okno.Name = "text_okno";
            this.text_okno.ReadOnly = true;
            this.text_okno.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_okno.Size = new System.Drawing.Size(413, 216);
            this.text_okno.TabIndex = 15;
            this.text_okno.Text = "Здесь будет отображаться корень и число шагов";
            this.text_okno.TextChanged += new System.EventHandler(this.text_okno_TextChanged);
            // 
            // Log
            // 
            this.Log.AutoSize = true;
            this.Log.Location = new System.Drawing.Point(5, 47);
            this.Log.Margin = new System.Windows.Forms.Padding(2);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(165, 17);
            this.Log.TabIndex = 16;
            this.Log.Text = "Метод Ложного положения";
            this.Log.UseVisualStyleBackColor = true;
            this.Log.CheckedChanged += new System.EventHandler(this.Log_CheckedChanged);
            // 
            // Kasat_Chekt
            // 
            this.Kasat_Chekt.AutoSize = true;
            this.Kasat_Chekt.Location = new System.Drawing.Point(5, 70);
            this.Kasat_Chekt.Margin = new System.Windows.Forms.Padding(2);
            this.Kasat_Chekt.Name = "Kasat_Chekt";
            this.Kasat_Chekt.Size = new System.Drawing.Size(127, 17);
            this.Kasat_Chekt.TabIndex = 17;
            this.Kasat_Chekt.Text = "Метод касательных";
            this.Kasat_Chekt.UseVisualStyleBackColor = true;
            this.Kasat_Chekt.CheckedChanged += new System.EventHandler(this.Kasat_Chekt_CheckedChanged);
            // 
            // W_ND
            // 
            this.W_ND.Location = new System.Drawing.Point(70, 184);
            this.W_ND.Margin = new System.Windows.Forms.Padding(2);
            this.W_ND.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.W_ND.Name = "W_ND";
            this.W_ND.Size = new System.Drawing.Size(90, 20);
            this.W_ND.TabIndex = 18;
            this.W_ND.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.W_ND.Value = new decimal(new int[] {
            375,
            0,
            0,
            0});
            this.W_ND.Visible = false;
            this.W_ND.ValueChanged += new System.EventHandler(this.W_ND_ValueChanged);
            // 
            // w_text
            // 
            this.w_text.AutoSize = true;
            this.w_text.Location = new System.Drawing.Point(3, 189);
            this.w_text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.w_text.Name = "w_text";
            this.w_text.Size = new System.Drawing.Size(55, 13);
            this.w_text.TabIndex = 19;
            this.w_text.Text = "W*1000 =";
            this.w_text.Visible = false;
            // 
            // Metod_Rid_Chect
            // 
            this.Metod_Rid_Chect.AutoSize = true;
            this.Metod_Rid_Chect.Location = new System.Drawing.Point(5, 94);
            this.Metod_Rid_Chect.Margin = new System.Windows.Forms.Padding(2);
            this.Metod_Rid_Chect.Name = "Metod_Rid_Chect";
            this.Metod_Rid_Chect.Size = new System.Drawing.Size(104, 17);
            this.Metod_Rid_Chect.TabIndex = 20;
            this.Metod_Rid_Chect.Text = "Метод Ридерса";
            this.Metod_Rid_Chect.UseVisualStyleBackColor = true;
            this.Metod_Rid_Chect.CheckedChanged += new System.EventHandler(this.Metod_Rid_Chect_CheckedChanged);
            // 
            // fraz
            // 
            this.fraz.AutoSize = true;
            this.fraz.Location = new System.Drawing.Point(21, 59);
            this.fraz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fraz.MaximumSize = new System.Drawing.Size(150, 0);
            this.fraz.Name = "fraz";
            this.fraz.Size = new System.Drawing.Size(131, 26);
            this.fraz.TabIndex = 21;
            this.fraz.Text = "Укажите интервал на котором имеются корни";
            this.fraz.Visible = false;
            // 
            // zapisat
            // 
            this.zapisat.Location = new System.Drawing.Point(164, 289);
            this.zapisat.Margin = new System.Windows.Forms.Padding(2);
            this.zapisat.Name = "zapisat";
            this.zapisat.Size = new System.Drawing.Size(210, 51);
            this.zapisat.TabIndex = 22;
            this.zapisat.Text = "Записать в файл";
            this.zapisat.UseVisualStyleBackColor = true;
            this.zapisat.Click += new System.EventHandler(this.zapisat_Click);
            // 
            // Bisec_RB
            // 
            this.Bisec_RB.AutoSize = true;
            this.Bisec_RB.Location = new System.Drawing.Point(6, 19);
            this.Bisec_RB.Name = "Bisec_RB";
            this.Bisec_RB.Size = new System.Drawing.Size(109, 17);
            this.Bisec_RB.TabIndex = 23;
            this.Bisec_RB.TabStop = true;
            this.Bisec_RB.Text = "Метод Бисекции";
            this.Bisec_RB.UseVisualStyleBackColor = true;
            this.Bisec_RB.CheckedChanged += new System.EventHandler(this.Bisec_RB_CheckedChanged);
            // 
            // Log_RB
            // 
            this.Log_RB.AutoSize = true;
            this.Log_RB.Location = new System.Drawing.Point(6, 45);
            this.Log_RB.Name = "Log_RB";
            this.Log_RB.Size = new System.Drawing.Size(164, 17);
            this.Log_RB.TabIndex = 24;
            this.Log_RB.TabStop = true;
            this.Log_RB.Text = "Метод Ложного положения";
            this.Log_RB.UseVisualStyleBackColor = true;
            this.Log_RB.CheckedChanged += new System.EventHandler(this.Log_RB_CheckedChanged);
            // 
            // Metod_Rid_RB
            // 
            this.Metod_Rid_RB.AutoSize = true;
            this.Metod_Rid_RB.Location = new System.Drawing.Point(6, 91);
            this.Metod_Rid_RB.Name = "Metod_Rid_RB";
            this.Metod_Rid_RB.Size = new System.Drawing.Size(103, 17);
            this.Metod_Rid_RB.TabIndex = 25;
            this.Metod_Rid_RB.TabStop = true;
            this.Metod_Rid_RB.Text = "Метод Ридерса";
            this.Metod_Rid_RB.UseVisualStyleBackColor = true;
            this.Metod_Rid_RB.CheckedChanged += new System.EventHandler(this.Metod_Rid_RB_CheckedChanged);
            // 
            // Kasat_RB
            // 
            this.Kasat_RB.AutoSize = true;
            this.Kasat_RB.Location = new System.Drawing.Point(6, 68);
            this.Kasat_RB.Name = "Kasat_RB";
            this.Kasat_RB.Size = new System.Drawing.Size(126, 17);
            this.Kasat_RB.TabIndex = 26;
            this.Kasat_RB.TabStop = true;
            this.Kasat_RB.Text = "Метод касательных";
            this.Kasat_RB.UseVisualStyleBackColor = true;
            this.Kasat_RB.CheckedChanged += new System.EventHandler(this.Kasat_RB_CheckedChanged);
            // 
            // Iskl_GB
            // 
            this.Iskl_GB.Controls.Add(this.Bisec_RB);
            this.Iskl_GB.Controls.Add(this.Kasat_RB);
            this.Iskl_GB.Controls.Add(this.Log_RB);
            this.Iskl_GB.Controls.Add(this.Metod_Rid_RB);
            this.Iskl_GB.Location = new System.Drawing.Point(587, 68);
            this.Iskl_GB.Name = "Iskl_GB";
            this.Iskl_GB.Size = new System.Drawing.Size(200, 125);
            this.Iskl_GB.TabIndex = 27;
            this.Iskl_GB.TabStop = false;
            this.Iskl_GB.Text = "Взаимоискючающие";
            this.Iskl_GB.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dop_GB
            // 
            this.dop_GB.Controls.Add(this.Bisec_Checet);
            this.dop_GB.Controls.Add(this.Log);
            this.dop_GB.Controls.Add(this.Kasat_Chekt);
            this.dop_GB.Controls.Add(this.Metod_Rid_Chect);
            this.dop_GB.Location = new System.Drawing.Point(587, 72);
            this.dop_GB.Name = "dop_GB";
            this.dop_GB.Size = new System.Drawing.Size(200, 121);
            this.dop_GB.TabIndex = 28;
            this.dop_GB.TabStop = false;
            this.dop_GB.Text = "Взаимдополняющие";
            this.dop_GB.Visible = false;
            this.dop_GB.Enter += new System.EventHandler(this.dop_GB_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bibor_Sposoba_TSMenu,
            this.дополнительноеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Bibor_Sposoba_TSMenu
            // 
            this.Bibor_Sposoba_TSMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Iskl_TS_Menu,
            this.Dop_TS_Menu});
            this.Bibor_Sposoba_TSMenu.Name = "Bibor_Sposoba_TSMenu";
            this.Bibor_Sposoba_TSMenu.Size = new System.Drawing.Size(182, 20);
            this.Bibor_Sposoba_TSMenu.Text = "Выбор способа отображения";
            // 
            // Iskl_TS_Menu
            // 
            this.Iskl_TS_Menu.Name = "Iskl_TS_Menu";
            this.Iskl_TS_Menu.Size = new System.Drawing.Size(199, 22);
            this.Iskl_TS_Menu.Text = "Взаимоисключающий";
            this.Iskl_TS_Menu.Click += new System.EventHandler(this.Iskl_TS_Menu_Click);
            // 
            // Dop_TS_Menu
            // 
            this.Dop_TS_Menu.Name = "Dop_TS_Menu";
            this.Dop_TS_Menu.Size = new System.Drawing.Size(199, 22);
            this.Dop_TS_Menu.Text = "Взаимодополняющий";
            this.Dop_TS_Menu.Click += new System.EventHandler(this.Dop_TS_Menu_Click);
            // 
            // дополнительноеToolStripMenuItem
            // 
            this.дополнительноеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RITM,
            this.Vernet_UravTM});
            this.дополнительноеToolStripMenuItem.Name = "дополнительноеToolStripMenuItem";
            this.дополнительноеToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.дополнительноеToolStripMenuItem.Text = "Дополнительное";
            // 
            // RITM
            // 
            this.RITM.Name = "RITM";
            this.RITM.Size = new System.Drawing.Size(204, 22);
            this.RITM.Text = "Задача \"РИТМ\"";
            this.RITM.Click += new System.EventHandler(this.RITM_Click);
            // 
            // zagruzka
            // 
            this.zagruzka.Location = new System.Drawing.Point(393, 289);
            this.zagruzka.Margin = new System.Windows.Forms.Padding(2);
            this.zagruzka.Name = "zagruzka";
            this.zagruzka.Size = new System.Drawing.Size(210, 51);
            this.zagruzka.TabIndex = 30;
            this.zagruzka.Text = "Загрузить из файл";
            this.zagruzka.UseVisualStyleBackColor = true;
            this.zagruzka.Click += new System.EventHandler(this.zagruzka_Click);
            // 
            // Vernet_UravTM
            // 
            this.Vernet_UravTM.Name = "Vernet_UravTM";
            this.Vernet_UravTM.Size = new System.Drawing.Size(204, 22);
            this.Vernet_UravTM.Text = "Вернуться к уравнению";
            this.Vernet_UravTM.Click += new System.EventHandler(this.Vernet_UravTM_Click);
            // 
            // RnovText
            // 
            this.RnovText.AutoSize = true;
            this.RnovText.Location = new System.Drawing.Point(11, 241);
            this.RnovText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RnovText.Name = "RnovText";
            this.RnovText.Size = new System.Drawing.Size(33, 13);
            this.RnovText.TabIndex = 31;
            this.RnovText.Text = "Rnov";
            this.RnovText.Visible = false;
            // 
            // Rnov
            // 
            this.Rnov.Location = new System.Drawing.Point(50, 239);
            this.Rnov.Margin = new System.Windows.Forms.Padding(2);
            this.Rnov.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Rnov.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Rnov.Name = "Rnov";
            this.Rnov.Size = new System.Drawing.Size(90, 20);
            this.Rnov.TabIndex = 32;
            this.Rnov.Value = new decimal(new int[] {
            412,
            0,
            0,
            0});
            this.Rnov.Visible = false;
            this.Rnov.ValueChanged += new System.EventHandler(this.Rnov_ValueChanged);
            // 
            // m_NU
            // 
            this.m_NU.Location = new System.Drawing.Point(50, 275);
            this.m_NU.Margin = new System.Windows.Forms.Padding(2);
            this.m_NU.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.m_NU.Name = "m_NU";
            this.m_NU.Size = new System.Drawing.Size(90, 20);
            this.m_NU.TabIndex = 34;
            this.m_NU.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.m_NU.Visible = false;
            this.m_NU.ValueChanged += new System.EventHandler(this.m_NU_ValueChanged);
            // 
            // MLabel
            // 
            this.MLabel.AutoSize = true;
            this.MLabel.Location = new System.Drawing.Point(11, 277);
            this.MLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MLabel.Name = "MLabel";
            this.MLabel.Size = new System.Drawing.Size(15, 13);
            this.MLabel.TabIndex = 33;
            this.MLabel.Text = "m";
            this.MLabel.Visible = false;
            // 
            // S_NU
            // 
            this.S_NU.Location = new System.Drawing.Point(50, 306);
            this.S_NU.Margin = new System.Windows.Forms.Padding(2);
            this.S_NU.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.S_NU.Name = "S_NU";
            this.S_NU.Size = new System.Drawing.Size(90, 20);
            this.S_NU.TabIndex = 36;
            this.S_NU.Value = new decimal(new int[] {
            450,
            0,
            0,
            0});
            this.S_NU.Visible = false;
            this.S_NU.ValueChanged += new System.EventHandler(this.S_NU_ValueChanged);
            // 
            // SLabel
            // 
            this.SLabel.AutoSize = true;
            this.SLabel.Location = new System.Drawing.Point(11, 308);
            this.SLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SLabel.Name = "SLabel";
            this.SLabel.Size = new System.Drawing.Size(36, 13);
            this.SLabel.TabIndex = 35;
            this.SLabel.Text = "S*100";
            this.SLabel.Visible = false;
            // 
            // Urav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 412);
            this.Controls.Add(this.S_NU);
            this.Controls.Add(this.SLabel);
            this.Controls.Add(this.m_NU);
            this.Controls.Add(this.MLabel);
            this.Controls.Add(this.Rnov);
            this.Controls.Add(this.RnovText);
            this.Controls.Add(this.zagruzka);
            this.Controls.Add(this.dop_GB);
            this.Controls.Add(this.Iskl_GB);
            this.Controls.Add(this.zapisat);
            this.Controls.Add(this.fraz);
            this.Controls.Add(this.w_text);
            this.Controls.Add(this.W_ND);
            this.Controls.Add(this.text_okno);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.b_text);
            this.Controls.Add(this.A_text);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Urav";
            this.Text = "Уравнения";
            this.Load += new System.EventHandler(this.Urav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.W_ND)).EndInit();
            this.Iskl_GB.ResumeLayout(false);
            this.Iskl_GB.PerformLayout();
            this.dop_GB.ResumeLayout(false);
            this.dop_GB.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rnov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_NU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_NU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox Bisec_Checet;
        private System.Windows.Forms.Label A_text;
        private System.Windows.Forms.Label b_text;
        private System.Windows.Forms.NumericUpDown a;
        private System.Windows.Forms.NumericUpDown b;
        private System.Windows.Forms.TextBox text_okno;
        private System.Windows.Forms.CheckBox Log;
        private System.Windows.Forms.CheckBox Kasat_Chekt;
        private System.Windows.Forms.NumericUpDown W_ND;
        private System.Windows.Forms.Label w_text;
        private System.Windows.Forms.CheckBox Metod_Rid_Chect;
        private System.Windows.Forms.Label fraz;
        private System.Windows.Forms.Button zapisat;
        private System.Windows.Forms.RadioButton Bisec_RB;
        private System.Windows.Forms.RadioButton Log_RB;
        private System.Windows.Forms.RadioButton Metod_Rid_RB;
        private System.Windows.Forms.RadioButton Kasat_RB;
        private System.Windows.Forms.GroupBox Iskl_GB;
        private System.Windows.Forms.GroupBox dop_GB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Bibor_Sposoba_TSMenu;
        private System.Windows.Forms.ToolStripMenuItem Iskl_TS_Menu;
        private System.Windows.Forms.ToolStripMenuItem Dop_TS_Menu;
        private System.Windows.Forms.Button zagruzka;
        private System.Windows.Forms.ToolStripMenuItem дополнительноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RITM;
        private System.Windows.Forms.ToolStripMenuItem Vernet_UravTM;
        private System.Windows.Forms.Label RnovText;
        private System.Windows.Forms.NumericUpDown Rnov;
        private System.Windows.Forms.NumericUpDown m_NU;
        private System.Windows.Forms.Label MLabel;
        private System.Windows.Forms.NumericUpDown S_NU;
        private System.Windows.Forms.Label SLabel;
    }
}