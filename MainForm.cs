using BusinessManager.Properties;
using BusinessManager.ViewModels;
using BusinessManager.Views;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace BusinessManager
{
    partial class MainForm : Form
    {
        ClientViewModel ListOfClients = new ClientViewModel();
        ServicesViewModel ListOfServices { get; set; }
        EmployeeViewModel ListOfEmployees { get; set; }
        InvoiceViewModel ListOfInvoices { get; set; }

        public MainForm()
        {
            InitializeComponent();

            ListOfServices = new ServicesViewModel();
            ListOfEmployees = new EmployeeViewModel();
            ListOfInvoices = new InvoiceViewModel();

            //Assigns collections to data grids
            clientsDataGrid.DataSource = ClientViewModel.Clients;
            servicesDataGrid.DataSource = ListOfServices.Services;
            invoicesDataGrid.DataSource = ListOfEmployees.Employees;
            invoicesDataGrid.DataSource = ListOfInvoices.Invoices;

            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            string path = currentDirectory.Substring(0, index);

            this.BackgroundImage = Image.FromFile(path + "\\Assets\\backgroundImage.jpg");
          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
