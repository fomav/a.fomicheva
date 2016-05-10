using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class client
    {
        protected int id;
        protected int phoneNumber;
        protected float orderPrice;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public float OrderPrice
        {
            get { return orderPrice; }
            set { orderPrice = value; }
        }

        public client (float orderPrice) 
            {
            Console.WriteLine(String.Format("Сумма заказа {0:C2}.", orderPrice));
        }


    }
}
