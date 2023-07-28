using ClientBusinessLayer;
using PersonBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserBusinessLayer;

namespace BankSystemWinForm
{
    public partial class frmDepositAndWithdraw : Form
    {
        public enum enMode { Deposit = 0 , Withdraw = -1};


        int _Operartion;
        public frmDepositAndWithdraw(int ChooseOperation)
        {
            InitializeComponent();

            _Operartion = ChooseOperation;

        }

        clsClient _Client;

        clsPerson _Person;

        private void ShowInfo()
        {

            lblAccountNumberText.Visible = true;
            lblNameText.Visible = true;
            lblPhoneText.Visible = true;
            lblEmailText.Visible = true;
            lblPinCodeText.Visible = true;
            lblBalanceText.Visible = true;



            lblAccountNumber.Visible = true;
            lblName.Visible= true;
            lblPhone.Visible = true;
            lblEmail.Visible = true;
            lblPinCode.Visible = true;
            lblBalance.Visible = true;



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

                lblAccountNumber.Text = _Client.AccountNumber;
                lblName.Text = _Person.Name;
                lblPhone.Text = _Person.Phone;
                lblEmail.Text = _Person.Email;
                lblPinCode.Text = _Person.PinCode;
                lblBalance.Text = _Client.Balance;

                ShowInfo();
            }
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (_Client == null)
            {
                MessageBox.Show("this form will be closed because No Client with ID " + txtAccountNumber.Text);
                this.Close();
                return;
            }
            if (_Operartion == -1)
            {
                if (Convert.ToInt32(_Client.Balance) > 0)
                {

                    if (clsClient.Withdraw(_Client.AccountNumber, Convert.ToInt32(txtDepositOrWithdrawAmount.Text)))
                    {
                        lblDepositOrWithdraw.Text = "Withdrawed " + txtDepositOrWithdrawAmount.Text + " Successfully";
                        lblDepositOrWithdraw.Visible = true;
                    }

                }
                else
                {
                    lblDepositOrWithdraw.Text = "unable to withdraw, because there is no money in the account";

                }
            }
            else
            {
                if (clsClient.Deposit(_Client.AccountNumber, Convert.ToInt32(txtDepositOrWithdrawAmount.Text)))
                {
                    lblDepositOrWithdraw.Text = "Deposited " + txtDepositOrWithdrawAmount.Text + " Successfully";
                    lblDepositOrWithdraw.Visible = true;
                }
            }


        }

        private void frmDepositAndWithdraw_Load(object sender, EventArgs e)
        {
            if (_Operartion == -1)
            {
                lblDepositAndWithdraw.Text = "Withdraw Amount";
                btnDepositAndWithdraw.Text = "Withdraw";
            }
          

        }
    }
}
