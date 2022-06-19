using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Вычмат_1
{
    class metod_nelen_sist
    {
        //прямые функции функции
        private double F1(double x, double y)
        {
            return Math.Cos(x) + y - 1.5;
        }

        private double F2(double x, double y)
        {
            return 2*x - Math.Sin(y - 0.5) - 1;
        }


        private double F(double x, double y,byte i)
        {
            double func;

            if (i == 0)
            {
                func = F1(x, y);
            }
            else
            {
                func = F2(x, y);
            }

            return func;
        }


        //частные производные
        private double d1F1X(double X, double Y)
        {
            double h = 0.0001;
            //double h = 1/1000;
            return (-F1(X + 2 * h,Y) + 8 * F1(X + h,Y) - 8 * F1(X - h, Y) + F1(X - 2 * h, Y)) / 12 / h;
        }
        private double d1F1Y(double X, double Y)
        {
            double h = 0.0001;
            return (-F1(X, Y + 2 * h) + 8 * F1(X, Y + h) - 8 * F1(X, Y - h) + F1(X, Y - 2 * h)) / 12 / h;
        }
        private double d1F2X(double X, double Y)
        {
            double h = 0.0001;
            return (-F2(X + 2 * h, Y) + 8 * F2(X + h, Y) - 8 * F2(X - h, Y) + F2(X - 2 * h, Y)) / 12 / h;
        }
        private double d1F2Y(double X, double Y)
        {
            double h = 0.0001;
            return (-F2(X, Y + 2 * h) + 8 * F2(X, Y + h) - 8 * F2(X, Y - h) + F2(X, Y - 2 * h)) / 12 / h;
        }

        //обратные функции
        private double X1_obr(double y)
        {
            return (1+Math.Sin(y-0.5))/2;
        }
        private double X2_obr(double x)
        {
            return (1.5 - Math.Cos(x));
        }

        private double X_obr(double x, double y, byte i)
        {
            double func;

            if (i == 0)
            {
                func = X1_obr(y);
            }
            else
            {
                func = X2_obr(x);
            }

            return func;
        }


        //счёт определителя
        private double W_opred(double[] x)
        {
            double opred = d1F1X(x[0],x[1])*d1F2Y(x[0], x[1]) - d1F2X(x[0], x[1]) *d1F1Y(x[0], x[1]);
            return opred;
        }

        //сам метод
        public double[] Nutona_Rafsona(double[] x0)
        {
            double[] x = x0;

            double[] x_p = new double[2];

            for (byte i = 0; i <= 1; i++)
            {
                x_p[i] = -F(x[0], x[1], i)/ (W_opred(x));
            }

            bool sigma = true; // условие, что погрешность всё ещё больше 0,001
            double eps = 1;
            int k = 0;
            while (sigma)
            {
                eps = 0;
                k++;


                metod_SLU metod = new metod_SLU();
                metod.A[0, 0] = d1F1X(x[0], x[1]);
                metod.A[0, 1] = d1F1Y(x[0], x[1]);
                metod.A[1, 0] = d1F2X(x[0], x[1]);
                metod.A[1, 1] = d1F2Y(x[0], x[1]);

                metod.B[0] = -F1(x[0], x[1]);
                metod.B[1] = -F2(x[0], x[1]);

                x_p = metod.Kramer(2);

                

                double[] x_0 = new double[2];
                for (byte i = 0; i <= 1; i++)
                {
                    x_0[i] = x[i];
                }

                for (byte i = 0; i <= 1; i++)
                {
                    x[i] = x[i] + x_p[i];
                }

                byte kol = 1;
                for (byte i = 0; i <= 1; i++)
                {
                    eps += Math.Abs(x[i] - x_0[i]);
                    kol = (byte)(i + 1);
                }
                eps = eps/kol;



                if (eps < 0.001)
                {
                    sigma = false;
                }
                if (k>5000)
                {
                    sigma = false;
                }
            }

            return x;
        }
    }
}
