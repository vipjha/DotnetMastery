using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProject
{
    public class ReadAndPrintElementsArray
    {
        public void ReadAndPrintElementsArr() 
        { 
            int[] arr = new int[10];
            int i;//Declare of loop  varible 'i'

            Console.WriteLine("Input 10 elements in the array :\n");

            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);  // Prompt for input element number
                arr[i] = Convert.ToInt32(Console.ReadLine());  // Read user input and convert it to an integer, then store in the array
            }
            Console.Write("\nElements in array are: ");  // Display message before printing array elements

            // Loop to print the elements of the array
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);  // Print each element of the array
            }
            Console.Write("\n");  // Move to the next line for better readability
        }
    }
}
