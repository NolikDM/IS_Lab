using System;
using System.Collections.Generic;
using System.IO;

namespace lab_1
{
    class DBLoader
    {
        private readonly static string DATABASE_FILENAME = "DataBase.txt";
        StreamReader reader = File.OpenText(DATABASE_FILENAME);
        List<Car> DB = new List<Car>();
        public void load()
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] items = line.Split('\t');
                String name = items[0];
                name = name.Replace("\"", "");
                long price = Convert.ToInt64(items[1]);
                int year = Convert.ToInt32(items[2]);
                string transmission = items[3];
                string drive = items[4];
                string raw_color = items[5];
                string auto_class = items[6];
                Color color = Color.Any;
                switch (raw_color)
                {
                    case "Black":
                        color = Color.Black;
                        break;
                    case "White":
                        color = Color.White;
                        break;
                    case "Blue":
                        color = Color.Blue;
                        break;
                    case "Green":
                        color = Color.Green;
                        break;
                    case "Red":
                        color = Color.Red;
                        break;
                    case "Grey":
                        color = Color.Grey;
                        break;
                    case "Yellow":
                        color = Color.Yellow;
                        break;
                    case "Orange":
                        color = Color.Orange;
                        break;
                }
                DB.Add(new Car(name, price, year, transmission, drive, color, auto_class));
            }
        }
        public List<Car> GetDB()
        {
            return DB;
        }
    }
}
