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
    public class InvoiceViewModel
    {
        public static BindingList<InvoiceModel> Invoices { get; set; }
        public static Dictionary<string, InvoiceModel[]> ClientInvoices { get; set; }
        public static int InvoicesCounter = 0;

        public InvoiceViewModel() 
        {
            Invoices = new BindingList<InvoiceModel>();
            ClientInvoices = new Dictionary<string, InvoiceModel[]>();
            PopulateInvoicesList();
        }

        public static void PopulateInvoicesList()
        {
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

                InvoicesCounter = Invoices.Count;

            }
        }

        public static async Task SendInvoice(string clientEmail, string invoiceID, string clientName = "")
        {
            var toAddress = clientEmail;
            var smtpServer = "smtp.gmail.com";
            var username = "radprojectgroup7@gmail.com";
            var password = "iqpvopsltwntzsqc";


            MailAddress to = new MailAddress(toAddress);
            MailAddress from = new MailAddress(username);

            MailMessage email = new MailMessage(from, to);

            var attachment = new Attachment(MainForm.ProgramPath + $"Assets\\invoices\\{invoiceID}");
            email.Attachments.Add(attachment);

            invoiceID = invoiceID.Substring(0, 4);
            email.Subject = $"Work order - Invoice {invoiceID} - Golden Strings";

            email.Body = (clientName == "") ? "Hello,\n" : $"Hello {clientName},\n\n";
            email.Body += $"Please find attached your invoice {invoiceID}.\nIn case of any inquiries, feel free to contact us.\n\nBest Regards,\n\nGolden Strings Repair Shop.";


            SmtpClient smtp = new SmtpClient();
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
