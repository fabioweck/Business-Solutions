﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Models
{

    public class ServiceModel
    {
        public int Id { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }

        public ServiceModel(int id, string description, double price) 
        {
            Id = id;
            Description = description;
            Price = price;
        }
    }
}
