namespace BusinessManager.Views
{
    partial class InvoiceView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings1 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings1 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceView));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings1 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            this.pdfViewerControl = new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl();
            this.SuspendLayout();
            // 
            // pdfViewerControl
            // 
            this.pdfViewerControl.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            this.pdfViewerControl.EnableContextMenu = true;
            this.pdfViewerControl.EnableNotificationBar = true;
            this.pdfViewerControl.HorizontalScrollOffset = 0;
            this.pdfViewerControl.IsBookmarkEnabled = true;
            this.pdfViewerControl.IsTextSearchEnabled = true;
            this.pdfViewerControl.IsTextSelectionEnabled = true;
            this.pdfViewerControl.Location = new System.Drawing.Point(64, 12);
            messageBoxSettings1.EnableNotification = true;
            this.pdfViewerControl.MessageBoxSettings = messageBoxSettings1;
            this.pdfViewerControl.MinimumZoomPercentage = 50;
            this.pdfViewerControl.Name = "pdfViewerControl";
            this.pdfViewerControl.PageBorderThickness = 1;
            pdfViewerPrinterSettings1.Copies = 1;
            pdfViewerPrinterSettings1.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings1.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings1.PrintLocation = ((System.Drawing.PointF)(resources.GetObject("pdfViewerPrinterSettings1.PrintLocation")));
            pdfViewerPrinterSettings1.ShowPrintStatusDialog = true;
            this.pdfViewerControl.PrinterSettings = pdfViewerPrinterSettings1;
            this.pdfViewerControl.ReferencePath = null;
            this.pdfViewerControl.ScrollDisplacementValue = 0;
            this.pdfViewerControl.ShowHorizontalScrollBar = true;
            this.pdfViewerControl.ShowToolBar = true;
            this.pdfViewerControl.ShowVerticalScrollBar = true;
            this.pdfViewerControl.Size = new System.Drawing.Size(947, 925);
            this.pdfViewerControl.SpaceBetweenPages = 8;
            this.pdfViewerControl.TabIndex = 0;
            this.pdfViewerControl.Text = "pdfViewerControl";
            textSearchSettings1.CurrentInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(64)))));
            textSearchSettings1.HighlightAllInstance = true;
            textSearchSettings1.OtherInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pdfViewerControl.TextSearchSettings = textSearchSettings1;
            this.pdfViewerControl.VerticalScrollOffset = 0;
            this.pdfViewerControl.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Default;
            this.pdfViewerControl.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // InvoiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 987);
            this.Controls.Add(this.pdfViewerControl);
            this.Name = "InvoiceView";
            this.Text = "InvoiceView";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl pdfViewerControl;
    }
}