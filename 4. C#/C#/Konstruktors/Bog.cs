using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktors
{
    class Bog
    {
        private int Pris;
        private string Titel;

        public Bog(int Pris, string Title) //Konstruktors med  alle instans variablerne
        {
            this.Pris = Pris; 
            this.Titel = Title;
        }

        public Bog(string Title) // Konstruktors med 1 af instans variablerne
        {
            this.Titel = Title; 

        }

        public bool HarRåd(int Mymoney)
        {
             
            Console.WriteLine("Bogen koster {0}kr.",Pris);
            Console.WriteLine();
            Console.WriteLine("Hvor mange penge har du??");
            Mymoney = Convert.ToInt32(Console.ReadLine());

            if (Mymoney >= Pris)
            {
                return
                true;
                
            }
            else
            {
                return
                false;
                
            }

        }




        public void PrintInfo()
        {
            Console.WriteLine("Title: {0} - koster {1} kr.",Titel,Pris);
        }
    }
}
