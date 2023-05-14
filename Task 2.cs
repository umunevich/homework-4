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
                        int Lines, Columns, max, min;

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

            max = arr[0, 0];
            for (int i = 0; i < Lines; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                }
            }

            min = arr[0, 0];
            for (int i = 0; i < Lines; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                    }
                }
            }

            Console.WriteLine($"The summa of max {max} and min {min} is {max+min}");

            Console.ReadKey(false);
        }
    }
}
