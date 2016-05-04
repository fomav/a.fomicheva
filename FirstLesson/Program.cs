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
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();
            int valueint1;
            int valueint2;

            bool resultvalue1 = Int32.TryParse(value1, out valueint1);
            bool resultvalue2 = Int32.TryParse(value2, out valueint2);
            if ((resultvalue1 == false) || (resultvalue2 == false))
            {
                Console.WriteLine("Неправильный тип введенных данных");

            }
            else
            {
                int value3 = Convert.ToInt32(value1) + Convert.ToInt32(value2);
                Console.WriteLine("Сумма: " + value3);
            }
            
            Console.WriteLine("2-е задание, введите i и n");
            string stri = Console.ReadLine();
            string strn = Console.ReadLine();
            int n;
            int i;
            bool resulti = Int32.TryParse(stri, out i);
            bool resultn = Int32.TryParse(strn, out n);

            if ((resulti == false) || (resultn == false))
             {
                Console.WriteLine("Неправильный тип введенных данных");

             }
             else
              {
                int shiftn = n << i;
                int ibit = shiftn & 1;
                Console.WriteLine("i-ый бит числа n " + ibit);
            }

            Console.WriteLine("3-е задание, введите число");
            string value = Console.ReadLine();
            int valueint;
            int zerobit;
            bool result = Int32.TryParse(value, out valueint);
            if (result == false)
             {
                Console.WriteLine("Неправильный тип введенных данных");
               
             }
            else
             {
                zerobit = valueint & 1022;
                Console.WriteLine("Если обнулить последний бит, то получится " + zerobit);
                Console.ReadLine();
             }

        }
    }
}
