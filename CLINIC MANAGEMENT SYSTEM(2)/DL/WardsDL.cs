using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace CLINIC_MANAGEMENT_SYSTEM_2_.DL
{
    class WardsDL
    {
        private static List<BL.WardBL> wards = new List<BL.WardBL>();

        public static void applyForTreatment(BL.WardBL ward)
        {
            for (int i = 0; i < wards.Count; i++)
            {
                if (ward.Cost == wards[i].Cost && ward.Expenses == wards[i].Expenses && ward.Name == wards[i].Name && ward.Rooms == wards[i].Rooms && ward.Performed == wards[i].Performed)
                {
                    wards[i].Performed++;
                    wards[i].Rooms--;
                }
            }
        }
        public static void deleteWard(int num)
        {
            wards.Remove(wards[num]);
        }
        public static void addWard(BL.WardBL ward)
        {
            wards.Add(ward);
        }
        public static void putWardsIntoFile()
        {
            string path = "Wards.txt";
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < wards.Count; i++)
            {
                if (i>0)
                {
                    file.WriteLine();
                }
                file.Write(wards[i].Name + "," + wards[i].Cost + "," + wards[i].Expenses + "," + wards[i].Rooms + "," + wards[i].Performed);
            }
            file.Flush();
            file.Close();
        }
        public static void readWardsFromFile()
        {
            string path = "Wards.txt";
            string record;
            string name;
            double cost , expenses;
            int rooms, performed;
            StreamReader file = new StreamReader(path);
            while ((record = file.ReadLine()) != null)
            {
                name = parseData(record, 1);
                cost = double.Parse(parseData(record, 2));
                expenses = double.Parse(parseData(record, 3));
                rooms = int.Parse(parseData(record, 4));
                performed = int.Parse(parseData(record, 5));
                BL.WardBL ward = new BL.WardBL(name, performed, rooms, cost, expenses);
                wards.Add(ward);
            }
            file.Close();
        }

        public static string parseData(string data, int field)
        {
            int comma = 1;
            string item = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + data[i];
                }
            }
            return item;
        }
        public static double getProfit()
        {
            double profit = 0;
            for (int i = 0; i < wards.Count; i++)
            {
                profit = profit + ((wards[i].Cost - wards[i].Expenses) * wards[i].Performed);
            }
            return profit;
        }

        public static List<BL.WardBL> GetWards()
        {
            wards = wards.OrderByDescending(o => o.Cost).ToList();
            return wards;
        }
    }
}
