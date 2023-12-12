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
        ClientViewModel ListOfClients = new ClientViewModel();
        ServicesViewModel ListOfServices { get; set; }
        //  EmployeeViewModel ListOfEmployees { get; set; }
        InvoiceViewModel ListOfInvoices { get; set; }
        EmployeeModel LoggerUser { get; set; }
        public bool isAdmin { get; set; }
        public int userID { get; set; } = 0;
        public static string ProgramPath = string.Empty;

        public event EventHandler LogoutRequested;


        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void UpdateMainForm(EmployeeModel loggedUser)
        {
            isAdmin = loggedUser.IsAdmin;
            userID = loggedUser.Id;

            string currentDirectory = Directory.GetCurrentDirectory();
            int index = currentDirectory.LastIndexOf("bin");
            ProgramPath = currentDirectory.Substring(0, index);


            ListOfServices = new ServicesViewModel();
            ListOfServices.PopulateServices();
          
            ListOfInvoices = new InvoiceViewModel();

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

            //Assigns collections to data grids
            clientsDataGrid.DataSource = ClientViewModel.Clients;
            servicesDataGrid.DataSource = ServicesViewModel.Services;
            employeesDataGrid.DataSource = EmployeeViewModel.Employees;
            invoicesDataGrid.DataSource = InvoiceViewModel.Invoices;


            //this.BackgroundImage = Image.FromFile(ProgramPath + "Assets\\backgroundImage.jpg");

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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnLogoutRequested();
            this.Close();
        }
        protected virtual void OnLogoutRequested()
        {
            LogoutRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}
