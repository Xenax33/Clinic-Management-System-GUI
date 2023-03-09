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
    class MUsersDL
    {
        private static List<BL.MUserBL> Users = new List<BL.MUserBL>();

        public static int getPatientNumber(BL.MUserBL mUser)
        {
            int idx = 0;
            for (int i = 0; i < Users.Count; i++)
            {
                if (mUser.Username == Users[i].Username && mUser.Password == Users[i].Password)
                {
                    idx = i;
                }
            }
            return idx;
        }

        public static void UpdatePatient(int num , string username , string password)
        {
            Users[num].Username = username;
            Users[num].Password = password;
        }
        public static void deletePatient(int num)
        {
            Users.Remove(Users[num + 1]);
        }
        public static void ChangeOwnerID(string username , string password)
        {
            Users[0].Password = password;
            Users[0].Username = username;
        }
        public static BL.MUserBL getOwner()
        {
            return Users[0];
        }
        public static List<BL.MUserBL> getPatients()
        {
            List<BL.MUserBL> patients = new List<BL.MUserBL>();
            for (int i = 1; i < Users.Count; i++)
            {
                patients.Add(Users[i]);
            }
            return patients;
        }
        public static void readData()
        {
            string username, password, role;
            string record;
            string path = "users.txt";
            StreamReader file = new StreamReader(path);
            while ((record = file.ReadLine()) != null)
            {
                username = parseData(record, 1);
                password = parseData(record, 2);
                role = parseData(record, 3);
                BL.MUserBL user = new BL.MUserBL(username, password, role);
                Users.Add(user);
            }
            file.Close();
        }

        public static void writeData()
        {
            string path = "users.txt";
            StreamWriter file = new StreamWriter(path, false);
            for (int i = 0; i < Users.Count; i++)
            {
                if (i > 0)
                {
                    file.WriteLine();
                }
                file.Write("{0},{1},{2}", Users[i].Username, Users[i].Password, Users[i].Role);
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

        public static string checkData(string username , string password)
        {
            string role = "NONE";
            for (int i = 0; i < Users.Count; i++)
            {
                if (username == Users[i].Username && password == Users[i].Password)
                {
                    role = Users[i].Role;
                }
            }
            return role;
        }


        public static void AddUser(BL.MUserBL mUserBL)
        {
            Users.Add(mUserBL);
        }
    }
}
