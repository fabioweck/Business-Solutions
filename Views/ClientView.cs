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
    }
}
