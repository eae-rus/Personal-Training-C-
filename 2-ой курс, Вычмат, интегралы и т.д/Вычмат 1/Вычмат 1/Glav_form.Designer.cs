namespace Vicmat_G
{
    partial class Glav_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Glav_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMiVibor = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMineINT = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMineUrav = new System.Windows.Forms.ToolStripMenuItem();
            this.SLU_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.CHY_F = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ODU_TSMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.TSMiVibor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(723, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 24);
            this.toolStripMenuItem1.Text = "Файл";
            this.toolStripMenuItem1.ToolTipText = "Файл";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(128, 26);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // TSMiVibor
            // 
            this.TSMiVibor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMineINT,
            this.TSMineUrav,
            this.SLU_TSM,
            this.CHY_F,
            this.ODU_TSMenu});
            this.TSMiVibor.Name = "TSMiVibor";
            this.TSMiVibor.Size = new System.Drawing.Size(108, 24);
            this.TSMiVibor.Text = "Выбор темы";
            // 
            // TSMineINT
            // 
            this.TSMineINT.Name = "TSMineINT";
            this.TSMineINT.Size = new System.Drawing.Size(193, 26);
            this.TSMineINT.Text = "Интегралы...";
            this.TSMineINT.Click += new System.EventHandler(this.TSMineINT_Click);
            // 
            // TSMineUrav
            // 
            this.TSMineUrav.Name = "TSMineUrav";
            this.TSMineUrav.Size = new System.Drawing.Size(193, 26);
            this.TSMineUrav.Text = "Уравнения...";
            this.TSMineUrav.Click += new System.EventHandler(this.TSMineUrav_Click);
            // 
            // SLU_TSM
            // 
            this.SLU_TSM.Name = "SLU_TSM";
            this.SLU_TSM.Size = new System.Drawing.Size(193, 26);
            this.SLU_TSM.Text = "СЛУ...";
            this.SLU_TSM.Click += new System.EventHandler(this.SLU_TSM_Click);
            // 
            // CHY_F
            // 
            this.CHY_F.Name = "CHY_F";
            this.CHY_F.Size = new System.Drawing.Size(193, 26);
            this.CHY_F.Text = "СНУ";
            this.CHY_F.Click += new System.EventHandler(this.CHY_F_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // ODU_TSMenu
            // 
            this.ODU_TSMenu.Name = "ODU_TSMenu";
            this.ODU_TSMenu.Size = new System.Drawing.Size(193, 26);
            this.ODU_TSMenu.Text = "ОДУ (система)...";
            this.ODU_TSMenu.Click += new System.EventHandler(this.ODU_TSMenu_Click);
            // 
            // Glav_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 482);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Glav_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Вычмат";
            this.Load += new System.EventHandler(this.Glav_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem TSMiVibor;
        private System.Windows.Forms.ToolStripMenuItem TSMineINT;
        private System.Windows.Forms.ToolStripMenuItem TSMineUrav;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SLU_TSM;
        private System.Windows.Forms.ToolStripMenuItem CHY_F;
        private System.Windows.Forms.ToolStripMenuItem ODU_TSMenu;
    }
}