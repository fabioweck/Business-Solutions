﻿using BusinessManager.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManager.Views
{
    public partial class EmployeeView : Form
    {

        public EmployeeView()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            lbl_id.Visible = false;
            lbl_Id_label.Visible = false;
            lbl_id.Text = "";
        }

        //Overload constructor
        public EmployeeView(int id, string name, string address,
            string email, string phone, string password, string confirmPassword, bool isAdmin)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            this.lbl_id.Text = id.ToString();
            this.txt_box_name.Text = name;
            this.txt_box_address.Text = address;
            this.txt_box_email.Text = email;
            this.txt_box_phone.Text = phone;
            this.txtBox_password.Text = password;
            this.txtBox_password.PasswordChar = '*';
            this.txtBox_confirmPassword.Text = confirmPassword;
            this.txtBox_confirmPassword.PasswordChar = '*';
            this.checkBox_admin.Checked = isAdmin;

            //check if it's admin
            if (!isAdmin)
            {
                checkBox_admin.Visible = false;
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //Method to add a new employee
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            //check if the email has a valid format
            if (!IsValidEmail(txt_box_email.Text))
            {
                MessageBox.Show("Invalid email format.Please enter a valid email address.", "Error");
                return;
            }

            //check if any field is empty
            if (string.IsNullOrEmpty(txtBox_password.Text) || string.IsNullOrEmpty(txtBox_confirmPassword.Text))
            {
                MessageBox.Show("Please fill in both password and confirmation fields.", "Error");
                return;
            }

            //Check if the password matches
            if (txtBox_password.Text != txtBox_confirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match. Please make sure your password and confirmation match.", "Error");
                return;
            }

            //Pass info to add an employee
            EmployeeViewModel.AddEmployee(lbl_id.Text, txt_box_name.Text,
            txt_box_address.Text, txt_box_email.Text, txt_box_phone.Text,
            txtBox_password.Text, txtBox_confirmPassword.Text, checkBox_admin.Checked);

            MessageBox.Show("Employee saved successfully");

            this.Close();
        }

        //method to check if the email is valid
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            //use regex to check
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}