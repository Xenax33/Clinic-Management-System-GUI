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

namespace CLINIC_MANAGEMENT_SYSTEM_2_.BL
{
    class NameBL
    {
        private static string name;

        public static string Name { get => name; set => name = value; }

        public static void putNameInFile()
        {
            string path = "Name.txt";
            StreamWriter file = new StreamWriter(path, false);
            file.Write(Name);
            file.Close();
        }
        
        public static void ReadNameFromFile()
        {
            string path = "Name.txt";
            StreamReader file = new StreamReader(path);
            Name = file.ReadLine();
            file.Close();
        }
    }
}
