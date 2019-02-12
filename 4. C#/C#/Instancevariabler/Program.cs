using System;

namespace ConsoleApp6
{

    class MainClass
    {
        static void Main(string[] args)
        {
            

            Bog MobyDick = new Bog();

            

            // kalder methoden og udskriver at brugern har rød eller ej indsted for at skrive true eller false 

            // selve metholen fider ud af om brugen har penge eller ej derfor jeg skal bare kald metholen her ud og udskrive den 
            if (MobyDick.HarRåd(0, 0) == true)
            {
                Console.WriteLine(" Jeg har råd");
            }
            else { Console.WriteLine(" Jeg har desværre ikke råd"); }


            Console.ReadKey();

        }


    }
}
