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
            int Lines, Columns, index, sum, MaxSum;

            Console.WriteLine("Enter the size of array: ");
            Console.Write("Number of lines - ");
            Lines = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of columns - ");
            Columns = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[Lines, Columns];
            Console.WriteLine($"Enter an array of {Lines*Columns} elements:");
            for (int i = 0; i < Lines; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            
            index = 0;
            MaxSum = 0;
            for (int j = 0; j < Columns; j++)
            {
                MaxSum += arr[0, j];
            }

            for (int i = 1; i < Lines; i++)
            {
                sum = 0;
                for (int j = 0; j < Columns; j++)
                {
                    sum += arr[i, j];
                }
                if (sum > MaxSum)
                {
                    MaxSum = sum;
                    index = i;
                }
            }

            for (int i = 0; i < Lines; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"The line of max summa of elements is {index+1}");

            Console.ReadKey(false);
        }
    }
}
