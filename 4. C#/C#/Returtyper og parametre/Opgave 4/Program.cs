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
            
            double gass = 2.5; // laver en double og giver en vædi 2,5 
            

            moter.FillGas(gass,true); // Kalder methode her og giver bool vædi til true så ulskriver "Filled tank with 2,5 liters of Diesel"

            moter.FillGas(gass, false); // Kalder methode her og giver bool vædi til fals så ulskriver "Filled tank with 2,5 liters of Brnzin"

            Console.WriteLine(moter.RemainingGas()); // udskriver methoden direkt i en console linje

            double Rgass = moter.RemainingGas(); // gemmer methoden i en variable 

            Rgass = 1; // skifter return vædi 

            Console.WriteLine(Rgass); // udskriver methoden ved brugen af variable navn 


            Console.ReadKey();
        }
    }
}
