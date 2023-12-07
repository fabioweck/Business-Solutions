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
        private void btnFindService_Click(object sender, EventArgs e)
        {
        
            if (radBtnServiceID.Checked)
            {
                foreach (DataGridViewRow row in servicesDataGrid.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtSearchService.Text)
                    {
                        servicesDataGrid.ClearSelection();
                        servicesDataGrid.Rows[row.Index].Selected = true;
                        servicesDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }

            if (radBtnDescription.Checked)
            {
                foreach (DataGridViewRow row in servicesDataGrid.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().ToLower().Contains(txtSearchService.Text.ToLower()))
                    {
                        servicesDataGrid.ClearSelection();
                        servicesDataGrid.Rows[row.Index].Selected = true;
                        servicesDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }
    }
}
