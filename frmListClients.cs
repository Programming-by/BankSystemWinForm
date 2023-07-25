using ClientBusinessLayer;
using PersonBusinessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemWinForm
{
    public partial class frmListClients : Form
    {
        public frmListClients()
        {
            InitializeComponent();
        }

        //fix find client

        private void _RefreshClientsList()
        {
            dgvAllClients.DataSource = clsClient.GetAllClients();
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    _RefreshClientsList();
        //}

        private void addClient_Click(object sender, EventArgs e)
        {
            frmAddEditClient frm = new frmAddEditClient(-1);

            frm.ShowDialog();

            _RefreshClientsList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditClient frm = new frmAddEditClient((int)dgvAllClients.CurrentRow.Cells[0].Value);

            frm.ShowDialog();

            _RefreshClientsList();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are you sure you want to delete Client [" + dgvAllClients.CurrentRow.Cells[0].Value + "]" , "Confirm Delete" , MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsClient.DeleteClient((int)dgvAllClients.CurrentRow.Cells[0].Value))
                {
                    if(clsPerson.DeletePerson((int)dgvAllClients.CurrentRow.Cells[0].Value))
                    {
                        MessageBox.Show("Client Deleted Successfully.");
                        _RefreshClientsList();

                    }
                }

            }

        }

        private void findClient_Click(object sender, EventArgs e)
        {

            frmFindClient frm = new frmFindClient(dgvAllClients);

            frm.ShowDialog();

      


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Clients")
            {

            }

            if (comboBox1.Text == "Users")
            {


            }


        }

        private void listClients_Click(object sender, EventArgs e)
        {
            _RefreshClientsList();
        }
    }
}
