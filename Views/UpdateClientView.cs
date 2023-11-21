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
    public partial class UpdateClientView : Form
    {
        private int Id;

        public UpdateClientView(string name, int id)
        {
            InitializeComponent();

            lblClientName.Text = name;
            Id = id;

            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Checked_CheckBoxes(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;

            if(chk.Checked)
            {
                switch (chk.Name)
                {
                    case "chkAddress":
                        txtAddress.Enabled = true;
                        break;
                    case "chkEmail":
                        txtEmail.Enabled = true;
                        break;
                    case "chkPhone":
                        txtPhone.Enabled = true;
                        break;
                }
            }
            else
            {
                switch (chk.Name)
                {
                    case "chkAddress":
                        txtAddress.Enabled = false;
                        break;
                    case "chkEmail":
                        txtEmail.Enabled = false;
                        break;
                    case "chkPhone":
                        txtPhone.Enabled = false;
                        break;
                }
            }    
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string address = string.Empty, email = string.Empty, phone = string.Empty;
            if(chkAddress.Checked) address = txtAddress.Text;
            if(chkEmail.Checked) email = txtEmail.Text;
            if(chkPhone.Checked) phone = txtPhone.Text;

            ClientViewModel.UpdateClient(Id, address, email, phone);
            MessageBox.Show("Client details updated.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
