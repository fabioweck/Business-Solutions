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

namespace BusinessManager.ViewModels
{
    public class ServiceCartViewModel
    {
        public BindingList<ServiceCartModel> ServicesCart { get; set; }

        public ServiceCartViewModel()
        {
            ServicesCart = new BindingList<ServiceCartModel>();
        }

        public void AddToCart(int qtd, int id, string description, double price)
        {
            ServicesCart.Add(new ServiceCartModel(qtd, id, description, price));
        }

        public void RemoveFromCart(int index)
        {
            ServicesCart.RemoveAt(index);
        }

        public decimal SumTotalCart()
        {
            double sum = 0;

            foreach (ServiceCartModel model in ServicesCart)
            {
                sum += model.Quantity * model.Price;
            }

            return ((decimal)sum);
        }

        public async void GenerateInvoice(int clientId, string clientName, string clientPhone, string clientEmail)
        {
            //Initialize excel engine
            using (ExcelEngine excelEngine = new ExcelEngine())
            {

                try
                {
                    IApplication application = excelEngine.Excel;
                    application.DefaultVersion = ExcelVersion.Xlsx;

                    //Reads the current path and set the correct path to locate the work order template
                    string currentDirectory = Directory.GetCurrentDirectory();
                    int index = currentDirectory.LastIndexOf("bin");
                    string path = currentDirectory.Substring(0, index) + "Assets";

                    //Opens the template for modification
                    IWorkbook workbook = application.Workbooks.Open(path + "\\templates\\work_order.xlsx");
                    //IWorkbook workbook = application.Workbooks.Open(@"C:\Users\Fabio Weck\Documents\Bow Valley\Fall 2023\SODV2101 - Rapid Application Development\Business-Solutions-Clone\Assets\templates\work_order.xlsx");
                    IWorksheet worksheet = workbook.Worksheets[0];

                    //Disable gridlines in the worksheet
                    worksheet.IsGridLinesVisible = false;

                    //Collects client's details
                    worksheet.Range["B10"].Text = clientName;
                    worksheet.Range["B11"].Text = clientPhone;
                    worksheet.Range["B12"].Text = clientEmail;

                    int invoiceNumber = InvoiceViewModel.InvoicesCounter + 1;
                    string invoiceID = string.Empty;
                    invoiceID = (invoiceNumber > 9) ? $"#0{invoiceNumber}" : $"#00{invoiceNumber}";
                    worksheet.Range["G6"].Text = invoiceID;

                    worksheet.Range["G7"].Text = clientId.ToString();

                    //Adds services

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

                    //Opens the save dialog to allow user selecting the folder and file name to be saved
                    using (SaveFileDialog saveFile = new SaveFileDialog()
                    {
                        Filter = "PDF Document | *.pdf",
                        ValidateNames = true,
                        InitialDirectory = path + "\\invoices",
                        FileName = $"{invoiceID}.pdf"
                    })
                    {
                        if (saveFile.ShowDialog() == DialogResult.OK)
                        {
                            pdfDocument.Save(saveFile.FileName);
                            InvoiceViewModel.PopulateInvoicesList();

                            DialogResult res = MessageBox.Show($"Invoice succesfully created. Client {clientName}, invoice {invoiceID}. Would you like to send invoice to {clientEmail}?", "Invoice created", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            
                            if (res == DialogResult.Yes)
                            {
                                try
                                {
                                    await InvoiceViewModel.SendEmail(clientEmail, invoiceID);
                                }
                                catch
                                {
                                    MessageBox.Show("Unable to send email...");
                                }
                            }
                            else{ return; }
                        }
                        else { return; }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Verify all fields before proceeding.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
    }
}
