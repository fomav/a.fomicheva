using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("введите целое числo");
            Console.WriteLine(GetInt());
            Console.ReadLine();

            Console.WriteLine("введите дробное числo");
            Console.WriteLine(GetDouble());
            Console.ReadLine();

            int outNumber = 23;
            OutputInt(outNumber);

            Console.WriteLine("Введите m");
            Console.WriteLine("Введите n");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[m, n];
            Random rnd = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);

                }

            }
            OutputMatrix( matrix, m, n);

        }




        // Считывает целое число.
        private static int GetInt()
        {
            int number;

            if (Int32.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            return 0;
        }
        // Считывает дробное число.
        private static double GetDouble()
        {
            double number;

            if (Double.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            return 0;
        }

        //Выводит целое число.
        private static void OutputInt(int outNumber)
        {
            Console.WriteLine(string.Format("number = {0}", outNumber));
        }

        //Выводит дробное число.
        private static void OutputDouble(double outNumber)
        {
            Console.WriteLine($"number= {outNumber}");
        }
        //Выводит матрицу.
        private static void OutputMatrix(int[,] matrix, int m, int n)
        {
            for (int i = 0; i < m; i++)
             {
                for (int j = 0; j < n; j++)
               
                    {
                        Console.Write($"{matrix[i, j]} ");
                    }
                    Console.WriteLine(Environment.NewLine);
            }
            Console.ReadLine();
        }
    }
}
