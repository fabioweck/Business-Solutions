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
        public string Contract { get; private set; }

        public EmployeeModel(int id, string name, string address, string phone, string email, string date)
        { 
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            Contract = date;
        }
    }
}
