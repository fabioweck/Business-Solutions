using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool IsAdmin { get; set; }

        public EmployeeModel(int id, string name, string address, string email,
            string phone, string password, string confirmPassword, bool isAdmin)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
            Password = password;
            ConfirmPassword = confirmPassword;
            IsAdmin = isAdmin;
        }
    }
}
