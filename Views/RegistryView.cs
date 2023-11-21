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

        private void SelectedCellInvoice(object sender, DataGridViewCellEventArgs e)
        {
            btnViewInvoice.Enabled = true;
            btnViewInvoice.BackColor = ButtonBase.DefaultBackColor;

            if (invoicesDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = invoicesDataGrid.SelectedRows[0];

                // Assuming your DataGridView has columns named "NameColumn" and "AgeColumn"
                string name = selectedRow.Cells["Name"].Value.ToString();
                string path = selectedRow.Cells["File"].Value.ToString();

                lblSelectInvoice.Text = $"Invoice selected: {name}";
                // Display the selected row's data in a label
                invoicePath = path;
            }
        }

        private void btnViewInvoice_Click(object sender, EventArgs e)
        {
            InvoiceView invoiceView = new InvoiceView(invoicePath);
            invoiceView.ShowDialog();
        }
    }
}
