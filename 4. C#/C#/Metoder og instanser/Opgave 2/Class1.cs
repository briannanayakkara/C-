using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    class bog // laver en klasse
    {
        public void PrintInfo ()
        {Console.WriteLine("Jeg er bogen");}

        public bool HarRåd(int PriceOfTheBook, double MoneyIHave) // laver en mothose hvor den kan give en feedback (uden at skrive void) 
        {
            PriceOfTheBook = 150; // husker hvor meget bogen koster 
            Console.WriteLine("bogen koster {0}",PriceOfTheBook);// skriver hvad koster bogen 
            // søger for at bruger har penge
            Console.WriteLine("hvor mange penge har du");  
            MoneyIHave = Convert.ToDouble(Console.ReadLine());
            if (MoneyIHave >= PriceOfTheBook)// hvis brugern har penge så er det tru eller er det fals
            {
                return true;
            }
            else { return false; }


        }
    }


}
