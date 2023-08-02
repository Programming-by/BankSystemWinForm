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

        public enum enPermissions { eAll = -1, pShowAllClients = 1, pAddNewClient = 2, pDeleteClient = 4, pUpdateClient = 8, pFindClient = 16, pTransactions = 32, pManageUsers = 64, pLoginRegisters = 128 };

        private void _LoadPermissions()
        {
            if (_User.Permissions == -1)
            {
                chkAll.Checked = true;
            }

            if (_User.Permissions == 1)
            {
                chkShowAllClients.Checked = true;
            }

            if (_User.Permissions == 2)
            {
                chkAddNewClient.Checked = true;
            }

            if (_User.Permissions == 4)
            {
                chkDeleteClient.Checked = true;
            }

            if (_User.Permissions == 8)
            {
                chkUpdateClient.Checked = true;
            }

            if (_User.Permissions == 16)
            {
                chkFindClient.Checked = true;
            }

            if (_User.Permissions == 32)
            {
                chkManageUsers.Checked = true;
            }

            if (_User.Permissions == 64)
            {
                chkTransactions.Checked = true;
            }

            if (_User.Permissions == 128)
            {
                chkLoginRegister.Checked = true;
            }


            if (_User.Permissions == 3)
            {
                chkShowAllClients.Checked = true;
                chkAddNewClient.Checked = true;
            }
            if (_User.Permissions == 5)
            {
                chkShowAllClients.Checked = true;
                chkDeleteClient.Checked = true;
            }

            if (_User.Permissions == 9)
            {
                chkShowAllClients.Checked = true;
                chkUpdateClient.Checked = true;
            }

            if (_User.Permissions == 17)
            {
                chkShowAllClients.Checked = true;
                chkFindClient.Checked = true;
            }

            if (_User.Permissions == 33)
            {
                chkShowAllClients.Checked = true;
                chkTransactions.Checked = true;
            }
            if (_User.Permissions == 65)
            {
                chkShowAllClients.Checked = true;
                chkManageUsers.Checked = true;
            }
            if (_User.Permissions == 129)
            {
                chkShowAllClients.Checked = true;
                chkLoginRegister.Checked = true;
            }



            if (_User.Permissions == 6)
            {
                chkAddNewClient.Checked = true;
                chkDeleteClient.Checked = true;
            }

            if (_User.Permissions == 10)
            {
                chkAddNewClient.Checked = true;
                chkUpdateClient.Checked = true;
            }

            if (_User.Permissions == 18)
            {
                chkAddNewClient.Checked = true;
                chkFindClient.Checked = true;
            }

            if (_User.Permissions == 34)
            {
                chkAddNewClient.Checked = true;
                chkTransactions.Checked = true;
            }

            if (_User.Permissions == 66)
            {
                chkAddNewClient.Checked = true;
                chkManageUsers.Checked = true;
            }

            if (_User.Permissions == 130)
            {
                chkAddNewClient.Checked = true;
                chkLoginRegister.Checked = true;
            }




            if (_User.Permissions == 12)
            {
                chkDeleteClient.Checked = true;
                chkUpdateClient.Checked = true;
            }

            if (_User.Permissions == 20)
            {
                chkDeleteClient.Checked = true;
                chkFindClient.Checked = true;
            }

            if (_User.Permissions == 36)
            {
                chkDeleteClient.Checked = true;
                chkTransactions.Checked = true;
            }

            if (_User.Permissions == 68)
            {
                chkDeleteClient.Checked = true;
                chkManageUsers.Checked = true;
            }



            if (_User.Permissions == 132)
            {
                chkDeleteClient.Checked = true;
                chkLoginRegister.Checked = true;
            }

            if (_User.Permissions == 24)
            {
                chkUpdateClient.Checked = true;
                chkFindClient.Checked = true;
            }

            if (_User.Permissions == 40)
            {
                chkUpdateClient.Checked = true;
                chkTransactions.Checked = true;
            }

            if (_User.Permissions == 72)
            {
                chkUpdateClient.Checked = true;
                chkManageUsers.Checked = true;
            }

            if (_User.Permissions == 136)
            {
                chkUpdateClient.Checked = true;
                chkLoginRegister.Checked = true;
            }


            if (_User.Permissions == 48)
            {
                chkFindClient.Checked = true;
                chkTransactions.Checked = true;
            }


            if (_User.Permissions == 80)
            {
                chkFindClient.Checked = true;
                chkManageUsers.Checked = true;
            }

            if (_User.Permissions == 144)
            {
                chkFindClient.Checked = true;
                chkLoginRegister.Checked = true;
            }



            if (_User.Permissions == 96)
            {
                chkTransactions.Checked = true;
                chkManageUsers.Checked = true;
            }


            if (_User.Permissions == 160)
            {
                chkTransactions.Checked = true;
                chkLoginRegister.Checked = true;
            }



            if (_User.Permissions == 192)
            {
                chkManageUsers.Checked = true;
                chkLoginRegister.Checked = true;
            }




        }

        private int CalculatePermissions()
        {
            int TotalPermissions = 0;

            if (chkAll.Checked)
            {
                return (int)enPermissions.eAll;
            }

            if (chkShowAllClients.Checked)
            {
                TotalPermissions += (int)enPermissions.pShowAllClients;
            }

            if (chkAddNewClient.Checked)
            {
                TotalPermissions += (int)enPermissions.pAddNewClient;
            }

            if (chkDeleteClient.Checked)
            {
                TotalPermissions += (int)enPermissions.pDeleteClient;
            }


            if (chkUpdateClient.Checked)
            {
                TotalPermissions += (int)enPermissions.pUpdateClient;
            }

            if (chkFindClient.Checked)
            {
                TotalPermissions += (int)enPermissions.pFindClient;
            }


            if (chkManageUsers.Checked)
            {
                TotalPermissions += (int)enPermissions.pManageUsers;
            }


            if (chkTransactions.Checked)
            {
                TotalPermissions += (int)enPermissions.pTransactions;
            }

            if (chkLoginRegister.Checked)
            {
                TotalPermissions += (int)enPermissions.pLoginRegisters;
            }

            return TotalPermissions;
        }




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
            _User.Permissions = CalculatePermissions();


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
            panelPermissions.Enabled = true;
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
                _LoadPermissions();
                EnableFoundInfo();

            }
        }
    }
}
