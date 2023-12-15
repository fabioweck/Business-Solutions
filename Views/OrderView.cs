using BusinessManager.ViewModels;
using System;
using System.Windows.Forms;

namespace BusinessManager.Views
{
    public partial class OrderView : Form
    {
        //Delegate to accept method from parent
        public delegate void RefreshInvoicesDataGrid();

        public string Email {  get; set; }

        //Instantiate a new SerivceCartModel
        ServiceCartViewModel serviceCartViewModel = new ServiceCartViewModel();
        RefreshInvoicesDataGrid InvoicesDataGrid;

        public OrderView(int id, string name, string address, string email, string phone, RefreshInvoicesDataGrid invoicesDataGrid)
        {
            InitializeComponent();
            InitializeOrderGridView();
            InitializeCartGridView();
            this.StartPosition = FormStartPosition.CenterParent;
            this.Email = email;
            lbl_IdData.Text = id.ToString();
            lbl_nameData.Text = name;
            lbl_phoneData.Text = phone;
            InvoicesDataGrid = invoicesDataGrid;
        }

        //Method to assign data bindings to order grid view
        private void InitializeOrderGridView()
        {
            OrderGridView.DataSource = ServicesViewModel.Services;
        }

        //Method to initialize cart grid view
        private void InitializeCartGridView()
        {
            //Use BindingSource for dynamic updates
            BindingSource cartBindingSource = new BindingSource();
            cartBindingSource.DataSource = serviceCartViewModel.ServicesCart;
            CartGridView.DataSource = cartBindingSource;
        }

        //Closes the window
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Method to find a service
        private void btnFindService_Click(object sender, EventArgs e)
        {
            //Find a service by ID
            if (radBtnServiceID.Checked)
            {
                foreach (DataGridViewRow row in OrderGridView.Rows)
                {
                    //Once the service is found, highlight on the table
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtSearchService.Text)
                    {
                        OrderGridView.ClearSelection();
                        OrderGridView.Rows[row.Index].Selected = true;
                        OrderGridView.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }

            //Find a service by description
            if (radBtnDescription.Checked)
            {
                foreach (DataGridViewRow row in OrderGridView.Rows)
                {
                    //Once the service is found, highlight on the table
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().ToLower().Contains(txtSearchService.Text.ToLower()))
                    {
                        OrderGridView.ClearSelection();
                        OrderGridView.Rows[row.Index].Selected = true;
                        OrderGridView.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }

        //Method to add a service to the invoice
        private void btn_addItem_Click(object sender, EventArgs e)
        {
            //Determine a limit of 14 rows in order to not overlap the invoice document
            if (OrderGridView.SelectedRows.Count > 0 && CartGridView.Rows.Count < 14 && tB_quantity.Text != "" && int.Parse(tB_quantity.Text) != 0)
            {
                DataGridViewRow selectedRow = OrderGridView.SelectedRows[0];

                //Get all the information form the table
                int id = (int)selectedRow.Cells["Id"].Value;
                string description = selectedRow.Cells["Description"].Value.ToString();
                double price = (double)selectedRow.Cells["Price"].Value;
                int qtd = int.Parse(tB_quantity.Text);

                //Add the service to the cart
                serviceCartViewModel.AddToCart(qtd, id, description, price);

                //Display the total amount and GST
                lbl_totalSum.Text = $"${serviceCartViewModel.SumTotalCart()}";
                lblGST.Text = $"+${Math.Round(Convert.ToDouble(serviceCartViewModel.SumTotalCart()) * 0.05, 2)} GST";
            }
        }

        //Method to remove a service from the cart
        private void btn_removeItem_Click(object sender, EventArgs e)
        {
            if (CartGridView.SelectedRows.Count > 0)
            {
                //Get the selected row
                DataGridViewRow selectedRow = CartGridView.SelectedRows[0];

                int index = selectedRow.Index;

                //Pass the row's index to be removed
                serviceCartViewModel.RemoveFromCart(index);

                //update total and GST amount
                lbl_totalSum.Text = "$" + serviceCartViewModel.SumTotalCart().ToString();
                lblGST.Text = $"+${Math.Round(Convert.ToDouble(serviceCartViewModel.SumTotalCart()) * 0.05, 2)} GST";
            }
        }

        //Method to create an invoice
        private void btn_createInvoice_Click(object sender, EventArgs e)
        {
            if (CartGridView.RowCount > 0)
            {
                //Call the method from ServiceCartViewModel
                serviceCartViewModel.GenerateInvoice(int.Parse(lbl_IdData.Text), lbl_nameData.Text, lbl_phoneData.Text, Email);
            }

            //Invoke the delegate to refresh/populate the invoices table
            InvoicesDataGrid.Invoke();
            this.Close();
        }
    }
}
