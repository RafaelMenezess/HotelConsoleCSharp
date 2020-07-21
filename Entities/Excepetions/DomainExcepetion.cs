using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Entities.Excepetions
{
    class DomainExcepetion : ApplicationException
    {
        public DomainExcepetion(string message) : base (message)
        {

        }
    }
}
