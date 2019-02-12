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
         
            double KmtoAndFromWork, fradrag; // laver en double 


            Console.WriteLine("hvor mange km der køres hver dag til og fra arbejde");

            KmtoAndFromWork = Convert.ToDouble(Console.ReadLine()); // intager vadirene for var
           

            // laver en if statment (hvis burgen køre mindre end 25 KM om dage)
            if (KmtoAndFromWork < 25)
            {
                Console.WriteLine("Du får ikke noget fradrag");
            }
            // hvis brugern køre imelm 25 - 120 km om dagen
            else if (KmtoAndFromWork > 24 && KmtoAndFromWork < 120)
            {
                fradrag = (KmtoAndFromWork-24) * 1.93; // Formel  
                Console.WriteLine("gives der 1,93 kr. pr. km i fradrag ");
                Console.WriteLine("du få {0}kr i alt",fradrag);
            }
            // hvis brugern køre over 120 om dagen 
            else if (KmtoAndFromWork > 119)
            {

                fradrag = 96 * 1.93+(KmtoAndFromWork-120) *0.97; // Formel  

                Console.WriteLine("gives der 0,97 kr. pr. km i fradrag ");
                Console.WriteLine("du få {0}kr i alt", fradrag);
            }

            Console.ReadKey();
            
        }

    }
}
    