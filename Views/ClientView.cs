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

namespace BusinessManager
{

    //Extension of main form to handle Client Tab
    public partial class MainForm
    {
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ListOfClients.AddClient(txtName.Text, txtAddress.Text, txtEmail.Text);

            //Change data source to null to clear the grid view, then set data source again with new list

            clientsDataGrid.DataSource = null;
            clientsDataGrid.DataSource = ListOfClients.Clients;

            if (clientsDataGrid.Rows.Count > 0)
            {
                int lastIndex = clientsDataGrid.Rows.Count - 1;
                clientsDataGrid.FirstDisplayedScrollingRowIndex = lastIndex;
                clientsDataGrid.Rows[lastIndex].Selected = true; // Optionally select the last row
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(radBtnID.Checked)
            {
                foreach(DataGridViewRow row in clientsDataGrid.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtSearch.Text)
                    {
                        clientsDataGrid.ClearSelection();
                        clientsDataGrid.Rows[row.Index].Selected = true;
                        clientsDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }

            if(radBtnName.Checked)
            {
                foreach (DataGridViewRow row in clientsDataGrid.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().ToLower().StartsWith(txtSearch.Text.ToLower()))
                    {
                        clientsDataGrid.ClearSelection();
                        clientsDataGrid.Rows[row.Index].Selected = true;
                        clientsDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }

            if (radBtnEmail.Checked)
            {
                foreach (DataGridViewRow row in clientsDataGrid.Rows)
                {
                    if (row.Cells[3].Value != null && row.Cells[3].Value.ToString().ToLower().StartsWith(txtSearch.Text.ToLower()))
                    {
                        clientsDataGrid.ClearSelection();
                        clientsDataGrid.Rows[row.Index].Selected = true;
                        clientsDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }

    }
}
