using BusinessManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mime;

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

        private void btnSendEmail_Click(object sender, EventArgs e)
        {

            var toAddress = "fabio.weck@gmail.com";
            var smtpServer = "smtp.gmail.com";
            var username = "radprojectgroup7@gmail.com";
            var password = "iqpvopsltwntzsqc";

            MailAddress to = new MailAddress(toAddress);
            MailAddress from = new MailAddress(username);

            MailMessage email = new MailMessage(from, to);
            email.Subject = "Testing out email sending";
            email.Body = "Hello all the way from the land of C#";
            var attachment = new Attachment(invoicePath);
            email.Attachments.Add(attachment);

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
            smtp.Host = smtpServer;
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(username, password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(email);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
