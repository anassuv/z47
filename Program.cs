using System;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("m = ");
            int m = Int32.Parse(Console.ReadLine());
            Console.Write("n = ");
            int n = Int32.Parse(Console.ReadLine());
            double[,] a = new double[m, n];
            Random rd = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rd.Next(-99, 100) / 10.0;
                    Console.Write("{0,7:0.0}", a[i, j]);
                }
                Console.WriteLine();
            }            
            Console.ReadKey();
        }
    }
}