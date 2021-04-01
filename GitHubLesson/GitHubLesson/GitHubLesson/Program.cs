 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}");


            Random r = new Random();
            int a = r.Next(0, 100 + 1), b = r.Next(0, 100);
            Console.WriteLine($"{a}+{b} = {a+b}.");
            
            Console.ReadKey();

            Console.ReadLine();
        }
    }
}
