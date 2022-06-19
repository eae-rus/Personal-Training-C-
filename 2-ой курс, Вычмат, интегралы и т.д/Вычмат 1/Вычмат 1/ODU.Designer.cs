namespace Вычмат_1
{
    partial class ODU
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
            this.X_Label = new System.Windows.Forms.Label();
            this.Y1_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Y2_Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Y3_Text = new System.Windows.Forms.TextBox();
            this.Otvet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Xk_Text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Shag_Text = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // X_Label
            // 
            this.X_Label.AutoSize = true;
            this.X_Label.Location = new System.Drawing.Point(62, 71);
            this.X_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.X_Label.Name = "X_Label";
            this.X_Label.Size = new System.Drawing.Size(43, 17);
            this.X_Label.TabIndex = 12;
            this.X_Label.Text = "Y1(0)";
            // 
            // Y1_Text
            // 
            this.Y1_Text.Location = new System.Drawing.Point(160, 71);
            this.Y1_Text.Margin = new System.Windows.Forms.Padding(4);
            this.Y1_Text.Name = "Y1_Text";
            this.Y1_Text.Size = new System.Drawing.Size(132, 22);
            this.Y1_Text.TabIndex = 11;
            this.Y1_Text.Text = "0";
            this.Y1_Text.TextChanged += new System.EventHandler(this.Y1_Text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Y2(0)";
            // 
            // Y2_Text
            // 
            this.Y2_Text.Location = new System.Drawing.Point(160, 115);
            this.Y2_Text.Margin = new System.Windows.Forms.Padding(4);
            this.Y2_Text.Name = "Y2_Text";
            this.Y2_Text.Size = new System.Drawing.Size(132, 22);
            this.Y2_Text.TabIndex = 13;
            this.Y2_Text.Text = "1";
            this.Y2_Text.TextChanged += new System.EventHandler(this.Y2_Text_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Y3(0)";
            // 
            // Y3_Text
            // 
            this.Y3_Text.Location = new System.Drawing.Point(160, 168);
            this.Y3_Text.Margin = new System.Windows.Forms.Padding(4);
            this.Y3_Text.Name = "Y3_Text";
            this.Y3_Text.Size = new System.Drawing.Size(132, 22);
            this.Y3_Text.TabIndex = 15;
            this.Y3_Text.Text = "1";
            this.Y3_Text.TextChanged += new System.EventHandler(this.Y3_Text_TextChanged);
            // 
            // Otvet
            // 
            this.Otvet.Location = new System.Drawing.Point(13, 222);
            this.Otvet.Margin = new System.Windows.Forms.Padding(4);
            this.Otvet.Multiline = true;
            this.Otvet.Name = "Otvet";
            this.Otvet.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Otvet.Size = new System.Drawing.Size(548, 182);
            this.Otvet.TabIndex = 27;
            this.Otvet.UseWaitCursor = true;
            this.Otvet.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "X конечное";
            // 
            // Xk_Text
            // 
            this.Xk_Text.Location = new System.Drawing.Point(367, 101);
            this.Xk_Text.Margin = new System.Windows.Forms.Padding(4);
            this.Xk_Text.Name = "Xk_Text";
            this.Xk_Text.Size = new System.Drawing.Size(132, 22);
            this.Xk_Text.TabIndex = 28;
            this.Xk_Text.Text = "10";
            this.Xk_Text.TextChanged += new System.EventHandler(this.Xk_Text_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "шаг";
            // 
            // Shag_Text
            // 
            this.Shag_Text.Location = new System.Drawing.Point(367, 173);
            this.Shag_Text.Margin = new System.Windows.Forms.Padding(4);
            this.Shag_Text.Name = "Shag_Text";
            this.Shag_Text.Size = new System.Drawing.Size(132, 22);
            this.Shag_Text.TabIndex = 30;
            this.Shag_Text.Text = "0,01";
            this.Shag_Text.TextChanged += new System.EventHandler(this.Shag_Text_TextChanged);
            // 
            // ODU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 440);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Shag_Text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Xk_Text);
            this.Controls.Add(this.Otvet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Y3_Text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Y2_Text);
            this.Controls.Add(this.X_Label);
            this.Controls.Add(this.Y1_Text);
            this.Name = "ODU";
            this.Text = "x";
            this.Load += new System.EventHandler(this.ODU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label X_Label;
        private System.Windows.Forms.TextBox Y1_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Y2_Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Y3_Text;
        private System.Windows.Forms.TextBox Otvet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Xk_Text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Shag_Text;
    }
}