using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNewtonMethodTask1
{
    public static class NewtonMethod
    {
        /// <summary>
        /// Method calculating root of the n-th degree from double value with accuracy
        /// </summary>
        /// <param name="value">value to the calculate</param>
        /// <param name="power">degree to the calculate</param>
        /// <param name="accuracy">accurancy to the check</param>
        /// <returns></returns>
        public static double RootCalculation(double value, double power, double accuracy)
        {
            if (power == 0)
            {
              throw new ArgumentException("Attempting to extract the root of zero degree");
            }
            if (value == 0) return 0;
            else
                if (power % 2 == 0 && value < 0)
                {
                    throw new ArgumentException("The attempt to extract an even root of a negative number");
                }

            double startValueX0 = 1;
            double squareRoot = (1 / power) * ((power - 1) * startValueX0 + (value / Math.Pow(startValueX0, power - 1)));

            double temp;
            do
            {
                temp = squareRoot;
                squareRoot = (1 / power) * ((power - 1) * squareRoot + (value / Math.Pow(squareRoot, power - 1)));
            } while (Math.Abs(temp - squareRoot) > accuracy);
            return squareRoot;
        }
    }
}
