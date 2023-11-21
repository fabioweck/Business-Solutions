using BusinessManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            string path = currentDirectory.Substring(0, index);

            using (StreamReader sr = new StreamReader(path + "Assets\\database\\employees.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] splitted = line.Split(';');
                        Employees.Add(new EmployeeModel(Employees.Count, splitted[0], splitted[1], splitted[2], splitted[3], splitted[4]));
                    }
                }
            }
        }
    }
}
