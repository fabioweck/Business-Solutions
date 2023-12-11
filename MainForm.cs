using BusinessManager.Models;
using BusinessManager.Properties;
using BusinessManager.ViewModels;
using BusinessManager.Views;
using MimeKit;
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
using System.Web.UI.Design;
using System.Windows.Forms;
//using MailKit.Net.Smtp;
//using MailKit.Security;
//using MimeKit;
using System.Net.Mail;
using System.Net;

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

        public MainForm() // bypass - for admin
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
            userID = loggedUser.Id;
                 
            ListOfServices = new ServicesViewModel();
            ListOfServices.PopulateServices();
            ListOfEmployees = listOfEmployees;
            if (!isAdmin)
            {
                EmployeeViewModel.Employees = new BindingList<EmployeeModel>
                {
                    loggedUser
                };
                btn_addEmployee.Visible = false;
                lbl_addEmployee.Visible = false;
                btn_deleteEmployee.Visible = false;
                lbl_deleteEmployee.Visible = false;
            }
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


            this.employeesDataGrid.Columns["Password"].Visible = false;
            this.employeesDataGrid.Columns["ConfirmPassword"].Visible = false;
            if (!isAdmin)
            {
                this.employeesDataGrid.Columns["IsAdmin"].Visible = false;
            }
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
            clientsDataGrid.Refresh();
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

                OrderView orderView = new OrderView(id, name, address, email, phone, invoicesDataGrid.Refresh);
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
            string password = selectedRow.Cells["Password"].Value.ToString();
            string confirmPassword = selectedRow.Cells["ConfirmPassword"].Value.ToString();
            bool isAdmin = (Boolean)selectedRow.Cells["IsAdmin"].Value;

            EmployeeView employeeProfileView = new EmployeeView(id, name, address, email,
                phone, password, confirmPassword, isAdmin);

            employeeProfileView.ShowDialog();
            employeesDataGrid.Refresh();
        }

        private void btn_deleteEmployee_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = employeesDataGrid.SelectedRows[0];
            int id = (int)selectedRow.Cells["Id"].Value;
            string name = selectedRow.Cells["Name"].Value.ToString();
            string address = selectedRow.Cells["Address"].Value.ToString();
            string email = selectedRow.Cells["Email"].Value.ToString();
            string phone = selectedRow.Cells["Phone"].Value.ToString();
            string password = selectedRow.Cells["Password"].Value.ToString();
            string confirmPassword = selectedRow.Cells["confirmPassword"].Value.ToString();
            bool isAdmin = (Boolean)selectedRow.Cells["IsAdmin"].Value;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                EmployeeViewModel.RemoveEmployee(id);

                MessageBox.Show("Employee removed successfully");

                employeesDataGrid.Refresh();
            }
        }
        

        private void btn_itemDetail_Click(object sender, EventArgs e)
        {
            if (servicesDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = servicesDataGrid.SelectedRows[0];

                int id = (int)selectedRow.Cells["Id"].Value;
                string description = selectedRow.Cells["Description"].Value.ToString();
                string price = selectedRow.Cells["Price"].Value.ToString();

                ItemProfileView itemProfileView = new ItemProfileView(id, description, double.Parse(price), isAdmin);
                itemProfileView.ShowDialog();

                servicesDataGrid.Refresh();
            }
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            ItemProfileView addItem = new ItemProfileView();
            addItem.ShowDialog();
            servicesDataGrid.Refresh();
        }

        private void btn_findEmployee_Click(object sender, EventArgs e)
        {
            if (radioBtn_byId.Checked)
            {
                foreach (DataGridViewRow row in employeesDataGrid.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtBox_search.Text)
                    {
                        employeesDataGrid.ClearSelection();
                        employeesDataGrid.Rows[row.Index].Selected = true;
                        employeesDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }

            if (radioBtn_byName.Checked)
            {
                foreach (DataGridViewRow row in employeesDataGrid.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().ToLower().Contains(txtBox_search.Text.ToLower()))
                    {
                        employeesDataGrid.ClearSelection();
                        employeesDataGrid.Rows[row.Index].Selected = true;
                        employeesDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }
    }
}
