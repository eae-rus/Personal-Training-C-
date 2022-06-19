using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vichmat_Prokt
{
    class Metods_Urav
    {
        public double F(double X)
        {
            //return -X / (Math.Abs(X) + 1.2);
           return X * X * X - 3 * X - 1;

        }

        // X= Rstar
        public double R(double X,double S, byte m, double Rnov)
        {
            double z = Rnov - (X + 3*m*(S - (2 + Math.Pow(3, (X - 200)/100)/(1 + Math.Pow(3, (X - 300)/100)))));
            return z;
        }

        private double h = 0.000001;

        private double d1F(double X)
        {
            // return (F(X+h)-F(X-h))/2/h;
            return (-F(X + 2 * h) + 8 * F(X + h) - 8 * F(X - h) + F(X - 2*h)) / 12 / h;
        }

        private double d1F(double X,double h1)
        {
            return (-F(X + 2 * h1) + 8 * F(X + h1) - 8 * F(X - h1) + F(X - 2 * h1)) / 12 / h1;
        }


        private double d2F(double X)
        {
            return (-d1F(X + 2 * h) + 8 * d1F(X + h) - 8 * d1F(X - h) + d1F(X - 2 * h)) / 12 / h;
        }


        private double d1R(double X, double S, byte m, double Rnov)
        {
            // return (F(X+h)-F(X-h))/2/h;
            return (-R(X + 2*h, S, m, Rnov) + 8*R(X + h, S, m, Rnov) - 8*R(X - h, S, m, Rnov) + R(X - 2*h, S, m, Rnov))/12/h;
        }

        private double d2R(double X, double S, byte m, double Rnov)
        {
            return (-d1R(X + 2 * h, S, m, Rnov) + 8 * d1R(X + h, S, m, Rnov) - 8 * d1R(X - h, S, m, Rnov) + d1R(X - 2 * h, S, m, Rnov)) / 12 / h;
        }


        public int N = 0;

        public float[,] naxogd_Interval(float a, float b)
        {
            float[,] s = new float[100, 2];
            s[0, 0] = 0; // этот сектор отвечает за количество корней 
            byte j = 1;
            float h = (float)0.01;
            float a1 = a;
            for (int i = 0; i < (int)(b - a1) / h; i++)
            {
                if (F(a-h) * F(a + h) <= 0|| (d1F(a-h) * d1F(a + h) < 0 && F(a)<2*h ))
                {
                    double z = d1F(a) * d1F(a + i * h);
                    double z1 = F(a);
                    double z2 = F(a+h);
                    s[j, 0] = a;
                    s[j, 1] = a+h;
                    s[0, 0] = j;
                    j++;
                    a += h * 10;
                }
                a += h;
            }
            float w = s[0, 0];
            return s;
        }


        public double bisect(double a, double b)
        {
            N = 0;
            double c = 0;
            while (Math.Abs(b - a) > 0.0001)
            {
                c = (a+b) / 2;
                if (F(a) * F(c) < 0)
                {
                    b = c;
                    N += 1;
                }
                else {
                    if (F(c) * F(b) < 0)
                    {
                        a = c;
                        N += 1;
                    }
                    else {
                        a = c;
                        b = c;
                    }
                }
            }

            return (a+b)/2;
        }

        public double bisect(double a, double b,double Rnov, byte m, double s)
        {
            N = 0;
            double c = 0;
            while (Math.Abs(b - a) > 0.0001)
            {
                c = (a + b) / 2;
                if (R(a,s,m,Rnov) * R(c, s, m, Rnov) < 0)
                {
                    b = c;
                    N += 1;
                }
                else
                {
                    if (R(c, s, m, Rnov) * R(b, s, m, Rnov) < 0)
                    {
                        a = c;
                        N += 1;
                    }
                    else
                    {
                        a = c;
                        b = c;
                    }
                }
            }

            return (a + b) / 2;
        }

        public double Lognogo_pol(double a, double b, double Rnov, byte m, double s)
        {
            N = 0;
            double c = 0;
            double d = 1;

            while (Math.Abs(d)> 0.0001)
            {


                c = a-(b-a)/(R(b, s, m, Rnov) - R(a, s, m, Rnov))*R(a, s, m, Rnov);

                if (R(a, s, m, Rnov) * R(c, s, m, Rnov) < 0)
                {
                    d = b - c;
                    b = c;
                    N += 1;
                }
                else
                {
                    if (R(b, s, m, Rnov) * R(c, s, m, Rnov) < 0)
                    {
                        d = c - a;
                        a = c;
                        N += 1;
                    }
                    else
                    {
                        a = c;
                        b = c;
                        d = 0;
                    }
                }
            }

            return c;
        }

        public double Lognogo_pol(double a, double b)
        {
            N = 0;
            double c = 0;
            double d = 1;

            while (Math.Abs(d) > 0.0001)
            {


                c = a - (b - a) / (F(b) - F(a)) * F(a);

                if (F(a) * F(c) < 0)
                {
                    d = b - c;
                    b = c;
                    N += 1;
                }
                else
                {
                    if (F(b) * F(c) < 0)
                    {
                        d = c - a;
                        a = c;
                        N += 1;
                    }
                    else
                    {
                        a = c;
                        b = c;
                        d = 0;
                    }
                }
            }

            return c;
        }



        public double kasat(double a, double b, double w)
        {
            N = 0;
            double x_0;
            if (F(a) * d2F(a) > 0)
            {
                x_0 = a;
            }
            else {
                x_0 = b;
            }

            w /= 1000;

            double x = x_0-w*F(x_0)/d1F(x_0);
            while (Math.Abs(x - x_0) > 0.0001)
            {

                x_0 = x;
                x = x_0 - w*F(x_0) / d1F(x_0);
                N += 1;
            }

            return x;
        }

        public double kasat(double a, double b, double w, double Rnov, byte m, double s)
        {
            N = 0;
            double x_0;
            if (R(a, s, m, Rnov) * d2R(a, s, m, Rnov) > 0)
            {
                x_0 = a;
            }
            else
            {
                x_0 = b;
            }

            w /= 1000;

            double x = x_0 - w * R(x_0, s, m, Rnov) / d1R(x_0, s, m, Rnov);
            while (Math.Abs(x - x_0) > 0.0001)
            {

                x_0 = x;
                x = x_0 - w * R(x_0, s, m, Rnov) / d1R(x_0, s, m, Rnov);
                N += 1;
            }

            return x;
        }

        private double[] sort(double[] z)
        {
            for (int i = 0; i <= 2; i++)
            {
                for (int j = i+1; j <=3; j++)
                {
                    if (z[i] > z[j])
                    {
                        z[i] = z[i] + z[j];
                        z[j] = z[i] - z[j];
                        z[i] = z[i] - z[j];
                    }
                }
            }
            return z;
        }

        public double M_Rid(double a, double b)
        {
            N = 0;

            bool ne_perv = false;
            bool usl = true;
            double pred = 0;
            double c = 0;
            double x = 0;
            double[] z = new double[4];

            while (usl)
            {
               c = (a + b) / 2;
               x = c + (c - a) * (Math.Sign(F(a) - F(b)) * F(c))/Math.Sqrt(Math.Abs(F(c)*F(c)-F(a)*F(c)));
                if (ne_perv)
                {
                    if (Math.Abs(x - pred) < 0.0001)
                    {
                        usl = false;
                    }
                }

                pred = x;

                z[0] = a; z[1] = b; z[2] = c; z[3] = x;
                z = sort(z);
                for (int i = 0; i <=2; i++)
                {
                    if (F(z[i]) * F(z[i + 1]) <= 0)
                    {
                        a = z[i];
                        b = z[i + 1];
                    }
                }

                ne_perv = true;
                N++;

            }

            return x;
        }


        public double M_Rid(double a, double b, double Rnov, byte m, double s)
        {
            N = 0;

            bool ne_perv = false;
            bool usl = true;
            double pred = 0;
            double c = 0;
            double x = 0;
            double[] z = new double[4];

            while (usl)
            {
                c = (a + b) / 2;
                x = c + (c - a) * (Math.Sign(R(a, s, m, Rnov) - R(b, s, m, Rnov)) * R(c, s, m, Rnov)) / Math.Sqrt(Math.Abs(R(c, s, m, Rnov) * R(c, s, m, Rnov) - R(a, s, m, Rnov) * R(c, s, m, Rnov)));
                if (ne_perv)
                {
                    if (Math.Abs(x - pred) < 0.0001)
                    {
                        usl = false;
                    }
                }

                pred = x;

                z[0] = a; z[1] = b; z[2] = c; z[3] = x;
                z = sort(z);
                for (int i = 0; i <= 2; i++)
                {
                    if (R(z[i], s, m, Rnov) * R(z[i + 1], s, m, Rnov) <= 0)
                    {
                        a = z[i];
                        b = z[i + 1];
                    }
                }

                ne_perv = true;
                N++;

            }

            return x;
        }
    }
}
