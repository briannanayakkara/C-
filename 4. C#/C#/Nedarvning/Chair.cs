using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Chair : Furniture
    {
        private double Cost;

        public void SetCost(double Cost)
        {
            this.Cost = Cost;
        }

        public double GetCost ()
        {
            return Cost;
        }
            

        public void PrintInfo()
        {
            Console.WriteLine("Chair1");
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("It cost {0}kr.",Cost);
        }
    }
}
