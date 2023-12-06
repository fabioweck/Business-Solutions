﻿using BusinessManager.Models;
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
        EmployeeModel LoggerUser { get; }
        public bool isAdmin { get; }
        public int userID { get; } = 0;

        public MainForm() // bypass - 
        {

            InitializeComponent();
            isAdmin = true;


            ListOfServices = new ServicesViewModel();
            ListOfServices.PopulateServices();
            ListOfInvoices = new InvoiceViewModel();
            ListOfEmployees = new EmployeeViewModel();

            //Assigns collections to data grids
            clientsDataGrid.DataSource = ClientViewModel.Clients;
            servicesDataGrid.DataSource = ServicesViewModel.Services;
            employeesDataGrid.DataSource = EmployeeViewModel.Employees;
            invoicesDataGrid.DataSource = InvoiceViewModel.Invoices;

            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            string path = currentDirectory.Substring(0, index);

            this.BackgroundImage = Image.FromFile(path + "\\Assets\\backgroundImage.jpg");
          
        }
        public MainForm(EmployeeViewModel listOfEmployees, Models.EmployeeModel loggedUser)
        {

            InitializeComponent();
            isAdmin = loggedUser.IsAdmin;
            userID = loggedUser.Id;////////////------------------here-------------
                 
            ListOfServices = new ServicesViewModel();
            ListOfServices.PopulateServices();
            ListOfEmployees = listOfEmployees; //---------------------------------------
            ListOfInvoices = new InvoiceViewModel();

            //Assigns collections to data grids
            clientsDataGrid.DataSource = ClientViewModel.Clients;
            servicesDataGrid.DataSource = ServicesViewModel.Services;
            employeesDataGrid.DataSource = EmployeeViewModel.Employees;
            invoicesDataGrid.DataSource = InvoiceViewModel.Invoices;

            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            string path = currentDirectory.Substring(0, index);

            this.BackgroundImage = Image.FromFile(path + "\\Assets\\backgroundImage.jpg");
            this.LoggerUser = loggedUser;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addButton1_Click(object sender, EventArgs e)
        { 
            ClientProfileView addNewClientView2 = new ClientProfileView();
            addNewClientView2.ShowDialog();
        }

        private void btnClientDetails_Click_1(object sender, EventArgs e)
        {
            if (clientsDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = clientsDataGrid.SelectedRows[0];

                int id = (int)selectedRow.Cells["Id"].Value;
                string name = selectedRow.Cells["Name"].Value.ToString();
                string address = selectedRow.Cells["Address"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string phone = selectedRow.Cells["Phone"].Value.ToString();

               ClientProfileView clientProfileView = new ClientProfileView(id,name,address,email,phone,isAdmin);
               clientProfileView.ShowDialog();
              
               clientsDataGrid.Refresh();
            }
        }

        private void btn_addNewClient_Click(object sender, EventArgs e)
        {
            ClientProfileView addNewClientView2 = new ClientProfileView();
            addNewClientView2.ShowDialog();
        }

        private void btn_newOrder_Click(object sender, EventArgs e)
        {

            if (clientsDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = clientsDataGrid.SelectedRows[0];

                int id = (int)selectedRow.Cells["Id"].Value;
                string name = selectedRow.Cells["Name"].Value.ToString();
                string address = selectedRow.Cells["Address"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string phone = selectedRow.Cells["Phone"].Value.ToString();

                // ClientProfileView clientProfileView = new ClientProfileView(id, name, address, email, phone, isAdmin);
                // clientProfileView.ShowDialog();

                OrderView orderView = new OrderView(id, name, address, email, phone);
                orderView.ShowDialog();
                           



               // clientsDataGrid.Refresh();
            }
        }

         private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            EmployeeView employeeView = new EmployeeView();
            employeeView.ShowDialog();
            employeesDataGrid.Refresh();
        }

        private void employee_details_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = employeesDataGrid.SelectedRows[0];
            int id = (int)selectedRow.Cells["Id"].Value;
            string name = selectedRow.Cells["Name"].Value.ToString();
            string address = selectedRow.Cells["Address"].Value.ToString();
            string email = selectedRow.Cells["Email"].Value.ToString();
            string phone = selectedRow.Cells["Phone"].Value.ToString();
            bool isAdmin = (Boolean)selectedRow.Cells["IsAdmin"].Value;
            string password = selectedRow.Cells["Password"].Value.ToString();

            EmployeeView employeeProfileView = new EmployeeView(id, name, address, email, phone, password, isAdmin);
            employeeProfileView.ShowDialog();
        }

        private void btn_deleteEmployee_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = employeesDataGrid.SelectedRows[0];
            int id = (int)selectedRow.Cells["Id"].Value;
            string name = selectedRow.Cells["Name"].Value.ToString();
            string address = selectedRow.Cells["Address"].Value.ToString();
            string email = selectedRow.Cells["Email"].Value.ToString();
            string phone = selectedRow.Cells["Phone"].Value.ToString();
            bool isAdmin = (Boolean)selectedRow.Cells["IsAdmin"].Value;
            string password = selectedRow.Cells["Password"].Value.ToString();

            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                EmployeeViewModel.RemoveEmployee(id);

                MessageBox.Show("Employee removed successfully");

                employeesDataGrid.Refresh();
            }
        }


    }
}
