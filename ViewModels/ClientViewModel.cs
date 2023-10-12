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
            Clients.Add(new ClientModel(Clients.Count, "Client1", "Address1", "client1@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client2", "Address2", "client2@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client3", "Address3", "client3@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client4", "Address4", "client4@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client5", "Address5", "client5@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client6", "Address6", "client6@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client7", "Address7", "client7@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client8", "Address8", "client8@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client9", "Address9", "client9@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client10", "Address10", "client10@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client11", "Address11", "client11@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client12", "Address12", "client12@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client13", "Address13", "client13@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client14", "Address14", "client14@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client15", "Address15", "client15@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client16", "Address16", "client16@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client17", "Address17", "client17@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client18", "Address18", "client18@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client19", "Address19", "client19@user.com"));
            Clients.Add(new ClientModel(Clients.Count, "Client20", "Address20", "client20@user.com"));
        }

        public void AddClient(string name, string address, string email)
        {
            Clients.Add(new ClientModel(Clients.Count, name, address, email));
        }
    }
}
