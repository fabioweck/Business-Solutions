using BusinessManager.ViewModels;
using System;
using System.Windows.Forms;

namespace BusinessManager.Views
{
    public partial class OrderView : Form
    { 
        public delegate void RefreshInvoicesDataGrid();

        public string Email {  get; set; }
        ServiceCartViewModel serviceCartViewModel = new ServiceCartViewModel();
        RefreshInvoicesDataGrid InvoicesDataGrid;


        public OrderView(int id, string name, string address, string email, string phone, RefreshInvoicesDataGrid invoicesDataGrid)
        {
            InitializeComponent();
            InitializeOrderGridView();
            InitializeCartGridView();
            this.Email = email;
            lbl_IdData.Text = id.ToString();
            lbl_nameData.Text = name;
            lbl_phoneData.Text = phone;
            InvoicesDataGrid = invoicesDataGrid;
        }
        private void InitializeOrderGridView()
        {
            OrderGridView.DataSource = ServicesViewModel.Services;
        }

        private void InitializeCartGridView()
        {
            //Use BindingSource for dynamic updates
            BindingSource cartBindingSource = new BindingSource();
            cartBindingSource.DataSource = serviceCartViewModel.ServicesCart;
            CartGridView.DataSource = cartBindingSource;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindService_Click(object sender, EventArgs e)
        {
            if (radBtnServiceID.Checked)
            {
                foreach (DataGridViewRow row in OrderGridView.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == txtSearchService.Text)
                    {
                        OrderGridView.ClearSelection();
                        OrderGridView.Rows[row.Index].Selected = true;
                        OrderGridView.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }

            if (radBtnDescription.Checked)
            {
                foreach (DataGridViewRow row in OrderGridView.Rows)
                {
                    if (row.Cells[1].Value != null && row.Cells[1].Value.ToString().ToLower().Contains(txtSearchService.Text.ToLower()))
                    {
                        OrderGridView.ClearSelection();
                        OrderGridView.Rows[row.Index].Selected = true;
                        OrderGridView.FirstDisplayedScrollingRowIndex = row.Index;
                    }
                }
            }
        }

        private void btn_addItem_Click(object sender, EventArgs e)
        {
            if (OrderGridView.SelectedRows.Count > 0 && CartGridView.Rows.Count < 14 && tB_quantity.Text != "" && int.Parse(tB_quantity.Text) != 0)
            {
                DataGridViewRow selectedRow = OrderGridView.SelectedRows[0];

                int id = (int)selectedRow.Cells["Id"].Value;
                string description = selectedRow.Cells["Description"].Value.ToString();
                double price = (double)selectedRow.Cells["Price"].Value;
                int qtd = int.Parse(tB_quantity.Text);

                serviceCartViewModel.AddToCart(qtd, id, description, price);
                lbl_totalSum.Text = $"${serviceCartViewModel.SumTotalCart()}";
                lblGST.Text = $"+${Math.Round(Convert.ToDouble(serviceCartViewModel.SumTotalCart()) * 0.05, 2)} GST";
            }
        }

        private void btn_removeItem_Click(object sender, EventArgs e)
        {
            if (CartGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = CartGridView.SelectedRows[0];

                int index = selectedRow.Index;

                serviceCartViewModel.RemoveFromCart(index);
                lbl_totalSum.Text = "$" + serviceCartViewModel.SumTotalCart().ToString();
            }
        }

        private void btn_createInvoice_Click(object sender, EventArgs e)
        {
            if (CartGridView.RowCount > 0)
            {
                serviceCartViewModel.GenerateInvoice(int.Parse(lbl_IdData.Text), lbl_nameData.Text, lbl_phoneData.Text, Email);
            }

            InvoicesDataGrid.Invoke();
            this.Close();
        }
    }
}
