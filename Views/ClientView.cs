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
        private void btnFindClient_Click(object sender, EventArgs e)
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

        //private void btnClientDetails_Click(object sender, EventArgs e)
        //{
        //    if (clientsDataGrid.SelectedRows.Count > 0)
        //    {
        //        DataGridViewRow selectedRow = clientsDataGrid.SelectedRows[0];

        //        string name = selectedRow.Cells["Name"].Value.ToString();
        //        int id = (int)selectedRow.Cells["Id"].Value;
        //        string address = selectedRow.Cells["Address"].Value.ToString();
        //        string email = selectedRow.Cells["Email"].Value.ToString();
        //        string phone = selectedRow.Cells["Phone"].Value.ToString();

        //        ClientDetailsView clientDetails = new ClientDetailsView(name, id, address, email, phone);
        //        clientDetails.ShowDialog();
        //        clientsDataGrid.Refresh();
        //    }
        //}
    }
}
