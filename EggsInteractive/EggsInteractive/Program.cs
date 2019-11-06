using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggsInteractive
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfChicken = 4;
            int userNumOfEggs;


            Console.Write("How many eggs has your 1 of your chickens laid? >>> ");
            userNumOfEggs = Convert.ToInt32(Console.ReadLine());

            int sumOfEggs = numOfChicken * userNumOfEggs;
            int sumOfEggsDozen = sumOfEggs % 12;
            int eggsRemaining = sumOfEggs / 12;

            Console.WriteLine("Your chicken has laid {0} dozen and {1} eggs", sumOfEggsDozen, eggsRemaining);


        }
    }
}
