using System;
class cikle
 {
    static void Main() 
    {
        Console.WriteLine("эта программа возводит любое целое число в любую целую степень ");
    float  x = Convert.ToInt32(Console.ReadLine());
    int  y = Convert.ToInt32(Console.ReadLine());
        float z;
        z = x;
        if (y>0)
        {
            for (uint i = 2; i <= y; i++)
            {
                z = z * x;
            }
        };
        if (y < 0)
        {
            for (uint i = 2; i <= -y; i++)
            {
                z = z * x;
            }
        };

           if (y > 0)
           {
               Console.WriteLine("Ответ выражения х^y = ");
               Console.WriteLine(z);
               Console.ReadKey();
           }
           else
           {
               if (y == 0)
               {
                   Console.WriteLine("Ответ выражения х^y = ");
                   Console.WriteLine('1');
                   Console.ReadKey();
               }
               else
               {
                   Console.WriteLine("Ответ выражения х^y = ");
                   Console.WriteLine(1/z);
                   Console.ReadKey();
               }
           }

 }
}
