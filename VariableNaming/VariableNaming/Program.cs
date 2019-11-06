using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 15;
            int resultAdd = num1 + num2;
            int resultMinus = num1 - num2;
            int resultDivide = num2 / num1;
            int resultMultiply = num1 * num2;
            int resultModulus = num2 % num1;

            Console.WriteLine("The result of ${0} + ${1} is equal to ${2}", num1, num2, resultAdd);
            Console.WriteLine("The result of ${1} - ${0} is equal to ${2}", num1, num2, resultMinus);
            Console.WriteLine("The result of ${1} / ${0} is equal to ${2}", num1, num2, resultDivide);
            Console.WriteLine("The result of ${1} * ${0} is equal to ${2}", num1, num2, resultMultiply);
            Console.WriteLine("The result of ${1} % ${0} is equal to ${2}", num1, num2, resultModulus);

        }
    }
}
