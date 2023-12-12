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

namespace BusinessManager.Views
{
    public partial class SendEmail : Form
    {
        private string File;

        public SendEmail(string file)
        {
            InitializeComponent();
            File = file;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private async void btnSendInvoice_Click(object sender, EventArgs e)
        {
            string email = txtBoxEmail.Text;

            try
            {
                await InvoiceViewModel.SendEmail(email, File);
                MessageBox.Show($"Invoice succesfully sent to {email}", "Invoice sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Unable to send invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelSendInvoice_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
