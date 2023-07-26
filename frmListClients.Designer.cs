namespace BankSystemWinForm
{
    partial class frmListClients
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
            this.components = new System.ComponentModel.Container();
            this.dgvAllClientsAndAllUsers = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listClients = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.deleteClient = new System.Windows.Forms.Button();
            this.updateClient = new System.Windows.Forms.Button();
            this.findClient = new System.Windows.Forms.Button();
            this.btnListUsers = new System.Windows.Forms.Button();
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnFindUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClientsAndAllUsers)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllClientsAndAllUsers
            // 
            this.dgvAllClientsAndAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllClientsAndAllUsers.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllClientsAndAllUsers.Location = new System.Drawing.Point(314, 26);
            this.dgvAllClientsAndAllUsers.Name = "dgvAllClientsAndAllUsers";
            this.dgvAllClientsAndAllUsers.RowHeadersWidth = 51;
            this.dgvAllClientsAndAllUsers.RowTemplate.Height = 24;
            this.dgvAllClientsAndAllUsers.Size = new System.Drawing.Size(1085, 478);
            this.dgvAllClientsAndAllUsers.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // listClients
            // 
            this.listClients.Location = new System.Drawing.Point(12, 26);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(249, 52);
            this.listClients.TabIndex = 2;
            this.listClients.Text = "List Clients";
            this.listClients.UseVisualStyleBackColor = true;
            this.listClients.Click += new System.EventHandler(this.listClients_Click);
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(12, 99);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(249, 52);
            this.addClient.TabIndex = 3;
            this.addClient.Text = "Add New Client";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // deleteClient
            // 
            this.deleteClient.Location = new System.Drawing.Point(12, 176);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(249, 52);
            this.deleteClient.TabIndex = 4;
            this.deleteClient.Text = "Delete Client";
            this.deleteClient.UseVisualStyleBackColor = true;
            this.deleteClient.Click += new System.EventHandler(this.deleteClient_Click);
            // 
            // updateClient
            // 
            this.updateClient.Location = new System.Drawing.Point(12, 247);
            this.updateClient.Name = "updateClient";
            this.updateClient.Size = new System.Drawing.Size(249, 52);
            this.updateClient.TabIndex = 5;
            this.updateClient.Text = "Update Client";
            this.updateClient.UseVisualStyleBackColor = true;
            this.updateClient.Click += new System.EventHandler(this.updateClient_Click);
            // 
            // findClient
            // 
            this.findClient.Location = new System.Drawing.Point(12, 321);
            this.findClient.Name = "findClient";
            this.findClient.Size = new System.Drawing.Size(249, 52);
            this.findClient.TabIndex = 6;
            this.findClient.Text = "Find Client";
            this.findClient.UseVisualStyleBackColor = true;
            this.findClient.Click += new System.EventHandler(this.findClient_Click);
            // 
            // btnListUsers
            // 
            this.btnListUsers.Location = new System.Drawing.Point(12, 396);
            this.btnListUsers.Name = "btnListUsers";
            this.btnListUsers.Size = new System.Drawing.Size(249, 52);
            this.btnListUsers.TabIndex = 7;
            this.btnListUsers.Text = "List Users";
            this.btnListUsers.UseVisualStyleBackColor = true;
            this.btnListUsers.Click += new System.EventHandler(this.btnListUsers_Click);
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Location = new System.Drawing.Point(12, 462);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(249, 52);
            this.btnAddNewUser.TabIndex = 8;
            this.btnAddNewUser.Text = "Add New User";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(12, 533);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(249, 52);
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(12, 600);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(249, 52);
            this.btnUpdateUser.TabIndex = 10;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // btnFindUser
            // 
            this.btnFindUser.Location = new System.Drawing.Point(12, 658);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(249, 52);
            this.btnFindUser.TabIndex = 11;
            this.btnFindUser.Text = "Find User";
            this.btnFindUser.UseVisualStyleBackColor = true;
            // 
            // frmListClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 727);
            this.Controls.Add(this.btnFindUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnAddNewUser);
            this.Controls.Add(this.btnListUsers);
            this.Controls.Add(this.findClient);
            this.Controls.Add(this.updateClient);
            this.Controls.Add(this.deleteClient);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.listClients);
            this.Controls.Add(this.dgvAllClientsAndAllUsers);
            this.Name = "frmListClients";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClientsAndAllUsers)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllClientsAndAllUsers;
        private System.Windows.Forms.Button listClients;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Button updateClient;
        private System.Windows.Forms.Button findClient;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnListUsers;
        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnFindUser;
    }
}

