using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Telephone
    {
        private string cityCode;
        private string numberPhone;

        //Конструктор.
        public  Telephone(string cCode, string phNumber)
        {
            cityCode = cCode;
            numberPhone = phNumber;
        }

        public string CityCode
        {
            get
            {
                return cityCode;
            }
            set
            {
                cityCode = value;
            }
        }

        public string NumberPhone
        {
            get
            {
                return numberPhone;
            }
            set
            {
                numberPhone = value;
            }
        }
        public string transformNumber()
        {
            if ((cityCode == null) || (cityCode==""))
            {
                return numberPhone;
            }
            else return "(" + cityCode + ")" + numberPhone;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Telephone MyPhone = new Telephone("383","2665013");
            Console.WriteLine(MyPhone.transformNumber());
            Console.ReadLine();
            Console.WriteLine(MyPhone.CityCode);
            Console.WriteLine(MyPhone.NumberPhone);
            Console.ReadLine();
        }
    }
}
