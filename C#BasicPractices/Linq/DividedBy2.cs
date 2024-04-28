using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class DividedBy2
    {
        public void DividedBy2Met()
        {
            int[] intArray = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var nQuery = intArray.Where(x=>x%2==0);
            
            Console.WriteLine("\nThe numbers which produce the remainder 0 after divided by 2 are : \n");
            foreach(var n in nQuery)
            {
                Console.Write("{0}", n);
                Console.Write("\n");
            }
        }
    }
}
