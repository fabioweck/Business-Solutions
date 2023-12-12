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

namespace BusinessManager.Views
{
    public partial class LoginView : Form
    {
        private EmployeeViewModel employeeViewModel;

        public MainForm mainForm = new MainForm();

        public BindingList<Models.EmployeeModel> employees;

        public LoginView()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Visible = false;

            employeeViewModel = new EmployeeViewModel();
            textBox_password.PasswordChar = '*';

            LogoutListener logoutListener = new LogoutListener(mainForm);

            // Subscribe to the LogoutRequested event
            mainForm.LogoutRequested += MainForm_LogoutRequested;
            employees = EmployeeViewModel.Employees;
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        { 
          
            Models.EmployeeModel employeeModel = employees.ToList().Find(emp => emp.Email == textBox_email.Text);

            if (employeeModel == null)
            {
                MessageBox.Show("User not found");
                return;
            }

            if (employeeModel.Password != textBox_password.Text)
            {
                MessageBox.Show("Invalid user");
                return;
            }

            // Creating an instance of MainForm
            mainForm.UpdateMainForm(employeeModel);

            // Hide the current form
            this.Visible = false;

            // Show the MainForm
            mainForm.ShowDialog();
        }

        // Event handler for the MainForm's LogoutRequested event
        private void MainForm_LogoutRequested(object sender, EventArgs e)
        {
            this.textBox_email.Text = "";
            this.textBox_password.Text = "";
            this.Visible = true;
            mainForm.Close();        
        }

        public class LogoutListener
        {
            private MainForm mainForm;

            public LogoutListener(MainForm mainForm)
            {
                this.mainForm = mainForm;
                WireUpEvents();
            }

            private void WireUpEvents()
            {
                if (mainForm != null)
                {
                    mainForm.LogoutRequested += MainForm_LogoutRequested;
                }
            }
            private void MainForm_LogoutRequested(object sender, EventArgs e)
            {
                MessageBox.Show("Success logout");
            }
        }
    }
}
