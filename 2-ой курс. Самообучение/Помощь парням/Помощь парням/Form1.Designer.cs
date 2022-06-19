namespace Помощь_парням
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joescashlabel = new System.Windows.Forms.Label();
            this.bobscashlabel = new System.Windows.Forms.Label();
            this.bankcashlabel = new System.Windows.Forms.Label();
            this.joegivestobob = new System.Windows.Forms.Button();
            this.bobgivetojoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "Give $10 to Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(375, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 67);
            this.button2.TabIndex = 1;
            this.button2.Text = "receive $5 from Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joescashlabel
            // 
            this.joescashlabel.AutoSize = true;
            this.joescashlabel.Location = new System.Drawing.Point(86, 53);
            this.joescashlabel.Name = "joescashlabel";
            this.joescashlabel.Size = new System.Drawing.Size(35, 13);
            this.joescashlabel.TabIndex = 2;
            this.joescashlabel.Text = "label1";
            // 
            // bobscashlabel
            // 
            this.bobscashlabel.AutoSize = true;
            this.bobscashlabel.Location = new System.Drawing.Point(86, 112);
            this.bobscashlabel.Name = "bobscashlabel";
            this.bobscashlabel.Size = new System.Drawing.Size(35, 13);
            this.bobscashlabel.TabIndex = 3;
            this.bobscashlabel.Text = "label2";
            // 
            // bankcashlabel
            // 
            this.bankcashlabel.AutoSize = true;
            this.bankcashlabel.Location = new System.Drawing.Point(89, 164);
            this.bankcashlabel.Name = "bankcashlabel";
            this.bankcashlabel.Size = new System.Drawing.Size(35, 13);
            this.bankcashlabel.TabIndex = 4;
            this.bankcashlabel.Text = "label1";
            // 
            // joegivestobob
            // 
            this.joegivestobob.Location = new System.Drawing.Point(86, 382);
            this.joegivestobob.Name = "joegivestobob";
            this.joegivestobob.Size = new System.Drawing.Size(143, 64);
            this.joegivestobob.TabIndex = 5;
            this.joegivestobob.Text = "Joy gives $10 to Bob";
            this.joegivestobob.UseVisualStyleBackColor = true;
            this.joegivestobob.Click += new System.EventHandler(this.joegivestobob_Click);
            // 
            // bobgivetojoe
            // 
            this.bobgivetojoe.Location = new System.Drawing.Point(375, 382);
            this.bobgivetojoe.Name = "bobgivetojoe";
            this.bobgivetojoe.Size = new System.Drawing.Size(154, 64);
            this.bobgivetojoe.TabIndex = 6;
            this.bobgivetojoe.Text = "Bob gives $5 to Joe";
            this.bobgivetojoe.UseVisualStyleBackColor = true;
            this.bobgivetojoe.Click += new System.EventHandler(this.bobgivetojoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 472);
            this.Controls.Add(this.bobgivetojoe);
            this.Controls.Add(this.joegivestobob);
            this.Controls.Add(this.bankcashlabel);
            this.Controls.Add(this.bobscashlabel);
            this.Controls.Add(this.joescashlabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label joescashlabel;
        private System.Windows.Forms.Label bobscashlabel;
        private System.Windows.Forms.Label bankcashlabel;
        private System.Windows.Forms.Button joegivestobob;
        private System.Windows.Forms.Button bobgivetojoe;
    }
}

