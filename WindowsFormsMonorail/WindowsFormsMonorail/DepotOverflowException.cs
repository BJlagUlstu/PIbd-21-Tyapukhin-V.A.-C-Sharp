using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMonorail
{
    class DepotOverflowException : Exception
    {
        public DepotOverflowException() : base("В депо нет свободных мест")
        {

        }
    }
}