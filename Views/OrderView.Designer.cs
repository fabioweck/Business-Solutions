namespace BusinessManager.Views
{
    partial class OrderView
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
            this.lbl_newOrder = new System.Windows.Forms.Label();
            this.lbl_nameLabel = new System.Windows.Forms.Label();
            this.lbl_nameData = new System.Windows.Forms.Label();
            this.llbl_IdLabel = new System.Windows.Forms.Label();
            this.lbl_IdData = new System.Windows.Forms.Label();
            this.lbl_phoneLabel = new System.Windows.Forms.Label();
            this.lbl_phoneData = new System.Windows.Forms.Label();
            this.OrderGridView = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.gb_Order = new System.Windows.Forms.GroupBox();
            this.btnFindService = new System.Windows.Forms.Button();
            this.txtSearchService = new System.Windows.Forms.TextBox();
            this.radBtnDescription = new System.Windows.Forms.RadioButton();
            this.radBtnServiceID = new System.Windows.Forms.RadioButton();
            this.CartGridView = new System.Windows.Forms.DataGridView();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.tB_quantity = new System.Windows.Forms.TextBox();
            this.lbl_quantityLabel = new System.Windows.Forms.Label();
            this.btn_removeItem = new System.Windows.Forms.Button();
            this.btn_createInvoice = new System.Windows.Forms.Button();
            this.lbl_totalLabel = new System.Windows.Forms.Label();
            this.lbl_totalSum = new System.Windows.Forms.Label();
            this.lblGST = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            this.gb_Order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_newOrder
            // 
            this.lbl_newOrder.AutoSize = true;
            this.lbl_newOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newOrder.Location = new System.Drawing.Point(460, 63);
            this.lbl_newOrder.Name = "lbl_newOrder";
            this.lbl_newOrder.Size = new System.Drawing.Size(134, 23);
            this.lbl_newOrder.TabIndex = 2;
            this.lbl_newOrder.Text = "NEW ORDER";
            // 
            // lbl_nameLabel
            // 
            this.lbl_nameLabel.AutoSize = true;
            this.lbl_nameLabel.Location = new System.Drawing.Point(347, 107);
            this.lbl_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nameLabel.Name = "lbl_nameLabel";
            this.lbl_nameLabel.Size = new System.Drawing.Size(47, 16);
            this.lbl_nameLabel.TabIndex = 3;
            this.lbl_nameLabel.Text = "Name:";
            // 
            // lbl_nameData
            // 
            this.lbl_nameData.AutoSize = true;
            this.lbl_nameData.Location = new System.Drawing.Point(405, 107);
            this.lbl_nameData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nameData.Name = "lbl_nameData";
            this.lbl_nameData.Size = new System.Drawing.Size(66, 16);
            this.lbl_nameData.TabIndex = 3;
            this.lbl_nameData.Text = "tmpName";
            // 
            // llbl_IdLabel
            // 
            this.llbl_IdLabel.AutoSize = true;
            this.llbl_IdLabel.Location = new System.Drawing.Point(165, 107);
            this.llbl_IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbl_IdLabel.Name = "llbl_IdLabel";
            this.llbl_IdLabel.Size = new System.Drawing.Size(23, 16);
            this.llbl_IdLabel.TabIndex = 3;
            this.llbl_IdLabel.Text = "ID:";
            // 
            // lbl_IdData
            // 
            this.lbl_IdData.AutoSize = true;
            this.lbl_IdData.Location = new System.Drawing.Point(224, 107);
            this.lbl_IdData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_IdData.Name = "lbl_IdData";
            this.lbl_IdData.Size = new System.Drawing.Size(40, 16);
            this.lbl_IdData.TabIndex = 3;
            this.lbl_IdData.Text = "tmpId";
            // 
            // lbl_phoneLabel
            // 
            this.lbl_phoneLabel.AutoSize = true;
            this.lbl_phoneLabel.Location = new System.Drawing.Point(775, 107);
            this.lbl_phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phoneLabel.Name = "lbl_phoneLabel";
            this.lbl_phoneLabel.Size = new System.Drawing.Size(49, 16);
            this.lbl_phoneLabel.TabIndex = 3;
            this.lbl_phoneLabel.Text = "Phone:";
            // 
            // lbl_phoneData
            // 
            this.lbl_phoneData.AutoSize = true;
            this.lbl_phoneData.Location = new System.Drawing.Point(833, 107);
            this.lbl_phoneData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_phoneData.Name = "lbl_phoneData";
            this.lbl_phoneData.Size = new System.Drawing.Size(68, 16);
            this.lbl_phoneData.TabIndex = 3;
            this.lbl_phoneData.Text = "tmpPhone";
            // 
            // OrderGridView
            // 
            this.OrderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Location = new System.Drawing.Point(67, 231);
            this.OrderGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.ReadOnly = true;
            this.OrderGridView.RowHeadersWidth = 51;
            this.OrderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGridView.Size = new System.Drawing.Size(467, 346);
            this.OrderGridView.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(541, 647);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(131, 34);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gb_Order
            // 
            this.gb_Order.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gb_Order.Controls.Add(this.btnFindService);
            this.gb_Order.Controls.Add(this.txtSearchService);
            this.gb_Order.Controls.Add(this.radBtnDescription);
            this.gb_Order.Controls.Add(this.radBtnServiceID);
            this.gb_Order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_Order.ForeColor = System.Drawing.Color.Black;
            this.gb_Order.Location = new System.Drawing.Point(169, 138);
            this.gb_Order.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Order.Name = "gb_Order";
            this.gb_Order.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Order.Size = new System.Drawing.Size(520, 71);
            this.gb_Order.TabIndex = 13;
            this.gb_Order.TabStop = false;
            this.gb_Order.Text = "Search";
            // 
            // btnFindService
            // 
            this.btnFindService.Location = new System.Drawing.Point(428, 25);
            this.btnFindService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFindService.Name = "btnFindService";
            this.btnFindService.Size = new System.Drawing.Size(75, 26);
            this.btnFindService.TabIndex = 4;
            this.btnFindService.Text = "Find";
            this.btnFindService.UseVisualStyleBackColor = true;
            this.btnFindService.Click += new System.EventHandler(this.btnFindService_Click);
            // 
            // txtSearchService
            // 
            this.txtSearchService.Location = new System.Drawing.Point(19, 27);
            this.txtSearchService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchService.Name = "txtSearchService";
            this.txtSearchService.Size = new System.Drawing.Size(143, 22);
            this.txtSearchService.TabIndex = 3;
            // 
            // radBtnDescription
            // 
            this.radBtnDescription.AutoSize = true;
            this.radBtnDescription.Location = new System.Drawing.Point(287, 27);
            this.radBtnDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.radBtnServiceID.Location = new System.Drawing.Point(197, 27);
            this.radBtnServiceID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radBtnServiceID.Name = "radBtnServiceID";
            this.radBtnServiceID.Size = new System.Drawing.Size(59, 20);
            this.radBtnServiceID.TabIndex = 0;
            this.radBtnServiceID.TabStop = true;
            this.radBtnServiceID.Text = "by ID";
            this.radBtnServiceID.UseVisualStyleBackColor = true;
            // 
            // CartGridView
            // 
            this.CartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGridView.Location = new System.Drawing.Point(541, 231);
            this.CartGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CartGridView.Name = "CartGridView";
            this.CartGridView.ReadOnly = true;
            this.CartGridView.RowHeadersWidth = 51;
            this.CartGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartGridView.Size = new System.Drawing.Size(467, 346);
            this.CartGridView.TabIndex = 5;
            // 
            // btn_addItem
            // 
            this.btn_addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItem.Location = new System.Drawing.Point(400, 580);
            this.btn_addItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(133, 34);
            this.btn_addItem.TabIndex = 12;
            this.btn_addItem.Text = "+ Add Item";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // tB_quantity
            // 
            this.tB_quantity.Location = new System.Drawing.Point(251, 583);
            this.tB_quantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tB_quantity.Name = "tB_quantity";
            this.tB_quantity.Size = new System.Drawing.Size(143, 22);
            this.tB_quantity.TabIndex = 3;
            // 
            // lbl_quantityLabel
            // 
            this.lbl_quantityLabel.AutoSize = true;
            this.lbl_quantityLabel.Location = new System.Drawing.Point(184, 587);
            this.lbl_quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_quantityLabel.Name = "lbl_quantityLabel";
            this.lbl_quantityLabel.Size = new System.Drawing.Size(55, 16);
            this.lbl_quantityLabel.TabIndex = 3;
            this.lbl_quantityLabel.Text = "Quantity";
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeItem.Location = new System.Drawing.Point(541, 580);
            this.btn_removeItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(133, 34);
            this.btn_removeItem.TabIndex = 12;
            this.btn_removeItem.Text = "- Remove Item";
            this.btn_removeItem.UseVisualStyleBackColor = true;
            this.btn_removeItem.Click += new System.EventHandler(this.btn_removeItem_Click);
            // 
            // btn_createInvoice
            // 
            this.btn_createInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createInvoice.Location = new System.Drawing.Point(400, 647);
            this.btn_createInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_createInvoice.Name = "btn_createInvoice";
            this.btn_createInvoice.Size = new System.Drawing.Size(133, 34);
            this.btn_createInvoice.TabIndex = 12;
            this.btn_createInvoice.Text = "Create Invoice";
            this.btn_createInvoice.UseVisualStyleBackColor = true;
            this.btn_createInvoice.Click += new System.EventHandler(this.btn_createInvoice_Click);
            // 
            // lbl_totalLabel
            // 
            this.lbl_totalLabel.AutoSize = true;
            this.lbl_totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalLabel.Location = new System.Drawing.Point(781, 586);
            this.lbl_totalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalLabel.Name = "lbl_totalLabel";
            this.lbl_totalLabel.Size = new System.Drawing.Size(68, 25);
            this.lbl_totalLabel.TabIndex = 14;
            this.lbl_totalLabel.Text = "Total:";
            // 
            // lbl_totalSum
            // 
            this.lbl_totalSum.AutoSize = true;
            this.lbl_totalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalSum.Location = new System.Drawing.Point(856, 586);
            this.lbl_totalSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalSum.Name = "lbl_totalSum";
            this.lbl_totalSum.Size = new System.Drawing.Size(66, 25);
            this.lbl_totalSum.TabIndex = 14;
            this.lbl_totalSum.Text = "$0.00";
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGST.Location = new System.Drawing.Point(861, 615);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(0, 20);
            this.lblGST.TabIndex = 15;
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 695);
            this.Controls.Add(this.lblGST);
            this.Controls.Add(this.lbl_totalSum);
            this.Controls.Add(this.lbl_totalLabel);
            this.Controls.Add(this.gb_Order);
            this.Controls.Add(this.tB_quantity);
            this.Controls.Add(this.btn_removeItem);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.btn_createInvoice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.CartGridView);
            this.Controls.Add(this.OrderGridView);
            this.Controls.Add(this.lbl_IdData);
            this.Controls.Add(this.lbl_nameData);
            this.Controls.Add(this.lbl_quantityLabel);
            this.Controls.Add(this.llbl_IdLabel);
            this.Controls.Add(this.lbl_phoneData);
            this.Controls.Add(this.lbl_phoneLabel);
            this.Controls.Add(this.lbl_nameLabel);
            this.Controls.Add(this.lbl_newOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OrderView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
            this.gb_Order.ResumeLayout(false);
            this.gb_Order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_newOrder;
        private System.Windows.Forms.Label lbl_nameLabel;
        private System.Windows.Forms.Label lbl_nameData;
        private System.Windows.Forms.Label llbl_IdLabel;
        private System.Windows.Forms.Label lbl_IdData;
        private System.Windows.Forms.Label lbl_phoneLabel;
        private System.Windows.Forms.Label lbl_phoneData;
        private System.Windows.Forms.DataGridView OrderGridView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gb_Order;
        private System.Windows.Forms.Button btnFindService;
        private System.Windows.Forms.TextBox txtSearchService;
        private System.Windows.Forms.RadioButton radBtnDescription;
        private System.Windows.Forms.RadioButton radBtnServiceID;
        private System.Windows.Forms.DataGridView CartGridView;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.TextBox tB_quantity;
        private System.Windows.Forms.Label lbl_quantityLabel;
        private System.Windows.Forms.Button btn_removeItem;
        private System.Windows.Forms.Button btn_createInvoice;
        private System.Windows.Forms.Label lbl_totalLabel;
        private System.Windows.Forms.Label lbl_totalSum;
        private System.Windows.Forms.Label lblGST;
    }
}