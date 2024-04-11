using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class ReemoveStringInList
    {
        public void ReemoveStringInListMethod(string nameToRemove) 
        {
            List<string> nameList = new List<string>();
            nameList.Add("Raj");
            nameList.Add("Amit");
            nameList.Add("Raj");
            nameList.Add("Koyal");
            nameList.Add("Raj");
            nameList.RemoveAll(n => n == nameToRemove);
            Console.WriteLine("List after removing" + nameToRemove + ":");
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }

        }
    }
}
