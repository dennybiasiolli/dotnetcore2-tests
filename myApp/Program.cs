using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var names = new List<string> { "Denny", "Ana", "Felipe" };
            writeList(names, "Hello ", "!");

            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            writeList(names, "Hello ", "!");
        }

        static void writeList(List<string> list, String prefix, String suffix)
        {
            foreach (String s in list)
            {
                Console.WriteLine($"{prefix}{s.ToUpper()}{suffix}");
            }
        }
    }
}
