using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLINIC_MANAGEMENT_SYSTEM_2_.BL
{
    public class MUserBL
    {
        private string username;
        private string password;
        private string role;

        public MUserBL(string username, string password, string role)
        {
            this.Password = password;
            this.Role = role;
            this.Username = username;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
    }
}
