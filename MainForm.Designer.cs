using System.IO;
using Syncfusion.XlsIO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BusinessManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFindService = new System.Windows.Forms.Button();
            this.txtSearchService = new System.Windows.Forms.TextBox();
            this.radBtnDescription = new System.Windows.Forms.RadioButton();
            this.radBtnServiceID = new System.Windows.Forms.RadioButton();
            this.servicesDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnClientDetails = new System.Windows.Forms.Button();
            this.lblClientDetails = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFindClient = new System.Windows.Forms.Button();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.radBtnClientEmail = new System.Windows.Forms.RadioButton();
            this.radBtnClientName = new System.Windows.Forms.RadioButton();
            this.radBtnClientID = new System.Windows.Forms.RadioButton();
            this.clientsDataGrid = new System.Windows.Forms.DataGridView();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtPhoneWorksheet = new System.Windows.Forms.TextBox();
            this.txtEmailWorksheet = new System.Windows.Forms.TextBox();
            this.txtNameWorksheet = new System.Windows.Forms.TextBox();
            this.txtPriceWorksheet = new System.Windows.Forms.TextBox();
            this.txtDescriptionWorksheet = new System.Windows.Forms.TextBox();
            this.txtQtyWorksheet = new System.Windows.Forms.TextBox();
            this.txtIdWorksheet = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tabRegistry = new System.Windows.Forms.TabPage();
            this.lblSelectInvoice = new System.Windows.Forms.Label();
            this.btnViewInvoice = new System.Windows.Forms.Button();
            this.invoicesDataGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGrid)).BeginInit();
            this.tabs.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabRegistry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.servicesDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1203, 686);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Services";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.btnFindService);
            this.groupBox2.Controls.Add(this.txtSearchService);
            this.groupBox2.Controls.Add(this.radBtnDescription);
            this.groupBox2.Controls.Add(this.radBtnServiceID);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(341, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 72);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btnFindService
            // 
            this.btnFindService.Location = new System.Drawing.Point(428, 25);
            this.btnFindService.Name = "btnFindService";
            this.btnFindService.Size = new System.Drawing.Size(75, 26);
            this.btnFindService.TabIndex = 4;
            this.btnFindService.Text = "Find";
            this.btnFindService.UseVisualStyleBackColor = true;
            this.btnFindService.Click += new System.EventHandler(this.btnFindService_Click);
            // 
            // txtSearchService
            // 
            this.txtSearchService.Location = new System.Drawing.Point(18, 27);
            this.txtSearchService.Name = "txtSearchService";
            this.txtSearchService.Size = new System.Drawing.Size(143, 22);
            this.txtSearchService.TabIndex = 3;
            // 
            // radBtnDescription
            // 
            this.radBtnDescription.AutoSize = true;
            this.radBtnDescription.Location = new System.Drawing.Point(287, 27);
            this.radBtnDescription.Name = "radBtnDescription";
            this.radBtnDescription.Size = new System.Drawing.Size(114, 20);
            this.radBtnDescription.TabIndex = 1;
            this.radBtnDescription.TabStop = true;
            this.radBtnDescription.Text = "by Description";
            this.radBtnDescription.UseVisualStyleBackColor = true;
            // 
            // radBtnServiceID
            // 
            this.radBtnServiceID.AutoSize = true;
            this.radBtnServiceID.Location = new System.Drawing.Point(198, 27);
            this.radBtnServiceID.Name = "radBtnServiceID";
            this.radBtnServiceID.Size = new System.Drawing.Size(59, 20);
            this.radBtnServiceID.TabIndex = 0;
            this.radBtnServiceID.TabStop = true;
            this.radBtnServiceID.Text = "by ID";
            this.radBtnServiceID.UseVisualStyleBackColor = true;
            // 
            // servicesDataGrid
            // 
            this.servicesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDataGrid.Location = new System.Drawing.Point(33, 127);
            this.servicesDataGrid.Name = "servicesDataGrid";
            this.servicesDataGrid.RowHeadersWidth = 51;
            this.servicesDataGrid.RowTemplate.Height = 24;
            this.servicesDataGrid.Size = new System.Drawing.Size(1150, 500);
            this.servicesDataGrid.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.btnClientDetails);
            this.tabPage1.Controls.Add(this.lblClientDetails);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.clientsDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1203, 686);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clients";
            // 
            // btnClientDetails
            // 
            this.btnClientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientDetails.Location = new System.Drawing.Point(426, 596);
            this.btnClientDetails.Name = "btnClientDetails";
            this.btnClientDetails.Size = new System.Drawing.Size(75, 39);
            this.btnClientDetails.TabIndex = 7;
            this.btnClientDetails.Text = "Details";
            this.btnClientDetails.UseVisualStyleBackColor = true;
            this.btnClientDetails.Click += new System.EventHandler(this.btnClientDetails_Click);
            // 
            // lblClientDetails
            // 
            this.lblClientDetails.AutoSize = true;
            this.lblClientDetails.Location = new System.Drawing.Point(202, 607);
            this.lblClientDetails.Name = "lblClientDetails";
            this.lblClientDetails.Size = new System.Drawing.Size(0, 16);
            this.lblClientDetails.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnFindClient);
            this.groupBox1.Controls.Add(this.txtSearchClient);
            this.groupBox1.Controls.Add(this.radBtnClientEmail);
            this.groupBox1.Controls.Add(this.radBtnClientName);
            this.groupBox1.Controls.Add(this.radBtnClientID);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(294, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnFindClient
            // 
            this.btnFindClient.Location = new System.Drawing.Point(505, 25);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(75, 26);
            this.btnFindClient.TabIndex = 4;
            this.btnFindClient.Text = "Find";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Location = new System.Drawing.Point(18, 27);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(143, 22);
            this.txtSearchClient.TabIndex = 3;
            // 
            // radBtnClientEmail
            // 
            this.radBtnClientEmail.AutoSize = true;
            this.radBtnClientEmail.Location = new System.Drawing.Point(395, 27);
            this.radBtnClientEmail.Name = "radBtnClientEmail";
            this.radBtnClientEmail.Size = new System.Drawing.Size(80, 20);
            this.radBtnClientEmail.TabIndex = 2;
            this.radBtnClientEmail.TabStop = true;
            this.radBtnClientEmail.Text = "by Email";
            this.radBtnClientEmail.UseVisualStyleBackColor = true;
            // 
            // radBtnClientName
            // 
            this.radBtnClientName.AutoSize = true;
            this.radBtnClientName.Location = new System.Drawing.Point(287, 27);
            this.radBtnClientName.Name = "radBtnClientName";
            this.radBtnClientName.Size = new System.Drawing.Size(83, 20);
            this.radBtnClientName.TabIndex = 1;
            this.radBtnClientName.TabStop = true;
            this.radBtnClientName.Text = "by Name";
            this.radBtnClientName.UseVisualStyleBackColor = true;
            // 
            // radBtnClientID
            // 
            this.radBtnClientID.AutoSize = true;
            this.radBtnClientID.Location = new System.Drawing.Point(198, 27);
            this.radBtnClientID.Name = "radBtnClientID";
            this.radBtnClientID.Size = new System.Drawing.Size(59, 20);
            this.radBtnClientID.TabIndex = 0;
            this.radBtnClientID.TabStop = true;
            this.radBtnClientID.Text = "by ID";
            this.radBtnClientID.UseVisualStyleBackColor = true;
            // 
            // clientsDataGrid
            // 
            this.clientsDataGrid.AllowUserToAddRows = false;
            this.clientsDataGrid.AllowUserToDeleteRows = false;
            this.clientsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientsDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.clientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGrid.Location = new System.Drawing.Point(26, 206);
            this.clientsDataGrid.Name = "clientsDataGrid";
            this.clientsDataGrid.ReadOnly = true;
            this.clientsDataGrid.RowHeadersWidth = 51;
            this.clientsDataGrid.RowTemplate.Height = 24;
            this.clientsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsDataGrid.Size = new System.Drawing.Size(1150, 350);
            this.clientsDataGrid.TabIndex = 0;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Controls.Add(this.tabRegistry);
            this.tabs.Location = new System.Drawing.Point(26, 43);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1211, 715);
            this.tabs.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.txtPhoneWorksheet);
            this.tabPage3.Controls.Add(this.txtEmailWorksheet);
            this.tabPage3.Controls.Add(this.txtNameWorksheet);
            this.tabPage3.Controls.Add(this.txtPriceWorksheet);
            this.tabPage3.Controls.Add(this.txtDescriptionWorksheet);
            this.tabPage3.Controls.Add(this.txtQtyWorksheet);
            this.tabPage3.Controls.Add(this.txtIdWorksheet);
            this.tabPage3.Controls.Add(this.btnGenerate);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1203, 686);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Admin";
            // 
            // txtPhoneWorksheet
            // 
            this.txtPhoneWorksheet.Location = new System.Drawing.Point(624, 55);
            this.txtPhoneWorksheet.Name = "txtPhoneWorksheet";
            this.txtPhoneWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtPhoneWorksheet.TabIndex = 8;
            this.txtPhoneWorksheet.Text = "Phone";
            // 
            // txtEmailWorksheet
            // 
            this.txtEmailWorksheet.Location = new System.Drawing.Point(464, 55);
            this.txtEmailWorksheet.Name = "txtEmailWorksheet";
            this.txtEmailWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtEmailWorksheet.TabIndex = 7;
            this.txtEmailWorksheet.Text = "Email";
            // 
            // txtNameWorksheet
            // 
            this.txtNameWorksheet.Location = new System.Drawing.Point(305, 55);
            this.txtNameWorksheet.Name = "txtNameWorksheet";
            this.txtNameWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtNameWorksheet.TabIndex = 6;
            this.txtNameWorksheet.Text = "Name";
            // 
            // txtPriceWorksheet
            // 
            this.txtPriceWorksheet.Location = new System.Drawing.Point(624, 91);
            this.txtPriceWorksheet.Name = "txtPriceWorksheet";
            this.txtPriceWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtPriceWorksheet.TabIndex = 4;
            this.txtPriceWorksheet.Text = "Price";
            // 
            // txtDescriptionWorksheet
            // 
            this.txtDescriptionWorksheet.Location = new System.Drawing.Point(518, 91);
            this.txtDescriptionWorksheet.Name = "txtDescriptionWorksheet";
            this.txtDescriptionWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtDescriptionWorksheet.TabIndex = 3;
            this.txtDescriptionWorksheet.Text = "Description";
            // 
            // txtQtyWorksheet
            // 
            this.txtQtyWorksheet.Location = new System.Drawing.Point(411, 91);
            this.txtQtyWorksheet.Name = "txtQtyWorksheet";
            this.txtQtyWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtQtyWorksheet.TabIndex = 2;
            this.txtQtyWorksheet.Text = "Quantity";
            // 
            // txtIdWorksheet
            // 
            this.txtIdWorksheet.Location = new System.Drawing.Point(305, 91);
            this.txtIdWorksheet.Name = "txtIdWorksheet";
            this.txtIdWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtIdWorksheet.TabIndex = 1;
            this.txtIdWorksheet.Text = "ID";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(758, 66);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(139, 47);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate invoice";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnLoadTemplate);
            // 
            // tabRegistry
            // 
            this.tabRegistry.BackColor = System.Drawing.Color.Gainsboro;
            this.tabRegistry.Controls.Add(this.lblSelectInvoice);
            this.tabRegistry.Controls.Add(this.btnViewInvoice);
            this.tabRegistry.Controls.Add(this.invoicesDataGrid);
            this.tabRegistry.Location = new System.Drawing.Point(4, 25);
            this.tabRegistry.Name = "tabRegistry";
            this.tabRegistry.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegistry.Size = new System.Drawing.Size(1203, 686);
            this.tabRegistry.TabIndex = 3;
            this.tabRegistry.Text = "Registry";
            // 
            // lblSelectInvoice
            // 
            this.lblSelectInvoice.AutoSize = true;
            this.lblSelectInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectInvoice.Location = new System.Drawing.Point(90, 526);
            this.lblSelectInvoice.Name = "lblSelectInvoice";
            this.lblSelectInvoice.Size = new System.Drawing.Size(134, 20);
            this.lblSelectInvoice.TabIndex = 9;
            this.lblSelectInvoice.Text = "Invoice selected:";
            // 
            // btnViewInvoice
            // 
            this.btnViewInvoice.BackColor = System.Drawing.Color.Gainsboro;
            this.btnViewInvoice.Enabled = false;
            this.btnViewInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInvoice.Location = new System.Drawing.Point(548, 573);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Size = new System.Drawing.Size(106, 39);
            this.btnViewInvoice.TabIndex = 8;
            this.btnViewInvoice.Text = "Visualize";
            this.btnViewInvoice.UseVisualStyleBackColor = false;
            this.btnViewInvoice.Click += new System.EventHandler(this.btnViewInvoice_Click);
            // 
            // invoicesDataGrid
            // 
            this.invoicesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoicesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.invoicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicesDataGrid.Location = new System.Drawing.Point(26, 129);
            this.invoicesDataGrid.Name = "invoicesDataGrid";
            this.invoicesDataGrid.RowHeadersWidth = 51;
            this.invoicesDataGrid.RowTemplate.Height = 24;
            this.invoicesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoicesDataGrid.Size = new System.Drawing.Size(1150, 375);
            this.invoicesDataGrid.TabIndex = 0;
            this.invoicesDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectedCellInvoice);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loginToolStripMenuItem.Text = "Login...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 801);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Business Manager 1.0";
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGrid)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabRegistry.ResumeLayout(false);
            this.tabRegistry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView servicesDataGrid;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFindClient;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.RadioButton radBtnClientEmail;
        private System.Windows.Forms.RadioButton radBtnClientName;
        private System.Windows.Forms.RadioButton radBtnClientID;
        private System.Windows.Forms.DataGridView clientsDataGrid;
        private System.Windows.Forms.TabControl tabs;
        private TabPage tabPage3;
        private Button btnGenerate;
        private TextBox txtPriceWorksheet;
        private TextBox txtDescriptionWorksheet;
        private TextBox txtQtyWorksheet;
        private TextBox txtIdWorksheet;
        private TextBox txtPhoneWorksheet;
        private TextBox txtEmailWorksheet;
        private TextBox txtNameWorksheet;
        private Label lblClientDetails;
        private DataGridView invoicesDataGrid;
        public TabPage tabRegistry;
        private Button btnClientDetails;
        private GroupBox groupBox2;
        private Button btnFindService;
        private TextBox txtSearchService;
        private RadioButton radBtnDescription;
        private RadioButton radBtnServiceID;
        private Button btnViewInvoice;
        private Label lblSelectInvoice;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}

