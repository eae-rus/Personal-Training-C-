namespace Вычмат_1
{
    partial class nelen_sist
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
            this.Y_Label = new System.Windows.Forms.Label();
            this.Y_Text = new System.Windows.Forms.TextBox();
            this.X_Label = new System.Windows.Forms.Label();
            this.X_Text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Otvet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Y_Label
            // 
            this.Y_Label.AutoSize = true;
            this.Y_Label.Location = new System.Drawing.Point(272, 108);
            this.Y_Label.Name = "Y_Label";
            this.Y_Label.Size = new System.Drawing.Size(14, 13);
            this.Y_Label.TabIndex = 12;
            this.Y_Label.Text = "Y";
            // 
            // Y_Text
            // 
            this.Y_Text.Location = new System.Drawing.Point(306, 105);
            this.Y_Text.Name = "Y_Text";
            this.Y_Text.Size = new System.Drawing.Size(100, 20);
            this.Y_Text.TabIndex = 11;
            this.Y_Text.Text = "0";
            this.Y_Text.TextChanged += new System.EventHandler(this.Y_Text_TextChanged);
            // 
            // X_Label
            // 
            this.X_Label.AutoSize = true;
            this.X_Label.Location = new System.Drawing.Point(91, 108);
            this.X_Label.Name = "X_Label";
            this.X_Label.Size = new System.Drawing.Size(14, 13);
            this.X_Label.TabIndex = 10;
            this.X_Label.Text = "X";
            // 
            // X_Text
            // 
            this.X_Text.Location = new System.Drawing.Point(127, 105);
            this.X_Text.Name = "X_Text";
            this.X_Text.Size = new System.Drawing.Size(100, 20);
            this.X_Text.TabIndex = 9;
            this.X_Text.Text = "0";
            this.X_Text.TextChanged += new System.EventHandler(this.X_Text_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введите начальные приближения";
            // 
            // Otvet
            // 
            this.Otvet.Location = new System.Drawing.Point(152, 217);
            this.Otvet.Multiline = true;
            this.Otvet.Name = "Otvet";
            this.Otvet.Size = new System.Drawing.Size(234, 149);
            this.Otvet.TabIndex = 26;
            this.Otvet.TextChanged += new System.EventHandler(this.Otvet_TextChanged);
            // 
            // nelen_sist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 460);
            this.Controls.Add(this.Otvet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Y_Label);
            this.Controls.Add(this.Y_Text);
            this.Controls.Add(this.X_Label);
            this.Controls.Add(this.X_Text);
            this.Name = "nelen_sist";
            this.Text = "nelen_sist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Y_Label;
        private System.Windows.Forms.TextBox Y_Text;
        private System.Windows.Forms.Label X_Label;
        private System.Windows.Forms.TextBox X_Text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Otvet;
    }
}