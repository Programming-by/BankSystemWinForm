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
            this.dgvAllClients = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listClients = new System.Windows.Forms.Button();
            this.addClient = new System.Windows.Forms.Button();
            this.deleteClient = new System.Windows.Forms.Button();
            this.updateClient = new System.Windows.Forms.Button();
            this.findClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllClients
            // 
            this.dgvAllClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllClients.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllClients.Location = new System.Drawing.Point(314, 26);
            this.dgvAllClients.Name = "dgvAllClients";
            this.dgvAllClients.RowHeadersWidth = 51;
            this.dgvAllClients.RowTemplate.Height = 24;
            this.dgvAllClients.Size = new System.Drawing.Size(1085, 478);
            this.dgvAllClients.TabIndex = 0;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Clients",
            "Users"});
            this.comboBox1.Location = new System.Drawing.Point(12, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listClients
            // 
            this.listClients.Location = new System.Drawing.Point(12, 89);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(219, 70);
            this.listClients.TabIndex = 2;
            this.listClients.Text = "List Clients";
            this.listClients.UseVisualStyleBackColor = true;
            this.listClients.Click += new System.EventHandler(this.listClients_Click);
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(12, 190);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(219, 70);
            this.addClient.TabIndex = 3;
            this.addClient.Text = "Add New Client";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // deleteClient
            // 
            this.deleteClient.Location = new System.Drawing.Point(12, 279);
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(219, 70);
            this.deleteClient.TabIndex = 4;
            this.deleteClient.Text = "Delete Client";
            this.deleteClient.UseVisualStyleBackColor = true;
            // 
            // updateClient
            // 
            this.updateClient.Location = new System.Drawing.Point(12, 372);
            this.updateClient.Name = "updateClient";
            this.updateClient.Size = new System.Drawing.Size(219, 70);
            this.updateClient.TabIndex = 5;
            this.updateClient.Text = "Update Client";
            this.updateClient.UseVisualStyleBackColor = true;
            // 
            // findClient
            // 
            this.findClient.Location = new System.Drawing.Point(12, 458);
            this.findClient.Name = "findClient";
            this.findClient.Size = new System.Drawing.Size(219, 70);
            this.findClient.TabIndex = 6;
            this.findClient.Text = "Find Client";
            this.findClient.UseVisualStyleBackColor = true;
            this.findClient.Click += new System.EventHandler(this.findClient_Click);
            // 
            // frmListClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 526);
            this.Controls.Add(this.findClient);
            this.Controls.Add(this.updateClient);
            this.Controls.Add(this.deleteClient);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.listClients);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvAllClients);
            this.Name = "frmListClients";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllClients;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button listClients;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Button deleteClient;
        private System.Windows.Forms.Button updateClient;
        private System.Windows.Forms.Button findClient;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

