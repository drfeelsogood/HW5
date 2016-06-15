using System;
using System.Linq;

namespace ca5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            int number = 0;
            int x = 0;
            int factorial = 1;
            int maxNumber;
            Random rnd = new Random();

            do
            {
                number = rnd.Next(11);
                if (Array.IndexOf(myArray, number) == -1)
                {
                    myArray[x] = number;
                    Console.WriteLine(myArray[x]);
                    x++;
                }
            } while (x < 10);

            maxNumber = myArray.Max();

            for (int i = 1; i < maxNumber + 1; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Max number is: " + maxNumber);
            Console.WriteLine("Max number's factorial is: " + factorial);

            Console.ReadKey();
        }
    }
}
