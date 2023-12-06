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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
            this.gb_Order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CartGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_newOrder
            // 
            this.lbl_newOrder.AutoSize = true;
            this.lbl_newOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newOrder.Location = new System.Drawing.Point(345, 51);
            this.lbl_newOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_newOrder.Name = "lbl_newOrder";
            this.lbl_newOrder.Size = new System.Drawing.Size(110, 18);
            this.lbl_newOrder.TabIndex = 2;
            this.lbl_newOrder.Text = "NEW ORDER";
            // 
            // lbl_nameLabel
            // 
            this.lbl_nameLabel.AutoSize = true;
            this.lbl_nameLabel.Location = new System.Drawing.Point(260, 87);
            this.lbl_nameLabel.Name = "lbl_nameLabel";
            this.lbl_nameLabel.Size = new System.Drawing.Size(38, 13);
            this.lbl_nameLabel.TabIndex = 3;
            this.lbl_nameLabel.Text = "Name:";
            // 
            // lbl_nameData
            // 
            this.lbl_nameData.AutoSize = true;
            this.lbl_nameData.Location = new System.Drawing.Point(304, 87);
            this.lbl_nameData.Name = "lbl_nameData";
            this.lbl_nameData.Size = new System.Drawing.Size(52, 13);
            this.lbl_nameData.TabIndex = 3;
            this.lbl_nameData.Text = "tmpName";
            // 
            // llbl_IdLabel
            // 
            this.llbl_IdLabel.AutoSize = true;
            this.llbl_IdLabel.Location = new System.Drawing.Point(124, 87);
            this.llbl_IdLabel.Name = "llbl_IdLabel";
            this.llbl_IdLabel.Size = new System.Drawing.Size(21, 13);
            this.llbl_IdLabel.TabIndex = 3;
            this.llbl_IdLabel.Text = "ID:";
            // 
            // lbl_IdData
            // 
            this.lbl_IdData.AutoSize = true;
            this.lbl_IdData.Location = new System.Drawing.Point(168, 87);
            this.lbl_IdData.Name = "lbl_IdData";
            this.lbl_IdData.Size = new System.Drawing.Size(33, 13);
            this.lbl_IdData.TabIndex = 3;
            this.lbl_IdData.Text = "tmpId";
            // 
            // lbl_phoneLabel
            // 
            this.lbl_phoneLabel.AutoSize = true;
            this.lbl_phoneLabel.Location = new System.Drawing.Point(581, 87);
            this.lbl_phoneLabel.Name = "lbl_phoneLabel";
            this.lbl_phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.lbl_phoneLabel.TabIndex = 3;
            this.lbl_phoneLabel.Text = "Phone:";
            // 
            // lbl_phoneData
            // 
            this.lbl_phoneData.AutoSize = true;
            this.lbl_phoneData.Location = new System.Drawing.Point(625, 87);
            this.lbl_phoneData.Name = "lbl_phoneData";
            this.lbl_phoneData.Size = new System.Drawing.Size(55, 13);
            this.lbl_phoneData.TabIndex = 3;
            this.lbl_phoneData.Text = "tmpPhone";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Services",
            "Products"});
            this.comboBox1.Location = new System.Drawing.Point(559, 149);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // OrderGridView
            // 
            this.OrderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridView.Location = new System.Drawing.Point(50, 188);
            this.OrderGridView.Name = "OrderGridView";
            this.OrderGridView.ReadOnly = true;
            this.OrderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGridView.Size = new System.Drawing.Size(350, 281);
            this.OrderGridView.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(488, 526);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 28);
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
            this.gb_Order.Location = new System.Drawing.Point(127, 112);
            this.gb_Order.Margin = new System.Windows.Forms.Padding(2);
            this.gb_Order.Name = "gb_Order";
            this.gb_Order.Padding = new System.Windows.Forms.Padding(2);
            this.gb_Order.Size = new System.Drawing.Size(390, 58);
            this.gb_Order.TabIndex = 13;
            this.gb_Order.TabStop = false;
            this.gb_Order.Text = "Search";
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
            this.btnFindService.Click += new System.EventHandler(this.btnFindService_Click);
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
            // CartGridView
            // 
            this.CartGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CartGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CartGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CartGridView.Location = new System.Drawing.Point(406, 188);
            this.CartGridView.Name = "CartGridView";
            this.CartGridView.ReadOnly = true;
            this.CartGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CartGridView.Size = new System.Drawing.Size(350, 281);
            this.CartGridView.TabIndex = 5;
            // 
            // btn_addItem
            // 
            this.btn_addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addItem.Location = new System.Drawing.Point(300, 471);
            this.btn_addItem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(100, 28);
            this.btn_addItem.TabIndex = 12;
            this.btn_addItem.Text = "+ Add Item";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += new System.EventHandler(this.btn_addItem_Click);
            // 
            // tB_quantity
            // 
            this.tB_quantity.Location = new System.Drawing.Point(188, 474);
            this.tB_quantity.Margin = new System.Windows.Forms.Padding(2);
            this.tB_quantity.Name = "tB_quantity";
            this.tB_quantity.Size = new System.Drawing.Size(108, 20);
            this.tB_quantity.TabIndex = 3;
            // 
            // lbl_quantityLabel
            // 
            this.lbl_quantityLabel.AutoSize = true;
            this.lbl_quantityLabel.Location = new System.Drawing.Point(138, 477);
            this.lbl_quantityLabel.Name = "lbl_quantityLabel";
            this.lbl_quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.lbl_quantityLabel.TabIndex = 3;
            this.lbl_quantityLabel.Text = "Quantity";
            // 
            // btn_removeItem
            // 
            this.btn_removeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeItem.Location = new System.Drawing.Point(656, 471);
            this.btn_removeItem.Margin = new System.Windows.Forms.Padding(2);
            this.btn_removeItem.Name = "btn_removeItem";
            this.btn_removeItem.Size = new System.Drawing.Size(100, 28);
            this.btn_removeItem.TabIndex = 12;
            this.btn_removeItem.Text = "- Remove Item";
            this.btn_removeItem.UseVisualStyleBackColor = true;
            this.btn_removeItem.Click += new System.EventHandler(this.btn_removeItem_Click);
            // 
            // btn_createInvoice
            // 
            this.btn_createInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createInvoice.Location = new System.Drawing.Point(355, 526);
            this.btn_createInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btn_createInvoice.Name = "btn_createInvoice";
            this.btn_createInvoice.Size = new System.Drawing.Size(100, 28);
            this.btn_createInvoice.TabIndex = 12;
            this.btn_createInvoice.Text = "Create Invoice";
            this.btn_createInvoice.UseVisualStyleBackColor = true;
            this.btn_createInvoice.Click += new System.EventHandler(this.btn_createInvoice_Click);
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 565);
            this.Controls.Add(this.gb_Order);
            this.Controls.Add(this.tB_quantity);
            this.Controls.Add(this.btn_removeItem);
            this.Controls.Add(this.btn_addItem);
            this.Controls.Add(this.btn_createInvoice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.CartGridView);
            this.Controls.Add(this.OrderGridView);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_IdData);
            this.Controls.Add(this.lbl_nameData);
            this.Controls.Add(this.lbl_quantityLabel);
            this.Controls.Add(this.llbl_IdLabel);
            this.Controls.Add(this.lbl_phoneData);
            this.Controls.Add(this.lbl_phoneLabel);
            this.Controls.Add(this.lbl_nameLabel);
            this.Controls.Add(this.lbl_newOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.ComboBox comboBox1;
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
    }
}