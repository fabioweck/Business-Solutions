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
            this.btn_addItem = new System.Windows.Forms.Button();
            this.btn_itemDetail = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFindService = new System.Windows.Forms.Button();
            this.txtSearchService = new System.Windows.Forms.TextBox();
            this.radBtnDescription = new System.Windows.Forms.RadioButton();
            this.radBtnServiceID = new System.Windows.Forms.RadioButton();
            this.servicesDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_newOrder = new System.Windows.Forms.Button();
            this.btn_addNewClient = new System.Windows.Forms.Button();
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.employeesDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabRegistry = new System.Windows.Forms.TabPage();
            this.lblSelectInvoice = new System.Windows.Forms.Label();
            this.btnViewInvoice = new System.Windows.Forms.Button();
            this.invoicesDataGrid = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_findEmployee = new System.Windows.Forms.Button();
            this.txtBox_search = new System.Windows.Forms.TextBox();
            this.radioBtn_byName = new System.Windows.Forms.RadioButton();
            this.radioBtn_byId = new System.Windows.Forms.RadioButton();
            this.btn_deleteEmployee = new BusinessManager.CustomComponents.DeleteButton();
            this.updateButton5 = new BusinessManager.CustomComponents.UpdateButton();
            this.btn_addEmployee = new BusinessManager.CustomComponents.AddButton();
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
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGrid)).BeginInit();
            this.tabs.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGrid)).BeginInit();
            this.tabRegistry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.btn_addItem);
            this.tabPage2.Controls.Add(this.btn_itemDetail);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.servicesDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(900, 555);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Items";
            // 
            // btn_addItem
            // 
            this.btn_addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItem.Location = new System.Drawing.Point(144, 483);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(100, 30);
            this.btn_addItem.TabIndex = 10;
            this.btn_addItem.Text = "+ Add Item";
            this.btn_addItem.UseVisualStyleBackColor = true;
            // 
            // btn_itemDetail
            // 
            this.btn_itemDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_itemDetail.Location = new System.Drawing.Point(38, 483);
            this.btn_itemDetail.Name = "btn_itemDetail";
            this.btn_itemDetail.Size = new System.Drawing.Size(100, 30);
            this.btn_itemDetail.TabIndex = 10;
            this.btn_itemDetail.Text = "Item Detail";
            this.btn_itemDetail.UseVisualStyleBackColor = true;
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
            this.groupBox2.Location = new System.Drawing.Point(256, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(390, 58);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btnFindService
            // 
            this.btnFindService.Location = new System.Drawing.Point(321, 20);
            this.btnFindService.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindService.Name = "btnFindService";
            this.btnFindService.Size = new System.Drawing.Size(56, 21);
            this.btnFindService.TabIndex = 4;
            this.btnFindService.Text = "Find";
            this.btnFindService.UseVisualStyleBackColor = true;
            // 
            // txtSearchService
            // 
            this.txtSearchService.Location = new System.Drawing.Point(14, 22);
            this.txtSearchService.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchService.Name = "txtSearchService";
            this.txtSearchService.Size = new System.Drawing.Size(108, 20);
            this.txtSearchService.TabIndex = 3;
            // 
            // radBtnDescription
            // 
            this.radBtnDescription.AutoSize = true;
            this.radBtnDescription.Location = new System.Drawing.Point(215, 22);
            this.radBtnDescription.Margin = new System.Windows.Forms.Padding(2);
            this.radBtnDescription.Name = "radBtnDescription";
            this.radBtnDescription.Size = new System.Drawing.Size(92, 17);
            this.radBtnDescription.TabIndex = 1;
            this.radBtnDescription.TabStop = true;
            this.radBtnDescription.Text = "by Description";
            this.radBtnDescription.UseVisualStyleBackColor = true;
            // 
            // radBtnServiceID
            // 
            this.radBtnServiceID.AutoSize = true;
            this.radBtnServiceID.Location = new System.Drawing.Point(148, 22);
            this.radBtnServiceID.Margin = new System.Windows.Forms.Padding(2);
            this.radBtnServiceID.Name = "radBtnServiceID";
            this.radBtnServiceID.Size = new System.Drawing.Size(50, 17);
            this.radBtnServiceID.TabIndex = 0;
            this.radBtnServiceID.TabStop = true;
            this.radBtnServiceID.Text = "by ID";
            this.radBtnServiceID.UseVisualStyleBackColor = true;
            // 
            // servicesDataGrid
            // 
            this.servicesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDataGrid.Location = new System.Drawing.Point(38, 184);
            this.servicesDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.servicesDataGrid.Name = "servicesDataGrid";
            this.servicesDataGrid.RowHeadersWidth = 51;
            this.servicesDataGrid.RowTemplate.Height = 24;
            this.servicesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.servicesDataGrid.Size = new System.Drawing.Size(825, 284);
            this.servicesDataGrid.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.btn_newOrder);
            this.tabPage1.Controls.Add(this.btn_addNewClient);
            this.tabPage1.Controls.Add(this.btnClientDetails);
            this.tabPage1.Controls.Add(this.lblClientDetails);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.clientsDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(900, 555);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clients";
            // 
            // btn_newOrder
            // 
            this.btn_newOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newOrder.Location = new System.Drawing.Point(764, 483);
            this.btn_newOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_newOrder.Name = "btn_newOrder";
            this.btn_newOrder.Size = new System.Drawing.Size(99, 32);
            this.btn_newOrder.TabIndex = 8;
            this.btn_newOrder.Text = "New Order";
            this.btn_newOrder.UseVisualStyleBackColor = true;
            this.btn_newOrder.Click += new System.EventHandler(this.btn_newOrder_Click);
            // 
            // btn_addNewClient
            // 
            this.btn_addNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addNewClient.Location = new System.Drawing.Point(155, 483);
            this.btn_addNewClient.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addNewClient.Name = "btn_addNewClient";
            this.btn_addNewClient.Size = new System.Drawing.Size(99, 32);
            this.btn_addNewClient.TabIndex = 7;
            this.btn_addNewClient.Text = "+ New Client";
            this.btn_addNewClient.UseVisualStyleBackColor = true;
            this.btn_addNewClient.Click += new System.EventHandler(this.btn_addNewClient_Click);
            // 
            // btnClientDetails
            // 
            this.btnClientDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientDetails.Location = new System.Drawing.Point(38, 483);
            this.btnClientDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientDetails.Name = "btnClientDetails";
            this.btnClientDetails.Size = new System.Drawing.Size(99, 32);
            this.btnClientDetails.TabIndex = 7;
            this.btnClientDetails.Text = "Client Details";
            this.btnClientDetails.UseVisualStyleBackColor = true;
            this.btnClientDetails.Click += new System.EventHandler(this.btnClientDetails_Click_1);
            // 
            // lblClientDetails
            // 
            this.lblClientDetails.AutoSize = true;
            this.lblClientDetails.Location = new System.Drawing.Point(152, 493);
            this.lblClientDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClientDetails.Name = "lblClientDetails";
            this.lblClientDetails.Size = new System.Drawing.Size(0, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(220, 51);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(460, 58);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnFindClient
            // 
            this.btnFindClient.Location = new System.Drawing.Point(379, 20);
            this.btnFindClient.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindClient.Name = "btnFindClient";
            this.btnFindClient.Size = new System.Drawing.Size(56, 21);
            this.btnFindClient.TabIndex = 4;
            this.btnFindClient.Text = "Find";
            this.btnFindClient.UseVisualStyleBackColor = true;
            this.btnFindClient.Click += new System.EventHandler(this.btnFindClient_Click);
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Location = new System.Drawing.Point(14, 22);
            this.txtSearchClient.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(108, 20);
            this.txtSearchClient.TabIndex = 3;
            // 
            // radBtnClientEmail
            // 
            this.radBtnClientEmail.AutoSize = true;
            this.radBtnClientEmail.Location = new System.Drawing.Point(296, 22);
            this.radBtnClientEmail.Margin = new System.Windows.Forms.Padding(2);
            this.radBtnClientEmail.Name = "radBtnClientEmail";
            this.radBtnClientEmail.Size = new System.Drawing.Size(64, 17);
            this.radBtnClientEmail.TabIndex = 2;
            this.radBtnClientEmail.TabStop = true;
            this.radBtnClientEmail.Text = "by Email";
            this.radBtnClientEmail.UseVisualStyleBackColor = true;
            // 
            // radBtnClientName
            // 
            this.radBtnClientName.AutoSize = true;
            this.radBtnClientName.Location = new System.Drawing.Point(215, 22);
            this.radBtnClientName.Margin = new System.Windows.Forms.Padding(2);
            this.radBtnClientName.Name = "radBtnClientName";
            this.radBtnClientName.Size = new System.Drawing.Size(67, 17);
            this.radBtnClientName.TabIndex = 1;
            this.radBtnClientName.TabStop = true;
            this.radBtnClientName.Text = "by Name";
            this.radBtnClientName.UseVisualStyleBackColor = true;
            // 
            // radBtnClientID
            // 
            this.radBtnClientID.AutoSize = true;
            this.radBtnClientID.Location = new System.Drawing.Point(148, 22);
            this.radBtnClientID.Margin = new System.Windows.Forms.Padding(2);
            this.radBtnClientID.Name = "radBtnClientID";
            this.radBtnClientID.Size = new System.Drawing.Size(50, 17);
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
            this.clientsDataGrid.Location = new System.Drawing.Point(38, 167);
            this.clientsDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.clientsDataGrid.Name = "clientsDataGrid";
            this.clientsDataGrid.ReadOnly = true;
            this.clientsDataGrid.RowHeadersWidth = 51;
            this.clientsDataGrid.RowTemplate.Height = 24;
            this.clientsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clientsDataGrid.Size = new System.Drawing.Size(825, 284);
            this.clientsDataGrid.TabIndex = 0;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Controls.Add(this.tabRegistry);
            this.tabs.Location = new System.Drawing.Point(20, 35);
            this.tabs.Margin = new System.Windows.Forms.Padding(2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(908, 581);
            this.tabs.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(900, 555);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profile";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_deleteEmployee);
            this.groupBox6.Controls.Add(this.updateButton5);
            this.groupBox6.Controls.Add(this.btn_addEmployee);
            this.groupBox6.Controls.Add(this.employeesDataGrid);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Location = new System.Drawing.Point(107, 106);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(686, 336);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Employees";
            // 
            // employeesDataGrid
            // 
            this.employeesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.employeesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.employeesDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.employeesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDataGrid.Location = new System.Drawing.Point(8, 17);
            this.employeesDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.employeesDataGrid.Name = "employeesDataGrid";
            this.employeesDataGrid.ReadOnly = true;
            this.employeesDataGrid.RowHeadersWidth = 51;
            this.employeesDataGrid.RowTemplate.Height = 24;
            this.employeesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesDataGrid.Size = new System.Drawing.Size(670, 223);
            this.employeesDataGrid.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Add employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Update employee";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(540, 276);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Remove employee";
            // 
            // tabRegistry
            // 
            this.tabRegistry.BackColor = System.Drawing.Color.Gainsboro;
            this.tabRegistry.Controls.Add(this.lblSelectInvoice);
            this.tabRegistry.Controls.Add(this.btnViewInvoice);
            this.tabRegistry.Controls.Add(this.invoicesDataGrid);
            this.tabRegistry.Location = new System.Drawing.Point(4, 22);
            this.tabRegistry.Margin = new System.Windows.Forms.Padding(2);
            this.tabRegistry.Name = "tabRegistry";
            this.tabRegistry.Padding = new System.Windows.Forms.Padding(2);
            this.tabRegistry.Size = new System.Drawing.Size(900, 555);
            this.tabRegistry.TabIndex = 3;
            this.tabRegistry.Text = "Invoices";
            // 
            // lblSelectInvoice
            // 
            this.lblSelectInvoice.AutoSize = true;
            this.lblSelectInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectInvoice.Location = new System.Drawing.Point(68, 427);
            this.lblSelectInvoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectInvoice.Name = "lblSelectInvoice";
            this.lblSelectInvoice.Size = new System.Drawing.Size(113, 17);
            this.lblSelectInvoice.TabIndex = 9;
            this.lblSelectInvoice.Text = "Invoice selected:";
            // 
            // btnViewInvoice
            // 
            this.btnViewInvoice.BackColor = System.Drawing.Color.Gainsboro;
            this.btnViewInvoice.Enabled = false;
            this.btnViewInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInvoice.Location = new System.Drawing.Point(411, 466);
            this.btnViewInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewInvoice.Name = "btnViewInvoice";
            this.btnViewInvoice.Size = new System.Drawing.Size(80, 32);
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
            this.invoicesDataGrid.Location = new System.Drawing.Point(20, 105);
            this.invoicesDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.invoicesDataGrid.Name = "invoicesDataGrid";
            this.invoicesDataGrid.RowHeadersWidth = 51;
            this.invoicesDataGrid.RowTemplate.Height = 24;
            this.invoicesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoicesDataGrid.Size = new System.Drawing.Size(862, 305);
            this.invoicesDataGrid.TabIndex = 0;
            this.invoicesDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectedCellInvoice);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(321, 188);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Update employee";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(131, 188);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 15);
            this.label12.TabIndex = 21;
            this.label12.Text = "Add employee";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.loginToolStripMenuItem.Text = "Login...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem1.Text = "About...";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.btn_findEmployee);
            this.groupBox3.Controls.Add(this.txtBox_search);
            this.groupBox3.Controls.Add(this.radioBtn_byName);
            this.groupBox3.Controls.Add(this.radioBtn_byId);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(253, 24);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(390, 58);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // btn_findEmployee
            // 
            this.btn_findEmployee.Location = new System.Drawing.Point(321, 20);
            this.btn_findEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btn_findEmployee.Name = "btn_findEmployee";
            this.btn_findEmployee.Size = new System.Drawing.Size(56, 21);
            this.btn_findEmployee.TabIndex = 4;
            this.btn_findEmployee.Text = "Find";
            this.btn_findEmployee.UseVisualStyleBackColor = true;
            // 
            // txtBox_search
            // 
            this.txtBox_search.Location = new System.Drawing.Point(14, 22);
            this.txtBox_search.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_search.Name = "txtBox_search";
            this.txtBox_search.Size = new System.Drawing.Size(108, 20);
            this.txtBox_search.TabIndex = 3;
            // 
            // radioBtn_byName
            // 
            this.radioBtn_byName.AutoSize = true;
            this.radioBtn_byName.Location = new System.Drawing.Point(215, 22);
            this.radioBtn_byName.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtn_byName.Name = "radioBtn_byName";
            this.radioBtn_byName.Size = new System.Drawing.Size(67, 17);
            this.radioBtn_byName.TabIndex = 1;
            this.radioBtn_byName.TabStop = true;
            this.radioBtn_byName.Text = "by Name";
            this.radioBtn_byName.UseVisualStyleBackColor = true;
            // 
            // radioBtn_byId
            // 
            this.radioBtn_byId.AutoSize = true;
            this.radioBtn_byId.Location = new System.Drawing.Point(148, 22);
            this.radioBtn_byId.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtn_byId.Name = "radioBtn_byId";
            this.radioBtn_byId.Size = new System.Drawing.Size(50, 17);
            this.radioBtn_byId.TabIndex = 0;
            this.radioBtn_byId.TabStop = true;
            this.radioBtn_byId.Text = "by ID";
            this.radioBtn_byId.UseVisualStyleBackColor = true;
            // 
            // btn_deleteEmployee
            // 
            this.btn_deleteEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_deleteEmployee.BackgroundImage")));
            this.btn_deleteEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_deleteEmployee.Location = new System.Drawing.Point(485, 259);
            this.btn_deleteEmployee.Name = "btn_deleteEmployee";
            this.btn_deleteEmployee.Size = new System.Drawing.Size(50, 50);
            this.btn_deleteEmployee.TabIndex = 26;
            this.btn_deleteEmployee.UseVisualStyleBackColor = false;
            this.btn_deleteEmployee.Click += new System.EventHandler(this.btn_deleteEmployee_Click);
            // 
            // updateButton5
            // 
            this.updateButton5.BackColor = System.Drawing.Color.Transparent;
            this.updateButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateButton5.BackgroundImage")));
            this.updateButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton5.Location = new System.Drawing.Point(258, 260);
            this.updateButton5.Name = "updateButton5";
            this.updateButton5.Size = new System.Drawing.Size(50, 50);
            this.updateButton5.TabIndex = 25;
            this.updateButton5.UseVisualStyleBackColor = false;
            this.updateButton5.Click += new System.EventHandler(this.employee_details_Click);
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btn_addEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addEmployee.BackgroundImage")));
            this.btn_addEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addEmployee.Location = new System.Drawing.Point(48, 259);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Size = new System.Drawing.Size(50, 50);
            this.btn_addEmployee.TabIndex = 24;
            this.btn_addEmployee.UseVisualStyleBackColor = false;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addEmployee_Click);
            // 
            // addButton4
            // 
            this.addButton4.BackColor = System.Drawing.Color.Transparent;
            this.addButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton4.BackgroundImage")));
            this.addButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton4.Location = new System.Drawing.Point(86, 176);
            this.addButton4.Margin = new System.Windows.Forms.Padding(2);
            this.addButton4.Name = "addButton4";
            this.addButton4.Size = new System.Drawing.Size(38, 41);
            this.addButton4.TabIndex = 18;
            this.addButton4.UseVisualStyleBackColor = true;
            // 
            // deleteButton4
            // 
            this.deleteButton4.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton4.BackgroundImage")));
            this.deleteButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton4.Location = new System.Drawing.Point(481, 176);
            this.deleteButton4.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton4.Name = "deleteButton4";
            this.deleteButton4.Size = new System.Drawing.Size(38, 41);
            this.deleteButton4.TabIndex = 19;
            this.deleteButton4.UseVisualStyleBackColor = false;
            // 
            // updateButton4
            // 
            this.updateButton4.BackColor = System.Drawing.Color.Transparent;
            this.updateButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateButton4.BackgroundImage")));
            this.updateButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton4.Location = new System.Drawing.Point(276, 176);
            this.updateButton4.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton4.Name = "updateButton4";
            this.updateButton4.Size = new System.Drawing.Size(38, 41);
            this.updateButton4.TabIndex = 20;
            this.updateButton4.UseVisualStyleBackColor = false;
            // 
            // updateButton3
            // 
            this.updateButton3.BackColor = System.Drawing.Color.Transparent;
            this.updateButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateButton3.BackgroundImage")));
            this.updateButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton3.Location = new System.Drawing.Point(16, 87);
            this.updateButton3.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton3.Name = "updateButton3";
            this.updateButton3.Size = new System.Drawing.Size(38, 41);
            this.updateButton3.TabIndex = 11;
            this.updateButton3.UseVisualStyleBackColor = false;
            // 
            // addButton3
            // 
            this.addButton3.BackColor = System.Drawing.Color.Transparent;
            this.addButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton3.BackgroundImage")));
            this.addButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton3.Location = new System.Drawing.Point(16, 41);
            this.addButton3.Margin = new System.Windows.Forms.Padding(2);
            this.addButton3.Name = "addButton3";
            this.addButton3.Size = new System.Drawing.Size(38, 41);
            this.addButton3.TabIndex = 9;
            this.addButton3.UseVisualStyleBackColor = true;
            // 
            // deleteButton3
            // 
            this.deleteButton3.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton3.BackgroundImage")));
            this.deleteButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton3.Location = new System.Drawing.Point(16, 132);
            this.deleteButton3.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton3.Name = "deleteButton3";
            this.deleteButton3.Size = new System.Drawing.Size(38, 41);
            this.deleteButton3.TabIndex = 10;
            this.deleteButton3.UseVisualStyleBackColor = false;
            // 
            // updateButton2
            // 
            this.updateButton2.BackColor = System.Drawing.Color.Transparent;
            this.updateButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateButton2.BackgroundImage")));
            this.updateButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton2.Location = new System.Drawing.Point(18, 87);
            this.updateButton2.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton2.Name = "updateButton2";
            this.updateButton2.Size = new System.Drawing.Size(38, 41);
            this.updateButton2.TabIndex = 11;
            this.updateButton2.UseVisualStyleBackColor = false;
            // 
            // addButton2
            // 
            this.addButton2.BackColor = System.Drawing.Color.Transparent;
            this.addButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton2.BackgroundImage")));
            this.addButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton2.Location = new System.Drawing.Point(18, 41);
            this.addButton2.Margin = new System.Windows.Forms.Padding(2);
            this.addButton2.Name = "addButton2";
            this.addButton2.Size = new System.Drawing.Size(38, 41);
            this.addButton2.TabIndex = 9;
            this.addButton2.UseVisualStyleBackColor = true;
            // 
            // deleteButton2
            // 
            this.deleteButton2.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton2.BackgroundImage")));
            this.deleteButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton2.Location = new System.Drawing.Point(18, 132);
            this.deleteButton2.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton2.Name = "deleteButton2";
            this.deleteButton2.Size = new System.Drawing.Size(38, 41);
            this.deleteButton2.TabIndex = 10;
            this.deleteButton2.UseVisualStyleBackColor = false;
            // 
            // updateButton1
            // 
            this.updateButton1.BackColor = System.Drawing.Color.Transparent;
            this.updateButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateButton1.BackgroundImage")));
            this.updateButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateButton1.Location = new System.Drawing.Point(18, 87);
            this.updateButton1.Margin = new System.Windows.Forms.Padding(2);
            this.updateButton1.Name = "updateButton1";
            this.updateButton1.Size = new System.Drawing.Size(38, 41);
            this.updateButton1.TabIndex = 11;
            this.updateButton1.UseVisualStyleBackColor = false;
            // 
            // addButton1
            // 
            this.addButton1.BackColor = System.Drawing.Color.Transparent;
            this.addButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addButton1.BackgroundImage")));
            this.addButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addButton1.Location = new System.Drawing.Point(18, 28);
            this.addButton1.Margin = new System.Windows.Forms.Padding(2);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(38, 41);
            this.addButton1.TabIndex = 9;
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // deleteButton1
            // 
            this.deleteButton1.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton1.BackgroundImage")));
            this.deleteButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton1.Location = new System.Drawing.Point(18, 132);
            this.deleteButton1.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton1.Name = "deleteButton1";
            this.deleteButton1.Size = new System.Drawing.Size(38, 41);
            this.deleteButton1.TabIndex = 10;
            this.deleteButton1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 651);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDataGrid)).EndInit();
            this.tabRegistry.ResumeLayout(false);
            this.tabRegistry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesDataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private CustomComponents.DeleteButton deleteButton1;
        private CustomComponents.UpdateButton updateButton1;
        private GroupBox groupBox6;
        private DataGridView employeesDataGrid;
        private Label label10;
        private CustomComponents.AddButton addButton4;
        private CustomComponents.DeleteButton deleteButton4;
        private Label label11;
        private Label label12;
        private CustomComponents.UpdateButton updateButton4;
        private CustomComponents.UpdateButton updateButton3;
        private CustomComponents.AddButton addButton3;
        private CustomComponents.DeleteButton deleteButton3;
        private CustomComponents.UpdateButton updateButton2;
        private CustomComponents.AddButton addButton2;
        private CustomComponents.DeleteButton deleteButton2;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private Button btn_newOrder;
        private Button btn_addNewClient;
        private CustomComponents.DeleteButton btn_deleteEmployee;
        private CustomComponents.UpdateButton updateButton5;
        private CustomComponents.AddButton btn_addEmployee;
        private Label label2;
        private Label label1;
        private Button btn_itemDetail;
        private Button btn_addItem;
        private GroupBox groupBox3;
        private Button btn_findEmployee;
        private TextBox txtBox_search;
        private RadioButton radioBtn_byName;
        private RadioButton radioBtn_byId;
    }
}

