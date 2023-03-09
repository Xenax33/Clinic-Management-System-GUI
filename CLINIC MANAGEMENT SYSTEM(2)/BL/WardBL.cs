using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINIC_MANAGEMENT_SYSTEM_2_.BL
{
    class WardBL
    {
        private string name;
        private int performed;
        private int rooms;
        private double cost;
        private double expenses;

        List<MUserBL> Patients = new List<MUserBL>();

        public string Name { get => name; set => name = value; }
        public int Performed { get => performed; set => performed = value; }
        public int Rooms { get => rooms; set => rooms = value; }
        public double Cost { get => cost; set => cost = value; }
        public double Expenses { get => expenses; set => expenses = value; }

        public WardBL(string name , int performed , int rooms , double cost , double expenses)
        {
            this.name = name;
            this.performed = performed;
            this.rooms = rooms;
            this.expenses = expenses;
            this.cost = cost;
        }
    }
}
