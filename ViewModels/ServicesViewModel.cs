﻿using BusinessManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BusinessManager.ViewModels
{
    public class ServicesViewModel
    {

        public static BindingList<ServiceModel> Services { get; set; }


        public ServicesViewModel()
        {
            Services = new BindingList<ServiceModel>();
        }


        public void PopulateServices()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            string path = currentDirectory.Substring(0, index);

            using (StreamReader sr = new StreamReader(path + "Assets\\database\\services.csv"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] splitted = line.Split(',');
                        Services.Add(new ServiceModel(Convert.ToInt16(splitted[0]), splitted[1], Convert.ToDouble(splitted[2])));
                    }
                }
            }
        }

        public static void AddItem(string id, string description, double price)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            string path = currentDirectory.Substring(0, index);
            string CsvFilePath = currentDirectory.Substring(0, index) + "Assets\\database\\services.csv";
            int itemId;

            if (id == "")
            {
                // If id is not provided, get the next available id
                itemId = GetNextAvailableId();
                Services.Add(new ServiceModel(itemId,description, price));
            }
            else
            {
                // If id is provided, try to parse it
                if (int.TryParse(id, out itemId))
                {
                    // Check if the client with the given id already exists in the Clients list
                    ServiceModel existingService = Services.FirstOrDefault(service => service.Id == itemId);

                    if (existingService != null)
                    {
                        // If the client exists, update its properties
                        existingService.Description = description;
                        existingService.Price = price;
                    
                    }
                    else
                    {
                        // If the client doesn't exist, add a new entry to the Clients list
                        Services.Add(new ServiceModel(itemId, description, price));
                    }
                }
                else
                {
                    // Handle the case where parsing id fails
                    // You may want to log an error or handle it according to your application's requirements
                    Console.WriteLine("Invalid id format");
                }
            }

            UpdateCSV(CsvFilePath, Services);

        }

        public static void RemoveItem(string id)
        {
            // If id is provided, try to parse it
            if (int.TryParse(id, out int itemId))
            {
                // Check if the client with the given id exists in the Clients list
                ServiceModel existingService = Services.FirstOrDefault(service => service.Id == itemId);

                if (existingService != null)
                {
                    // If the client exists, remove it from the Clients list
                    Services.Remove(existingService);

                    // Update the CSV file with the modified Clients list
                    string currentDirectory = Directory.GetCurrentDirectory();
                    int index = currentDirectory.LastIndexOf("bin");
                    string CsvFilePath = currentDirectory.Substring(0, index) + "Assets\\database\\services.csv";
                    UpdateCSV(CsvFilePath, Services);
                }
                else
                {
                    // If the client doesn't exist, you may want to log or handle it accordingly
                    Console.WriteLine($"Client with id {itemId} not found.");
                }
            }
            else
            {
                // Handle the case where parsing id fails
                // You may want to log an error or handle it according to your application's requirements
                Console.WriteLine("Invalid id format");
            }
        }

        public static int GetNextAvailableId()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            string path = currentDirectory.Substring(0, index);
            string CsvFilePath = currentDirectory.Substring(0, index) + "Assets\\database\\services.csv";
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

        private static string ConvertToCsv(BindingList<ServiceModel> csv)
        {
            // Assuming ClientModel has properties like Id, Name, etc.
            // Adjust the property names accordingly

            // Convert each ClientModel object to CSV row
            string rows = string.Join("\n", csv.Select(service =>
                $"{service.Id},{service.Description},{service.Price}"));

            // Combine header and rows
            string csvContent = rows;

            return csvContent;
        }
        public static void UpdateCSV(string path, BindingList<ServiceModel> csv)
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


    public class ServiceCartViewModel
    {
        public BindingList<ServiceCartModel> ServicesCart { get; set; }

        public ServiceCartViewModel()
        {
            ServicesCart = new BindingList<ServiceCartModel>();
        }

        public void AddToCart(int qtd, int id, string description, double price)
        {
            ServicesCart.Add(new ServiceCartModel(qtd, id, description, price));
        }

        public void RemoveFromCart(int index)
        {
            ServicesCart.RemoveAt(index);
        }


        public decimal SumTotalCart()
        {
            double sum = 0;

            foreach(ServiceCartModel model in ServicesCart)
            {
                sum += model.Quantity * model.Price; 
            }
            
            return ((decimal)sum);
        }




        public void GenerateInvoice(ServiceCartViewModel serviceCartViewModel, int clientId, string clientName, string clientPhone, string clientEmail)
        {
            StringBuilder invoiceDetails = new StringBuilder();

            // Append information to the StringBuilder
            invoiceDetails.AppendLine($"Client ID: {clientId}");
            invoiceDetails.AppendLine($"Client Name: {clientName}");
            invoiceDetails.AppendLine($"Client Phone: {clientPhone}");
            invoiceDetails.AppendLine($"Client Email: {clientEmail}");

            // Append cart details
            invoiceDetails.AppendLine("Cart Details:");

            foreach (var serviceCartItem in serviceCartViewModel.ServicesCart)
            {
                invoiceDetails.AppendLine($" - Item: {serviceCartItem.Description}, Quantity: {serviceCartItem.Quantity}, Price: {serviceCartItem.Price}");
            }

            // Display the MessageBox
            MessageBox.Show(invoiceDetails.ToString(), "Invoice Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


    }



}
