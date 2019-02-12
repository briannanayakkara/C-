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
          
            String farve; int alder;

            Console.Title = "Festen"; // set titlen

            Console.WriteLine(" hvilken farve du foretrækker vælge mellem rød, grøn, blå og gul");
            farve = Console.ReadLine();

            Console.WriteLine("hvor gammel er du??");
            alder = Convert.ToInt32(Console.ReadLine());

            if (alder >= 18) //laver en if statment for at ved om brugern er over 18 eller ej
            {
                if (farve == "rød")// skifter baugrubd farver
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                }
                if (farve == "grøn")// skifter baugrubd farver
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                }
                if (farve == "blå")// skifter baugrubd farver
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                }
                if (farve == "gul")// skifter baugrubd farver
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                }

                Console.WriteLine("velkommen til cocktailbaren");

            }

            else if (alder < 18) //laver en if statment for at ved om brugern er over 18 eller ej
            {
                if (farve == "rød") // skifter baugrubd farver
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                }
                if (farve == "grøn") // skifter baugrubd farver
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                }
                if (farve == "blå") // skifter baugrubd farver
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                }
                if (farve == "gul") // skifter baugrubd farver
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                }
                Console.WriteLine(" velkommen til sodavandsbaren ");
            }

            System.Threading.Thread.Sleep(10000);  // sluk program efter 10 sekunder 
         
        }

    }
}
    