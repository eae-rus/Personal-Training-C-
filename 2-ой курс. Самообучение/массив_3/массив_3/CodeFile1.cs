using System;

class _main
{
    static void Main()
    {
        Console.Write("введите размер массива(количество сотолбцов)  ");
        byte m = Convert.ToByte(Console.ReadLine());
        Console.Write("введите размер массива(количество строк)  ");
        byte n = Convert.ToByte(Console.ReadLine());
        
        byte[,] a = new byte[n,m];
        Random rand = new Random();
        for (byte i = 0; i < n ; i++)
        {
            for (byte j = 0; j < m; j++)
            {
                a[i,j] = (byte)rand.Next(0,1000);
                Console.Write(a[i, j] + "  ");

            }
            Console.WriteLine(" ");
        }
        Console.ReadKey();

        Console.WriteLine("  ");

        for (byte i = 0; i < n; i++)
        {
            for (byte j = 0; j < m; j++)
            {
                if (i == 0)
                {
                    if (j == 0)
                    {
                        if ((a[i, j] < a[i, j + 1]) & (a[i, j] < a[i + 1, j]) & (a[i, j] < a[i + 1, j + 1]))
                        {
                            Console.Write("0  ");
                        }
                        else
                            Console.Write(a[i, j] + "  ");
                    }
                    else
                        if (j != m-1)
                        {
                            if ((a[i, j] < a[i, j - 1]) & (a[i, j] < a[i+1, j -1]) & (a[i, j] < a[i + 1, j]) & (a[i, j] < a[i + 1, j + 1]) & (a[i,j] < a[i,j-1]))
                            {
                                Console.Write("0  ");
                            }
                            else
                                Console.Write(a[i, j] + "  "); 
                        }

                        else
                            if ((a[i, j] < a[i + 1, j - 1]) & (a[i, j] < a[i, j - 1]) & (a[i, j] < a[i + 1, j]) )
                            {
                                Console.Write("0  ");
                            }
                            else
                                Console.Write(a[i, j] + "  "); 
                }


                if ((j == 0) & (i != 0))
                {
                    if (i != n-1)
                    {
                        if ( (a[i,j]<a[i-1,j]) & (a[i,j]<a[i-1,j+1]) & (a[i,j]<a[i,j+1]) & (a[i,j]<a[i+1,j+1]) & (a[i,j]<a[i+1,j]))
                        {
                            Console.Write("0  ");
                        }
                        else
                            Console.Write(a[i, j] + "  "); 
                    }
                    else
                        if ((a[i, j] < a[i - 1, j]) & (a[i, j] < a[i - 1, j + 1]) & (a[i, j] < a[i, j + 1]))
                        {
                            Console.Write("0  ");
                        }
                        else
                            Console.Write(a[i, j] + "  "); 

                }



                if ((j != 0) & (i == n-1))
                {
                    if (j != m-1)
                    {
                        if ((a[i, j] < a[i , j-1]) & (a[i, j] < a[i - 1, j - 1]) & (a[i, j] < a[i-1, j]) & (a[i,j] < a[i - 1, j + 1]) & (a[i, j] < a[i, j + 1]))
                        {
                            Console.Write("0  ");
                        }
                        else
                            Console.Write(a[i, j] + "  ");
                    }
                    else
                    {
                        if ((a[i, j] < a[i - 1, j]) & (a[i, j] < a[i - 1, j - 1]) & (a[i, j] < a[i, j - 1]))
                        {
                            Console.Write("0  ");
                        }
                        else
                            Console.Write(a[i, j] + "  ");
                    }
                }


                if ((j == m-1) & (i != 0) & (i != n-1))
                {
                    if ((a[i, j] < a[i - 1, j]) & (a[i, j] < a[i - 1, j - 1]) & (a[i, j] < a[i, j - 1]) & (a[i, j] < a[i + 1, j - 1]) & (a[i, j] < a[i + 1, j]))
                    {
                        Console.Write("0  ");
                    }
                    else
                        Console.Write(a[i, j] + "  ");
                }


                if ((i != 0) & (i != n-1) & (j != 0) & (j != m-1))
                {
                    if ((a[i, j] < a[i - 1, j]) & (a[i, j] < a[i - 1, j - 1]) & (a[i, j] < a[i, j - 1]) & (a[i, j] < a[i + 1, j - 1]) & (a[i, j] < a[i + 1, j]) & (a[i, j] < a[i + 1, j + 1]) & (a[i, j] < a[i, j - +1]) & (a[i, j] < a[i-1, j +1]))
                    {
                        Console.Write("0  ");
                    }
                    else
                        Console.Write(a[i, j] + "  ");
                }

            }
            Console.WriteLine(" ");
        }



        Console.ReadKey();
    }

}
