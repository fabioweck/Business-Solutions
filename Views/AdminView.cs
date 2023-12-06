using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Pdf;
using Syncfusion.ExcelToPdfConverter;
using System.IO;
using System.Windows.Forms;
using Syncfusion.Pdf.Graphics;
using System.ComponentModel;
using System.Windows;
using Syncfusion.Pdf.Parsing;
using static System.Net.Mime.MediaTypeNames;
using BusinessManager.ViewModels;
using BusinessManager.Views;

namespace BusinessManager
{
    public partial class MainForm
    {

        private void btnLoadTemplate(object sender, EventArgs e)
        {
            //Initialize excel engine
            using(ExcelEngine excelEngine = new ExcelEngine())
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
                    IWorksheet worksheet = workbook.Worksheets[0];

                    //Disable gridlines in the worksheet
                    worksheet.IsGridLinesVisible = false;

                    //Collects client's details
                   

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
                        InitialDirectory = path + "\\invoices"
                    })
                    {
                        if (saveFile.ShowDialog() == DialogResult.OK)
                        {
                            pdfDocument.Save(saveFile.FileName);
                            InvoiceViewModel.PopulateInvoices();
                            invoicesDataGrid.Refresh();
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Verify all fields before proceeding", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }      
            }     
        }
    }
}
