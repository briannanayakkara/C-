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

            // kalder metholen 
            moter.MoterOn(); 
            moter.MoterOff();

            Console.ReadKey();
        }
    }
}
