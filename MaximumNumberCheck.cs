using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProblem
{
    class MaximumNumberCheck
    {
        public static int maximumIntegerNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) > 0)
            {
                return secondValue;
            }
            else
            {
                return thirdValue;
            }

        }
        public static double maximumFloateNumber(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            else if (secondValue.CompareTo(thirdValue) > 0 && secondValue.CompareTo(firstValue) > 0)
            {
                return secondValue;
            }
            else
            {
                return thirdValue;
            }
        }

    }
}