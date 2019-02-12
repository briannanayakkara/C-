using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name,un = "hej", pass = "hej",Uun,Upss2;
            Console.WriteLine("enter your name");

            name = Console.ReadLine();

            Console.WriteLine("enter the username ");
            Uun = Console.ReadLine();
            Console.WriteLine("enter password ");
            Upss2 = Console.ReadLine();

            if (Uun== un && Upss2 == pass)
            {
                Console.WriteLine("Welcome " + name);
            }

            else
            {
                Console.WriteLine("username or password is wrong");
            }
            Console.ReadKey();
        }

    }
}
    