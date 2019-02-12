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
         
            double indkome,bundskat,mellemskat, topskat;

            Console.WriteLine("hvad er din indkome??");

            indkome = Convert.ToDouble(Console.ReadLine());


            // laver formuler for at regne ud hvor meget de skal betale skat
            bundskat = (indkome * 30) / 100;
            mellemskat = (indkome * 6) / 100;
            topskat = (indkome * 15) / 100;


            if (indkome < 42000)
            {
                Console.WriteLine("du skal ikke betales skat");
                
            }

            if (indkome == 42000 || indkome > 42000 && indkome < 280000)
            {
                Console.WriteLine(" du skal betales bundskat på 30%."); // bundskat
                Console.WriteLine("du skal betale {0}kr", bundskat);
            }

            if (indkome >= 280000 && indkome < 390000)
            {
                Console.WriteLine("du skal betales 6% mellemskat."); // mellemskat
                Console.WriteLine("du skal betale {0}kr", mellemskat);
            }

            if (indkome >= 390000)
            {

                Console.WriteLine("skal der yderligere betales 15% topskat."); // topskat
                Console.WriteLine("du skal betale {0}kr", topskat);
            }
            Console.ReadKey();
            
        }
    }
}
