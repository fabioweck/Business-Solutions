using BusinessManager.Models;
using Syncfusion.ExcelToPdfConverter;
using Syncfusion.Pdf;
using Syncfusion.XlsIO;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Graphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessManager.Views;

namespace BusinessManager.ViewModels
{
    //This class manipulates all the models and serves as a bridge between the model and the view

    public class ServiceCartViewModel
    {
        //Create a list of services cart
        public BindingList<ServiceCartModel> ServicesCart { get; set; }

        public ServiceCartViewModel()
        {
            ServicesCart = new BindingList<ServiceCartModel>();
        }

        //Method to add a service to the cart
        public void AddToCart(int qtd, int id, string description, double price)
        {
            ServicesCart.Add(new ServiceCartModel(qtd, id, description, price));
        }

        //Method to remove a service from the cart
        public void RemoveFromCart(int index)
        {
            ServicesCart.RemoveAt(index);
        }

        //Method to sum the total amount for the invoice
        public decimal SumTotalCart()
        {
            double sum = 0;

            //Iterates over all values and sum them
            foreach (ServiceCartModel model in ServicesCart)
            {
                sum += model.Quantity * model.Price;
            }

            return ((decimal)sum);
        }

        //Method to generate an invoice
        public async void GenerateInvoice(int clientId, string clientName, string clientPhone, string clientEmail)
        {
            //Initialize excel engine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {

                try
                {
                    //Configures the engine
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Xlsx;

                    //Opens the template for modification
                    IWorkbook workbook = application.Workbooks.Open(MainForm.ProgramPath + "Assets\\templates\\work_order_wecklab.xlsx");
                 
                    IWorksheet worksheet = workbook.Worksheets[0];

                    //Disable gridlines in the worksheet
                    worksheet.IsGridLinesVisible = false;

                    //Collects client's details
                    //Each "range" represents cells in the xlsx file
                    worksheet.Range["B10"].Text = clientName;
                    worksheet.Range["B11"].Text = clientPhone;
                    worksheet.Range["B12"].Text = clientEmail;

                    //Properly format information to display in the file
                    int invoiceNumber = InvoiceViewModel.InvoicesCounter + 1;
                    string invoiceID = string.Empty;

                    //If invoice number is lees than 10, then display with two trailing zeros
                    invoiceID = (invoiceNumber > 9) ? $"#0{invoiceNumber}" : $"#00{invoiceNumber}";
                    worksheet.Range["G6"].Text = invoiceID;

                    worksheet.Range["G7"].Text = clientId.ToString();

                    //Add services
                    for (int i = 0; i < ServicesCart.Count; i++)
                    {
                        worksheet.Range[$"B{18 + i}"].Number = Convert.ToDouble(ServicesCart[i].Id);
                        worksheet.Range[$"C{18 + i}"].Number = Convert.ToDouble(ServicesCart[i].Quantity);
                        worksheet.Range[$"D{18 + i}"].Text = ServicesCart[i].Description;
                        worksheet.Range[$"F{18 + i}"].Number = Convert.ToDouble(ServicesCart[i].Price);
                        worksheet.Range[$"G{18 + i}"].Formula = $"=C{18 + i}*F{18 + i}";
                    }

                    //Initialize ExcelToPdfConverter
                    ExcelToPdfConverter converter = new ExcelToPdfConverter(workbook);

                    //Initialize PDF document
                    PdfDocument pdfDocument = new PdfDocument();

                    //Convert Excel document into PDF document
                    pdfDocument = converter.Convert();

                    //Get the path to the list of invoices
                    string pathToSave = MainForm.ProgramPath + "Assets\\invoices\\" + $"{invoiceID}.pdf";

                    //Saves the file on the folder
                    pdfDocument.Save(pathToSave);

                    //Opens the save dialog to allow user selecting another folder and file name to be saved
                    using (SaveFileDialog saveFile = new SaveFileDialog()
                    {
                        Filter = "PDF Document | *.pdf",
                        ValidateNames = true,
                        InitialDirectory = "C:\\",
                        FileName = $"{invoiceID}.pdf"

                    })
                       
                    {
                        if (saveFile.ShowDialog() == DialogResult.OK)
                        {
                            
                            pdfDocument.Save(saveFile.FileName);

                            //Calls the method again to populate the list with updated folder
                            InvoiceViewModel.PopulateInvoicesList();

                            //ask if the user wants to send it by email
                            DialogResult res = MessageBox.Show($"Invoice succesfully created.\nClient {clientName}, invoice {invoiceID}.\nWould you like to send invoice to {clientEmail}?", "Invoice created", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            
                            if (res == DialogResult.Yes)
                            {
                                try
                                {
                                    //await the process and then advise the user
                                    await InvoiceViewModel.SendInvoice(clientEmail, $"{invoiceID}.pdf", clientName);
                                    MessageBox.Show($"Invoice sent to {clientEmail}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                }
                                catch
                                {
                                    MessageBox.Show("Unable to send email.");
                                }
                            }
                            //If the user doesn't want to send email, then do nothing
                            else{ return; }
                        }
                        //If the user doesn't want to save the file, then do nothing
                        else { return; }
                        
                    }
                }
                //If the engine fails to read/update the template, handle the error
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create invoice.\n" + ex, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
    }
}
