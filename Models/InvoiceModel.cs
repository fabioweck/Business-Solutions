using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Models
{
    public class InvoiceModel
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string File { get; private set; }
        public DateTime Date { get; private set; }

        public InvoiceModel(int id, string name, string path, DateTime date) 
        { 
            Id = id;
            Name = name;
            File = path;
            Date = date;
        }

    }
}
