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
        public static BindingList<InvoiceModel> Invoices { get; set; }

        public InvoiceViewModel() 
        {
            Invoices = new BindingList<InvoiceModel>();
            PopulateInvoices();
        }

        public static void PopulateInvoices()
        {
            if(Invoices.Count > 0)
            {
                Invoices.Clear();
            }

            //Reads the current path and set the correct path to locate the invoice
            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            string path = currentDirectory.Substring(0, index) + "Assets\\invoices";

            if (Directory.Exists(path))
            {
                // Get the list of files in the folder
                string[] files = Directory.GetFiles(path);

                // Display the paths of the files
                foreach (string filePath in files)
                {
                    int idx = filePath.LastIndexOf('\\') + 1;
                    if (idx == -1) continue;
                    else Invoices.Add(new InvoiceModel(Invoices.Count, filePath.Substring(idx), filePath.ToString()));
                }
            }
        }
    }
}
