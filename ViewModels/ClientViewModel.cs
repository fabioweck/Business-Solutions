using BusinessManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.ViewModels
{
    public class ClientViewModel
    {
        public List<ClientModel> Clients { get; set; }

        public ClientViewModel() 
        {
            Clients = new List<ClientModel>();
            PopulateClients();
        }

        public void PopulateClients()
        {
            Clients.Add(new ClientModel(Clients.Count, "John Smith", "123 Main St, Cityville, Country", "john.smith@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Alice Johnson", "456 Elm St, Townsville, Country", "alice.j@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Michael Davis", "789 Oak St, Villageland, Country", "michael.d@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Emily Wilson", "101 Pine St, Hamletown, Country", "emily.w@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Daniel Lee", "202 Cedar St, Countryside, Country", "daniel.l@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Sophia White", "303 Maple St, Suburbia, Country", "sophia.w@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Liam Clark", "404 Birch St, Ruralville, Country", "liam.c@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Olivia Hill", "505 Spruce St, Farmland, Country", "olivia.h@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Ethan Turner", "606 Fir St, Outskirts, Country", "ethan.t@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Ava Hall", "707 Pineapple St, Countryscape, Country", "ava.h@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Noah Adams", "808 Lemon St, Meadowland, Country", "noah.a@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Emma Evans", "909 Orange St, Rivershore, Country", "emma.e@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "William Murphy", "1010 Cherry St, Lakeside, Country", "william.m@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Mia Reed", "1111 Grape St, Mountainside, Country", "mia.r@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "James Baker", "1212 Blueberry St, Seaside, Country", "james.b@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Charlotte Cook", "1313 Raspberry St, Hillside, Country", "charlotte.c@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Benjamin Young", "1414 Strawberry St, Countryside, Country", "benjamin.y@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Amelia King", "1515 Blackberry St, Farmland, Country", "amelia.k@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Lucas Mitchell", "1616 Raspberry St, Outskirts, Country", "lucas.m@example.com"));
            Clients.Add(new ClientModel(Clients.Count, "Grace Lopez", "1717 Blueberry St, Riverside, Country", "grace.l@example.com"));

        }

        public void AddClient(string name, string address, string email)
        {
            Clients.Add(new ClientModel(Clients.Count, name, address, email));
        }
    }
}
