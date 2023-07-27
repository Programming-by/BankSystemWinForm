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
    public partial class frmFindUser : Form
    {
        clsPerson _Person;
        clsUser _User;
        public frmFindUser(bool isClicked = false)
        {
            InitializeComponent();

            if (isClicked)
            {
                btnDelete.Visible = true;
            }

        }


        private void ShowUserInfo()
        {
            lblUserNameText.Visible = true;
            lblNameText.Visible = true;
            lblPhoneText.Visible = true;
            lblEmailText.Visible = true;
            lblPasswordText.Visible = true;
            lblPermissionsText.Visible = true;

            lblUserName.Visible = true;
            lblName.Visible = true;
            lblPhone.Visible = true;
            lblEmail.Visible = true;
            lblPassword.Visible = true;
            lblPermissions.Visible = true;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            _User = clsUser.Find(txtFindUser.Text);

            if (_User == null)
            {
                MessageBox.Show("this form will be closed because No User with ID " + txtFindUser.Text);
                this.Close();
            }
            else
            {
                _Person = clsPerson.Find(_User.PersonID);

                lblUserName.Text = _User.UserName;
                lblName.Text = _Person.Name;
                lblPhone.Text = _Person.Phone;
                lblEmail.Text = _Person.Email;
                lblPassword.Text = _Person.PinCode;
                lblPermissions.Text = _User.Permissions.ToString();
                ShowUserInfo();

            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete User [" + _User.UserName + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsUser.DeleteUser(txtFindUser.Text))
                {
                    if (clsPerson.DeletePerson(_User.PersonID))
                    {
                        MessageBox.Show("User Deleted Successfully.");
                    }
                }
            }
        }
    }
}
