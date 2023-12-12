namespace BusinessManager.Views
{
    partial class SendEmail
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
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSendInvoice = new System.Windows.Forms.Button();
            this.btnCancelSendInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(115, 101);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(218, 22);
            this.txtBoxEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send invoice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(53, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email:";
            // 
            // btnSendInvoice
            // 
            this.btnSendInvoice.Location = new System.Drawing.Point(115, 160);
            this.btnSendInvoice.Name = "btnSendInvoice";
            this.btnSendInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnSendInvoice.TabIndex = 3;
            this.btnSendInvoice.Text = "Send";
            this.btnSendInvoice.UseVisualStyleBackColor = true;
            this.btnSendInvoice.Click += new System.EventHandler(this.btnSendInvoice_Click);
            // 
            // btnCancelSendInvoice
            // 
            this.btnCancelSendInvoice.Location = new System.Drawing.Point(196, 160);
            this.btnCancelSendInvoice.Name = "btnCancelSendInvoice";
            this.btnCancelSendInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSendInvoice.TabIndex = 4;
            this.btnCancelSendInvoice.Text = "Cancel";
            this.btnCancelSendInvoice.UseVisualStyleBackColor = true;
            this.btnCancelSendInvoice.Click += new System.EventHandler(this.btnCancelSendInvoice_Click);
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(387, 224);
            this.Controls.Add(this.btnCancelSendInvoice);
            this.Controls.Add(this.btnSendInvoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendEmail";
            this.Text = "SendEmail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSendInvoice;
        private System.Windows.Forms.Button btnCancelSendInvoice;
    }
}