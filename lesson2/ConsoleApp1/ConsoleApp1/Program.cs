using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            switch (n)
            {
                case 0: Console.WriteLine("H");
                    break;
                case 1: Console.WriteLine("e");
                    break;
                case 5: Console.WriteLine("l");
                    break;
                default: Console.WriteLine("p");
                    break;

            }
            Console.WriteLine("-----------------------------");
            string s = Console.ReadLine();
            switch (s)
            {
                case "0": Console.WriteLine(false); break;
                case "1": Console.WriteLine(true); break;
                default: Console.WriteLine("none"); break;

            }
            Console.WriteLine("-----------------------------");
            string sum = "";
            long[] arr = new long[10];
            arr = new long[] { 0L, 1L, 0L, 1L, 0L, 0L, 1L, 1L, 0L, 1L };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                Console.WriteLine(Convert.ToInt32(sum, 2));
            }
            Console.WriteLine("-----------------------------");
            int F = 0;
            for (; ; ) {
                F++;
                if (F > 10) { break; }
                Console.WriteLine(F);
            }
            Console.WriteLine("-----------------------------");
            int t = 10;
            while (t > 0)
            {
                Console.WriteLine(t);
                t--;
            }
            Console.WriteLine("-----------------------------");
            int a = -10;
            do
            {
                Console.WriteLine(a);
                a++;
            }
            while (a <= 10);
        }
    }
}
