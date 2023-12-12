using BusinessManager.ViewModels;
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
        private void btn_addEmployee_Click(object sender, EventArgs e)
        {
            EmployeeView employeeView = new EmployeeView();
            employeeView.ShowDialog();
            employeesDataGrid.Refresh();
        }

        private void employee_details_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = employeesDataGrid.SelectedRows[0];
            int id = (int)selectedRow.Cells["Id"].Value;
            string name = selectedRow.Cells["Name"].Value.ToString();
            string address = selectedRow.Cells["Address"].Value.ToString();
            string email = selectedRow.Cells["Email"].Value.ToString();
            string phone = selectedRow.Cells["Phone"].Value.ToString();
            string password = selectedRow.Cells["Password"].Value.ToString();
            string confirmPassword = selectedRow.Cells["ConfirmPassword"].Value.ToString();
            bool isAdmin = (Boolean)selectedRow.Cells["IsAdmin"].Value;

            EmployeeView employeeProfileView = new EmployeeView(id, name, address, email,
                phone, password, confirmPassword, isAdmin);

            employeeProfileView.ShowDialog();
            employeesDataGrid.Refresh();
        }

        private void btn_deleteEmployee_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = employeesDataGrid.SelectedRows[0];
            int id = (int)selectedRow.Cells["Id"].Value;
            string name = selectedRow.Cells["Name"].Value.ToString();
            string address = selectedRow.Cells["Address"].Value.ToString();
            string email = selectedRow.Cells["Email"].Value.ToString();
            string phone = selectedRow.Cells["Phone"].Value.ToString();
            string password = selectedRow.Cells["Password"].Value.ToString();
            string confirmPassword = selectedRow.Cells["confirmPassword"].Value.ToString();
            bool isAdmin = (Boolean)selectedRow.Cells["IsAdmin"].Value;

            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                EmployeeViewModel.RemoveEmployee(id);

                MessageBox.Show("Employee removed successfully");

                employeesDataGrid.Refresh();
            }
        }

        private void btn_findEmployee_Click(object sender, EventArgs e)
        {
            if (radioBtn_byId.Checked)
            {
                foreach (DataGridViewRow row in employeesDataGrid.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtBox_search.Text)
                    {
                        employeesDataGrid.ClearSelection();
                        employeesDataGrid.Rows[row.Index].Selected = true;
                        employeesDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }

            if (radioBtn_byName.Checked)
            {
                foreach (DataGridViewRow row in employeesDataGrid.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().ToLower().Contains(txtBox_search.Text.ToLower()))
                    {
                        employeesDataGrid.ClearSelection();
                        employeesDataGrid.Rows[row.Index].Selected = true;
                        employeesDataGrid.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }
    }
}
