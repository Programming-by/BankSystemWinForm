using ClientBusinessLayer;
using PersonBusinessLayer;
using System;
using System.Windows.Forms;

namespace BankSystemWinForm
{
    public partial class frmAddEditClient : Form
    {
        //check when user add existed account number
        public enum enMode {AddNew = 0, Update = 1};

        int _ClientID;
        private enMode _Mode;

        clsClient _Client;

        clsPerson _Person;
        public frmAddEditClient(int ClientID)
        {
            InitializeComponent();

            _ClientID = ClientID;

            if (_ClientID == -1 )
            {
                _Mode = enMode.AddNew;
            } else
            {
                _Mode = enMode.Update;
            }
                


        }

        private void _LoadData()
        {

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Client";
                _Client = new clsClient();
                _Person = new clsPerson(); 
                return;
            }

            _Person = clsPerson.Find(_ClientID);
            _Client = clsClient.Find(_ClientID);

            if(_Client == null || _Person == null )
            {
                MessageBox.Show("this form will be closed because No Client with ID  = " + _Client.ClientID);
                this.Close();
            }

            lblMode.Text = "Edit Client ID = " + _Person.PersonID.ToString();
            lblClientID.Text = _Client.PersonID.ToString();
            txtAccountNumber.Text = _Client.AccountNumber;
            txtName.Text = _Person.Name;
            txtEmail.Text = _Person.Email;
            txtPhone.Text = _Person.Phone;
            txtPinCode.Text = _Person.PinCode;
            txtBalance.Text = _Client.Balance;

            txtAccountNumber.ReadOnly = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Client.AccountNumber = txtAccountNumber.Text;
            _Person.Name = txtName.Text;
            _Person.Email = txtEmail.Text;
            _Person.Phone = txtPhone.Text;
            _Person.PinCode = txtPinCode.Text;
            _Client.Balance = txtBalance.Text;

            if (_Person.Save())
            {
                _Client.PersonID = _Person.PersonID;

                if (_Client.Save())
                {

                MessageBox.Show("Client Saved Successfully");
                }
                else
                {
                    MessageBox.Show("Client failed to save");
                }
            }


            _Mode = enMode.Update;
            lblMode.Text = "Edit Client with ID " + _Person.PersonID.ToString();
            lblClientID.Text = _Client.PersonID.ToString();



        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddClient_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
   
    
    
    }
}
