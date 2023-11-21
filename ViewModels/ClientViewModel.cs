using BusinessManager.Models;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.ViewModels
{
    public class ClientViewModel
    {
        public static BindingList<ClientModel> Clients { get; set; }

        public ClientViewModel() 
        {
            Clients = new BindingList<ClientModel>();
            PopulateClients();
        }

        public void PopulateClients()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            string path = currentDirectory.Substring(0, index);

            using (StreamReader sr = new StreamReader(path + "Assets\\database\\clients.csv"))
            {
                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] splitted = line.Split(';');
                        Clients.Add(new ClientModel(Clients.Count, splitted[0], splitted[1], splitted[2], splitted[3]));
                    }
                }
            }
        }

        public static void AddClient(string name, string address, string email, string phone)
        {
            Clients.Add(new ClientModel(Clients.Count, name, address, email, phone));
        }

        public static void UpdateClient(int id, string address, string email, string phone)
        {
            foreach(ClientModel client in Clients)
            {
                if(client.Id == id)
                {
                    if(address != string.Empty) client.Address = address;
                    if(email != string.Empty) client.Email = email;
                    if(phone != string.Empty) client.Phone = phone;
                }
            }
        }
    }
}
