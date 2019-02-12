using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name; // eklere en var for navn (det er nemmer at gøre det såden hvis jeg vill gerene skift mit naven serner)
            Console.WriteLine("indtaste dit navn..");
            name = Console.ReadLine(); // give it vædi for "name" 
            // venstra side (top)
            for (int x = 20, y = 4; x <=30 || y <8; x++, y++)
            {
                if (x<30)
                {
                    Console.SetCursorPosition(x, 4);
                    Console.WriteLine("─");
                    Console.SetCursorPosition(x, 8);
                    Console.WriteLine("─");
                }

                if (y < 8)
                {
                    Console.SetCursorPosition(20, y);
                    Console.WriteLine("│");
                    Console.SetCursorPosition(30, y);
                    Console.WriteLine("│");
                }
   
                // hjørner (venstra)
                Console.SetCursorPosition(20, 4);
                Console.WriteLine("┌");
                Console.SetCursorPosition(20, 8);
                Console.WriteLine("└");
                // hjørner (højer)
                Console.SetCursorPosition(30, 4);
                Console.WriteLine("┐");
                Console.SetCursorPosition(30, 8);
                Console.WriteLine("┘");
                
            }

            // scriver brugers navn i miden
      
            Console.SetCursorPosition(24,6); // 25X og 6y fordi det er miden af boxen 
            Console.WriteLine(name);
 
            Console.ReadKey();
        }
    }
}
