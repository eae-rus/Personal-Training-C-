using System;

class _main
{
    static void Main()
    {
        math vv = new math();
        vv.schet();
        Console.ReadKey();
    }

}

class math
{
    public void schet()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int z = 1;
        chet tt = new chet();
        tt.text1();
        Console.Write(x);
        tt.text2();
        for (int i = 1; i <= x; i++)
        {
            z = z * 2;
        }
        Console.Write(z);


    }

    public void text1()
    {
        Console.Write("число 2 в ");

    }
}
class chet
{
    public void text2()
    {
        Console.Write(" степени =");
 
    }

}