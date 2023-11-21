using BusinessManager.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
}
