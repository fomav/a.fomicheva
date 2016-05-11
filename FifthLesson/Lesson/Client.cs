using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Client
    {
        protected int id;
        protected int phoneNumber;
        protected float orderPrice;

        // Свойство.
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        // Свойство.
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        // Свойство.
        public float OrderPrice
        {
            get { return orderPrice; }
            set { orderPrice = value; }
        }
        // Метод.
        public void priceFormate(float orderPrice)
        {
            Console.WriteLine(String.Format("Сумма заказа {0:C2}.", orderPrice));

        }
        // Конструктор.
        public Client(int _id, int _phoneNumber, float _orderPrice)
        {
            Id = _id;
            PhoneNumber = _phoneNumber;
            OrderPrice = _orderPrice;
        }
        // Конструктор.
        public Client(float _orderPrice)
        {
            OrderPrice = _orderPrice;
        }


    }
}
