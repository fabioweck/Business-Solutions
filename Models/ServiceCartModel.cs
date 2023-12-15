using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Models
{
    //Holds all information about services in the cart

    public class ServiceCartModel
    {
        public int Quantity { get; private set; }
        public int Id { get; private set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public ServiceCartModel(int quantity, int id, string description, double price)
        {
            Id = id;
            Description = description;
            Price = price;
            Quantity = quantity;
        }
    }
}
