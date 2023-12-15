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
    public partial class SendEmailView : Form
    {
        //Variable to hold file path
        private string File;

        public SendEmailView(string file)
        {
            InitializeComponent();
            File = file;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //Method to send invoice by email
        private async void btnSendInvoice_Click(object sender, EventArgs e)
        {
            //get the email address
            string email = txtBoxEmail.Text;

            try
            {
                //Call the task from InvoiceViewModel and advise the user
                await InvoiceViewModel.SendInvoice(email, File);
                MessageBox.Show($"Invoice succesfully sent to {email}", "Invoice sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                //Display a message if it is not possible to send the email
                MessageBox.Show("Unable to send invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Method to close the window
        private void btnCancelSendInvoice_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
