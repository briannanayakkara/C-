using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Furniture
    {
        protected string Model;
        protected string Color;

        public void SetModel(string Model)
        { this.Model = Model; }

        public string GetModel()
        { return Model; }

        public void SetColor(string Color)
        { this.Color = Color; }

        public string GetColor()
        { return Color; }

        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Model: {0}",Model);
            Console.WriteLine("Color: {0}",Color);
        }
    }
}
