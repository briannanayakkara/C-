using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil moter = new Bil(); //laver en objekt af bil klassen

            // kalder methoden 
            moter.MoterOn(); 
            moter.MoterOff();

            // kalder methoden 
            moter.FillGas(2.5); // giver en parameteren 2.5 (den kode udskriver Filled tank with 2,5 liters)
            double gass = 2.6; // laver en double og giver en vædi 2,6 
            moter.FillGas(gass); // kalder methoden og skriver navnet af double jeg laved som en parameter (den kode udskriver Filled tank with 2,6 liters)



            Console.ReadKey();
        }
    }
}
