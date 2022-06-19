using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Вычмат_1
{
    class metod_SLU
    {
        public double [,] A = new double[3,3];
        public double[] B = new double[3];

        private double[,] Ar = new double[3, 3];
        private double[] Br = new double[3];
        public uint N;

        private double[,] treugol(double[,] a,byte n,byte m)
        {
            for (byte i = 1; i <= n; i++)
            {

                for (byte k = i ; k <= n; k++)
                {
                    double q = -a[k, i - 1] / a[i - 1, i - 1];
                    for (byte j = (byte)(i - 1); j <= m; j++)
                    {
                        a[k, j] = a[k, j] + q * a[i - 1, j];
                    }
                }
                   
            }


            return a;
        }

        private double[,] treugol(double[,] a, byte n, byte m, double[] br)
        {
            for (byte i = 1; i <= n; i++)
            {

                for (byte k = i; k <= n; k++)
                {
                    double q = -a[k, i - 1] / a[i - 1, i - 1];
                    for (byte j = (byte)(i - 1); j <= n; j++)
                    {
                        a[k, j] = a[k, j] + q * a[i - 1, j];
                    }
                    br[k] = br[k] + q*br[i-1];
                }

            }

            double[,] ab = new double[n+1,m+1];

            for (byte i = 0; i <= n; i++)
            {
                for (byte j = 0; j <= n; j++)
                {
                    ab[i, j] = a[i, j];
                }
                ab[i, m] = br[i];
            }

            return ab;
        }

        private double opredel(double[,] a, byte n)
        {
            double s = 1;
            for (byte i = 0; i <= n-1; i++)
                s *= a[i, i];
            return s;
        }

        private double[,] zamena(double[,] a, byte k, double[] b)
        {
            for (byte i = 0; i <= 2; i++)
                a[i, k] = b[i];
            return a;
        }

        private double[,] inic_mas(double[,] a)
        {
            double[,] ar = new double[3,3];
            for (byte i = 0; i <= 2; i++)
            {
                for (byte j = 0; j <= 2; j++)
                {
                    ar[i, j] = a[i, j];
                }
            }
            return ar;
        }

        private double[] inic_mas(double[] b)
        {
            double[] br = new double[3];
            for (byte i = 0; i <= 2; i++)
            {
                br[i] = b[i];
            }
            return br;
        }

        private void men(byte n)
        {
            double z;
            for (byte i = 0; i < n; i++)
            {
                z = A[0, i];
                A[0, i] = A[1, i];
                A[1, i] = z;
            }

            z = B[0];
            B[0] = B[1];
            B[1] = z;
        }


        public double[] Kramer(byte n)
        {
            if (A[0, 0] == 0 & A[1, 0] != 0)
            {
                men(n);
            }

            double[] x = new double[n];
            Ar = inic_mas(A);
            Ar = treugol(Ar,(byte)(n-1), (byte)(n -1));
            double s = opredel(Ar,n);


            for (byte i = 0; i < n; i++)
            {
                Ar = inic_mas(A);
                Ar = zamena(Ar, i, B);
                Ar = treugol(Ar, (byte)(n - 1), (byte)(n - 1));
                double sx = opredel(Ar, n);
                x[i] = sx / s;
            }
            

            return x;
        }


        public double[] Gausa(byte n)
        {
            double[] x = new double[3];

            if (A[0, 0] == 0 & A[1, 0] != 0)
            {
                men(n);
            }

            Ar = inic_mas(A);
            Br = inic_mas(B);
            Ar = treugol(Ar, 2, 3,Br);

            for (int i = n-1; i >=0; i--)
            {
                double s = 0;
                for (int j = n-1; j >i; j--)
                {
                    s += Ar[i, j]*x[j];
                }

                x[i] = (Ar[i,n] - s)/Ar[i, i];
            }

            return x;
        }

        public double[] Gausa_Zeydely(byte n)
        {
            N = 0;
            double[] x = new double[n];

            for (byte i = 0; i<n; i++)
            {
                x[i] = 0;
            }

            if (A[0, 0] == 0 & A[1, 0] != 0)
            {
                men(n);
            }

            Ar = inic_mas(A);
            Br = inic_mas(B);
            Ar = treugol(Ar, 2, 3, Br);

            bool sigma = true; // условие, что погрешность всё ещё больше 0,001

            while (sigma)
            {
                double eps = 0;
                for (int i = 0; i < n; i++)
                {
                    double s = 0;
                    
                    for (int j = 0; j <n; j++)
                    {
                        if (j != i)
                        {
                            s += Ar[i, j] * x[j];
                        }
                    }

                    if (eps < Math.Abs(x[i] - (Ar[i,n] - s)/Ar[i, i]))
                    {
                        eps = Math.Abs(x[i] - (Ar[i, n] - s) / Ar[i, i]);
                    }

                    x[i] = (Ar[i, n] - s)/Ar[i, i];
                }

                if (eps < 0.001)
                {
                    sigma = false;
                }
                N++;
            }

            return x;
        }
    }
    
}
