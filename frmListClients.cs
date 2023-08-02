using Bank_Business_Layer;
using ClientBusinessLayer;
using PersonBusinessLayer;
using System;
using System.Windows.Forms;
using UserBusinessLayer;
using static BankSystemWinForm.frmAddEditUser;

namespace BankSystemWinForm
{
    public partial class frmListClients : Form
    {
        /*
         Group buttons under one Button
         UI
         */


        string _UserName;

        float TotalBalances = 0;

        clsUser _User;
        public frmListClients(clsUser User)
        {
            InitializeComponent();

            this._User = User;   

            _UserName = User.UserName;

            lblUserName.Text = _UserName;
        }


        private void _RefreshClientsList()
        {
            dgvShow.DataSource = clsClient.GetAllClients();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            if (!CheckAccessPermission(clsUser.enPermissions.pAddNewClient))
            {
                MessageBox.Show( "you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }


            frmAddEditClient frm = new frmAddEditClient(-1);

            frm.ShowDialog();

            _RefreshClientsList();
          

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!CheckAccessPermission(clsUser.enPermissions.pUpdateClient))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }

            frmAddEditClient frm = new frmAddEditClient((int)dgvShow.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _RefreshClientsList();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!CheckAccessPermission(clsUser.enPermissions.pDeleteClient))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }


            if (MessageBox.Show("Are you sure you want to delete Client [" + dgvShow.CurrentRow.Cells[0].Value + "]" , "Confirm Delete" , MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsClient.DeleteClient((int)dgvShow.CurrentRow.Cells[0].Value))
                {
                    if(clsPerson.DeletePerson((int)dgvShow.CurrentRow.Cells[0].Value))
                    {
                        MessageBox.Show("Client Deleted Successfully.");
                        _RefreshClientsList();
                    }
                }
            }
        }

        private void findClient_Click(object sender, EventArgs e)
        {

            if (!CheckAccessPermission(clsUser.enPermissions.pFindClient))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }

            frmFindClient frm = new frmFindClient();

            frm.ShowDialog();

      


        }

      

        private void listClients_Click(object sender, EventArgs e)
        {
            if (!CheckAccessPermission(clsUser.enPermissions.pShowAllClients))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }

            _RefreshClientsList();
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {

            if (!CheckAccessPermission(clsUser.enPermissions.pDeleteClient))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }

            frmFindClient frm = new frmFindClient(true);

            frm.ShowDialog();

            

            _RefreshClientsList();

        }

        private void updateClient_Click(object sender, EventArgs e)
        {

            if (!CheckAccessPermission(clsUser.enPermissions.pUpdateClient))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }

            frmUpdateClient frm = new frmUpdateClient();

            frm.ShowDialog();

            _RefreshClientsList();


        }

        private void _RefreshUsersList()
        {
            dgvShow.DataSource = clsUser.GetAllUsers();
        }

        private void btnListUsers_Click(object sender, EventArgs e)
        {
            if (!CheckAccessPermission(clsUser.enPermissions.pManageUsers))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }

            _RefreshUsersList();

            dgvShow.ContextMenuStrip = contextMenuStrip2;

        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (!CheckAccessPermission(clsUser.enPermissions.pManageUsers))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }

            frmAddEditUser frm = new frmAddEditUser(-1);

            frm.ShowDialog();

            _RefreshUsersList();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (!CheckAccessPermission(clsUser.enPermissions.pManageUsers))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }


            if (MessageBox.Show("Are you sure you want to delete User [" + dgvShow.CurrentRow.Cells[0].Value + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsUser.DeleteUser((int)dgvShow.CurrentRow.Cells[0].Value))
                {
                    if (clsPerson.DeletePerson((int)dgvShow.CurrentRow.Cells[0].Value))
                    {
                        MessageBox.Show("User Deleted Successfully.");
                        _RefreshUsersList();
                    }
                }
            }

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (!CheckAccessPermission(clsUser.enPermissions.pManageUsers))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }


            frmAddEditUser frm = new frmAddEditUser((int)dgvShow.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _RefreshUsersList();

        }

        private void btnFindUser_Click(object sender, EventArgs e)
        {
            if (!CheckAccessPermission(clsUser.enPermissions.pManageUsers))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }


            frmFindUser frm = new frmFindUser();

            frm.ShowDialog();

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {

            if (!CheckAccessPermission(clsUser.enPermissions.pManageUsers))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }

            frmFindUser frm = new frmFindUser(true);

            frm.ShowDialog();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (!CheckAccessPermission(clsUser.enPermissions.pManageUsers))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }


            frmUpdateUser frm = new frmUpdateUser();

            frm.ShowDialog();

            _RefreshUsersList();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (!CheckAccessPermission(clsUser.enPermissions.pTransactions))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }


            frmDepositAndWithdraw frm = new frmDepositAndWithdraw(0);

            frm.ShowDialog();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

            if (!CheckAccessPermission(clsUser.enPermissions.pTransactions))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }


            frmDepositAndWithdraw frm = new frmDepositAndWithdraw(-1);

            frm.ShowDialog();

            

        }

        private void btnTotalBalances_Click(object sender, EventArgs e)
        {

            if (!CheckAccessPermission(clsUser.enPermissions.pTransactions))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }

            dgvShow.DataSource = clsClient.GetTotalBalances();

            dgvShow.ContextMenuStrip = null;

            TotalBalances = clsClient.Sum();

            lblTotalBalances.Text = TotalBalances.ToString() + "$";

            lblTotalBalancesText.Visible = true;
            lblTotalBalances.Visible = true;



        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

            if (!CheckAccessPermission(clsUser.enPermissions.pTransactions))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }


            frmTransfer frm = new frmTransfer(_UserName);

            frm.ShowDialog();

        }

        private void btnTransferLogs_Click(object sender, EventArgs e)
        {
            if (!CheckAccessPermission(clsUser.enPermissions.pTransactions))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }


            dgvShow.DataSource = clsTransferLog.GetTransferLogs();

          dgvShow.ContextMenuStrip = null;

        }

        private void btnLoginRegisters_Click(object sender, EventArgs e)
        {

            if (!CheckAccessPermission(clsUser.enPermissions.pLoginRegisters))
            {
                MessageBox.Show("you are not allowed to enter this form because you don't have permission", "Access Denied", MessageBoxButtons.OK);

                return;
            }


            dgvShow.DataSource = clsLoginRegister.GetLoginRegisters();

            dgvShow.ContextMenuStrip = null;

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
               this.Close();
        }

        public bool CheckAccessPermission(clsUser.enPermissions enPermissions)
        {

            if (this._User.Permissions == (int)clsUser.enPermissions.eAll)
            {
                return true;
            }


            if (((int)enPermissions & this._User.Permissions) == (int)enPermissions)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
