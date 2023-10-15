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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.servicesDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.radBtnEmail = new System.Windows.Forms.RadioButton();
            this.radBtnName = new System.Windows.Forms.RadioButton();
            this.radBtnID = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.clientsDataGrid = new System.Windows.Forms.DataGridView();
            this.tabExcel = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtPhoneWorksheet = new System.Windows.Forms.TextBox();
            this.txtEmailWorksheet = new System.Windows.Forms.TextBox();
            this.txtNameWorksheet = new System.Windows.Forms.TextBox();
            this.txtPriceWorksheet = new System.Windows.Forms.TextBox();
            this.txtDescriptionWorksheet = new System.Windows.Forms.TextBox();
            this.txtQtyWorksheet = new System.Windows.Forms.TextBox();
            this.txtIdWorksheet = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGrid)).BeginInit();
            this.tabExcel.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblPrice);
            this.tabPage2.Controls.Add(this.txtPrice);
            this.tabPage2.Controls.Add(this.txtDescription);
            this.tabPage2.Controls.Add(this.btnAddService);
            this.tabPage2.Controls.Add(this.servicesDataGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 654);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Services";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(40, 95);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 16);
            this.lblPrice.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(43, 70);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(219, 22);
            this.txtPrice.TabIndex = 7;
            this.txtPrice.Text = "Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(43, 42);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(219, 22);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.Text = "Description";
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(343, 70);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(91, 23);
            this.btnAddService.TabIndex = 5;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // servicesDataGrid
            // 
            this.servicesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.servicesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesDataGrid.Location = new System.Drawing.Point(6, 127);
            this.servicesDataGrid.Name = "servicesDataGrid";
            this.servicesDataGrid.RowHeadersWidth = 51;
            this.servicesDataGrid.RowTemplate.Height = 24;
            this.servicesDataGrid.Size = new System.Drawing.Size(756, 433);
            this.servicesDataGrid.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.btnAddClient);
            this.tabPage1.Controls.Add(this.clientsDataGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 654);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clients";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.radBtnEmail);
            this.groupBox1.Controls.Add(this.radBtnName);
            this.groupBox1.Controls.Add(this.radBtnID);
            this.groupBox1.Location = new System.Drawing.Point(441, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 121);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(123, 78);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 26);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(110, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // radBtnEmail
            // 
            this.radBtnEmail.AutoSize = true;
            this.radBtnEmail.Location = new System.Drawing.Point(235, 52);
            this.radBtnEmail.Name = "radBtnEmail";
            this.radBtnEmail.Size = new System.Drawing.Size(80, 20);
            this.radBtnEmail.TabIndex = 2;
            this.radBtnEmail.TabStop = true;
            this.radBtnEmail.Text = "by Email";
            this.radBtnEmail.UseVisualStyleBackColor = true;
            // 
            // radBtnName
            // 
            this.radBtnName.AutoSize = true;
            this.radBtnName.Location = new System.Drawing.Point(119, 50);
            this.radBtnName.Name = "radBtnName";
            this.radBtnName.Size = new System.Drawing.Size(83, 20);
            this.radBtnName.TabIndex = 1;
            this.radBtnName.TabStop = true;
            this.radBtnName.Text = "by Name";
            this.radBtnName.UseVisualStyleBackColor = true;
            // 
            // radBtnID
            // 
            this.radBtnID.AutoSize = true;
            this.radBtnID.Location = new System.Drawing.Point(6, 50);
            this.radBtnID.Name = "radBtnID";
            this.radBtnID.Size = new System.Drawing.Size(59, 20);
            this.radBtnID.TabIndex = 0;
            this.radBtnID.TabStop = true;
            this.radBtnID.Text = "by ID";
            this.radBtnID.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 82);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 22);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "Email";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(24, 54);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(219, 22);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "Address";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(24, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 22);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "Name";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(249, 40);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(57, 51);
            this.btnAddClient.TabIndex = 1;
            this.btnAddClient.Text = "Add Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // clientsDataGrid
            // 
            this.clientsDataGrid.AllowUserToAddRows = false;
            this.clientsDataGrid.AllowUserToDeleteRows = false;
            this.clientsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.clientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGrid.Location = new System.Drawing.Point(6, 206);
            this.clientsDataGrid.Name = "clientsDataGrid";
            this.clientsDataGrid.RowHeadersWidth = 51;
            this.clientsDataGrid.RowTemplate.Height = 24;
            this.clientsDataGrid.Size = new System.Drawing.Size(756, 442);
            this.clientsDataGrid.TabIndex = 0;
            // 
            // tabExcel
            // 
            this.tabExcel.Controls.Add(this.tabPage1);
            this.tabExcel.Controls.Add(this.tabPage2);
            this.tabExcel.Controls.Add(this.tabPage3);
            this.tabExcel.Location = new System.Drawing.Point(12, 12);
            this.tabExcel.Name = "tabExcel";
            this.tabExcel.SelectedIndex = 0;
            this.tabExcel.Size = new System.Drawing.Size(776, 683);
            this.tabExcel.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblPath);
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
            this.tabPage3.Size = new System.Drawing.Size(768, 654);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Excel test";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblPath
            // 
            this.lblPath.Location = new System.Drawing.Point(58, 507);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(653, 112);
            this.lblPath.TabIndex = 9;
            this.lblPath.Text = "label1";
            // 
            // txtPhoneWorksheet
            // 
            this.txtPhoneWorksheet.Location = new System.Drawing.Point(494, 324);
            this.txtPhoneWorksheet.Name = "txtPhoneWorksheet";
            this.txtPhoneWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtPhoneWorksheet.TabIndex = 8;
            this.txtPhoneWorksheet.Text = "Phone";
            // 
            // txtEmailWorksheet
            // 
            this.txtEmailWorksheet.Location = new System.Drawing.Point(334, 324);
            this.txtEmailWorksheet.Name = "txtEmailWorksheet";
            this.txtEmailWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtEmailWorksheet.TabIndex = 7;
            this.txtEmailWorksheet.Text = "Email";
            // 
            // txtNameWorksheet
            // 
            this.txtNameWorksheet.Location = new System.Drawing.Point(175, 324);
            this.txtNameWorksheet.Name = "txtNameWorksheet";
            this.txtNameWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtNameWorksheet.TabIndex = 6;
            this.txtNameWorksheet.Text = "Name";
            // 
            // txtPriceWorksheet
            // 
            this.txtPriceWorksheet.Location = new System.Drawing.Point(494, 360);
            this.txtPriceWorksheet.Name = "txtPriceWorksheet";
            this.txtPriceWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtPriceWorksheet.TabIndex = 4;
            this.txtPriceWorksheet.Text = "Price";
            // 
            // txtDescriptionWorksheet
            // 
            this.txtDescriptionWorksheet.Location = new System.Drawing.Point(388, 360);
            this.txtDescriptionWorksheet.Name = "txtDescriptionWorksheet";
            this.txtDescriptionWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtDescriptionWorksheet.TabIndex = 3;
            this.txtDescriptionWorksheet.Text = "Description";
            // 
            // txtQtyWorksheet
            // 
            this.txtQtyWorksheet.Location = new System.Drawing.Point(281, 360);
            this.txtQtyWorksheet.Name = "txtQtyWorksheet";
            this.txtQtyWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtQtyWorksheet.TabIndex = 2;
            this.txtQtyWorksheet.Text = "Quantity";
            // 
            // txtIdWorksheet
            // 
            this.txtIdWorksheet.Location = new System.Drawing.Point(175, 360);
            this.txtIdWorksheet.Name = "txtIdWorksheet";
            this.txtIdWorksheet.Size = new System.Drawing.Size(100, 22);
            this.txtIdWorksheet.TabIndex = 1;
            this.txtIdWorksheet.Text = "ID";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(315, 414);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(139, 47);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate my template";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnLoadTemplate);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 707);
            this.Controls.Add(this.tabExcel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGrid)).EndInit();
            this.tabExcel.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.DataGridView servicesDataGrid;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton radBtnEmail;
        private System.Windows.Forms.RadioButton radBtnName;
        private System.Windows.Forms.RadioButton radBtnID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.DataGridView clientsDataGrid;
        private System.Windows.Forms.TabControl tabExcel;
        private TabPage tabPage3;
        private Button btnGenerate;
        private TextBox txtPriceWorksheet;
        private TextBox txtDescriptionWorksheet;
        private TextBox txtQtyWorksheet;
        private TextBox txtIdWorksheet;
        private TextBox txtPhoneWorksheet;
        private TextBox txtEmailWorksheet;
        private TextBox txtNameWorksheet;
        private Label lblPath;
    }
}

