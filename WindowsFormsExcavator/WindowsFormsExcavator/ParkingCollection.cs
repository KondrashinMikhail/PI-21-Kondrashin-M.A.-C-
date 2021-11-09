using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExcavator
{
    class ParkingCollection
    {
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;

        public List<string> Keys => parkingStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }

            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        public Parking<Vehicle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }


        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write($"ParkingCollection{Environment.NewLine}", fs);
                    foreach (var level in parkingStages)
                    {
                        sw.Write($"Parking{separator}{level.Key}{Environment.NewLine}", fs);
                        ITransport excavator = null;
                        for (int i = 0; (excavator = level.Value.GetNext(i)) != null; i++)
                        {
                            if (excavator != null)
                            {
                                if (excavator.GetType().Name == "Excavator")
                                {
                                    sw.Write($"Excavator{separator}", fs);
                                }
                                if (excavator.GetType().Name == "BucketExcavator")
                                {
                                    sw.Write($"BucketExcavator{separator}", fs);
                                }
                                sw.Write(excavator + Environment.NewLine, fs);
                            }
                        }
                    }
                }
            }
            return true;
        }
        public bool LoadData(string filename)
        {
            if (File.Exists(filename))
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line;
                    string bufStr = "";
                    bool check = false;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("ParkingCollection"))
                        {
                            parkingStages.Clear();
                            check = true;
                            continue;
                        }

                        if (check)
                        {
                            Vehicle excavator = null;

                            if (line.Contains("Parking:"))
                            {
                                bufStr = line.Split(separator)[1];
                                parkingStages.Add(line.Split(separator)[1], new Parking<Vehicle>(pictureWidth, pictureHeight));
                            }
                            if (line.Split(separator)[0] == "Excavator")
                            {
                                excavator = new Excavator(line.Split(separator)[1]);
                                if (bufStr != "")
                                {
                                    var result = parkingStages[bufStr] + excavator;
                                }
                            }
                            else if (line.Split(separator)[0] == "BucketExcavator")
                            {
                                excavator = new BucketExcavator(line.Split(separator)[1]);
                                if (bufStr != "")
                                {
                                    var result = parkingStages[bufStr] + excavator;
                                }
                            }
                        }
                    }
                    if (!check || bufStr == "")
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
