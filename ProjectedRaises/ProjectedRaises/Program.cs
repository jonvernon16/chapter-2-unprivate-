using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedRaises
{
    class Program

    {
        static void Main(string[] args)
        {
            
            const double RAISE = 0.04;

            double employ1 = 45000;
            double employ2 = 51000;
            double employ3 = 60000;
            double employ1ProjRaise = employ1 * RAISE;
            double employ2ProjRaise = employ2 * RAISE;
            double employ3ProjRaise = employ3 * RAISE;
            Console.WriteLine("Employee 1 is currently earning $45,000,\n" +
            "but next year it will be raised to {0}", employ1ProjRaise + employ1);
            Console.WriteLine("Employee 2 is currently earning $51,000,\n" +
            "but next year it will be raised to {0}", employ2ProjRaise + employ2);
            Console.WriteLine("Employee 3 is currently earning $60,000,\n" +
            "but next year it will be raised to {0}", employ3ProjRaise + employ3);
            






        }
    }
}
