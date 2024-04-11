using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class PrimeNumber
    {
        public void PrintPrimeNumber(int startNumber, int endNumber)
        {
            for (int number = startNumber; number <= endNumber; number++)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine(number);
                }
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            if (number == 2 || number == 3)
            {
                return true;
            }
            if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }

            int i = 5;
            int w = 2;
            while (i * i <= number) // 25*25 <= 50
            {
                if (number % i == 0) // 50
                {

                    return false;
                }
                i += w;
                w = 6 - w;
            }
            return true;
        }
    }
}
