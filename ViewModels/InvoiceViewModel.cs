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
    public class InvoiceViewModel
    {
        public BindingList<InvoiceModel> Invoices { get; set; }

        public InvoiceViewModel() 
        {
            Invoices = new BindingList<InvoiceModel>();
            PopulateInvoices();
        }

        public void PopulateInvoices()
        {
            //Reads the current path and set the correct path to locate the invoice
            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            string path = currentDirectory.Substring(0, index);

            Invoices.Add(new InvoiceModel(Invoices.Count, "Leandro #001", path + "Assets\\Leandro.pdf", new DateTime(2023, 05, 13)));
            Invoices.Add(new InvoiceModel(Invoices.Count, "Harry #002", path + "Assets\\Harry.pdf", new DateTime(2023, 06, 02)));
            Invoices.Add(new InvoiceModel(Invoices.Count, "Alfredo #003", path + "Assets\\Alfredo.pdf", new DateTime(2023, 07, 22)));

        }
    }
}
