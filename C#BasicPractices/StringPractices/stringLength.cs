using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractices
{
    public class stringLength
    {
        public void StringLengthMethod()
        {
            string input = "Hello World";
            int l = 0;
            foreach (char c in input)
            {
                l++;
            }
            Console.WriteLine(l);
        }
    }
}
