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
    class Managers
    {
        private string name;
        private double salary;
        private string username;
        private string password;

        public Managers(string name, double salary, string username, string password)
        {
            this.name = name;
            this.salary = salary;
            this.Password = password;
            this.Username = username;
            this.Password = password;
        }

        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
