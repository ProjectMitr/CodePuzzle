using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodePuzzle
{
    class Program
    {
        static void expression()
        { 
        string x= "my world";
        string y = "kabali";
        x = x + y;
        Console.WriteLine(x);
        Console.ReadLine();
        }

        static void expression1()
        {
            string x = "my world";
            string y = "ram";
            x += y;
            Console.WriteLine(x);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            expression();
        }
    }
}
