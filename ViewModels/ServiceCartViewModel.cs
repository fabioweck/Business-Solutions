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

                    //Opens the template for modification
                    IWorkbook workbook = application.Workbooks.Open(MainForm.ProgramPath + "Assets\\templates\\work_order.xlsx");
                 
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

                    string pathToSave = MainForm.ProgramPath + "Assets\\invoices\\" + $"{invoiceID}.pdf";
                    pdfDocument.Save(pathToSave);


                    //Opens the save dialog to allow user selecting the folder and file name to be saved
                    using (SaveFileDialog saveFile = new SaveFileDialog()
                    {
                        Filter = "PDF Document | *.pdf",
                        ValidateNames = true,
                        InitialDirectory = MainForm.ProgramPath + "\\invoices",
                        FileName = $"{invoiceID}.pdf"

                    })
                       
                    {
                        if (saveFile.ShowDialog() == DialogResult.OK)
                        {
                            
                            pdfDocument.Save(saveFile.FileName);
                            InvoiceViewModel.PopulateInvoicesList();

                            DialogResult res = MessageBox.Show($"Invoice succesfully created.\nClient {clientName}, invoice {invoiceID}.\nWould you like to send invoice to {clientEmail}?", "Invoice created", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            
                            if (res == DialogResult.Yes)
                            {
                                try
                                {
                                    await InvoiceViewModel.SendInvoice(clientEmail, $"{invoiceID}.pdf", clientName);
                                    MessageBox.Show($"Invoice sent to {clientEmail}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                }
                                catch
                                {
                                    MessageBox.Show("Unable to send email.");
                                }
                            }
                            else{ return; }
                        }
                        else { return; }
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create invoice.\n" + ex, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }
    }
}
