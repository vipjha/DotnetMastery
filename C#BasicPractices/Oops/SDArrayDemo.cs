using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    // Arrays stores the data in the form of a row.
    public class SDArrayDemo
    {
        //The memory allocation of an array gets performed only with the use of "new" operator or assignment of values.
        public void SDArrayDemoMethod()
        {
            int[] arr = new int[6];
            for (int i = 0; i < 6; i++)
                Console.Write(arr[i]+"");
            Console.WriteLine();
            arr[0] = 10;
            arr[1] = 20;
            arr[2] = 30;
            arr[3] = 40;
            arr[4] = 50;
            arr[5] = 60;

            foreach (int i in arr) 
                Console.Write(i+" ");
        }
    }
}
