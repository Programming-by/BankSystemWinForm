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
    public partial class FormChangePassword : Form
    {

        clsPerson _Person;
        clsUser _User;
        public FormChangePassword(clsUser User)
        {
            _User = User;
            InitializeComponent();
        }

        private void ChangePassword()
        {
            _Person = clsPerson.Find(_User.PersonID);

            if (txtCurrentPassword.Text == _Person.PinCode)
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text && txtNewPassword.Text != "") 
                {
                    ShowSuccessfulMessageForChangingPassword();
                } else
                {
                    ShowMessageForEmptyPassword();

                    MessageBox.Show("Passwords are not identical , Please Enter them Successfully", "Error Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            } else
            {
                ShowMessageForEmptyCurrentPassword();
         
                MessageBox.Show("Current Password is Wrong , Please Enter Your Current Password Again","Error Message", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void ShowSuccessfulMessageForChangingPassword()
        {
            if (_Person.UpdatePinCode(txtNewPassword.Text))
            {
                MessageBox.Show("Password Changed Successfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }
        }
        private void ShowMessageForEmptyCurrentPassword()
        {
            if (txtCurrentPassword.Text == "")
            {
                MessageBox.Show("Please Enter Current Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void ShowMessageForEmptyPassword()
        {
            if (txtNewPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
           ChangePassword();

        }
    }
}
