using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    class Bog // laver en klasse
    {

        // instansvariabler 
        private int pris = 240;
        private string titel = "Moby Dick";

        

        public void PrintInfo()
        { Console.WriteLine("Jeg er bogen"); }

        public bool HarRåd(int pris, double MoneyIHave) // laver en mothose hvor den kan give en feedback (uden at skrive void) 
        {
            pris = this.pris; // husker hvor meget bogen koster () "this." betylder at brug den instancevariable jeg har laved i starten 

            Console.WriteLine("{0} - koster {1}",this.titel, pris);// skriver hvad koster bogen "Moby Dick - koster 240"


            // søger for at bruger har penge


            Console.WriteLine("hvor mange penge har du");


            MoneyIHave = Convert.ToDouble(Console.ReadLine());


            if (MoneyIHave >= pris)// hvis brugern har penge så er det tru eller er det fals
            {
                return true;

            }
            else { return false; }



        }
    }


}
