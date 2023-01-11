using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
            Console.ReadLine();
        }
    }

    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        {
            int nrPositives = 0, nrNegatives = 0, nrZeros = 0;
            foreach (var item in arr)
            {
                if (item < 0)
                {
                    nrNegatives++;
                    continue;
                }
                if (item > 0)
                {
                    nrPositives++;                    
                }
                else
                {
                    nrZeros++;
                }
            }
            double resultPositives = Convert.ToDouble( nrPositives ) / Convert.ToDouble( arr.Count );
            double resultNegatives = Convert.ToDouble( nrNegatives ) / Convert.ToDouble( arr.Count );
            double resultZeros = Convert.ToDouble(nrZeros) / Convert.ToDouble(arr.Count);

            Console.WriteLine(resultPositives.ToString("0.000000"));
            Console.WriteLine(resultNegatives.ToString("0.000000"));
            Console.WriteLine(resultZeros.ToString("0.000000"));
        }

    }
}
