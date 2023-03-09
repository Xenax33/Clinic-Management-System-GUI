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
    class ManagersDL
    {
        private static List<BL.Managers> managers = new List<BL.Managers>();

        public static void deleteManager(int num)
        {
            managers.Remove(managers[num]);
        }
        public static List<BL.Managers> getManagers()
        {
            managers = managers.OrderByDescending(o => o.Salary).ToList();
            return managers;
        }
        public static void PutManagersIntoFile()
        {
            string path = "Managers.txt";
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < managers.Count; i++)
            {
                if (i>0)
                {
                    file.WriteLine();
                }
                file.Write(managers[i].Username + "," + managers[i].Password + "," + managers[i].Name + "," + managers[i].Salary);

            }
            file.Close();
        }

        public static void ReadManagersFromFile()
        {
            string path = "Managers.txt";
            string record;
            string username, password, role, name;
            double salary;
            StreamReader file = new StreamReader(path);
            while ((record = file.ReadLine()) != null)
            {
                username = parseData(record, 1);
                password = parseData(record, 2);
                name = parseData(record, 3);
                salary = double.Parse(parseData(record, 4));
                BL.Managers manager = new BL.Managers(name , salary , username , password);
                managers.Add(manager);
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

        public static bool checkManager(string username , string password)
        {
            bool flag = false;
            for (int i = 0; i < managers.Count; i++)
            {
                if (username == managers[i].Username && password == managers[i].Password)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public static double getSalaries()
        {
            double salaries = 0F;
            for (int i = 0; i < managers.Count; i++)
            {
                salaries = salaries + managers[i].Salary;
            }
            return salaries;
        }

        public static void AddManager(BL.Managers manager)
        {
            managers.Add(manager);
        }
    }
}
