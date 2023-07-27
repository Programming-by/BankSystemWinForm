using ClientBusinessLayer;
using PersonBusinessLayer;
using System;
using System.Windows.Forms;
using UserBusinessLayer;

namespace BankSystemWinForm
{
    public partial class frmUpdateUser : Form
    {
        public frmUpdateUser()
        {
            InitializeComponent();
        }

        clsPerson _Person;
        clsUser _User;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _Person.Name = txtName.Text;
            _Person.Phone = txtPhone.Text;
            _Person.Email = txtEmail.Text;
            _Person.PinCode = txtPassword.Text;
            _User.Permissions = Convert.ToInt32(txtPermissions.Text);

            if (_Person.Save())
            {
                _User.PersonID = _Person.PersonID;

                if (_User.Save())
                {

                    MessageBox.Show("User Saved Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User failed to save");
                }
            }

        }


        private void EnableFoundInfo()
        {
            txtUserName.Enabled = true;
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtPassword.Enabled = true;
            txtPermissions.Enabled = true;
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            _User = clsUser.Find(txtUserName.Text);

            if (_User == null)
            {
                MessageBox.Show("this form will be closed because No Client with ID " + txtUserName.Text);
                this.Close();
            }
            else
            {
                _Person = clsPerson.Find(_User.PersonID);

                txtUserName.Text = _User.UserName;
                txtName.Text = _Person.Name;
                txtPhone.Text = _Person.Phone;
                txtEmail.Text = _Person.Email;
                txtPassword.Text = _Person.PinCode;
                txtPermissions.Text = _User.Permissions.ToString();

                EnableFoundInfo();

            }
        }
    }
}
