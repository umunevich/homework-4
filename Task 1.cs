using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size, sum, count;

            Console.Write("Enter the size of array: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter an array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            sum = 0;
            foreach (int el in arr)
            {
                if (el > 0)
                {
                    sum += el;
                }
            }

            count = 0;
            foreach (int el in arr)
            {
                if (el%2 ==0)
                {
                    count++;
                }
            }

            Console.WriteLine($"The summa of positive numbers is {sum}");
            Console.WriteLine($"The number of even numbers is {count}");
            Console.ReadKey(false);
        }
    }
}
