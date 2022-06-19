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
    public partial class Form_CLU : Form
    {
        public Form_CLU()
        {
            InitializeComponent();
            metod.A[0, 0] = -2; metod.A[0, 1] = 2; metod.A[0, 2] = -2; metod.B[0] = 10;
            metod.A[1, 0] = 1; metod.A[1, 1] = 1; metod.A[1, 2] = 2; metod.B[1] = -10;
            metod.A[2, 0] = 1; metod.A[2, 1] = 4; metod.A[2, 2] = 2; metod.B[2] = -1;
            m = met_chect.Kramer_cht;
            perechcet();
        }
        metod_SLU metod = new metod_SLU();

        private enum met_chect
        {
            Gaus_cht=1, Kramer_cht=2, Gaus_Zeydel_cht = 3
        }
        met_chect m;

        private void Form_CLU_Load(object sender, EventArgs e)
        {
           
        }

        private void A11_NU_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void perechcet()
        {
            if (m == met_chect.Kramer_cht)
            {
                double[] x = metod.Kramer(3);
                string s = "";
                for (byte i = 0; i <= 2; i++)
                {
                    s = s + "X" + (i + 1) + "= " + x[i] + Environment.NewLine;
                }

                s+= "проверка" + Environment.NewLine;

                for (byte i = 0; i <= 2; i++)
                {
                    double sum = 0;
                    for (byte j = 0; j <= 2; j++)
                    {
                        sum += x[j] * metod.A[i, j];
                    }
                    s += sum + "=" + metod.B[i] + Environment.NewLine;
                }
                Otvet.Text = s;
            }
            if (m == met_chect.Gaus_cht)
            {
                double[] x = metod.Gausa(3);
                string s = "";
                for (byte i = 0; i <= 2; i++)
                {
                    s = s + "X" + (i + 1) + "= " + x[i] + Environment.NewLine;
                }

                s += "проверка" + Environment.NewLine;

                for (byte i = 0; i <= 2; i++)
                {
                    double sum = 0;
                    for (byte j = 0; j <= 2; j++)
                    {
                        sum += x[j] * metod.A[i, j];
                    }
                    s += sum + "=" + metod.B[i] + Environment.NewLine;
                }
                Otvet.Text = s;
            }

            if (m == met_chect.Gaus_Zeydel_cht)
            {
                double[] x = metod.Gausa_Zeydely(3);
                string s = "";
                for (byte i = 0; i <= 2; i++)
                {
                    s = s + "X" + (i + 1) + "= " + x[i] + Environment.NewLine;
                }

                s += "проверка" + Environment.NewLine;

                for (byte i = 0; i <= 2; i++)
                {
                    double sum = 0;
                    for (byte j = 0; j <= 2; j++)
                    {
                        sum += x[j]*metod.A[i, j];
                    }
                    s += sum + "=" + metod.B[i] + Environment.NewLine;
                }
                s += "Количество шагов" + Environment.NewLine + metod.N;
                Otvet.Text = s;
            }
        }


        private void A11_Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                metod.A[0, 0] = Convert.ToDouble(A11_Text.Text);
                perechcet();
            }
            catch
            {

            }
        }

        private void A12_Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                metod.A[0, 1] = Convert.ToDouble(A12_Text.Text);
                perechcet();
            }
            catch
            {

            }
        }

        private void A13_Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                metod.A[0, 2] = Convert.ToDouble(A13_Text.Text);
                perechcet();
            }
            catch
            {

            }
        }

        private void A21_Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                metod.A[1, 0] = Convert.ToDouble(A21_Text.Text);
                perechcet();
            }
            catch
            {

            }
        }

        private void A22_Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                metod.A[1, 1] = Convert.ToDouble(A22_Text.Text);
                perechcet();
            }
            catch
            {

            }
        }

        private void A23_Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                metod.A[1, 2] = Convert.ToDouble(A23_Text.Text);
                perechcet();
            }
            catch
            {

            }
        }

        private void A31_Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                metod.A[2, 0] = Convert.ToDouble(A31_Text.Text);
                perechcet();
            }
            catch
            {

            }
        }

        private void A32_Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                metod.A[2, 1] = Convert.ToDouble(A32_Text.Text);
                perechcet();
            }
            catch
            {

            }
        }

        private void A33_Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                metod.A[2, 2] = Convert.ToDouble(A33_Text.Text);
                perechcet();
            }
            catch
            {

            }
        }

        private void B1_Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                metod.B[0] = Convert.ToDouble(B1_Text.Text);
                perechcet();
            }
            catch
            {

            }
        }

        private void B2_Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                metod.B[1] = Convert.ToDouble(B2_Text.Text);
                perechcet();
            }
            catch
            {

            }
        }

        private void B3_Text_TextChanged(object sender, EventArgs e)
        {
            try
            {
                metod.B[2] = Convert.ToDouble(B3_Text.Text);
                perechcet();
            }
            catch
            {

            }
        }

        private void Otvet_TextChanged(object sender, EventArgs e)
        {
            perechcet();
        }

        private void Kramer_CheckedChanged(object sender, EventArgs e)
        {
            m = met_chect.Kramer_cht;
            perechcet();
        }

        private void Gausa_CheckedChanged(object sender, EventArgs e)
        {
            m = met_chect.Gaus_cht;
            perechcet();
        }

        private void Gausa_Zeydel_RB_CheckedChanged(object sender, EventArgs e)
        {
            m = met_chect.Gaus_Zeydel_cht;
            perechcet();
        }
    }
}
