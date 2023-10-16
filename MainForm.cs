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

        //SYNCFUSION TEST
        private Button btnCreate;
        System.Windows.Forms.Label label;

        public MainForm()
        {
            InitializeComponent();

            ListOfServices = new ServicesViewModel();
            ListOfClients = new ClientViewModel();

            //Assigns collections to data grids
            clientsDataGrid.DataSource = ListOfClients.Clients;
            servicesDataGrid.DataSource = ListOfServices.Services;

            clientsDataGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clientsDataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            clientsDataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
          
        }
    }
}
