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
        //Method to filter table by service
        private void btnFindService_Click(object sender, EventArgs e)
        {
        
            //If filter by ID is checked, then proceed
            if (radBtnServiceID.Checked)
            {
                foreach (DataGridViewRow row in servicesDataGrid.Rows)
                {
                    //If finds the row, the highlight the item on the table
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtSearchService.Text)
                    {
                        servicesDataGrid.ClearSelection();
                        servicesDataGrid.Rows[row.Index].Selected = true;
                        servicesDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }

            //If filter by description is checked, then proceed
            if (radBtnDescription.Checked)
            {
                foreach (DataGridViewRow row in servicesDataGrid.Rows)
                {
                    //If finds the row, the highlight the item on the table
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().ToLower().Contains(txtSearchService.Text.ToLower()))
                    {
                        servicesDataGrid.ClearSelection();
                        servicesDataGrid.Rows[row.Index].Selected = true;
                        servicesDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }

        //Method to open the item profile view
        private void btn_itemDetail_Click(object sender, EventArgs e)
        {
            if (servicesDataGrid.SelectedRows.Count > 0)
            {
                //Get the row data
                DataGridViewRow selectedRow = servicesDataGrid.SelectedRows[0];

                //Get the information
                int id = (int)selectedRow.Cells["Id"].Value;
                string description = selectedRow.Cells["Description"].Value.ToString();
                string price = selectedRow.Cells["Price"].Value.ToString();

                //Open a new item profile view with data
                ItemProfileView itemProfileView = new ItemProfileView(id, description, double.Parse(price), isAdmin);
                itemProfileView.ShowDialog();

                //Refresh services data grid view
                servicesDataGrid.Refresh();
            }
        }

        //Method to add an item to the table
        private void btn_addItem_Click(object sender, EventArgs e)
        {
            //Open a new Item profile view
            ItemProfileView addItem = new ItemProfileView();
            addItem.ShowDialog();

            //Refresh services data grid view
            servicesDataGrid.Refresh();
        }
    }
}
