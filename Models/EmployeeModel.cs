using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Models
{
    public class EmployeeModel
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool IsAdmin { get; private set; }

        public EmployeeModel(int id, string name, string address, string email,
            string phone, bool isAdmin, string password)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
}
