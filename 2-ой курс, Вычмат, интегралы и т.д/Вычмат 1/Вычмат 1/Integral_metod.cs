using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vichmat
{
    class Metods_Int
    {
        private float F(float x)
        {
            return x * x * x / (3 + x);
        }

        public float Prymougol(float a, float b, float N,float k)
        {
            float I = 0;
            float h= (b - a) / N;
            a = a + h * k; 
            for (int i = 1; i <= N; i++)
            {
                I += F(a + (i - 1) * h); ;
            }
            I *= h;
            return I;
        }

        public float Trapecii(float a, float b, float N)
        {
            float I = (F(a) + F(b)) / 2;
            float h = (b - a) / N;
            a = a + h;
            for (int i = 1; i <= N-1; i++)
            {
                I += F(a+(i-1)*h);
            }
            I *= h;
            return I;
        }

        public float Simpsona(float a, float b, float N)
        {
            float I = (F(a) + F(b));
            float h = (b - a) / N;

            for (int i = 1; i <= N/2-1; i++)
            {
                I += 4*F(a + (2*i - 1) * h);
                I += 2 * F(a + 2 * i * h);
            }
            I += 4 * F(a + (N - 1) * h);

            I *= h/3;
            return I;
        }


        public float Simpsona3_8(float a, float b, float N)
        {
            float h = (b - a) / N;
            float I = 3*(F(a) + F(b))/ 8 +7* (F(a+h)+F(b-h))/6 + 23*(F(a+2*h)+F(b-2*h))/24;

            for (int i = 4; i <= N - 2; i++)
            {
                I += F(a + (i - 1) * h);
            }

            I *= h;
            return I;
        }

        public float Gausa_Legandra(float a, float b, float N,byte p)
        {
            float[,] X = new float[7, 7];
            X[1, 1] = 0;
            X[2, 1] = (float)-0.57735; X[2, 2] =(float)0.57735;
            X[3, 1] = (float)-0.7745697; X[3, 2] = (float)0; X[3, 3] = (float)0.7745697;
            X[4, 1] = (float)-0.861136; X[4, 2] = (float)-0.339981; X[4, 3] = (float)0.339981; X[4, 4] = (float)0.861136;
            X[5, 1] = (float)-0.90618; X[5, 2] = (float)-0.538469; X[5, 3] = (float)0; X[5, 4] = (float)0.538469; X[5, 5] = (float)0.90618;
            X[6, 1] = (float)-0.93247; X[6, 2] = (float)-0.661209; X[6, 3] = (float)-0.238619; X[6, 4] = (float)0.238619; X[6, 5] = (float)0.661209; X[6, 6] = (float)0.93247;

            float[,] C = new float[7, 7];
            C[1, 1] = 2;
            C[2, 1] = 1; C[2, 2] = 1;
            C[3, 1] = (float)0.55556; C[3, 2] = (float)0.888889; C[3, 3] = (float)0.55556;
            C[4, 1] = (float)0.34785; C[4, 2] = (float)0.65215; C[4, 3] = (float)0.65215; C[4,4] = (float)0.34785;
            C[5, 1] = (float)0.23693; C[5, 2] = (float)0.47863; C[5, 3] = (float)0.56889; C[5, 4] = (float)0.47863; C[5, 5] = (float)0.23693;
            C[6, 1] = (float)0.17132; C[6, 2] = (float)0.36076; C[6, 3] = (float)0.467961; C[6, 4] = (float)0.467961; C[6, 5] = (float)0.36076; C[6, 6] = (float)0.17132;

            float h = (b - a) / N;
            float I =0;

            for (int j = 0; j <= N - 1;j++)
            {
                for (byte i = 1; i <= 6; i++)
                {
                    I= I + C[p, i] * F(X[p, i] * h / 2 + a + j * h + h / 2);
                }
            }

            return (I*(h/2));
        }

        private float max(float a, float b,float N)
        {
            float maxx = F(a);
            float h = (a + b) / N;

            for (int i = 1; i <= N; i++)
            {
                if (maxx < F(a + i * h))
                    maxx = F(a + i * h);
            }

            return maxx;
        }


        public float Monte_Karlo(float a, float b, float N)
        {
            float h = max(a,b,N);
            float N1 = 0;
            float I = 0;
            float x, y = 0;
            Random rand = new Random();
            N *= 100;
            for (int i = 1; i <= N ; i++)
            {
                x = a +(b- a)*(float)Convert.ToDouble(rand.Next(1001)) / 1000;
                y = h*(float)Convert.ToDouble(rand.Next(1001)) / 1000;

                if (y <= F(x))
                {
                    N1++;
                }

            }

            I = h*(b-a)*N1/N;
            return I;
        }

    }
}
