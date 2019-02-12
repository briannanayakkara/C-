using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Computer : Furniture
    {

        private double Year;

        public void SetYear(double Year)
        {
            this.Year = Year;
        }

        public double GetYear()
        {
            return Year;
        }


        public void PrintInfo()
        {
            
            Console.WriteLine("Computer1");
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Year: {0}", Year);
        }
    }
}
