using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class PostiveNumbList
    {
        public void PostiveNumbListMeth()
        {
            int[] n1 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14};
            Console.Write("\nThe numbers within the range of 1 to 11 are : \n");
            var query = n1.Where(x=>x>0).OrderByDescending(x=>x);
            foreach (int i in query) 
            {
                Console.Write(i);
                Console.Write("\n");
            }
        }
    }
}
