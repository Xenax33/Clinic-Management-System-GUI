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
    class DoctorsDL
    {
        private static List<BL.DoctorBL> Doctors = new List<BL.DoctorBL>(); 

        public static void takeAppointment(BL.DoctorBL doctor)
        {
            for (int i = 0; i < Doctors.Count; i++)
            {
                if (doctor.Name == Doctors[i].Name && doctor.Salary == Doctors[i].Salary &&doctor.Fees == Doctors[i].Fees&& doctor.Timing == Doctors[i].Timing && doctor.Appointments == Doctors[i].Appointments)
                {
                    Doctors[i].Appointments++;
                }
            }
        }
        public static BL.DoctorBL returnDoctor(int number)
        {
            return Doctors[number];
        }
        public static void deleteDoctor(int number)
        {
            Doctors.Remove(Doctors[number]);
        }
        public static void writeDoctorsIntoFile()
        {
            string path = "Doctors.txt";
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < Doctors.Count; i++)
            {
                if (i > 0)
                {
                    file.WriteLine();
                }
                file.Write(Doctors[i].Name + "," + Doctors[i].Salary + "," + Doctors[i].Fees + "," +  Doctors[i].Appointments + "," + Doctors[i].Timing);
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
        public static void readDoctorsFromFile()
        {
            string name, timing;
            double fees, salary;
            int appointments;
            string record;
            string path = "Doctors.txt";
            StreamReader file = new StreamReader(path);
            while ((record = file.ReadLine()) != null)
            {
                name = parseData(record, 1);
                salary = double.Parse(parseData(record, 2));
                fees = double.Parse(parseData(record, 3));
                appointments = int.Parse(parseData(record, 4));
                timing = parseData(record, 5);
                BL.DoctorBL doctor = new BL.DoctorBL(name, timing, salary, fees, appointments);
                DL.DoctorsDL.addDoctor(doctor);
            }
            file.Close();
        }
        public static void addDoctor(BL.DoctorBL doctor)
        {
            Doctors.Add(doctor);
        }
        public static double getProfit()
        {
            double salaries=0F;
            for (int i = 0; i < Doctors.Count; i++)
            {
                salaries = salaries + (Doctors[i].Salary - (Doctors[i].Fees * Doctors[i].Appointments));
            }
            return salaries;
        }

        public static List<BL.DoctorBL> getDoctors()
        {
            Doctors = Doctors.OrderByDescending(o => o.Fees).ToList();
            return Doctors;
        }
    }
}
