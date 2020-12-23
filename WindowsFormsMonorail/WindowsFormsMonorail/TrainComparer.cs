using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMonorail
{
    class TrainComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Monorail && y is Train)
            {
                return -1;

            }
            if (x is Train && y is Monorail)
            {
                return 1;

            }
            if (x is Monorail && y is Monorail)
            {
                return ComparerMonorail((Monorail)x, (Monorail)y);
            }
            if (x is Train && y is Train)
            {
                return ComparerTrain((Train)x, (Train)y);
            }

            return 0;
        }

        private int ComparerTrain(Train x, Train y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerMonorail(Monorail x, Monorail y)
        {
            var res = ComparerTrain(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Headlights != y.Headlights)
            {
                return x.Headlights.CompareTo(y.Headlights);
            }
            if (x.Bottom_monorail != y.Bottom_monorail)
            {
                return x.Bottom_monorail.CompareTo(y.Bottom_monorail);
            }
            if (x.SportLine != y.SportLine)
            {
                return x.SportLine.CompareTo(y.SportLine);
            }
            return 0;
        }
    }
}
