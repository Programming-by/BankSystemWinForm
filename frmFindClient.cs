using ClientBusinessLayer;
using PersonBusinessLayer;
using System;

using System.Windows.Forms;

namespace BankSystemWinForm
{
    public partial class frmFindClient : Form
    {

        DataGridView _DataGridForClients;
        public frmFindClient(DataGridView DataGridForClients)
        {
            InitializeComponent();

            _DataGridForClients = DataGridForClients;
        }

        clsClient _Client;

        clsPerson _Person;


        private void btnFind_Click(object sender, EventArgs e)
        {

            _Client = clsClient.Find(txtFindClient.Text);

            if (_Client == null)
            {
                MessageBox.Show("this form will be closed because No Client with ID  = " + _Client.PersonID);
                this.Close();
            }


            lblAccNumber.Text = _Client.AccountNumber;
            lblName.Text = _Person.Name;
            lblPhone.Text = _Person.Phone;
            lblEmail.Text = _Person.Email;
            lblPinCode.Text = _Person.PinCode;
            lblBalance.Text = _Client.Balance;


        }

      
    }
}
