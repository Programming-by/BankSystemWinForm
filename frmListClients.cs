using ClientBusinessLayer;
using PersonBusinessLayer;
using System;
using System.Windows.Forms;
using UserBusinessLayer;

namespace BankSystemWinForm
{
    public partial class frmListClients : Form
    {
        /*
         Permissions
         Currency Exchange
         
         */

        float TotalBalances = 0;

        public frmListClients()
        {
            InitializeComponent();
        }


        private void _RefreshClientsList()
        {
            dgvAllClientsAndAllUsers.DataSource = clsClient.GetAllClients();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            frmAddEditClient frm = new frmAddEditClient(-1);

            frm.ShowDialog();

            _RefreshClientsList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditClient frm = new frmAddEditClient((int)dgvAllClientsAndAllUsers.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _RefreshClientsList();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to delete Client [" + dgvAllClientsAndAllUsers.CurrentRow.Cells[0].Value + "]" , "Confirm Delete" , MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsClient.DeleteClient((int)dgvAllClientsAndAllUsers.CurrentRow.Cells[0].Value))
                {
                    if(clsPerson.DeletePerson((int)dgvAllClientsAndAllUsers.CurrentRow.Cells[0].Value))
                    {
                        MessageBox.Show("Client Deleted Successfully.");
                        _RefreshClientsList();
                    }
                }
            }
        }

        private void findClient_Click(object sender, EventArgs e)
        {

            frmFindClient frm = new frmFindClient();

            frm.ShowDialog();

      


        }

      

        private void listClients_Click(object sender, EventArgs e)
        {
            _RefreshClientsList();
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {
            frmFindClient frm = new frmFindClient(true);

            frm.ShowDialog();

            

            _RefreshClientsList();

        }

        private void updateClient_Click(object sender, EventArgs e)
        {

            frmUpdateClient frm = new frmUpdateClient();

            frm.ShowDialog();

            _RefreshClientsList();


        }

        private void _RefreshUsersList()
        {
            dgvAllClientsAndAllUsers.DataSource = clsUser.GetAllUsers();
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            _RefreshUsersList();

            dgvAllClientsAndAllUsers.ContextMenuStrip = contextMenuStrip2;

        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser(-1);

            frm.ShowDialog();

            _RefreshUsersList();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User [" + dgvAllClientsAndAllUsers.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsUser.DeleteUser((int)dgvAllClientsAndAllUsers.CurrentRow.Cells[0].Value))
                {
                    if (clsPerson.DeletePerson((int)dgvAllClientsAndAllUsers.CurrentRow.Cells[0].Value))
                    {
                        MessageBox.Show("User Deleted Successfully.");
                        _RefreshUsersList();
                    }
                }
            }

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser((int)dgvAllClientsAndAllUsers.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _RefreshUsersList();

        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            frmFindUser frm = new frmFindUser();

            frm.ShowDialog();

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            frmFindUser frm = new frmFindUser(true);

            frm.ShowDialog();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            frmUpdateUser frm = new frmUpdateUser();

            frm.ShowDialog();

            _RefreshUsersList();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            frmDepositAndWithdraw frm = new frmDepositAndWithdraw(0);

            frm.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            frmDepositAndWithdraw frm = new frmDepositAndWithdraw(-1);

            frm.ShowDialog();

            

        }

        private void btnTotalBalances_Click(object sender, EventArgs e)
        {

            dgvAllClientsAndAllUsers.DataSource = clsClient.GetTotalBalances();

            dgvAllClientsAndAllUsers.ContextMenuStrip = null;

            TotalBalances = clsClient.Sum();

            lblTotalBalances.Text = TotalBalances.ToString() + "$";

            lblTotalBalancesText.Visible = true;
            lblTotalBalances.Visible = true;



        }
    }
}
