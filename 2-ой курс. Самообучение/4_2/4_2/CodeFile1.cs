using System;

class forv
{
    static void Main()
    {
        int[] z = {0,0,0};

        int[] s = { 1, 2, 4, 8, 16 };

        int a = s[2] - s[1];
        int b = s[2] - s[1];
        for (int i = 0; i < 4; i++)
        {
            if (s[i]*b == s[i+1] )
            {
                z[0]++;
            };
            if (s[i+1] - s[i] == a)
            {
                z[1]++;
            };
            if (s[i] < s[i + 1])
            {
                z[2]++;
            };
        };

        if (z[0] == 4)
        {
            Console.WriteLine("геометрической прогрессией является");
        }
        else
        {
            Console.WriteLine("геометрической прогрессией неявляется");
        }

        if (z[1] == 4)
        {
            Console.WriteLine("арифметической прогрессией является");
        }
        else
        {
            Console.WriteLine("арифметической прогрессией неявляется");
        }

        if (z[2] == 4)
        {
            Console.WriteLine("Возрастающей прогрессией является");
        }
        else
        {
            Console.WriteLine("Возрастающей прогрессией неявляется");
        }
        Console.ReadKey();
      
    }
}