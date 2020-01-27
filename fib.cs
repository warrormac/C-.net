using System;

class Program
{

    static void fib(int a,int b,int c)
    {

        while (a>=2)
        {
            Console.WriteLine(c);
            Console.WriteLine(b);
            c += b;
            b += c;
            a -= 2;
        }
        
    }
    static void Main()
    {
        string val;
        int a = 0;
        int b = 1;
        //int c = 0;

        Console.WriteLine("ingrese limite de la sequencia fib: ");
        val = Console.ReadLine();
        a = Convert.ToInt32(val);
        fib(a,b,0);
       /* val = Console.ReadLine();
        a = Convert.ToInt32(val);
        Console.WriteLine(a);
        val = Console.ReadLine();
        b = Convert.ToInt32(val);
        Console.WriteLine(b);*/
    }
}