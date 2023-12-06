using BusinessManager.ViewModels;
using Syncfusion.XlsIO.Parser.Biff_Records.PivotTable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManager.Views
{
    public partial class ItemProfileView : Form
    {
        public ItemProfileView()
        {
            InitializeComponent();
            btn_delete.Visible = false;
            lbl_id.Visible = false;
            lbl_Id_label.Visible = false;
            lbl_id.Text = "";

            this.StartPosition = FormStartPosition.CenterParent;
        }


        public ItemProfileView(int id, string description, double price, bool isAdmin )
        {
            InitializeComponent();

            if (!isAdmin)
            {
                btn_delete.Enabled = false;
                btn_delete.BackColor = Color.IndianRed;
            }

            this.StartPosition = FormStartPosition.CenterParent;

            this.lbl_id.Text = id.ToString();
            this.txtBox_description.Text = description;
            this.txtBox_price.Text = price.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ServicesViewModel.AddItem(lbl_id.Text,txtBox_description.Text,double.Parse(txtBox_price.Text));

            MessageBox.Show("Item saved successfully");

            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ServicesViewModel.RemoveItem(lbl_id.Text);

            MessageBox.Show("Item removed successfully");

            this.Close();
        }
    }
}