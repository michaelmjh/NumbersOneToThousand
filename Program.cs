using System;

namespace NumbersOneToThousand
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] singleDigits = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] teens = new string[] {  };
            string[] tens = new string[] {"zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };


            for (int x = 0; x <= 1000; x++)
            {
                int remainingToDeduct = x;
                int hundredsCounter = 0;
                int tensCounter = 0;
                bool andUsed = false;

                if (remainingToDeduct > 999)
                {
                    Console.WriteLine($"{singleDigits[remainingToDeduct/1000]} thousand");
                    remainingToDeduct -= 1000;
                }

                if (remainingToDeduct > 99)
                {
                    while (remainingToDeduct > 99)
                    {
                        remainingToDeduct -= 100;
                        hundredsCounter += 1;
                    }

                    Console.Write($"{singleDigits[hundredsCounter]} hundred ");
                }

                if (remainingToDeduct > 19)
                {
                    while (remainingToDeduct > 9)
                    {
                        remainingToDeduct -= 10;
                        tensCounter += 1;
                    }
                    Console.Write($"{tens[tensCounter]} ");
                }

           
                if (remainingToDeduct > 0)
                {
                    Console.Write($"{singleDigits[remainingToDeduct]}");
                    remainingToDeduct -= 1;
                }

                Console.WriteLine();
                
            }
        }

    }
}
