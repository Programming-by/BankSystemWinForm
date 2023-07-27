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
    public partial class frmAddEditUser : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };

        enMode _Mode;

        int _UserID;

        clsUser _User;
        clsPerson _Person;
        public frmAddEditUser(int UserID)
        {
            InitializeComponent();

            _UserID = UserID;

            if (_UserID == -1) 
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
                lblMode.Text = "Add New User";
                _Person = new clsPerson();
                _User = new clsUser();
                return;

            }

            _User = clsUser.Find(_UserID);
            _Person = clsPerson.Find(_UserID);

            if (_User == null || _Person == null)
            {
                MessageBox.Show("this form will be closed because No Client with ID  = " + _User.UserID);
                this.Close();
            }

            lblMode.Text = "Edit User ID = " + _UserID.ToString();
            txtUserName.Text = _User.UserName;
            txtName.Text = _Person.Name;
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            txtPassword.Text = _Person.PinCode;
            txtPermissions.Text = _User.Permissions.ToString();

            txtUserName.ReadOnly = true;

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _User.UserName = txtUserName.Text.ToString();
            _Person.Name = txtName.Text.ToString();
            _Person.Phone = txtPhone.Text.ToString();
            _Person.Email = txtEmail.Text.ToString();
            _Person.PinCode = txtPassword.Text.ToString();
            _User.Permissions = Convert.ToInt32(txtPermissions.Text);
        
            if (_Person.Save())
            {

                _User.PersonID = _Person.PersonID;

                if (_User.Save())
                {

                    MessageBox.Show("User Saved Successfully");


                } else
                {
                    MessageBox.Show("User failed to Save");

                }

            }



        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            _LoadData();
        }
    }
}
