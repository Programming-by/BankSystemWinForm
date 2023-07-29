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
            this.dgvShow = new System.Windows.Forms.DataGridView();
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
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnTotalBalances = new System.Windows.Forms.Button();
            this.lblTotalBalancesText = new System.Windows.Forms.Label();
            this.lblTotalBalances = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnTransferLogs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvShow.Location = new System.Drawing.Point(314, 26);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersWidth = 51;
            this.dgvShow.RowTemplate.Height = 24;
            this.dgvShow.Size = new System.Drawing.Size(1085, 478);
            this.dgvShow.TabIndex = 0;
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
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(12, 533);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(249, 52);
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(12, 600);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(249, 52);
            this.btnUpdateUser.TabIndex = 10;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnFindUser
            // 
            this.btnFindUser.Location = new System.Drawing.Point(12, 658);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(249, 52);
            this.btnFindUser.TabIndex = 11;
            this.btnFindUser.Text = "Find User";
            this.btnFindUser.UseVisualStyleBackColor = true;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(123, 52);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(314, 545);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(249, 52);
            this.btnDeposit.TabIndex = 12;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(586, 545);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(249, 52);
            this.btnWithdraw.TabIndex = 13;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnTotalBalances
            // 
            this.btnTotalBalances.Location = new System.Drawing.Point(854, 545);
            this.btnTotalBalances.Name = "btnTotalBalances";
            this.btnTotalBalances.Size = new System.Drawing.Size(249, 52);
            this.btnTotalBalances.TabIndex = 14;
            this.btnTotalBalances.Text = "Total Balances";
            this.btnTotalBalances.UseVisualStyleBackColor = true;
            this.btnTotalBalances.Click += new System.EventHandler(this.btnTotalBalances_Click);
            // 
            // lblTotalBalancesText
            // 
            this.lblTotalBalancesText.AutoSize = true;
            this.lblTotalBalancesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalancesText.Location = new System.Drawing.Point(892, 376);
            this.lblTotalBalancesText.Name = "lblTotalBalancesText";
            this.lblTotalBalancesText.Size = new System.Drawing.Size(211, 32);
            this.lblTotalBalancesText.TabIndex = 15;
            this.lblTotalBalancesText.Text = "Total Balances:";
            this.lblTotalBalancesText.Visible = false;
            // 
            // lblTotalBalances
            // 
            this.lblTotalBalances.AutoSize = true;
            this.lblTotalBalances.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBalances.Location = new System.Drawing.Point(1122, 376);
            this.lblTotalBalances.Name = "lblTotalBalances";
            this.lblTotalBalances.Size = new System.Drawing.Size(62, 32);
            this.lblTotalBalances.TabIndex = 16;
            this.lblTotalBalances.Text = "???";
            this.lblTotalBalances.Visible = false;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(1128, 545);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(249, 52);
            this.btnTransfer.TabIndex = 17;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnTransferLogs
            // 
            this.btnTransferLogs.Location = new System.Drawing.Point(314, 635);
            this.btnTransferLogs.Name = "btnTransferLogs";
            this.btnTransferLogs.Size = new System.Drawing.Size(249, 52);
            this.btnTransferLogs.TabIndex = 18;
            this.btnTransferLogs.Text = "Transfer Logs";
            this.btnTransferLogs.UseVisualStyleBackColor = true;
            this.btnTransferLogs.Click += new System.EventHandler(this.btnTransferLogs_Click);
            // 
            // frmListClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 727);
            this.Controls.Add(this.btnTransferLogs);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.lblTotalBalances);
            this.Controls.Add(this.lblTotalBalancesText);
            this.Controls.Add(this.btnTotalBalances);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
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
            this.Controls.Add(this.dgvShow);
            this.Name = "frmListClients";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShow;
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnTotalBalances;
        private System.Windows.Forms.Label lblTotalBalancesText;
        private System.Windows.Forms.Label lblTotalBalances;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnTransferLogs;
    }
}

