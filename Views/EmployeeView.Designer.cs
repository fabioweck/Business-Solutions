namespace BusinessManager.Views
{
    partial class EmployeeView
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.checkBox_admin = new System.Windows.Forms.CheckBox();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_box_phone = new System.Windows.Forms.TextBox();
            this.txt_box_email = new System.Windows.Forms.TextBox();
            this.txt_box_address = new System.Windows.Forms.TextBox();
            this.txt_box_name = new System.Windows.Forms.TextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_Id_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_confirmPassword = new System.Windows.Forms.TextBox();
            this.lbl_confirmPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(292, 34);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(126, 25);
            this.labelTitle.TabIndex = 15;
            this.labelTitle.Text = "EMPLOYEE ";
            // 
            // checkBox_admin
            // 
            this.checkBox_admin.AutoSize = true;
            this.checkBox_admin.Location = new System.Drawing.Point(149, 345);
            this.checkBox_admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_admin.Name = "checkBox_admin";
            this.checkBox_admin.Size = new System.Drawing.Size(67, 20);
            this.checkBox_admin.TabIndex = 45;
            this.checkBox_admin.Text = "Admin";
            this.checkBox_admin.UseVisualStyleBackColor = true;
            // 
            // txtBox_password
            // 
            this.txtBox_password.Location = new System.Drawing.Point(220, 279);
            this.txtBox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(373, 22);
            this.txtBox_password.TabIndex = 44;
            this.txtBox_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Password:";
            // 
            // txt_box_phone
            // 
            this.txt_box_phone.Location = new System.Drawing.Point(149, 240);
            this.txt_box_phone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_box_phone.Name = "txt_box_phone";
            this.txt_box_phone.Size = new System.Drawing.Size(444, 22);
            this.txt_box_phone.TabIndex = 39;
            // 
            // txt_box_email
            // 
            this.txt_box_email.Location = new System.Drawing.Point(149, 201);
            this.txt_box_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_box_email.Name = "txt_box_email";
            this.txt_box_email.Size = new System.Drawing.Size(444, 22);
            this.txt_box_email.TabIndex = 40;
            // 
            // txt_box_address
            // 
            this.txt_box_address.Location = new System.Drawing.Point(149, 161);
            this.txt_box_address.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_box_address.Name = "txt_box_address";
            this.txt_box_address.Size = new System.Drawing.Size(444, 22);
            this.txt_box_address.TabIndex = 41;
            // 
            // txt_box_name
            // 
            this.txt_box_name.Location = new System.Drawing.Point(149, 124);
            this.txt_box_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_box_name.Name = "txt_box_name";
            this.txt_box_name.Size = new System.Drawing.Size(444, 22);
            this.txt_box_name.TabIndex = 42;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Location = new System.Drawing.Point(177, 400);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(98, 34);
            this.btnAddEmployee.TabIndex = 38;
            this.btnAddEmployee.Text = "Save";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(372, 400);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 34);
            this.btnClose.TabIndex = 37;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 36;
            this.label5.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Address:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(147, 89);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(63, 20);
            this.lbl_id.TabIndex = 31;
            this.lbl_id.Text = "lbl_tmp";
            // 
            // lbl_Id_label
            // 
            this.lbl_Id_label.AutoSize = true;
            this.lbl_Id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Id_label.Location = new System.Drawing.Point(45, 89);
            this.lbl_Id_label.Name = "lbl_Id_label";
            this.lbl_Id_label.Size = new System.Drawing.Size(36, 20);
            this.lbl_Id_label.TabIndex = 32;
            this.lbl_Id_label.Text = "ID: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Name:";
            // 
            // txtBox_confirmPassword
            // 
            this.txtBox_confirmPassword.Location = new System.Drawing.Point(220, 311);
            this.txtBox_confirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBox_confirmPassword.Name = "txtBox_confirmPassword";
            this.txtBox_confirmPassword.Size = new System.Drawing.Size(375, 22);
            this.txtBox_confirmPassword.TabIndex = 44;
            this.txtBox_confirmPassword.UseSystemPasswordChar = true;
            // 
            // lbl_confirmPassword
            // 
            this.lbl_confirmPassword.AutoSize = true;
            this.lbl_confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmPassword.Location = new System.Drawing.Point(47, 311);
            this.lbl_confirmPassword.Name = "lbl_confirmPassword";
            this.lbl_confirmPassword.Size = new System.Drawing.Size(152, 20);
            this.lbl_confirmPassword.TabIndex = 43;
            this.lbl_confirmPassword.Text = "Confirm Password:";
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 453);
            this.Controls.Add(this.checkBox_admin);
            this.Controls.Add(this.txtBox_confirmPassword);
            this.Controls.Add(this.txtBox_password);
            this.Controls.Add(this.lbl_confirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_box_phone);
            this.Controls.Add(this.txt_box_email);
            this.Controls.Add(this.txt_box_address);
            this.Controls.Add(this.txt_box_name);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_Id_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeView";
            this.Text = "EmployeeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox checkBox_admin;
        private System.Windows.Forms.TextBox txtBox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_box_phone;
        private System.Windows.Forms.TextBox txt_box_email;
        private System.Windows.Forms.TextBox txt_box_address;
        private System.Windows.Forms.TextBox txt_box_name;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_Id_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_confirmPassword;
        private System.Windows.Forms.Label lbl_confirmPassword;
    }
}