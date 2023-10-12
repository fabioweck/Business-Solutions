using BusinessManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.ViewModels
{
    public class ServicesViewModel
    {

        public List<ServiceModel> Services { get; set; }

        public ServicesViewModel() 
        {
            Services = new List<ServiceModel>();
            PopulateServices();
        }

        public void PopulateServices()
        {
            Services.Add(new ServiceModel(Services.Count, "Service 01", 10.90));
            Services.Add(new ServiceModel(Services.Count, "Service 02", 30.49));
            Services.Add(new ServiceModel(Services.Count, "Service 03", 50.00));
            Services.Add(new ServiceModel(Services.Count, "Service 04", 15.75));
            Services.Add(new ServiceModel(Services.Count, "Service 05", 22.40));
            Services.Add(new ServiceModel(Services.Count, "Service 06", 18.90));
            Services.Add(new ServiceModel(Services.Count, "Service 07", 40.25));
            Services.Add(new ServiceModel(Services.Count, "Service 08", 12.60));
            Services.Add(new ServiceModel(Services.Count, "Service 09", 35.90));
            Services.Add(new ServiceModel(Services.Count, "Service 10", 28.50));
            Services.Add(new ServiceModel(Services.Count, "Service 11", 55.20));
            Services.Add(new ServiceModel(Services.Count, "Service 12", 47.80));
            Services.Add(new ServiceModel(Services.Count, "Service 13", 19.99));
            Services.Add(new ServiceModel(Services.Count, "Service 14", 42.30));
            Services.Add(new ServiceModel(Services.Count, "Service 15", 33.75));
            Services.Add(new ServiceModel(Services.Count, "Service 16", 25.50));
            Services.Add(new ServiceModel(Services.Count, "Service 17", 38.20));
            Services.Add(new ServiceModel(Services.Count, "Service 18", 17.60));
            Services.Add(new ServiceModel(Services.Count, "Service 19", 29.90));
            Services.Add(new ServiceModel(Services.Count, "Service 20", 62.40));
            Services.Add(new ServiceModel(Services.Count, "Service 21", 21.80));
            Services.Add(new ServiceModel(Services.Count, "Service 22", 45.70));
        }

        public void AddService(string description, double price)
        {
            Services.Add(new ServiceModel(Services.Count, description, price));
        }
    }
}
