using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfEggsProd = 26;
            int numOfChickens = 4;
            int sumOfEggs = numOfEggsProd * numOfChickens;
            int totalDozen = sumOfEggs % 12;
            int totalDozenEgg = sumOfEggs / 12;

            Console.WriteLine("The total number of eggs is {0} dozen with {1} eggs to spare.", totalDozen, totalDozenEgg);

        }
    }
}
