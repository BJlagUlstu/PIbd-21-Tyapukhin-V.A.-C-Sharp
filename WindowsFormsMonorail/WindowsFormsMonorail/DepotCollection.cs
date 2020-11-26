using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsMonorail
{
    class DepotCollection
    {
        readonly Dictionary<string, Depot<Vehicle>> depotStages;

        public List<string> Keys => depotStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

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

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            using (StreamWriter sw = new StreamWriter(filename, false))
            {
                sw.WriteLine($"DepotCollection", sw);
                foreach (var level in depotStages)
                {
                    sw.WriteLine($"Depot{separator}{level.Key}", sw);

                    ITransport train;

                    for (int i = 0; (train = level.Value.GetNext(i)) != null; i++)
                    {
                        if (train != null)
                        {
                            if (train.GetType().Name == "Train")
                            {
                                sw.Write($"Train{separator}", sw);
                            }
                            if (train.GetType().Name == "Monorail")
                            {
                                sw.Write($"Monorail{separator}", sw);
                            }
                            sw.Write(train + sw.NewLine, sw);
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }

            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                if ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("DepotCollection"))
                    {
                        depotStages.Clear();
                    }
                    else
                    {
                        return false;
                    }

                    Vehicle train = null;

                    string key = string.Empty;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("Depot"))
                        {
                            key = line.Split(separator)[1];
                            depotStages.Add(key, new Depot<Vehicle>
                            (pictureWidth, pictureHeight));
                            continue;
                        }
                        if (string.IsNullOrEmpty(line))
                        {
                            continue;
                        }
                        if (line.Split(separator)[0] == "Train")
                        {
                            train = new Train(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Monorail")
                        {
                            train = new Monorail(line.Split(separator)[1]);
                        }

                        var result = depotStages[key] + train;
                        if (!result)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}