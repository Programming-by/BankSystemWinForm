namespace BankSystemWinForm
{
    partial class frmAddEditUser
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
            this.lblMode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbltest = new System.Windows.Forms.Label();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkLoginRegister = new System.Windows.Forms.CheckBox();
            this.chkManageUsers = new System.Windows.Forms.CheckBox();
            this.chkTransactions = new System.Windows.Forms.CheckBox();
            this.chkAddNewClient = new System.Windows.Forms.CheckBox();
            this.chkFindClient = new System.Windows.Forms.CheckBox();
            this.chkUpdateClient = new System.Windows.Forms.CheckBox();
            this.chkDeleteClient = new System.Windows.Forms.CheckBox();
            this.chkShowAllClients = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(354, 19);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(277, 46);
            this.lblMode.TabIndex = 0;
            this.lblMode.Text = "Add New User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 46);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 46);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 510);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 46);
            this.label7.TabIndex = 6;
            this.label7.Text = "Permissions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 46);
            this.label8.TabIndex = 7;
            this.label8.Text = "UserID";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(362, 434);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(298, 46);
            this.txtPassword.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(362, 291);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(298, 46);
            this.txtPhone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(362, 363);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(298, 46);
            this.txtEmail.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(362, 215);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 46);
            this.txtName.TabIndex = 12;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(340, 81);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(86, 46);
            this.lblUserID.TabIndex = 14;
            this.lblUserID.Text = "???";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(362, 153);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(298, 46);
            this.txtUserName.TabIndex = 15;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(815, 732);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 72);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(124, 765);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 72);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltest.Location = new System.Drawing.Point(788, 181);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(86, 46);
            this.lbltest.TabIndex = 21;
            this.lbltest.Text = "???";
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(3, 11);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(45, 21);
            this.chkAll.TabIndex = 22;
            this.chkAll.Text = "All";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkLoginRegister);
            this.panel1.Controls.Add(this.chkManageUsers);
            this.panel1.Controls.Add(this.chkTransactions);
            this.panel1.Controls.Add(this.chkAddNewClient);
            this.panel1.Controls.Add(this.chkFindClient);
            this.panel1.Controls.Add(this.chkUpdateClient);
            this.panel1.Controls.Add(this.chkDeleteClient);
            this.panel1.Controls.Add(this.chkShowAllClients);
            this.panel1.Controls.Add(this.chkAll);
            this.panel1.Location = new System.Drawing.Point(387, 524);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 265);
            this.panel1.TabIndex = 23;
            // 
            // chkLoginRegister
            // 
            this.chkLoginRegister.AutoSize = true;
            this.chkLoginRegister.Location = new System.Drawing.Point(3, 227);
            this.chkLoginRegister.Name = "chkLoginRegister";
            this.chkLoginRegister.Size = new System.Drawing.Size(122, 21);
            this.chkLoginRegister.TabIndex = 30;
            this.chkLoginRegister.Text = "Login Register";
            this.chkLoginRegister.UseVisualStyleBackColor = true;
            // 
            // chkManageUsers
            // 
            this.chkManageUsers.AutoSize = true;
            this.chkManageUsers.Location = new System.Drawing.Point(3, 173);
            this.chkManageUsers.Name = "chkManageUsers";
            this.chkManageUsers.Size = new System.Drawing.Size(122, 21);
            this.chkManageUsers.TabIndex = 29;
            this.chkManageUsers.Text = "Manage Users";
            this.chkManageUsers.UseVisualStyleBackColor = true;
            // 
            // chkTransactions
            // 
            this.chkTransactions.AutoSize = true;
            this.chkTransactions.Location = new System.Drawing.Point(3, 200);
            this.chkTransactions.Name = "chkTransactions";
            this.chkTransactions.Size = new System.Drawing.Size(112, 21);
            this.chkTransactions.TabIndex = 28;
            this.chkTransactions.Text = "Transactions";
            this.chkTransactions.UseVisualStyleBackColor = true;
            // 
            // chkAddNewClient
            // 
            this.chkAddNewClient.AutoSize = true;
            this.chkAddNewClient.Location = new System.Drawing.Point(3, 65);
            this.chkAddNewClient.Name = "chkAddNewClient";
            this.chkAddNewClient.Size = new System.Drawing.Size(125, 21);
            this.chkAddNewClient.TabIndex = 27;
            this.chkAddNewClient.Text = "Add New Client";
            this.chkAddNewClient.UseVisualStyleBackColor = true;
            // 
            // chkFindClient
            // 
            this.chkFindClient.AutoSize = true;
            this.chkFindClient.Location = new System.Drawing.Point(3, 146);
            this.chkFindClient.Name = "chkFindClient";
            this.chkFindClient.Size = new System.Drawing.Size(96, 21);
            this.chkFindClient.TabIndex = 26;
            this.chkFindClient.Text = "Find Client";
            this.chkFindClient.UseVisualStyleBackColor = true;
            // 
            // chkUpdateClient
            // 
            this.chkUpdateClient.AutoSize = true;
            this.chkUpdateClient.Location = new System.Drawing.Point(3, 119);
            this.chkUpdateClient.Name = "chkUpdateClient";
            this.chkUpdateClient.Size = new System.Drawing.Size(115, 21);
            this.chkUpdateClient.TabIndex = 25;
            this.chkUpdateClient.Text = "Update Client";
            this.chkUpdateClient.UseVisualStyleBackColor = true;
            // 
            // chkDeleteClient
            // 
            this.chkDeleteClient.AutoSize = true;
            this.chkDeleteClient.Location = new System.Drawing.Point(3, 92);
            this.chkDeleteClient.Name = "chkDeleteClient";
            this.chkDeleteClient.Size = new System.Drawing.Size(110, 21);
            this.chkDeleteClient.TabIndex = 24;
            this.chkDeleteClient.Text = "Delete Client";
            this.chkDeleteClient.UseVisualStyleBackColor = true;
            // 
            // chkShowAllClients
            // 
            this.chkShowAllClients.AutoSize = true;
            this.chkShowAllClients.Location = new System.Drawing.Point(3, 38);
            this.chkShowAllClients.Name = "chkShowAllClients";
            this.chkShowAllClients.Size = new System.Drawing.Size(129, 21);
            this.chkShowAllClients.TabIndex = 23;
            this.chkShowAllClients.Text = "Show All Clients";
            this.chkShowAllClients.UseVisualStyleBackColor = true;
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 898);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmAddEditUser";
            this.Text = "frmAddNewUser";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkLoginRegister;
        private System.Windows.Forms.CheckBox chkManageUsers;
        private System.Windows.Forms.CheckBox chkTransactions;
        private System.Windows.Forms.CheckBox chkAddNewClient;
        private System.Windows.Forms.CheckBox chkFindClient;
        private System.Windows.Forms.CheckBox chkUpdateClient;
        private System.Windows.Forms.CheckBox chkDeleteClient;
        private System.Windows.Forms.CheckBox chkShowAllClients;
    }
}