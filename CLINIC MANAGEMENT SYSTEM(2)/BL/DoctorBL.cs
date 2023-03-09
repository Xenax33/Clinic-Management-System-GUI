using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINIC_MANAGEMENT_SYSTEM_2_.BL
{
    class DoctorBL
    {
        private string name;
        private string timing;
        private double salary;
        private double fees;
        private int appointments;

        public event EventHandler Event;

        public int Appointments { get => appointments; set => appointments = value; }
        public string Name { get => name; set => name = value; }
        public string Timing { get => timing; set => timing = value; }
        public double Salary { get => salary; set => salary = value; }
        public double Fees { get => fees; set => fees = value; }

        public void Method()
        {
            throw new System.NotImplementedException();
        }

        public DoctorBL(string name ,  string timing , double salary , double fees , int appointments)
        {
            this.salary = salary;
            this.name = name;
            this.timing = timing;
            this.appointments = appointments;
            this.fees = fees;
        }

    }
}
