using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class IfDemo
    {
        public void IfDemoMethod()
        {
            int x, y;
            Console.Write("Enter x value:");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter y value:");
            y = int.Parse(Console.ReadLine());
            if (x > y)
                Console.WriteLine("X is greater");
            else if (y > x)
                Console.WriteLine("Y is greater");
            else Console.WriteLine("Both are equal");
        }
    }
}
