using BusinessManager.Models;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManager.ViewModels
{

    //This class manipulates all the models and serves as a bridge between the model and the view

    public class InvoiceViewModel
    {
        //Create a list of invoices and a counter for them
        public static BindingList<InvoiceModel> Invoices { get; set; }
        public static int InvoicesCounter = 0;

        public InvoiceViewModel() 
        {
            Invoices = new BindingList<InvoiceModel>();
            //populate the list of invoices
            PopulateInvoicesList();
        }

        //Method to populate list of invoices
        public static void PopulateInvoicesList()
        {
            //If the invoices list contains any invoice, clear to show properly on the table
            if(Invoices.Count > 0)
            {
                Invoices.Clear();
            }

            //Reads the current path and set the correct path to locate the invoice
            string path = MainForm.ProgramPath + "Assets\\invoices";

            if (Directory.Exists(path))
            {
                // Get the list of files in the folder
                string[] files = Directory.GetFiles(path);

                // Display the paths of the files
                foreach (string filePath in files)
                {
                    int idx = filePath.LastIndexOf('\\') + 1;
                    if (idx == -1) continue;
                    else Invoices.Add(new InvoiceModel(Invoices.Count + 1, filePath.Substring(idx), filePath.ToString()));
                }

                //assing the number of invoices to InvoicesCounter
                InvoicesCounter = Invoices.Count;

            }
        }

        //Task to handle email processes
        public static async Task SendInvoice(string clientEmail, string invoiceID, string clientName = "")
        {
            //Define the recipient and sender information 
            var toAddress = clientEmail;
            var smtpServer = "smtp.gmail.com";
            var username = "radprojectgroup7@gmail.com";
            var password = "iqpvopsltwntzsqc";

            //Convert email addresses to MailAddress format
            MailAddress to = new MailAddress(toAddress);
            MailAddress from = new MailAddress(username);

            //Instantiate an email message
            MailMessage email = new MailMessage(from, to);

            //Attaches the invoice file to the email
            var attachment = new Attachment(MainForm.ProgramPath + $"Assets\\invoices\\{invoiceID}");
            email.Attachments.Add(attachment);

            //Properly format the invoice number
            invoiceID = invoiceID.Substring(0, 4);
            email.Subject = $"Work order - Invoice {invoiceID} - WeckLab";

            //Add messages to the email's body
            email.Body = (clientName == "") ? "Hello,\n" : $"Hello {clientName},\n\n";
            email.Body += $"Please find attached your invoice {invoiceID}.\nIn case of any inquiries, feel free to contact us.\n\nBest Regards,\n\nWeckLab Repair Shop.";

            //Instantiate the SMTP service and configure it accordingly
            SmtpClient smtp = new SmtpClient();
            smtp.Host = smtpServer;
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(username, password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;

            //Send the email, if it's not possible, handle the error
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
