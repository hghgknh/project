using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Account
    {
        private int id;
        private string name;
        private string email;
        private string password;
        private string location;
        private string phone_num;
        private string type;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Location { get => location; set => location = value; }
        public string Phone_num { get => phone_num; set => phone_num = value; }
        public string Type { get => type; set => type = value; }

        public Account(string name, string email, string password, string location, string phone_num, string type)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.location = location;
            this.phone_num = phone_num;
            this.type = type;
        }
        public Account()
        {
            this.name = "";
            this.email = "";
            this.password = "";
            this.location = "";
            this.phone_num = "";
            this.type = "";
        }
    }
}
