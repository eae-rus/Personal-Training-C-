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
    public partial class ODU : Form
    {
        public ODU()
        {
            InitializeComponent();
            y0[0] = 0; y0[1] = 1; y0[2] = 1;
            xk = 10; shag = 0.01;
            perechcet();
        }
        double[] y0 = new double[3];
        double xk = new double();
        double shag = new double();
        private void ODU_Load(object sender, EventArgs e)
        {

        }

        private void Y1_Text_TextChanged(object sender, EventArgs e)
        {
            double a;
            bool z = double.TryParse(Y1_Text.Text, out a);
            y0[0] = a;

            if (!z)
            {
                MessageBox.Show("ошибка ввода введите в формате x,x  , где х - наборы цифр");
            }
            else
            {
                perechcet();
            }
        }

        private void Y2_Text_TextChanged(object sender, EventArgs e)
        {
            double a;
            bool z = double.TryParse(Y2_Text.Text, out a);
            y0[1] = a;

            if (!z)
            {
                MessageBox.Show("ошибка ввода введите в формате x,x  , где х - наборы цифр");
            }
            else
            {
                perechcet();
            }
        }

        private void Y3_Text_TextChanged(object sender, EventArgs e)
        {
            double a;
            bool z = double.TryParse(Y3_Text.Text, out a);
            y0[2] = a;

            if (!z)
            {
                MessageBox.Show("ошибка ввода введите в формате x,x  , где х - наборы цифр");
            }
            else
            {
                perechcet();
            }
        }

        private void Xk_Text_TextChanged(object sender, EventArgs e)
        {
            
            bool z = double.TryParse(Xk_Text.Text, out xk);

            if (!z | xk<=shag)
            {
                MessageBox.Show("ошибка ввода введите в формате x,x  , где х - наборы цифр (или введено значение <=шаг)");
            }
            else
            {
                perechcet();
            }
        }

        private void Shag_Text_TextChanged(object sender, EventArgs e)
        {
            bool z = double.TryParse(Shag_Text.Text, out shag);

            if (!z)
            {
                MessageBox.Show("ошибка ввода введите в формате x,x  , где х - наборы цифр");
            }
            else
            {
                perechcet();
            }
        }

        private void perechcet()
        {
            string s = "";
            Metod_ODU metod = new Metod_ODU();
            double[,] otvet = metod.Eler(y0, xk, shag);
            long l = (long)(xk / shag);
            for (int i = 0; i < l; i++)
            {
                s += "x="+otvet[3,i] + "   ";
                s += "y1=" + otvet[0, i] + "   ";
                s += "y2=" + otvet[1, i] + "   ";
                s += "y3=" + otvet[2, i] + Environment.NewLine;
            }

            Otvet.Text = s;
        }

      
    }
}
