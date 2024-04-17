using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{

    public delegate void AddDel(int x, int y);
    public delegate string SayDel(string name);

    public class DelegateDemo
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public string SayHello(string name)
        {
            return "Hello" + name;
        }
    }
}
