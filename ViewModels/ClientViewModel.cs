using BusinessManager.Models;
using Syncfusion.XlsIO;
using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.ViewModels
{

    //This class manipulates all the models and serves as a bridge between the model and the view

    public class ClientViewModel
    {

        //Create a list of clients
        public static BindingList<ClientModel> Clients { get; set; }

        public ClientViewModel() 
        {
            Clients = new BindingList<ClientModel>();

            //Calls the method to populate list of clients
            PopulateClients();
        }

        //Method to populate list of clients
        public void PopulateClients()
        {
            //First find the path to the csv file
            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            string path = currentDirectory.Substring(0, index);

            //Use stream reader to read the file
            using (StreamReader sr = new StreamReader(path + "Assets\\database\\clients.csv"))
            {
                while(!sr.EndOfStream)
                {
                    //Read until the end of file
                    string line = sr.ReadLine();
                    if (line != null)
                    {
                        //Split information
                        string[] splitted = line.Split(',');
                        int id = int.Parse(splitted[0]);

                        //Pass info to add a new client
                        Clients.Add(new ClientModel(id, splitted[1], splitted[2], splitted[3], splitted[4]));
                    }
                }
            }
        }
    
        //Method to produce IDs
        public static int GetNextAvailableId()
        {
            //First find the path to the csv file
            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            string path = currentDirectory.Substring(0, index);
            string CsvFilePath = currentDirectory.Substring(0, index) + "Assets\\database\\clients.csv";
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

        //Method to add clients to the list of clients
        public static void AddClient(string id, string name, string address, string email, string phone)
        {
            //First read the path of the csv file
            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            string path = currentDirectory.Substring(0, index);
            string CsvFilePath = currentDirectory.Substring(0, index) + "Assets\\database\\clients.csv";
            int clientId;

            if (id == "")
            {
                // If id is not provided, get the next available id
                clientId = GetNextAvailableId();
                Clients.Add(new ClientModel(clientId, name, address, email, phone));
            }
            else
            {
                // If id is provided, try to parse it
                if (int.TryParse(id, out clientId))
                {
                    // Check if the client with the given id already exists in the Clients list
                    ClientModel existingClient = Clients.FirstOrDefault(client => client.Id == clientId);

                    if (existingClient != null)
                    {
                        // If the client exists, update its properties
                        existingClient.Name = name;
                        existingClient.Address = address;
                        existingClient.Email = email;
                        existingClient.Phone = phone;
                    }
                    else
                    {
                        // If the client doesn't exist, add a new entry to the Clients list
                        Clients.Add(new ClientModel(clientId, name, address, email, phone));
                    }
                }
                else
                {
                    // Handle the case where parsing id fails
                    // You may want to log an error or handle it according to your application's requirements
                    Console.WriteLine("Invalid id format");
                }
            }
        
        //Calls update method to update csv file
        UpdateCSV(CsvFilePath, Clients);

        }

        //Method to update csv file
        public static void RemoveClient(string id)
        {
            // If id is provided, try to parse it
            if (int.TryParse(id, out int clientId))
            {
                // Check if the client with the given id exists in the Clients list
                ClientModel existingClient = Clients.FirstOrDefault(client => client.Id == clientId);

                if (existingClient != null)
                {
                    // If the client exists, remove it from the Clients list
                    Clients.Remove(existingClient);

                    // Update the CSV file with the modified Clients list
                    string currentDirectory = Directory.GetCurrentDirectory();
                    int index = currentDirectory.LastIndexOf("bin");
                    string CsvFilePath = currentDirectory.Substring(0, index) + "Assets\\database\\clients.csv";
                    UpdateCSV(CsvFilePath, Clients);
                }
                else
                {
                    // If the client doesn't exist, you may want to log or handle it accordingly
                    Console.WriteLine($"Client with id {clientId} not found.");
                }
            }
            else
            {
                // Handle the case where parsing id fails
                // You may want to log an error or handle it according to your application's requirements
                Console.WriteLine("Invalid id format");
            }
        }

        //method to convert client's info to csv
        private static string ConvertToCsv(BindingList<ClientModel> csv)
        {

            // Convert each ClientModel object to CSV row
            string rows = string.Join("\n", csv.Select(client =>
                $"{client.Id},{client.Name},{client.Address},{client.Email},{client.Phone}"));

            // Combine header and rows
            string csvContent =  rows;

            return csvContent;
        }

        //Method to update csv file
        public static void UpdateCSV(string path,  BindingList<ClientModel> csv)
        {
            try
            {
                // Convert the BindingList<ClientModel> to CSV format
                string csvContent = ConvertToCsv(csv);

                // Write the updated CSV content to the file
                File.WriteAllText(path, csvContent);
                Console.WriteLine("CSV file updated successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
