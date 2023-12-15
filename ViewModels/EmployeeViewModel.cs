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
    //This class manipulates all the models and serves as a bridge between the model and the view

    public class EmployeeViewModel
    {
        //Create a list of employees
        public static BindingList<EmployeeModel> Employees { get; set; }

        public EmployeeViewModel()
        {
            Employees = new BindingList<EmployeeModel>();

            //Populate the list of employees
            PopulateEmployees();
        }

        //Method to populate list of employees
        public void PopulateEmployees()
        {

            //First get the path to the csv file
            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            string path = currentDirectory.Substring(0, index);

            try
            {
                //Use stream reader to read the file
                using (StreamReader sr = new StreamReader(path + "Assets\\database\\employees.csv"))
                {
                    //Reads the file until the end
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line != null)
                        {
                            //split all information
                            string[] splitted = line.Split(',');

                            //Pass the splitted info to create a new employee
                            Employees.Add(new EmployeeModel(Int32.Parse(splitted[0]), splitted[1], splitted[2], splitted[3],
                                splitted[4], (splitted[5]), splitted[6], Boolean.Parse(splitted[7])));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred while populating employees: {e.Message}");
            }
        }


        //Method to produce an employee ID
        public static int GetNextAvailableId()
        {
            //First get the csv file path
            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            string path = currentDirectory.Substring(0, index);
            string CsvFilePath = currentDirectory.Substring(0, index) + "Assets\\database\\employees.csv";

            try
            {
                // Read all lines from the CSV file
                string[] lines = File.ReadAllLines(CsvFilePath);

                if (lines.Length > 0)
                {
                    // Extract the IDs from the first column
                    var ids = lines.Select(line => int.TryParse(line.Split(',')[0], out var id) ? id : 0)
                                   .ToList();

                    // Find the highest ID
                    int highestId = ids.Max();

                    // Return the next available ID (highest ID + 1)
                    return highestId + 1;
                }
                else
                {
                    // If the file is empty, start with ID 1
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return -1;  // Return -1 to indicate an error
            }
        }

        //Method to convert employee's info to csv
        private static string ConvertToCsv(BindingList<EmployeeModel> csv)
        {
            // Convert each EmployeeModel object to CSV row
            string rows = string.Join("\n", csv.Select(employee =>
               $"{employee.Id},{employee.Name},{employee.Address},{employee.Email},{employee.Phone},{employee.Password},{employee.ConfirmPassword},{employee.IsAdmin}"));


            // Combine header and rows
            string csvContent = rows;

            return csvContent;
        }

        //Method to update csv file
        public static void UpdateCSV(string path, BindingList<EmployeeModel> employees)
        {

            try
            {
                // Convert the BindingList<EmployeeModel> to CSV format
                string csvContent = ConvertToCsv(employees);

                // Write the updated CSV content to the file
                File.WriteAllText(path, csvContent);
                Console.WriteLine("CSV file updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        //Method to add a new employee
        public static void AddEmployee(string id, string name, string address,
        string email, string phone, string password, string confirmPassword, bool isAdmin)
        {

            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            string path = currentDirectory.Substring(0, index);
            string CsvFilePath = currentDirectory.Substring(0, index) + "Assets\\database\\employees.csv";
            int employeeId;

            if (id == "")
            {
                // If id is not provided, get the next available id
                employeeId = GetNextAvailableId();
                Employees.Add(new EmployeeModel(employeeId, name, address, email, phone, password, confirmPassword, isAdmin));
            }
            else
            {
                // If id is provided, try to parse it
                if (int.TryParse(id, out employeeId))
                {
                    // Check if the employee with the given id already exists in the Clients list
                    EmployeeModel existingEmployee = Employees.FirstOrDefault(employee => employee.Id == employeeId);

                    if (existingEmployee != null)
                    {
                        // If the employee exists, update its properties
                        existingEmployee.Name = name;
                        existingEmployee.Address = address;
                        existingEmployee.Email = email;
                        existingEmployee.Phone = phone;
                        existingEmployee.Password = password;
                        existingEmployee.ConfirmPassword = confirmPassword;
                        existingEmployee.IsAdmin = isAdmin;
                    }
                    else
                    {
                        // If the employee doesn't exist, add a new entry to the employee list
                        Employees.Add(new EmployeeModel(employeeId, name, address, email, phone, password, confirmPassword, isAdmin
                        ));
                    }
                }
                else
                {
                    // Handle the case where parsing id fails
                    Console.WriteLine("Invalid id format");
                }
            }

            UpdateCSV(CsvFilePath, Employees);

        }

        //Method to remove an employee
        public static void RemoveEmployee(int id)
        {
            // Check if the client with the given id exists in the Clients list
            EmployeeModel existingEmployee = Employees.FirstOrDefault(employee => employee.Id == id);

            if (existingEmployee != null)
            {
                // If the client exists, remove it from the Clients list
                Employees.Remove(existingEmployee);

                // Update the CSV file with the modified Clients list
                string currentDirectory = Directory.GetCurrentDirectory();
                int index = currentDirectory.LastIndexOf("bin");
                string CsvFilePath = currentDirectory.Substring(0, index) + "Assets\\database\\employees.csv";

                UpdateCSV(CsvFilePath, Employees);
            }
            else
            {
                // If the client doesn't exist
                Console.WriteLine($"Client with id {id} not found.");
            }
        }
    }
}
