using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<string> l = new List<string>() { "My favorite school subjects" };
            l.Add("My favorite school subjects");
            l.Add("My favorite school subjects");
            l.Add("My favorite school subjects");
            foreach (string f in l)
            {
                  Console.WriteLine("My favorite school subjects");
                
            }
            Console.WriteLine(l.Count);
            l.Clear();
        }
    }
}   
