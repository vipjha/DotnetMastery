using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class FrequencyOfNumber
    {
        public void FrequencyOfNumberMethod()
        {
            // Define an integer array
            int[] arr1 = { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            Console.Write("\nLINQ : Display the number and frequency of number from given array : \n");

            var query = from num in arr1 group num by num into newNum select newNum;

            foreach (var item in query)
            {
                Console.WriteLine("Number " + item.Key + "appears " + item.Count() + "times");
                Console.Write("\n");
            }
        }
    }
}
