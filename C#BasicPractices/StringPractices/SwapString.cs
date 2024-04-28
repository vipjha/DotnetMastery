using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPractices
{
    public class SwapString
    {
        public void SwapStringMethod()
        {
            string x = "Hello";
            string y = "World";
            Console.WriteLine($"Before swapping: x = {x}, y = {y}");
            x = String.Concat(x, y); // HelloWorld
            y = x.Substring(0, x.Length - y.Length);//10-5 // 
            x = x.Substring(y.Length);
            Console.WriteLine($"Before swapping: x = {x}, y = {y}");
        }
    }
}
