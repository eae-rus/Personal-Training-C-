using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Вычмат_1
{
    public partial class nelen_sist : Form
    {
        public nelen_sist()
        {
            InitializeComponent();
            x0[0] = 0;
            x0[1] = 0;
            perechcet();
        }

        private double[] x0 = new double[2];

        private void X_Text_TextChanged(object sender, EventArgs e)
        {
            double a;
            bool z = double.TryParse(Y_Text.Text, out a);
            if (!z)
            {
                MessageBox.Show("ошибка ввода");
            }
            try
            {
                x0[0] = Convert.ToDouble(X_Text.Text);
                perechcet();
            }
            catch
            {

            }
        }

        private void Y_Text_TextChanged(object sender, EventArgs e)
        {
            double a;
            bool z =  double.TryParse(Y_Text.Text,out a);
            if (!z)
            {
                MessageBox.Show("ошибка ввода");
            }
            try
            {
                x0[1] = Convert.ToDouble(Y_Text.Text);
                perechcet();
            }
            catch
            {

            }
        }


        private void perechcet()
        {
            string s = "";
            metod_nelen_sist metod = new metod_nelen_sist();
            double[] x = metod.Nutona_Rafsona(x0);
            for (byte i = 0; i <= 1; i++)
            {
                s += x[i] + Environment.NewLine;
            }

            Otvet.Text = s;

        }

        private void Otvet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}