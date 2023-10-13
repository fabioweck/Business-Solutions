using BusinessManager.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManager
{
    partial class MainForm : Form
    {
        ClientViewModel ListOfClients { get; set; }
        ServicesViewModel ListOfServices { get; set; }

        public MainForm()
        {
            InitializeComponent();

            ListOfServices = new ServicesViewModel();
            ListOfClients = new ClientViewModel();

            //Assigns collections to data grids
            clientsDataGrid.DataSource = ListOfClients.Clients;
            servicesDataGrid.DataSource = ListOfServices.Services;
        }
    }
}
