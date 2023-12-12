using BusinessManager.ViewModels;
using BusinessManager.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManager
{

    //Extension of main form to handle Client Tab
    public partial class MainForm
    {
        private void BtnFindClient_Click(object sender, EventArgs e)
        {
            if(radBtnClientID.Checked)
            {
                foreach(DataGridViewRow row in clientsDataGrid.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtSearchClient.Text)
                    {
                        clientsDataGrid.ClearSelection();
                        clientsDataGrid.Rows[row.Index].Selected = true;
                        clientsDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }

            if(radBtnClientName.Checked)
            {
                foreach (DataGridViewRow row in clientsDataGrid.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().ToLower().StartsWith(txtSearchClient.Text.ToLower()))
                    {
                        clientsDataGrid.ClearSelection();
                        clientsDataGrid.Rows[row.Index].Selected = true;
                        clientsDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }

            if (radBtnClientEmail.Checked)
            {
                foreach (DataGridViewRow row in clientsDataGrid.Rows)
                {
                    if (row.Cells[3].Value != null && row.Cells[3].Value.ToString().ToLower().StartsWith(txtSearchClient.Text.ToLower()))
                    {
                        clientsDataGrid.ClearSelection();
                        clientsDataGrid.Rows[row.Index].Selected = true;
                        clientsDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            ClientProfileView addNewClientView2 = new ClientProfileView();
            addNewClientView2.ShowDialog();
        }

        private void btnClientDetails_Click_1(object sender, EventArgs e)
        {
            if (clientsDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = clientsDataGrid.SelectedRows[0];

                int id = (int)selectedRow.Cells["Id"].Value;
                string name = selectedRow.Cells["Name"].Value.ToString();
                string address = selectedRow.Cells["Address"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string phone = selectedRow.Cells["Phone"].Value.ToString();

                ClientProfileView clientProfileView = new ClientProfileView(id, name, address, email, phone, isAdmin);
                clientProfileView.ShowDialog();

                clientsDataGrid.Refresh();
            }
        }

        private void btn_addNewClient_Click(object sender, EventArgs e)
        {
            ClientProfileView addNewClientView2 = new ClientProfileView();
            addNewClientView2.ShowDialog();
            clientsDataGrid.Refresh();
        }

        private void btn_newOrder_Click(object sender, EventArgs e)
        {

            if (clientsDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = clientsDataGrid.SelectedRows[0];

                int id = (int)selectedRow.Cells["Id"].Value;
                string name = selectedRow.Cells["Name"].Value.ToString();
                string address = selectedRow.Cells["Address"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string phone = selectedRow.Cells["Phone"].Value.ToString();

                // ClientProfileView clientProfileView = new ClientProfileView(id, name, address, email, phone, isAdmin);
                // clientProfileView.ShowDialog();

                OrderView orderView = new OrderView(id, name, address, email, phone, invoicesDataGrid.Refresh);
                orderView.ShowDialog();
                // clientsDataGrid.Refresh();
            }
        }
    }
}
