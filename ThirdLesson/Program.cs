using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-е задание, введите числo");
            Console.WriteLine(ReadInt());
            Console.ReadLine();
        }

        private static int ReadInt()
        {
            int a;

            if (Int32.TryParse(Console.ReadLine(), out a))
            {
                return a;
            }
            return 0;

        }

    }
}
