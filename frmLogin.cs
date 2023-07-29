using System;
using System.Windows.Forms;
using UserBusinessLayer;

namespace BankSystemWinForm
{
    public partial class frmLogin : Form
    {
        clsUser _User;
        int Counter = 3;
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
                    frmListClients frm = new frmListClients(_User.UserName);

                    frm.ShowDialog();
                }
            }
        }
    }
}
