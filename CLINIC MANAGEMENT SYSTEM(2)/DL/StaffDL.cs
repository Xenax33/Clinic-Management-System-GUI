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
    class StaffDL
    {
        private static List<BL.Staff> staff = new List<BL.Staff>();

        public static void deleteStaff(BL.Staff staffs)
        {
            for (int i = 0; i < staff.Count; i++)
            {
                if (staffs.Name == staff[i].Name && staffs.Salary == staff[i].Salary && staffs.Role == staff[i].Role)
                {
                    staff.Remove(staff[i]);
                }
            }
        }
        public static void addStaff(BL.Staff staffs)
        {
            staff.Add(staffs);
        }
        public static void putStaffIntoFile()
        {
            string path = "Staff.txt";
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < staff.Count; i++)
            {
                if (i > 0)
                {
                    file.WriteLine();
                }
                file.Write("{0},{1},{2}", staff[i].Name, staff[i].Salary, staff[i].Role);
            }
            file.Flush();
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
        public static void readStaffFromFile()
        {
            string name, role;
            double salary = 0F;
            string record;
            string path = "Staff.txt";
            StreamReader file = new StreamReader(path);
            while ((record = file.ReadLine()) != null)
            {
                name = parseData(record, 1);
                salary = double.Parse(parseData(record, 2));
                role = parseData(record, 3);
                BL.Staff staffs = new BL.Staff(name, salary, role);
                staff.Add(staffs);
            }
            file.Close();
        }
        public static List<BL.Staff> getNurses()
        {
            List<BL.Staff> staffs = new List<BL.Staff>();
            for (int i = 0; i < staff.Count; i++)
            {
                if (staff[i].Role == "Nurse")
                {
                    staffs.Add(staff[i]);
                }
            }
            return staffs;
        }

        public static List<BL.Staff> getCleaners()
        {
            List<BL.Staff> staffs = new List<BL.Staff>();
            for (int i = 0; i < staff.Count; i++)
            {
                if (staff[i].Role == "Cleaner")
                {
                    staffs.Add(staff[i]);
                }
            }
            return staffs;
        }
        public static List<BL.Staff> getStaff()
        {
            staff = staff.OrderByDescending(o => o.Salary).ToList();
            return staff;
        }
        public static double getSalaries()
        {
            double salaries=0F;
            for (int i = 0; i < staff.Count; i++)
            {
                salaries = salaries + staff[i].Salary;
            }
            return salaries;
        }
    }
}
