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
using System.Net.Mail;
using System.Net;

namespace BusinessManager
{
    partial class MainForm : Form
    {

        //Instantiate all classes needed, once they contain static lists/properties
        ClientViewModel ListOfClients = new ClientViewModel();
        ServicesViewModel ListOfServices { get; set; }
        InvoiceViewModel ListOfInvoices { get; set; }
        EmployeeModel LoggerUser { get; set; }

        public bool isAdmin { get; set; }
        public int userID { get; set; } = 0;
        public static string ProgramPath = string.Empty;

        //Handle the logout event
        public event EventHandler LogoutRequested;

        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Method to define the program behavior based on type of user (admin or employee)
        public void UpdateMainForm(EmployeeModel loggedUser)
        {
            isAdmin = loggedUser.IsAdmin;
            userID = loggedUser.Id;

            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            ProgramPath = currentDirectory.Substring(0, index);
            
            //instantiate classes to generate lists
            ListOfServices = new ServicesViewModel();
            ListOfServices.PopulateServices();
            ListOfInvoices = new InvoiceViewModel();

            //Check if user is not admin
            if (!isAdmin)
            {
                //If not admin, then the user can only see own name
                EmployeeViewModel.Employees = new BindingList<EmployeeModel>
                {
                    loggedUser
                };

                //hide all forbidden buttons for employees
                btn_addEmployee.Visible = false;
                lbl_addEmployee.Visible = false;
                btn_deleteEmployee.Visible = false;
                lbl_deleteEmployee.Visible = false;
                btn_addItem.Visible = false;
            }

            //Assigns collections to data grids
            clientsDataGrid.DataSource = ClientViewModel.Clients;
            servicesDataGrid.DataSource = ServicesViewModel.Services;
            employeesDataGrid.DataSource = EmployeeViewModel.Employees;
            invoicesDataGrid.DataSource = InvoiceViewModel.Invoices;

            this.LoggerUser = loggedUser;
            this.employeesDataGrid.Columns["Password"].Visible = false;
            this.employeesDataGrid.Columns["ConfirmPassword"].Visible = false;

            //If the user is not admin, hide some properties
            if (!isAdmin)
            {
                this.employeesDataGrid.Columns["IsAdmin"].Visible = false;
            }
        }

        //Method to close application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Method to call logout
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnLogoutRequested();

            //Re-enable all buttons in case of 'adm' login
            btn_addEmployee.Visible = true;
            lbl_addEmployee.Visible = true;
            btn_deleteEmployee.Visible = true;
            lbl_deleteEmployee.Visible = true;
            btn_addItem.Visible = true;
            this.Close();
        }

        //Method to invoke logout
        protected virtual void OnLogoutRequested()
        {
            
            LogoutRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
