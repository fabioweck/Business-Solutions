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
    public partial class ClientDetailsView : Form
    {
        public ClientDetailsView(string name, int id, string address, string email, string phone)
        {
            InitializeComponent();

            lblName.Text = name;
            lblAddress.Text = address;
            lblEmail.Text = email;
            lblPhone.Text = phone;
            lblID.Text = id.ToString();

            this.StartPosition = FormStartPosition.CenterParent;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateClientView clientUpdate = new UpdateClientView(lblName.Text, Convert.ToInt16(lblID.Text));
            clientUpdate.ShowDialog();
            this.Close();
        }
    }
}
