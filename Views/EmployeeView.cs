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
    public partial class EmployeeView : Form
    {
        public EmployeeView(int id, string name, string address, string email, string phone, string password, bool isAdmin)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.lbl_id.Text = id.ToString();
            this.txt_box_name.Text = name;
            this.txt_box_address.Text = address;
            this.txt_box_email.Text = email;
            this.txt_box_phone.Text = phone;
            this.txtBox_password.Text = password;
            this.checkBox_admin.Checked = isAdmin;
            this.txtBox_password.PasswordChar = '*';
        }

        public EmployeeView()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            lbl_id.Visible = false;
            lbl_Id_label.Visible = false;
            lbl_id.Text = "";
        }
        private void EmployeeControl_Load(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click_1(object sender, EventArgs e)
        {
            EmployeeViewModel.AddEmployee(lbl_id.Text, txt_box_name.Text,
                txt_box_address.Text, txt_box_email.Text, txt_box_phone.Text,
                checkBox_admin.Checked, txtBox_password.Text);

            MessageBox.Show("Employee saved successfully");

            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}