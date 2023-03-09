using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINIC_MANAGEMENT_SYSTEM_2_.BL
{
    class Staff
    {
        private string name;
        private double salary;
        private string role;

        public Staff(string name , double salary , string role)
        {
            this.name = name;
            this.role = role;
            this.salary = salary;
        }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
        public string Role { get => role; set => role = value; }
    }
}
