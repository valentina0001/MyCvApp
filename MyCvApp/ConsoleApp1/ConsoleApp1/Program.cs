using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 23, -22, -765, 43, 545, -4, -55, 43, 12, 351, -999, -87 };

            int[] arrayPos = new int[array.Length];
            int[] arrayNeg = new int[array.Length];
            int? value = null;
           

            int arrayCount = 0;

            foreach (int i in array)
            {
                if (i >= 0)
                {
                    arrayPos[arrayCount++] = i;
                }
                else
                {
                    arrayNeg[arrayCount++] = i;
                }
            }

            Console.WriteLine("Positive array: ");
            foreach (int i in arrayPos)
            {
                if (i > 0)
                    Console.WriteLine(" " + i);
            }

            Console.WriteLine("\nNegative array: ");


            foreach (int i in arrayNeg)

            

                if (value.HasValue)
                    Console.Write(" " + i);
                
            

            else
            {

                Console.Write(" " + i);
            }
        }




    }
}

    



