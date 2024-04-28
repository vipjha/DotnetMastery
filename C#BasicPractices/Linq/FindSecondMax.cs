using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class FindSecondMax
    {
        public int FindSecondMaxMethod(ArrayList list) 
        {
            int valueToSkip = 1;
            int secondMax = list.Cast<int>().OrderByDescending(x=>x).Skip(valueToSkip).FirstOrDefault();
            return secondMax;
        }

        
    }
}
