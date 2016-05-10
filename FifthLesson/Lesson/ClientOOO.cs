using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class clientOOO : client
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
        public clientOOO(string name,float orderPrice) 
            {
            Console.WriteLine(String.Format("ООО {0}:", name));
            client.cl

        }
         

    }
}
