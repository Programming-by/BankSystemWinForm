using Bank_Business_Layer;
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
    public partial class frmTransfer : Form
    {
        string _UserName;
        public frmTransfer(string UserName = "")
        {
            InitializeComponent();

            _UserName = UserName;
        }

        clsClient _Client1;
        clsClient _Client2;

        clsTransferLog _TransferLog;

        private void btnFind_Click(object sender, EventArgs e)
        {
            _Client1 = clsClient.Find(txtAccNumberFrom.Text);


            if (_Client1 == null)
            {
                MessageBox.Show("Wrong Account Number ,Please Enter a valid Account Number");
            } else
            {
                lblFoundAccountNumber.Text = "Account Exists";
                lblFoundAccountNumber.BackColor = Color.Green;
                lblFoundAccountNumber.Visible = true;
            }
        }

        private void btnFind2_Click(object sender, EventArgs e)
        {
            _Client2 = clsClient.Find(txtAccNumberTo.Text);

            if (_Client2 == null)
            {
                MessageBox.Show("Wrong Account Number ,Please Enter a valid Account Number");
            }
            else
            {
                lblFoundAccountNumber2.Text = "Account Exists";
                lblFoundAccountNumber2.BackColor = Color.Green;
                lblFoundAccountNumber2.Visible = true;
            }


   

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (_Client1 == null || _Client2 == null || txtTransferAmount.Text == null)
            {
                MessageBox.Show("Empty Fields", "Failed", MessageBoxButtons.OK);

                return;
            }
         

            if (_Client1.AccountNumber == _Client2.AccountNumber)
            {
                MessageBox.Show("Can't Transfer From To Same Account", "failed to transfer", MessageBoxButtons.OK);
                lblFoundAccountNumber.Text = "";
                lblFoundAccountNumber2.Text = "";
                return;
            } 

            if (Convert.ToInt32(_Client1.Balance) > 0)
            {
                if (clsClient.Withdraw(_Client1.AccountNumber, Convert.ToInt32(txtTransferAmount.Text)))
                {

                    if (clsClient.Deposit(_Client2.AccountNumber, Convert.ToInt32(txtTransferAmount.Text)))
                    {
                         _TransferLog = new clsTransferLog();

                        _TransferLog.Date = DateTime.Now;
                        _TransferLog.SourceAcc = _Client1.AccountNumber;
                        _TransferLog.DestinationAcc = _Client2.AccountNumber;
                        _TransferLog.Amount = txtTransferAmount.Text;
                        _TransferLog.SourceBalance = _Client1.Balance;
                        _TransferLog.DestinationBalance = _Client2.Balance;
                        _TransferLog.UserName =  _UserName;

                        if (_TransferLog.Save())
                        {

                            Console.WriteLine("Transfer Log Saved Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Transfer Log failed to save");
                        }

                        MessageBox.Show("Transfered Successfully","Transfered",MessageBoxButtons.OK);

                    }

                }

            }


          


        }
    }
}
