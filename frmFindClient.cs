using ClientBusinessLayer;
using PersonBusinessLayer;
using System;

using System.Windows.Forms;

namespace BankSystemWinForm
{
    public partial class frmFindClient : Form
    {

        public frmFindClient(bool isClicked = false)
        {
            InitializeComponent();

            if (isClicked)
            {
                btnDelete.Visible = true;
            }


        }

        clsClient _Client;

        clsPerson _Person;


        private void ShowClientInfo()
        {
            lblAccountNumberText.Visible = true;
            lblNameText.Visible = true;
            lblPhoneText.Visible = true;
            lblEmailText.Visible = true;
            lblPinCodeText.Visible = true;
            lblBalanceText.Visible = true;
            lblAccNumber.Visible = true;
            lblName.Visible = true;
            lblPhone.Visible = true;
            lblEmail.Visible = true;
            lblPinCode.Visible= true;
            lblClientBalance.Visible = true;


        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            _Client = clsClient.Find(txtFindClient.Text);
   
            if (_Client == null)
            {
                MessageBox.Show("this form will be closed because No Client with ID " + txtFindClient.Text);
                this.Close();
            } else
            {
                _Person = clsPerson.Find(_Client.PersonID);

            lblAccNumber.Text = _Client.AccountNumber;
            lblName.Text = _Person.Name;
            lblPhone.Text = _Person.Phone;
            lblEmail.Text = _Person.Email;
            lblPinCode.Text = _Person.PinCode;
            lblClientBalance.Text = _Client.Balance;
            ShowClientInfo();
                
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete Client [" + _Client.AccountNumber + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsClient.DeleteClient(txtFindClient.Text))
                {
                    if (clsPerson.DeletePerson(_Client.PersonID))
                    {
                        MessageBox.Show("Client Deleted Successfully.");
                    }
                }
            }

        }
    }
}
