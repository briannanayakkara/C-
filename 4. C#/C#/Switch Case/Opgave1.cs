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
            int tal;
            Console.WriteLine("intaster et tal mellem 1-6 begge tal inklusiv");

            tal = Convert.ToInt32(Console.ReadLine()); //indtager tallet
            switch (tal) // laver en switch case for at hvide on brugern har vundet eller ej
            {
                case 1:
                    Console.WriteLine(" Du har tastet "+ tal);
                    break;
                case 2:
                    Console.WriteLine(" Du har tastet " + tal);
                    break;
                case 3:
                    Console.WriteLine(" Du har tastet " + tal);
                    break;
                case 4:
                    Console.WriteLine("TILLYKKE DU HAR VUNDET"); // hvis brugern taster number 4 så er brugern vundet
                    break;
                case 5:
                    Console.WriteLine(" Du har tastet " + tal);
                    break;
                case 6:
                    Console.WriteLine(" Du har tastet " + tal);
                    break;

                default:
                    Console.WriteLine("Du har tastet forkert. Tallet skal være mellem 1 og 6"); // hvis brugern taster en tab som er ikke mellen 1-6 så køre program den kode 
                    System.Threading.Thread.Sleep(10000); // program slukker om 10 sekunder
                    break;
            }
         
        }

    }
}
    