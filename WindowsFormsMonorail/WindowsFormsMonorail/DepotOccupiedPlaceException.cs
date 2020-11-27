using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMonorail
{
    class DepotOccupiedPlaceException : Exception
    {
        public DepotOccupiedPlaceException() : base("Не удалось загрузить поезд в депо")
        {

        }
    }
}
