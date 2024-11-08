using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 9, 4, 7, 1, 5, 8, 6, 3, -1, -5, 15, -3 };

            Console.WriteLine("Original list: ");
            PrintList(numbers);

            RemoveNegativeNumbers(numbers);
            Console.WriteLine("\nList after removing negative numbers: ");
            PrintList(numbers);

            BubbleSortDescending(numbers);

            Console.WriteLine("\nSorted list: ");
            PrintList(numbers);

            int sumOfMultiplesOfThree = SumOfMultiplesOfThree(numbers);
            Console.WriteLine($"\nSum of elements divisible by 3: {sumOfMultiplesOfThree}");
        }

        static void BubbleSortDescending(List<int> list)
        {
            int n = list.Count;
            for(int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (list[j] < list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }

        static void RemoveNegativeNumbers(List<int> list)
        {
            list.RemoveAll(x => x < 0);
        }

        static int SumOfMultiplesOfThree(List<int> list)
        {
            int sum = 0;
            foreach (var number in list)
            {
                if (number % 3 == 0)
                {
                    sum += number;
                }
            }
            return sum;
        }


        static void PrintList(List<int> list)
        {
            foreach (var number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
