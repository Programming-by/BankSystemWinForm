using ClientBusinessLayer;
using PersonBusinessLayer;
using System;
using System.Windows.Forms;
using UserBusinessLayer;

namespace BankSystemWinForm
{
    /*
     List Users
     Add User
     Update User
     Delete User
     Find User
     */
    public partial class frmListClients : Form
    {
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
        }
    
    
    
    
    }
}
