using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdstep
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1------------------------------------------------------
            Console.WriteLine("Введите длину массива:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[N];
            Random rnd = new Random();
            string answer = "Yes";
            for (int i = 0; i < N; i++)
            {
               array[i] = rnd.Next(0, 100);
                Console.WriteLine(array[i] + " ");     
                }
            Console.WriteLine("Введите число А:");
            int A = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                if (array[i] == A)
                {
                    answer = "Yes";
                    break;
                }
                answer = "No";

            }
            Console.WriteLine(answer);
            Console.ReadLine();
            //Задание 2-------------------------------------------------
            Console.WriteLine("Введите m");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            //Random rnd1 = new Random();
            int[,] matrix = new int[m, n];
            int min = 10000;
            int[] minarray = new int[m];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(1, 20);
                    if (matrix[i,j] <min)
                    {
                        min = matrix[i, j];
                    }
                }
                minarray[i] = min;
                min = 1000;
               // Console.Write(minarray[i] + " ");

            }
            Array.Sort(minarray);
            Array.Reverse(minarray);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");

                }
                Console.Write("\n");

            }
            Console.Write("Минимальные элементы массива:\n");
            for (int i=0;i<m;i++)
            {
                Console.WriteLine(minarray[i] + "  ");
            }
            Console.ReadLine();
        }
        }
    }