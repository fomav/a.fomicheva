using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStep
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1----------------------------------------------------------------------- 
            Console.WriteLine("Введите кол-во чисел");
            int N = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int max = 0;
            int min = 1000;
            int cnt2 = 0;
            int exp = 1;

            Console.WriteLine("Введите положительные числа");
            for (int i = 0; i < N; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                sum = sum + a;
                //четные нечетные
                if (a % 2 == 0)
                {
                    cnt2 = cnt2 + 1;
                }
                else
                {
                    exp = exp * a;
                }

                if (a > max)
                {
                    max = a;
                }
                if (a <= min)
                {
                    min = a;
                }
            }
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Максимальное число: " + max);
            Console.WriteLine("Минимальное число: " + min);
            Console.WriteLine("Произведение нечетных чисел: " + exp);
            Console.WriteLine("Кол-во четных чисел: " + cnt2);
            Console.ReadLine();

            // Задание 2------------------------------------------------------------------
            Console.WriteLine("Введите длину массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            Array.Sort(numbers);
            Console.WriteLine("По возрастанию:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
            //Задание 3-----------------------------------------------------------------------
            Console.WriteLine("Введите m");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix1 = new int[m, m];
            int[,] matrix2 = new int[m, m];
            int[,] matrix3 = new int[m, m];
            Random rnd = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix1[i, j] = rnd.Next(0, 10);
                    matrix2[i, j] = rnd.Next(0, 10);
                }

            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    Console.Write(matrix1[i, j] + "   ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {

                    Console.Write(matrix2[i, j] + "   ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("сумма 2-х матриц:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.Write(matrix3[i, j] + "   ");
                }
                Console.Write("\n");

            }
            Console.ReadLine();

        }
    }
}
