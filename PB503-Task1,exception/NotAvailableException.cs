using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Task1_exception
{
    public class NotAvailableException : Exception
    {
        public NotAvailableException()
        {
            
        }
        public NotAvailableException(string message) : base(message)
        {

        }
    }
}
