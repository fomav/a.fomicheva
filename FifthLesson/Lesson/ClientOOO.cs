using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class ClientOOO : Client
    {
        private string name;
        private string bankAccount;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string BankAccount
        {
            get { return name; }
            set { name = value; }
        }

        // Конструктор.
        public ClientOOO (string _name,string _bankAccount,float _orderPrice) :base(_orderPrice)
        {
            Name = _name;
            BankAccount = _bankAccount;
        }
         

    }
}
