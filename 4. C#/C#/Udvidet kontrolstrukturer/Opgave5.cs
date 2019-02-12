using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            double pengePåKonto,r1,r2,r3;
            Console.WriteLine("hvor meget penge har du på din konto??");
            pengePåKonto = Convert.ToDouble(Console.ReadLine());

            r1 = (pengePåKonto * 0.025)+pengePåKonto;
            r2 = (pengePåKonto * 0.0125) + pengePåKonto;
            r3 = (150000 * 1.25 / 100) + (pengePåKonto - 150000) *0.5 / 100;
            if (pengePåKonto < 25000)
            {
                Console.WriteLine("du få 0,25% af {0}kr. det vill sige du få {1:n2}kr. after 1år ",pengePåKonto, r1);
            }
            if (pengePåKonto >= 25000  && pengePåKonto <= 150000)
            {
                Console.WriteLine("du få 1,25% af {0}kr. det vill sige du få {1:n2}kr. after 1år ", pengePåKonto, r2);
            }

            if (pengePåKonto > 150000 || 150000 <pengePåKonto)
            {
                Console.WriteLine("fås en rentesats på 1,25% af de første 150.000kr og 0,5% i rente af den del af beløbet som er over 150.000kr. det vill sige du få {0:n2}kr. after 1år ", r2);
            }
            Console.ReadKey();
           
        }
    }
}
