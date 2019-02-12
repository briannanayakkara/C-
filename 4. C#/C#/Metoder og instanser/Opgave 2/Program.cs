using System;

namespace ConsoleApp6
{

    class MainClass
    {
        static void Main(string[] args)
        {

            bog SherlockHolmes = new bog();

            SherlockHolmes.PrintInfo();

           // kalder methoden og udskriver at brugern har rød eller ej indsted for at skrive true eller false 

            // selve metholen fider ud af om brugen har penge eller ej derfor jeg skal bare kald metholen her ud og udskrive den 
            if (SherlockHolmes.HarRåd(150, 0) == true)
            {
                Console.WriteLine(" Jeg har råd");
            }
            else { Console.WriteLine(" Jeg har desværre ikke råd"); }

           

            Console.ReadKey();
            
        }

        
    }
}
