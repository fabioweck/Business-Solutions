using BusinessManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManager
{
    public partial class MainForm
    {
        string invoicePath;

        //This method defines the invoice the user want to open/visualize
        private void SelectedCellInvoice(object sender, DataGridViewCellEventArgs e)
        {
            //This unlocks the visualize button after selecting at least one row
            btnViewInvoice.Enabled = true;
            btnViewInvoice.BackColor = ButtonBase.DefaultBackColor;

            if (invoicesDataGrid.SelectedRows.Count > 0)
            {
                //Gets the object from row
                DataGridViewRow selectedRow = invoicesDataGrid.SelectedRows[0];

                //Gets the data from each column
                string name = selectedRow.Cells["Name"].Value.ToString();
                string path = selectedRow.Cells["File"].Value.ToString();

                //Displays which invoice will be opened
                lblSelectInvoice.Text = $"Invoice selected: {name}";

                //Assign the correct path to the variable
                invoicePath = path;
            }
        }

        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            //Takes the assigned path and passes as argument to the viewer
            InvoiceView invoiceView = new InvoiceView(invoicePath);
            invoiceView.ShowDialog();
        }
    }
}
