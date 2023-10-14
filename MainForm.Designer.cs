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
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.servicesDataGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 579);
            this.tabControl1.TabIndex = 0;
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
            this.tabPage1.Size = new System.Drawing.Size(768, 550);
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
            this.clientsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.clientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsDataGrid.Location = new System.Drawing.Point(6, 131);
            this.clientsDataGrid.Name = "clientsDataGrid";
            this.clientsDataGrid.RowHeadersWidth = 51;
            this.clientsDataGrid.RowTemplate.Height = 24;
            this.clientsDataGrid.Size = new System.Drawing.Size(756, 413);
            this.clientsDataGrid.TabIndex = 0;
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
            this.tabPage2.Size = new System.Drawing.Size(768, 550);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView clientsDataGrid;
        private System.Windows.Forms.DataGridView servicesDataGrid;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBtnEmail;
        private System.Windows.Forms.RadioButton radBtnName;
        private System.Windows.Forms.RadioButton radBtnID;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

