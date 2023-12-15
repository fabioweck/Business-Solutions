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
    
    public partial class MainForm
    {

        //Method to search for a client
        private void BtnFindClient_Click(object sender, EventArgs e)
        {

            //If search for id, the proceed
            if(radBtnClientID.Checked)
            {
                //Iterates over the data grid
                foreach(DataGridViewRow row in clientsDataGrid.Rows)
                {
                    //If find the client, then display
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtSearchClient.Text)
                    {
                        clientsDataGrid.ClearSelection();
                        clientsDataGrid.Rows[row.Index].Selected = true;
                        clientsDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }

            //If search for name, the proceed
            if (radBtnClientName.Checked)
            {
                //Iterates over the data grid
                foreach (DataGridViewRow row in clientsDataGrid.Rows)
                {
                    //If find the client, then display
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().ToLower().StartsWith(txtSearchClient.Text.ToLower()))
                    {                      
                        clientsDataGrid.ClearSelection();
                        clientsDataGrid.Rows[row.Index].Selected = true;
                        clientsDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }

            //If search for email, the proceed
            if (radBtnClientEmail.Checked)
            {
                //Iterates over the data grid
                foreach (DataGridViewRow row in clientsDataGrid.Rows)
                {
                    //If find the client, then display
                    if (row.Cells[3].Value != null && row.Cells[3].Value.ToString().ToLower().StartsWith(txtSearchClient.Text.ToLower()))
                    {
                        clientsDataGrid.ClearSelection();
                        clientsDataGrid.Rows[row.Index].Selected = true;
                        clientsDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }

        //Method to open client profile view
        private void addButton1_Click(object sender, EventArgs e)
        {
            ClientProfileView addNewClientView2 = new ClientProfileView();
            addNewClientView2.ShowDialog();
        }

        //Method to display client details
        private void btnClientDetails_Click_1(object sender, EventArgs e)
        {
            if (clientsDataGrid.SelectedRows.Count > 0)
            {
                //first get selected row
                DataGridViewRow selectedRow = clientsDataGrid.SelectedRows[0];

                //Defines all information
                int id = (int)selectedRow.Cells["Id"].Value;
                string name = selectedRow.Cells["Name"].Value.ToString();
                string address = selectedRow.Cells["Address"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string phone = selectedRow.Cells["Phone"].Value.ToString();

                //Pass information to open a client profile view
                ClientProfileView clientProfileView = new ClientProfileView(id, name, address, email, phone, isAdmin);
                clientProfileView.ShowDialog();

                //Refresh the list of clients
                clientsDataGrid.Refresh();
            }
        }

        //Method to open a client profile view
        private void btn_addNewClient_Click(object sender, EventArgs e)
        {
            ClientProfileView addNewClientView2 = new ClientProfileView();
            addNewClientView2.ShowDialog();
            clientsDataGrid.Refresh();
        }

        //Method to open a new order view
        private void btn_newOrder_Click(object sender, EventArgs e)
        {
            //Gets the selected client
            if (clientsDataGrid.SelectedRows.Count > 0)
            {
                //defines information contained in the row
                DataGridViewRow selectedRow = clientsDataGrid.SelectedRows[0];

                int id = (int)selectedRow.Cells["Id"].Value;
                string name = selectedRow.Cells["Name"].Value.ToString();
                string address = selectedRow.Cells["Address"].Value.ToString();
                string email = selectedRow.Cells["Email"].Value.ToString();
                string phone = selectedRow.Cells["Phone"].Value.ToString();

                //Pass all information to open an order view
                OrderView orderView = new OrderView(id, name, address, email, phone, invoicesDataGrid.Refresh);
                orderView.ShowDialog();
            }
        }
    }
}
