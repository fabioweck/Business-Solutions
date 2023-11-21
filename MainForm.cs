using BusinessManager.Properties;
using BusinessManager.ViewModels;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManager
{
    partial class MainForm : Form
    {
        ClientViewModel ListOfClients { get; set; }
        ServicesViewModel ListOfServices { get; set; }
        EmployeeViewModel ListOfEmployees { get; set; }
        InvoiceViewModel ListOfInvoices { get; set; }

        //SYNCFUSION TEST
        private Button btnCreate;
        System.Windows.Forms.Label label;

        public MainForm()
        {
            InitializeComponent();

            ListOfServices = new ServicesViewModel();
            ListOfClients = new ClientViewModel();
            ListOfEmployees = new EmployeeViewModel();
            ListOfInvoices = new InvoiceViewModel();

            //Assigns collections to data grids
            clientsDataGrid.DataSource = ListOfClients.Clients;
            servicesDataGrid.DataSource = ListOfServices.Services;
            employeesDataGrid.DataSource = ListOfEmployees.Employees;
            invoicesDataGrid.DataSource = ListOfInvoices.Invoices;

            tabAdmin.Enabled = false;
          
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
            if(tabAdmin.Enabled) tabAdmin.Enabled = false;
            else tabAdmin.Enabled = true;

            groupBox1.Text = "Changed text";
        }
    }
}
