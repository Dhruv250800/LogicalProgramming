using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograming
{
    internal class PerfectNumberChecker
    {
        public static bool IsPerfectNumber(int number)
        {
            int sumOfDivisors = CalculateSumOfDivisors(number);
            return sumOfDivisors == number;
        }

        private static int CalculateSumOfDivisors(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            return sum;
        }
    }
}
