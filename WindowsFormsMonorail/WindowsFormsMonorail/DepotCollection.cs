using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMonorail
{
    class DepotCollection
    {
        readonly Dictionary<string, Depot<Vehicle>> depotStages;

        public List<string> Keys => depotStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        public DepotCollection(int pictureWidth, int pictureHeight)
        {
            depotStages = new Dictionary<string, Depot<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddDepot(string name)
        {
            if (depotStages.ContainsKey(name))
            {
                return;
            }
            depotStages.Add(name, new Depot<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelDepot(string name)
        {
            if (depotStages.ContainsKey(name))
            {
                depotStages.Remove(name);
            }
        }

        public Depot<Vehicle> this[string index]
        {
            get
            {
                if (depotStages.ContainsKey(index))
                {
                    return depotStages[index];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
