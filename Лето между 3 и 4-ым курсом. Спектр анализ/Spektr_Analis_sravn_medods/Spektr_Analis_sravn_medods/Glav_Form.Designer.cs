namespace Spektr_Analis_sravn_medods
{
    partial class Glav_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glav_Form));
            this.menu_Glav = new System.Windows.Forms.MenuStrip();
            this.Fail_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.SpectrAnalis_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.MadeSignal_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.kachestvoElEn_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.Spravke_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.WorkSignal_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Glav.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Glav
            // 
            this.menu_Glav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_Glav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Fail_TSM,
            this.SpectrAnalis_TSM,
            this.kachestvoElEn_TSM,
            this.Spravke_TSM});
            this.menu_Glav.Location = new System.Drawing.Point(0, 0);
            this.menu_Glav.Name = "menu_Glav";
            this.menu_Glav.Size = new System.Drawing.Size(1082, 28);
            this.menu_Glav.TabIndex = 0;
            this.menu_Glav.Text = "menuStrip1";
            // 
            // Fail_TSM
            // 
            this.Fail_TSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit_TSM});
            this.Fail_TSM.Name = "Fail_TSM";
            this.Fail_TSM.Size = new System.Drawing.Size(57, 24);
            this.Fail_TSM.Text = "Файл";
            // 
            // Exit_TSM
            // 
            this.Exit_TSM.Name = "Exit_TSM";
            this.Exit_TSM.Size = new System.Drawing.Size(141, 26);
            this.Exit_TSM.Text = "Закрыть";
            // 
            // SpectrAnalis_TSM
            // 
            this.SpectrAnalis_TSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MadeSignal_TSM,
            this.WorkSignal_TSM});
            this.SpectrAnalis_TSM.Name = "SpectrAnalis_TSM";
            this.SpectrAnalis_TSM.Size = new System.Drawing.Size(175, 24);
            this.SpectrAnalis_TSM.Text = "Спектральный анализ";
            // 
            // MadeSignal_TSM
            // 
            this.MadeSignal_TSM.Name = "MadeSignal_TSM";
            this.MadeSignal_TSM.Size = new System.Drawing.Size(214, 26);
            this.MadeSignal_TSM.Text = "Создание сигнала";
            this.MadeSignal_TSM.Click += new System.EventHandler(this.MadeSignal_TSM_Click);
            // 
            // kachestvoElEn_TSM
            // 
            this.kachestvoElEn_TSM.Name = "kachestvoElEn_TSM";
            this.kachestvoElEn_TSM.Size = new System.Drawing.Size(129, 24);
            this.kachestvoElEn_TSM.Text = "Качество эл. эн.";
            // 
            // Spravke_TSM
            // 
            this.Spravke_TSM.Name = "Spravke_TSM";
            this.Spravke_TSM.Size = new System.Drawing.Size(79, 24);
            this.Spravke_TSM.Text = "Справка";
            // 
            // WorkSignal_TSM
            // 
            this.WorkSignal_TSM.Name = "WorkSignal_TSM";
            this.WorkSignal_TSM.Size = new System.Drawing.Size(214, 26);
            this.WorkSignal_TSM.Text = "Работа с сигналом";
            this.WorkSignal_TSM.Click += new System.EventHandler(this.WorkSignal_TSM_Click);
            // 
            // Glav_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Spektr_Analis_sravn_medods.Properties.Resources.FON;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 833);
            this.Controls.Add(this.menu_Glav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_Glav;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 880);
            this.MinimumSize = new System.Drawing.Size(1100, 880);
            this.Name = "Glav_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Спектральный анализ и качество эл. эн.";
            this.menu_Glav.ResumeLayout(false);
            this.menu_Glav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_Glav;
        private System.Windows.Forms.ToolStripMenuItem Fail_TSM;
        private System.Windows.Forms.ToolStripMenuItem SpectrAnalis_TSM;
        private System.Windows.Forms.ToolStripMenuItem kachestvoElEn_TSM;
        private System.Windows.Forms.ToolStripMenuItem Spravke_TSM;
        private System.Windows.Forms.ToolStripMenuItem Exit_TSM;
        private System.Windows.Forms.ToolStripMenuItem MadeSignal_TSM;
        private System.Windows.Forms.ToolStripMenuItem WorkSignal_TSM;
    }
}

