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
    public partial class MainForm : Form
    {
        ClientViewModel ListOfClients { get; set; }
        ServicesViewModel ListOfServices { get; set; }

        public MainForm()
        {
            InitializeComponent();
            ListOfClients = new ClientViewModel();
            ListOfServices = new ServicesViewModel();

            clientsDataGrid.DataSource = ListOfClients.Clients;
            servicesDataGrid.DataSource = ListOfServices.Services;
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ListOfClients.AddClient(txtName.Text, txtAddress.Text, txtEmail.Text);


            //Change data source to null to clear the grid view, then set data source again with new list

            clientsDataGrid.DataSource = null;
            clientsDataGrid.DataSource = ListOfClients.Clients;

            if (clientsDataGrid.Rows.Count > 0)
            {
                int lastIndex = clientsDataGrid.Rows.Count - 1;
                clientsDataGrid.FirstDisplayedScrollingRowIndex = lastIndex;
                clientsDataGrid.Rows[lastIndex].Selected = true; // Optionally select the last row
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                ListOfServices.AddService(txtDescription.Text, Convert.ToDouble(txtPrice.Text));
            }
            catch 
            {
                lblPrice.Text = "Please enter a valid price";
                return;
            }
            

            //Change data source to null to clear the grid view, then set data source again with new list
            servicesDataGrid.DataSource = null;
            servicesDataGrid.DataSource = ListOfServices.Services;

            if (servicesDataGrid.Rows.Count > 0)
            {
                int lastIndex = servicesDataGrid.Rows.Count - 1;
                servicesDataGrid.FirstDisplayedScrollingRowIndex = lastIndex;
                servicesDataGrid.Rows[lastIndex].Selected = true; // Optionally select the last row
            }
        }
    }
}
