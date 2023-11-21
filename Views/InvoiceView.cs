using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManager.Views
{
    public partial class InvoiceView : Form
    {
        public InvoiceView(string path)
        {
            InitializeComponent();
            pdfViewerControl.Load(path);
        }
    }
}
