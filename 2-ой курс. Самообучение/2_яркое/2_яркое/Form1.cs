using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2_яркое
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                for (byte c = 0; c < 254 & Visible; c++)
                    {
                        this.BackColor = Color.FromArgb(c, 255 - c, c);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(1);
                    }
                    for (byte c = 253 ; c > 0 & Visible; c--)
                    {
                        this.BackColor = Color.FromArgb(c, 255 - c, c);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(1);
                    }

            }
        }
    }
}
