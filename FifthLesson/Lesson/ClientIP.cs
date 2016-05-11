using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class ClientIP: Client

    {
        private string fio;
        private DateTime dateOB;
        
        public string Fio
        {
            get { return fio; }
            set { fio = value; }
        }
        public DateTime DateOB
        {
            get { return dateOB; }
            set { dateOB = value; }
        }
        // Конструктор.
        public ClientIP(string _fio, DateTime _dateOB, float _orderPrice) :base(_orderPrice)
        {
            Fio = _fio;
            DateOB = _dateOB;
        }

    }
}
