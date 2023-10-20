using BusinessManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            Clients.Add(new ClientModel(Clients.Count, "John Smith", "123 Main St, Cityville, Country", "john.smith@example.com", "999-888-7654"));
            Clients.Add(new ClientModel(Clients.Count, "Alice Johnson", "456 Elm St, Townsville, Country", "alice.j@example.com", "555-888-7654"));
            Clients.Add(new ClientModel(Clients.Count, "Michael Davis", "789 Oak St, Villageland, Country", "michael.d@example.com", "987-888-8784"));
            Clients.Add(new ClientModel(Clients.Count, "Emily Wilson", "101 Pine St, Hamletown, Country", "emily.w@example.com", "999-888-7687"));
            Clients.Add(new ClientModel(Clients.Count, "Daniel Lee", "202 Cedar St, Countryside, Country", "daniel.l@example.com", "999-888-7456"));
            Clients.Add(new ClientModel(Clients.Count, "Sophia White", "303 Maple St, Suburbia, Country", "sophia.w@example.com", "999-321-7657"));
            Clients.Add(new ClientModel(Clients.Count, "Liam Clark", "404 Birch St, Ruralville, Country", "liam.c@example.com", "789-888-7654"));
            Clients.Add(new ClientModel(Clients.Count, "Olivia Hill", "505 Spruce St, Farmland, Country", "olivia.h@example.com", "859-888-8784"));
            Clients.Add(new ClientModel(Clients.Count, "Ethan Turner", "606 Fir St, Outskirts, Country", "ethan.t@example.com", "129-888-1254"));
            Clients.Add(new ClientModel(Clients.Count, "Ava Hall", "707 Pineapple St, Countryscape, Country", "ava.h@example.com", "932-888-3214"   ));
            Clients.Add(new ClientModel(Clients.Count, "Noah Adams", "808 Lemon St, Meadowland, Country", "noah.a@example.com", "569-888-9154"));
            Clients.Add(new ClientModel(Clients.Count, "Emma Evans", "909 Orange St, Rivershore, Country", "emma.e@example.com", "559-888-7699"));
            Clients.Add(new ClientModel(Clients.Count, "William Murphy", "1010 Cherry St, Lakeside, Country", "william.m@example.com", "419-888-8888"));
            Clients.Add(new ClientModel(Clients.Count, "Mia Reed", "1111 Grape St, Mountainside, Country", "mia.r@example.com", "499-888-7856"));
            Clients.Add(new ClientModel(Clients.Count, "James Baker", "1212 Blueberry St, Seaside, Country", "james.b@example.com", "299-888-5178"));
            Clients.Add(new ClientModel(Clients.Count, "Charlotte Cook", "1313 Raspberry St, Hillside, Country", "charlotte.c@example.com", "329-888-6472"));
            Clients.Add(new ClientModel(Clients.Count, "Benjamin Young", "1414 Strawberry St, Countryside, Country", "benjamin.y@example.com", "919-888-9321"));
            Clients.Add(new ClientModel(Clients.Count, "Amelia King", "1515 Blackberry St, Farmland, Country", "amelia.k@example.com", "379-888-6774"));
            Clients.Add(new ClientModel(Clients.Count, "Lucas Mitchell", "1616 Raspberry St, Outskirts, Country", "lucas.m@example.com", "599-888-4264"));
            Clients.Add(new ClientModel(Clients.Count, "Grace Lopez", "1717 Blueberry St, Riverside, Country", "grace.l@example.com", "549-888-0000"));

        }

        public void AddClient(string name, string address, string email, string phone)
        {
            Clients.Add(new ClientModel(Clients.Count, name, address, email, phone));
        }
    }
}
