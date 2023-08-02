namespace BankSystemWinForm
{
    partial class frmUpdateUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelPermissions = new System.Windows.Forms.Panel();
            this.chkLoginRegister = new System.Windows.Forms.CheckBox();
            this.chkManageUsers = new System.Windows.Forms.CheckBox();
            this.chkTransactions = new System.Windows.Forms.CheckBox();
            this.chkAddNewClient = new System.Windows.Forms.CheckBox();
            this.chkFindClient = new System.Windows.Forms.CheckBox();
            this.chkUpdateClient = new System.Windows.Forms.CheckBox();
            this.chkDeleteClient = new System.Windows.Forms.CheckBox();
            this.chkShowAllClients = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.panelPermissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Permissions";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(51, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phone:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(254, 52);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(334, 38);
            this.txtUserName.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(254, 128);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(334, 38);
            this.txtName.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(254, 197);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(334, 38);
            this.txtPhone.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(254, 263);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(334, 38);
            this.txtEmail.TabIndex = 10;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(254, 333);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(334, 38);
            this.txtPassword.TabIndex = 11;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(633, 52);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(96, 38);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 678);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 53);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(535, 678);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 53);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelPermissions
            // 
            this.panelPermissions.Controls.Add(this.chkLoginRegister);
            this.panelPermissions.Controls.Add(this.chkManageUsers);
            this.panelPermissions.Controls.Add(this.chkTransactions);
            this.panelPermissions.Controls.Add(this.chkAddNewClient);
            this.panelPermissions.Controls.Add(this.chkFindClient);
            this.panelPermissions.Controls.Add(this.chkUpdateClient);
            this.panelPermissions.Controls.Add(this.chkDeleteClient);
            this.panelPermissions.Controls.Add(this.chkShowAllClients);
            this.panelPermissions.Controls.Add(this.chkAll);
            this.panelPermissions.Location = new System.Drawing.Point(254, 409);
            this.panelPermissions.Name = "panelPermissions";
            this.panelPermissions.Size = new System.Drawing.Size(200, 265);
            this.panelPermissions.TabIndex = 24;
            // 
            // chkLoginRegister
            // 
            this.chkLoginRegister.AutoSize = true;
            this.chkLoginRegister.Location = new System.Drawing.Point(3, 227);
            this.chkLoginRegister.Name = "chkLoginRegister";
            this.chkLoginRegister.Size = new System.Drawing.Size(116, 20);
            this.chkLoginRegister.TabIndex = 30;
            this.chkLoginRegister.Text = "Login Register";
            this.chkLoginRegister.UseVisualStyleBackColor = true;
            // 
            // chkManageUsers
            // 
            this.chkManageUsers.AutoSize = true;
            this.chkManageUsers.Location = new System.Drawing.Point(3, 173);
            this.chkManageUsers.Name = "chkManageUsers";
            this.chkManageUsers.Size = new System.Drawing.Size(118, 20);
            this.chkManageUsers.TabIndex = 29;
            this.chkManageUsers.Text = "Manage Users";
            this.chkManageUsers.UseVisualStyleBackColor = true;
            // 
            // chkTransactions
            // 
            this.chkTransactions.AutoSize = true;
            this.chkTransactions.Location = new System.Drawing.Point(3, 200);
            this.chkTransactions.Name = "chkTransactions";
            this.chkTransactions.Size = new System.Drawing.Size(107, 20);
            this.chkTransactions.TabIndex = 28;
            this.chkTransactions.Text = "Transactions";
            this.chkTransactions.UseVisualStyleBackColor = true;
            // 
            // chkAddNewClient
            // 
            this.chkAddNewClient.AutoSize = true;
            this.chkAddNewClient.Location = new System.Drawing.Point(3, 65);
            this.chkAddNewClient.Name = "chkAddNewClient";
            this.chkAddNewClient.Size = new System.Drawing.Size(120, 20);
            this.chkAddNewClient.TabIndex = 27;
            this.chkAddNewClient.Text = "Add New Client";
            this.chkAddNewClient.UseVisualStyleBackColor = true;
            // 
            // chkFindClient
            // 
            this.chkFindClient.AutoSize = true;
            this.chkFindClient.Location = new System.Drawing.Point(3, 146);
            this.chkFindClient.Name = "chkFindClient";
            this.chkFindClient.Size = new System.Drawing.Size(91, 20);
            this.chkFindClient.TabIndex = 26;
            this.chkFindClient.Text = "Find Client";
            this.chkFindClient.UseVisualStyleBackColor = true;
            // 
            // chkUpdateClient
            // 
            this.chkUpdateClient.AutoSize = true;
            this.chkUpdateClient.Location = new System.Drawing.Point(3, 119);
            this.chkUpdateClient.Name = "chkUpdateClient";
            this.chkUpdateClient.Size = new System.Drawing.Size(110, 20);
            this.chkUpdateClient.TabIndex = 25;
            this.chkUpdateClient.Text = "Update Client";
            this.chkUpdateClient.UseVisualStyleBackColor = true;
            // 
            // chkDeleteClient
            // 
            this.chkDeleteClient.AutoSize = true;
            this.chkDeleteClient.Location = new System.Drawing.Point(3, 92);
            this.chkDeleteClient.Name = "chkDeleteClient";
            this.chkDeleteClient.Size = new System.Drawing.Size(105, 20);
            this.chkDeleteClient.TabIndex = 24;
            this.chkDeleteClient.Text = "Delete Client";
            this.chkDeleteClient.UseVisualStyleBackColor = true;
            // 
            // chkShowAllClients
            // 
            this.chkShowAllClients.AutoSize = true;
            this.chkShowAllClients.Location = new System.Drawing.Point(3, 38);
            this.chkShowAllClients.Name = "chkShowAllClients";
            this.chkShowAllClients.Size = new System.Drawing.Size(123, 20);
            this.chkShowAllClients.TabIndex = 23;
            this.chkShowAllClients.Text = "Show All Clients";
            this.chkShowAllClients.UseVisualStyleBackColor = true;
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(3, 11);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(44, 20);
            this.chkAll.TabIndex = 22;
            this.chkAll.Text = "All";
            this.chkAll.UseVisualStyleBackColor = true;
            // 
            // frmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 775);
            this.Controls.Add(this.panelPermissions);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateUser";
            this.Text = "frmUpdateUser";
            this.panelPermissions.ResumeLayout(false);
            this.panelPermissions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelPermissions;
        private System.Windows.Forms.CheckBox chkLoginRegister;
        private System.Windows.Forms.CheckBox chkManageUsers;
        private System.Windows.Forms.CheckBox chkTransactions;
        private System.Windows.Forms.CheckBox chkAddNewClient;
        private System.Windows.Forms.CheckBox chkFindClient;
        private System.Windows.Forms.CheckBox chkUpdateClient;
        private System.Windows.Forms.CheckBox chkDeleteClient;
        private System.Windows.Forms.CheckBox chkShowAllClients;
        private System.Windows.Forms.CheckBox chkAll;
    }
}