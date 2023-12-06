using BusinessManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManager.ViewModels
{
    public class ServicesViewModel
    {

        public static List<ServiceModel> Services { get; set; }
       

        public ServicesViewModel() 
        {
            Services = new List<ServiceModel>();
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
                        string[] splitted = line.Split(';');
                        Services.Add(new ServiceModel(Services.Count, splitted[0], Convert.ToDouble(splitted[1])));
                    }
                }
            }
        }

        public void AddService(string description, double price)
        {
            Services.Add(new ServiceModel(Services.Count, description, price));
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
