using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Bil // laver en klasse
    {
        public void MoterOn() { Console.WriteLine("Motoren er startet"); } //laver en methode som skriver at motern er startet
        public void MoterOff() { Console.WriteLine("Motoren er slukket"); } //laver en methode som skriver at motern er slukket

        public void FillGas(double liters, bool isDiesel)
        {
            Console.Write("Filled tank with:{0} liters of ", liters ); // udskriver " Filled tank with x liters of ..


            // laver en if statment så hvis det er diesel so udkriver diesel efter "Filled tank with x liters of .." (har brught Console.Write(); instedfor Console.WriteLine();)
            if (isDiesel == true)
            {
                Console.WriteLine("Diesel");
            }
            else { Console.WriteLine("Benzin"); }

        }

        public double RemainingGas() // laver en methode some kan give en feedback
        {
            return 0; // feedback er "0"
        }
    }
}
