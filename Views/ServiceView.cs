using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager
{
    public partial class MainForm
    {
        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                ListOfServices.AddService(txtDescription.Text, Convert.ToDouble(txtPrice.Text));
            }
            catch
            {
                lblPrice.Text = "Please enter a valid price";
                return;
            }


            //Change data source to null to clear the grid view, then set data source again with new list
            servicesDataGrid.DataSource = null;
            servicesDataGrid.DataSource = ListOfServices.Services;

            if (servicesDataGrid.Rows.Count > 0)
            {
                int lastIndex = servicesDataGrid.Rows.Count - 1;
                servicesDataGrid.FirstDisplayedScrollingRowIndex = lastIndex;
                servicesDataGrid.Rows[lastIndex].Selected = true; // Optionally select the last row
            }
        }
    }
}
