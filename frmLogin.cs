﻿using Bank_Business_Layer;
using System;
using System.Windows.Forms;
using UserBusinessLayer;

namespace BankSystemWinForm
{
    public partial class frmLogin : Form
    {
        clsUser _User;
        clsUser _UserFind;
        int Counter = 3;
        clsLoginRegister _LoginRegister;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            _User = clsUser.Login(txtUserName.Text, txtPinCode.Text);
           
            if (_User == null )
            {

                lblInvalidMessage.Visible = true;
                Counter--;

                if (Counter == 2)
                {
                    lblInvalidMessage.Text = "Invalid UserName/Password , you have 2 more attempts";
                }

                if (Counter == 1)
                {
                    lblInvalidMessage.Text = "Invalid UserName/Password , you have 1 more attempt";
                }

                if (Counter == 0)
                {
                    lblInvalidMessage.Text = "you are blocked from entering the system";
                    btnLogin.Enabled = false;
                }
            } else
            {
                if (txtUserName.Text == _User.UserName && txtPinCode.Text == _User.PinCode)
                {
                    _LoginRegister = new clsLoginRegister();

                    _UserFind = clsUser.Find(_User.UserName);
                
                    _LoginRegister.Date = DateTime.Now;
                    _LoginRegister.UserName = _User.UserName;
                    _LoginRegister.Password = _User.PinCode;
                    _LoginRegister.Permissions = _UserFind.Permissions;


                    if (_LoginRegister.Save())
                    {
                        Console.WriteLine("Saved Record");
                    }


                    frmListClients frm = new frmListClients(_UserFind);

                    frm.DataBack += frmListClients_DataBack;

                    frm.ShowDialog();

                    

                }
            }
        }

        public void frmListClients_DataBack(string UserName , string PinCode)
        {
            txtUserName.Text = UserName;
            txtPinCode.Text = PinCode;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }
    }
}
