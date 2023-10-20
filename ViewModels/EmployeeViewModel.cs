using BusinessManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.ViewModels
{
    public class EmployeeViewModel
    {
        public BindingList<EmployeeModel> Employees { get; set; }

        public EmployeeViewModel()
        {
            Employees = new BindingList<EmployeeModel>();
            PopulateEmployees();
        }

        public void PopulateEmployees()
        {
            Employees.Add(new EmployeeModel(Employees.Count, "Fabio Augusto Weck", "0908 15st, Beltline, Calgary", "587-892-3124", "fabio@rad.com", new DateTime(2023, 03, 01)));
            Employees.Add(new EmployeeModel(Employees.Count, "Uyara Martins", "1112 Oak Ave., North, Calgary", "981-282-3461", "uyara@rad.com", new DateTime(2023, 03, 05)));
            Employees.Add(new EmployeeModel(Employees.Count, "Leandro Evaristo", "85 Orange Blossom, Calgary", "354-654-1916", "leandro@rad.com", new DateTime(2023, 03, 07)));
        }
    }
}
