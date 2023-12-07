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
            btn_delete.Visible = false;
            lbl_id.Visible = false;
            lbl_Id_label.Visible = false;
            lbl_id.Text = "";

            this.StartPosition = FormStartPosition.CenterParent;

        }

        public ClientProfileView(int id,  string name, string address, string email, string phone, bool isAdmin)
        {
            InitializeComponent();

            if (!isAdmin)
            {
                btn_delete.Enabled = false;
                btn_delete.BackColor = Color.IndianRed;
                txt_box_name.Enabled = false;
            }

            this.StartPosition = FormStartPosition.CenterParent;

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
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(txt_box_email.Text))
            {
                ClientViewModel.AddClient(lbl_id.Text, txt_box_name.Text, txt_box_address.Text, txt_box_email.Text, txt_box_phone.Text);

                MessageBox.Show("Client saved successfully");

                this.Close();
            }
            else
            {
                MessageBox.Show("Email invalid");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ClientViewModel.RemoveClient(lbl_id.Text);

            MessageBox.Show("Client removed successfully");

            this.Close();
        }
    }
}
