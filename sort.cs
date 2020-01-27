using System;

namespace ConsoleApp2
{
    class Program
    {

        static int ran(int []a, int size)
        {
            for(int i=0;i<size;i++)
            {
                Random ran = new Random();
                a[i] = ran.Next(0, size);
            }

            Console.WriteLine("array generado ");
            for (int i=0;i<size;i++)
                Console.Write(a[i] + "-");

            Console.WriteLine();
            return 0;
        }

        static void sort(int []a, int size)
        {
            Array.Sort(a);
            
            for (int i = 0; i < size; i++)
                Console.Write(a[i] + "-");

        }

        static void Main(string[] args)
        {
            string val;
            int temp;
            Console.WriteLine("ingrese el tamano del array generado: ");
            val = Console.ReadLine();
            temp = Convert.ToInt32(val);
            int [] arr = new int[temp];
            ran(arr,temp);
            sort(arr, temp);
        }
    }
}
