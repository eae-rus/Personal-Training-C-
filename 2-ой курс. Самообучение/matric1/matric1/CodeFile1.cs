using System;


class _main
{
    static void Main()
    {
        text tt = new text();
        
        math gg = new math();
        
        tt.vved();
        gg.tabl1();
        tt.vvedi();
        int c = Convert.ToInt32(Console.ReadLine());
        tt.gotov();
        gg.rad2(c);
    }


}

class math
{
    int[,] s = new int[4,10];
    Random rand = new Random();

    public void tabl1()
    {
        
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 9; j++)
            {

                s[i,j] = rand.Next(0,10);
                Console.Write(s[i,j] + "  ");
            }
            Console.WriteLine(' ');
        }
        Console.ReadKey();
    }

    public void rad2(int c)
    {

        for (int i = 0; i < 4; i++)
        {
            Console.Write(s[i, c-1] + "  ");
        }
        Console.ReadKey();
    }
}

class text
{
    public void vved()
    {
        Console.WriteLine("матрица");
        Console.ReadKey();
    }

    public void vvedi()
    {
        Console.WriteLine("введите нужный вам столбец");
    }

    public void gotov()
    {
        Console.WriteLine("вот ваш столбец");
    }
}