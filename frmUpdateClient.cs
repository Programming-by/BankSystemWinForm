using ClientBusinessLayer;
using PersonBusinessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemWinForm
{
    public partial class frmUpdateClient : Form
    {
        public frmUpdateClient()
        {
            InitializeComponent();
        }

        clsClient _Client;
        clsPerson _Person;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void btnFind_Click(object sender, EventArgs e)
        {
            _Client = clsClient.Find(txtAccountNumber.Text);

            if (_Client == null)
            {
                MessageBox.Show("this form will be closed because No Client with ID " + txtAccountNumber.Text);
                this.Close();
            }
            else
            {
                _Person = clsPerson.Find(_Client.PersonID);

                txtAccountNumber.Text = _Client.AccountNumber;
                txtName.Text = _Person.Name;
                txtPhone.Text = _Person.Phone;
                txtEmail.Text = _Person.Email;
                txtPinCode.Text = _Person.PinCode;
                txtBalance.Text = _Client.Balance;

                EnableFoundInfo();

            }
            }

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {
         DisableInfo();
        }
   

        private void DisableInfo()
        {
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtPinCode.Enabled = false;
            txtBalance.Enabled = false;
        }
    
        private void EnableFoundInfo()
        {
            txtAccountNumber.Enabled = false;
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtPinCode.Enabled = true;
            txtBalance.Enabled = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _Person.Name = txtName.Text;
            _Person.Phone = txtPhone.Text;
            _Person.Email = txtEmail.Text;
            _Person.PinCode = txtPinCode.Text;
            _Client.Balance = txtBalance.Text;

            if (_Person.Save())
            {
                _Client.PersonID = _Person.PersonID;

                if (_Client.Save())
                {

                    MessageBox.Show("Client Saved Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Client failed to save");
                }
            }

        }
    }
}
