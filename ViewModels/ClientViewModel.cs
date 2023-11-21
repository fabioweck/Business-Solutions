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
        public BindingList<ClientModel> Clients { get; set; }

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

        public void AddClient(string name, string address, string email, string phone)
        {
            Clients.Add(new ClientModel(Clients.Count, name, address, email, phone));
        }
    }
}
