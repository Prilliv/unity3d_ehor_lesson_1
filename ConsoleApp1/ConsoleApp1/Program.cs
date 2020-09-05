using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            double y = 14.26;
            //Console.WriteLine($"{x} {y}");
            //Console.WriteLine(x + " "+ y);
            //Console.WriteLine($" {6 + 14.25}");
            //int[] arr = new int[] { 1, 2, 3, 4, 5 };
            //float[] arr404;
            //arr404 = new float[10];
            //for (int i = 0; i < 10; i++)
            //arr404[i ] = i;
            //int j = 0;
            //while(j<10) 
            //{
            //Console.WriteLine(arr404[j]);
            //j++;
            //}

            x = 2;
            int[] arr = new int[] { 2, 4, 8, 16, 32, 64 };
            float[] arr404;
            arr404 = new float[6];
            for (int i = 0; i < 6; i++)
            {
                arr404[i] = (float)Math.Pow(2, i + 1);
                Console.WriteLine(arr404[i]);
               
            }     


        }
    }
}
