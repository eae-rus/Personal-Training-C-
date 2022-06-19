using System;

public class Metod_ODU
{
    private double[] f_i(double[] y)
    {
        double [] f = new double[3];
        f[0] = y[1]*y[2];
        f[1] = -y[0]*y[2];
        f[2] = -0.51*y[0]*y[1];
        return f;
    }

    public double [,] Eler(double[] y0,double xk,double h)
    {
        long l = (long) (xk/h) + 1;
        double [,] otvet = new double[4,l];
        double[] y = new double[3];
        y[0] = y0[0]; y[1] = y0[1]; y[2] = y0[2];
        double [] f = new double[3];
        double x = 0;
        otvet[3, 0] = 0; otvet[0, 0] = y[0]; otvet[1, 0] = y[1]; otvet[2, 0] = y[2];
        //4-ый)(3-номер) это значения х 
        x += h;
        long i = 1;
        while (x <= xk)
        {
            f = f_i(y);
            y[0] += h*f[0]; y[1] += h * f[1]; y[2] += h * f[2];
            otvet[3, i] = Math.Round(x, 2); otvet[0, i] = Math.Round(y[0], 4); otvet[1, i] = Math.Round(y[1], 4); otvet[2, i] = Math.Round(y[2], 4);
            x += h;
            i++;
        }


        return otvet; 
    }
}
