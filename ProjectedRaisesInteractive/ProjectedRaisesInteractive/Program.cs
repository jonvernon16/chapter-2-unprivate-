using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectedRaisesInteractive
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

            double userSal;

            Console.Write("Put in your salary >>> ");
            userSal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("This is your raised salary >>> " + (userSal * RAISE + userSal));
        }
    }
}
