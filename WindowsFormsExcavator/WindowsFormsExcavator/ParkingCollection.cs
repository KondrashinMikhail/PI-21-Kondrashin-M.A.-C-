using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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

        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                WriteToFile($"ParkingCollection{Environment.NewLine}", fs);
                foreach (var level in parkingStages)
                {
                    WriteToFile($"Parking{separator}{level.Key}{Environment.NewLine}",
                    fs);
                    ITransport excavator = null;
                    for (int i = 0; (excavator = level.Value.GetNext(i)) != null; i++)
                    {
                        if (excavator.GetType().Name == "Excavator")
                        {
                            WriteToFile($"Excavator{separator}", fs);
                        }
                        if (excavator.GetType().Name == "BucketExcavator")
                        {
                            WriteToFile($"BucketExcavator{separator}", fs);
                        }
                        WriteToFile(excavator + Environment.NewLine, fs);
                    }
                }
            }
        }
       
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                byte[] b = new byte[fs.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("ParkingCollection"))
            {
                parkingStages.Clear();
            }
            else
            {
                throw new FileFormatException("Неверный формат файла");
            }
            Vehicle excavator = null;
            string key = string.Empty;
            for (int i = 1; i < strs.Length; ++i)
            {
                if (strs[i].Contains("Parking"))
                {
                    key = strs[i].Split(separator)[1];
                    parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(separator)[0] == "Car")
                {
                    excavator = new Excavator(strs[i].Split(separator)[1]);
                }
                else if (strs[i].Split(separator)[0] == "SportCar")
                {
                    excavator = new BucketExcavator(strs[i].Split(separator)[1]);
                }
                if (!(parkingStages[key] + excavator))
                {
                    throw new FileLoadException("Не удалось загрузить автомобиль на парковку");
                }
            }tually done seventh lab
        }
    }
}
