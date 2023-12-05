using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManager.Models
{
    public class ClientModel
    {
        public int Id { get; private set; }
        public string Name { get;  set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ClientModel(int id, string name, string address, string email, string phone)
        {
            Address = address;
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
        }
    }
}
