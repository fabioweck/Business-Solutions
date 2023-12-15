using BusinessManager.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManager.Views
{
    public partial class ClientProfileView : Form
    {
        public ClientProfileView()
        {
            InitializeComponent();

            //Hide information
            btn_delete.Visible = false;
            lbl_id.Visible = false;
            lbl_Id_label.Visible = false;
            lbl_id.Text = "";

            this.StartPosition = FormStartPosition.CenterParent;

        }

        //Overload constructor
        public ClientProfileView(int id,  string name, string address, string email, string phone, bool isAdmin)
        {
            InitializeComponent();

            //Check if it is admin or not
            if (!isAdmin)
            {
                btn_delete.Enabled = false;
                btn_delete.BackColor = Color.IndianRed;
                txt_box_name.Enabled = false;
            }

            this.StartPosition = FormStartPosition.CenterParent;

            //Display info
            this.lbl_id.Text = id.ToString();
            this.txt_box_name.Text = name;
            this.txt_box_address.Text = address;
            this.txt_box_email.Text = email;
            this.txt_box_phone.Text = phone;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Method to check if the email is in a valid format
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            //User regex to check
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        //Method to add a client
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            //First check if the email format is valid
            if (IsValidEmail(txt_box_email.Text))
            {
                //Calls add client method from ClientViewModel
                ClientViewModel.AddClient(lbl_id.Text, txt_box_name.Text, txt_box_address.Text, txt_box_email.Text, txt_box_phone.Text);

                MessageBox.Show("Client saved successfully");

                this.Close();
            }
            else
            {
                MessageBox.Show("Email invalid");
            }
        }

        //Method to delete client
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //Calls remove client method from ClientViewModel
            ClientViewModel.RemoveClient(lbl_id.Text);

            MessageBox.Show("Client removed successfully");

            this.Close();
        }
    }
}
