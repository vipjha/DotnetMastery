using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    //Using a break statement after a case block is optional in our tredional laguage. ex c, c++, where as in case of c# language it is mendatory to use break after every case, even aftere default block also.
    public class SwitchCaseDemo
    {
        public void SwitchCaseDemoMethod()
        {
            Console.Write("Enter a student no (1-3):");
            int sno = int.Parse(Console.ReadLine());
            switch (sno)
            {
                case 1:
                    Console.WriteLine("Student 1");
                    break;

                case 2:
                    Console.WriteLine("Student 2");
                    break;

                case 3:
                    Console.WriteLine("Student 3");
                    break;
                default:
                    Console.WriteLine("Invalid student no:");
                    break;

            }
        }
    }
}
