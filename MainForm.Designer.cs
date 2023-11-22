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
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.addButton4 = new BusinessManager.CustomComponents.AddButton();
            this.deleteButton4 = new BusinessManager.CustomComponents.DeleteButton();
            this.updateButton4 = new BusinessManager.CustomComponents.UpdateButton();
            this.updateButton3 = new BusinessManager.CustomComponents.UpdateButton();
            this.addButton3 = new BusinessManager.CustomComponents.AddButton();
            this.deleteButton3 = new BusinessManager.CustomComponents.DeleteButton();
            this.updateButton2 = new BusinessManager.CustomComponents.UpdateButton();
            this.addButton2 = new BusinessManager.CustomComponents.AddButton();
            this.deleteButton2 = new BusinessManager.CustomComponents.DeleteButton();
            this.updateButton1 = new BusinessManager.CustomComponents.UpdateButton();
            this.addButton1 = new BusinessManager.CustomComponents.AddButton();
            this.deleteButton1 = new BusinessManager.CustomComponents.DeleteButton();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(341, 73);
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
            this.servicesDataGrid.Location = new System.Drawing.Point(51, 227);
            this.servicesDataGrid.Name = "servicesDataGrid";
            this.servicesDataGrid.RowHeadersWidth = 51;
            this.servicesDataGrid.RowTemplate.Height = 24;
            this.servicesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicesDataGrid.Size = new System.Drawing.Size(1100, 350);
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
            this.clientsDataGrid.Location = new System.Drawing.Point(51, 206);
            this.clientsDataGrid.Name = "clientsDataGrid";
            this.clientsDataGrid.ReadOnly = true;
            this.clientsDataGrid.RowHeadersWidth = 51;
            this.clientsDataGrid.RowTemplate.Height = 24;
            this.clientsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsDataGrid.Size = new System.Drawing.Size(1100, 350);
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
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
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
            this.txtPhoneWorksheet.Location = new System.Drawing.Point(651, 6);
            this.txtPhoneWorksheet.Name = "txtPhoneWorksheet";
            this.txtPhoneWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtPhoneWorksheet.TabIndex = 8;
            this.txtPhoneWorksheet.Text = "Phone";
            // 
            // txtEmailWorksheet
            // 
            this.txtEmailWorksheet.Location = new System.Drawing.Point(491, 6);
            this.txtEmailWorksheet.Name = "txtEmailWorksheet";
            this.txtEmailWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtEmailWorksheet.TabIndex = 7;
            this.txtEmailWorksheet.Text = "Email";
            // 
            // txtNameWorksheet
            // 
            this.txtNameWorksheet.Location = new System.Drawing.Point(332, 6);
            this.txtNameWorksheet.Name = "txtNameWorksheet";
            this.txtNameWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtNameWorksheet.TabIndex = 6;
            this.txtNameWorksheet.Text = "Name";
            // 
            // txtPriceWorksheet
            // 
            this.txtPriceWorksheet.Location = new System.Drawing.Point(651, 42);
            this.txtPriceWorksheet.Name = "txtPriceWorksheet";
            this.txtPriceWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtPriceWorksheet.TabIndex = 4;
            this.txtPriceWorksheet.Text = "Price";
            // 
            // txtDescriptionWorksheet
            // 
            this.txtDescriptionWorksheet.Location = new System.Drawing.Point(545, 42);
            this.txtDescriptionWorksheet.Name = "txtDescriptionWorksheet";
            this.txtDescriptionWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtDescriptionWorksheet.TabIndex = 3;
            this.txtDescriptionWorksheet.Text = "Description";
            // 
            // txtQtyWorksheet
            // 
            this.txtQtyWorksheet.Location = new System.Drawing.Point(438, 42);
            this.txtQtyWorksheet.Name = "txtQtyWorksheet";
            this.txtQtyWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtQtyWorksheet.TabIndex = 2;
            this.txtQtyWorksheet.Text = "Quantity";
            // 
            // txtIdWorksheet
            // 
            this.txtIdWorksheet.Location = new System.Drawing.Point(332, 42);
            this.txtIdWorksheet.Name = "txtIdWorksheet";
            this.txtIdWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtIdWorksheet.TabIndex = 1;
            this.txtIdWorksheet.Text = "ID";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(785, 17);
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
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.updateButton1);
            this.groupBox3.Controls.Add(this.addButton1);
            this.groupBox3.Controls.Add(this.deleteButton1);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(154, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 244);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clients data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Update client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Remove client";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.updateButton2);
            this.groupBox4.Controls.Add(this.addButton2);
            this.groupBox4.Controls.Add(this.deleteButton2);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(488, 67);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 244);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Services data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Remove service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Update service";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(84, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Add service";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.updateButton3);
            this.groupBox5.Controls.Add(this.addButton3);
            this.groupBox5.Controls.Add(this.deleteButton3);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(838, 67);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(210, 244);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Invoices data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Remove invoice";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(81, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Update invoice";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(81, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Add invoice";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(894, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(701, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 18);
            this.label10.TabIndex = 23;
            this.label10.Text = "Remove employee";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(428, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Update employee";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(175, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "Add employee";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.addButton4);
            this.groupBox6.Controls.Add(this.deleteButton4);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.updateButton4);
            this.groupBox6.Location = new System.Drawing.Point(144, 361);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(915, 277);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Employees";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(184, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Text";
            // 
            // addButton4
            // 
            this.addButton4.BackColor = System.Drawing.Color.Transparent;
            this.addButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton4.BackgroundImage")));
            this.addButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton4.Location = new System.Drawing.Point(115, 217);
            this.addButton4.Name = "addButton4";
            this.addButton4.Size = new System.Drawing.Size(50, 50);
            this.addButton4.TabIndex = 18;
            this.addButton4.UseVisualStyleBackColor = true;
            // 
            // deleteButton4
            // 
            this.deleteButton4.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton4.BackgroundImage")));
            this.deleteButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton4.Location = new System.Drawing.Point(641, 217);
            this.deleteButton4.Name = "deleteButton4";
            this.deleteButton4.Size = new System.Drawing.Size(50, 50);
            this.deleteButton4.TabIndex = 19;
            this.deleteButton4.UseVisualStyleBackColor = false;
            // 
            // updateButton4
            // 
            this.updateButton4.BackColor = System.Drawing.Color.Transparent;
            this.updateButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateButton4.BackgroundImage")));
            this.updateButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton4.Location = new System.Drawing.Point(368, 217);
            this.updateButton4.Name = "updateButton4";
            this.updateButton4.Size = new System.Drawing.Size(50, 50);
            this.updateButton4.TabIndex = 20;
            this.updateButton4.UseVisualStyleBackColor = false;
            // 
            // updateButton3
            // 
            this.updateButton3.BackColor = System.Drawing.Color.Transparent;
            this.updateButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateButton3.BackgroundImage")));
            this.updateButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton3.Location = new System.Drawing.Point(21, 107);
            this.updateButton3.Name = "updateButton3";
            this.updateButton3.Size = new System.Drawing.Size(50, 50);
            this.updateButton3.TabIndex = 11;
            this.updateButton3.UseVisualStyleBackColor = false;
            // 
            // addButton3
            // 
            this.addButton3.BackColor = System.Drawing.Color.Transparent;
            this.addButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton3.BackgroundImage")));
            this.addButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton3.Location = new System.Drawing.Point(21, 51);
            this.addButton3.Name = "addButton3";
            this.addButton3.Size = new System.Drawing.Size(50, 50);
            this.addButton3.TabIndex = 9;
            this.addButton3.UseVisualStyleBackColor = true;
            // 
            // deleteButton3
            // 
            this.deleteButton3.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton3.BackgroundImage")));
            this.deleteButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton3.Location = new System.Drawing.Point(21, 163);
            this.deleteButton3.Name = "deleteButton3";
            this.deleteButton3.Size = new System.Drawing.Size(50, 50);
            this.deleteButton3.TabIndex = 10;
            this.deleteButton3.UseVisualStyleBackColor = false;
            // 
            // updateButton2
            // 
            this.updateButton2.BackColor = System.Drawing.Color.Transparent;
            this.updateButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateButton2.BackgroundImage")));
            this.updateButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton2.Location = new System.Drawing.Point(24, 107);
            this.updateButton2.Name = "updateButton2";
            this.updateButton2.Size = new System.Drawing.Size(50, 50);
            this.updateButton2.TabIndex = 11;
            this.updateButton2.UseVisualStyleBackColor = false;
            // 
            // addButton2
            // 
            this.addButton2.BackColor = System.Drawing.Color.Transparent;
            this.addButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton2.BackgroundImage")));
            this.addButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton2.Location = new System.Drawing.Point(24, 51);
            this.addButton2.Name = "addButton2";
            this.addButton2.Size = new System.Drawing.Size(50, 50);
            this.addButton2.TabIndex = 9;
            this.addButton2.UseVisualStyleBackColor = true;
            // 
            // deleteButton2
            // 
            this.deleteButton2.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton2.BackgroundImage")));
            this.deleteButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton2.Location = new System.Drawing.Point(24, 163);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(50, 50);
            this.deleteButton2.TabIndex = 10;
            this.deleteButton2.UseVisualStyleBackColor = false;
            // 
            // updateButton1
            // 
            this.updateButton1.BackColor = System.Drawing.Color.Transparent;
            this.updateButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateButton1.BackgroundImage")));
            this.updateButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton1.Location = new System.Drawing.Point(24, 107);
            this.updateButton1.Name = "updateButton1";
            this.updateButton1.Size = new System.Drawing.Size(50, 50);
            this.updateButton1.TabIndex = 11;
            this.updateButton1.UseVisualStyleBackColor = false;
            // 
            // addButton1
            // 
            this.addButton1.BackColor = System.Drawing.Color.Transparent;
            this.addButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton1.BackgroundImage")));
            this.addButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton1.Location = new System.Drawing.Point(24, 51);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(50, 50);
            this.addButton1.TabIndex = 9;
            this.addButton1.UseVisualStyleBackColor = true;
            // 
            // deleteButton1
            // 
            this.deleteButton1.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton1.BackgroundImage")));
            this.deleteButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton1.Location = new System.Drawing.Point(24, 163);
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(50, 50);
            this.deleteButton1.TabIndex = 10;
            this.deleteButton1.UseVisualStyleBackColor = false;
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem1.Text = "About...";
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
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
        private CustomComponents.AddButton addButton1;
        private GroupBox groupBox3;
        private CustomComponents.DeleteButton deleteButton1;
        private CustomComponents.UpdateButton updateButton1;
        private Label label1;
        private Label label3;
        private Label label2;
        private GroupBox groupBox6;
        private DataGridView dataGridView1;
        private Label label10;
        private CustomComponents.AddButton addButton4;
        private CustomComponents.DeleteButton deleteButton4;
        private Label label11;
        private Label label12;
        private CustomComponents.UpdateButton updateButton4;
        private GroupBox groupBox5;
        private Label label7;
        private Label label8;
        private Label label9;
        private CustomComponents.UpdateButton updateButton3;
        private CustomComponents.AddButton addButton3;
        private CustomComponents.DeleteButton deleteButton3;
        private GroupBox groupBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private CustomComponents.UpdateButton updateButton2;
        private CustomComponents.AddButton addButton2;
        private CustomComponents.DeleteButton deleteButton2;
        private Label label13;
        private ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

