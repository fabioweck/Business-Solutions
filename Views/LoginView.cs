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
        public LoginView()
        {
            InitializeComponent();
            employeeViewModel = new EmployeeViewModel();  
            textBox_password.PasswordChar = '*';
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
  

        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            BindingList<Models.EmployeeModel> employees = EmployeeViewModel.Employees;
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
            this.Visible = false;
            new MainForm(employeeViewModel, employeeModel).ShowDialog();
           this.Close();

        }
    }
}
