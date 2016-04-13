using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStep
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("1-е задание, введите 2 числа");
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            int c = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine("Сумма: "+c);

            Console.WriteLine("2-е задание, введите i и n");
            string I = Console.ReadLine();
            string N = Console.ReadLine();
            int i = Convert.ToInt32(I);
            int n = Convert.ToInt32(N);
            int cc = n << i;
            int ccc = cc & 1;
            Console.WriteLine("i-ый бит числа n "+ccc);

            Console.WriteLine("3-е задание, введите число");
            string K = Console.ReadLine();
            int k = Convert.ToInt32(K);
            int kk = k & 1022;
            Console.WriteLine("Если обнулить последний бит, то получится "+kk);

        }
    }
}
