namespace BankSystemWinForm
{
    partial class frmFindUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFindUser = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblUserNameText = new System.Windows.Forms.Label();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblPhoneText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEmailText = new System.Windows.Forms.Label();
            this.lblPasswordText = new System.Windows.Forms.Label();
            this.lblPermissionsText = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPermissions = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName:";
            // 
            // txtFindUser
            // 
            this.txtFindUser.Location = new System.Drawing.Point(262, 115);
            this.txtFindUser.Multiline = true;
            this.txtFindUser.Name = "txtFindUser";
            this.txtFindUser.Size = new System.Drawing.Size(245, 37);
            this.txtFindUser.TabIndex = 2;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(537, 108);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 44);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblUserNameText
            // 
            this.lblUserNameText.AutoSize = true;
            this.lblUserNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameText.Location = new System.Drawing.Point(76, 225);
            this.lblUserNameText.Name = "lblUserNameText";
            this.lblUserNameText.Size = new System.Drawing.Size(156, 32);
            this.lblUserNameText.TabIndex = 4;
            this.lblUserNameText.Text = "UserName:";
            this.lblUserNameText.Visible = false;
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameText.Location = new System.Drawing.Point(76, 282);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(97, 32);
            this.lblNameText.TabIndex = 5;
            this.lblNameText.Text = "Name:";
            this.lblNameText.Visible = false;
            // 
            // lblPhoneText
            // 
            this.lblPhoneText.AutoSize = true;
            this.lblPhoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneText.Location = new System.Drawing.Point(76, 334);
            this.lblPhoneText.Name = "lblPhoneText";
            this.lblPhoneText.Size = new System.Drawing.Size(105, 32);
            this.lblPhoneText.TabIndex = 6;
            this.lblPhoneText.Text = "Phone:";
            this.lblPhoneText.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 32);
            this.label6.TabIndex = 7;
            // 
            // lblEmailText
            // 
            this.lblEmailText.AutoSize = true;
            this.lblEmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailText.Location = new System.Drawing.Point(76, 387);
            this.lblEmailText.Name = "lblEmailText";
            this.lblEmailText.Size = new System.Drawing.Size(94, 32);
            this.lblEmailText.TabIndex = 8;
            this.lblEmailText.Text = "Email:";
            this.lblEmailText.Visible = false;
            // 
            // lblPasswordText
            // 
            this.lblPasswordText.AutoSize = true;
            this.lblPasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordText.Location = new System.Drawing.Point(76, 436);
            this.lblPasswordText.Name = "lblPasswordText";
            this.lblPasswordText.Size = new System.Drawing.Size(146, 32);
            this.lblPasswordText.TabIndex = 9;
            this.lblPasswordText.Text = "Password:";
            this.lblPasswordText.Visible = false;
            // 
            // lblPermissionsText
            // 
            this.lblPermissionsText.AutoSize = true;
            this.lblPermissionsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermissionsText.Location = new System.Drawing.Point(76, 481);
            this.lblPermissionsText.Name = "lblPermissionsText";
            this.lblPermissionsText.Size = new System.Drawing.Size(177, 32);
            this.lblPermissionsText.TabIndex = 10;
            this.lblPermissionsText.Text = "Permissions:";
            this.lblPermissionsText.Visible = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(304, 225);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(62, 32);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "???";
            this.lblUserName.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(304, 387);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 32);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "???";
            this.lblEmail.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(301, 334);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(62, 32);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "???";
            this.lblPhone.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(301, 280);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 32);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "???";
            this.lblName.Visible = false;
            // 
            // lblPermissions
            // 
            this.lblPermissions.AutoSize = true;
            this.lblPermissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermissions.Location = new System.Drawing.Point(304, 481);
            this.lblPermissions.Name = "lblPermissions";
            this.lblPermissions.Size = new System.Drawing.Size(62, 32);
            this.lblPermissions.TabIndex = 16;
            this.lblPermissions.Text = "???";
            this.lblPermissions.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(304, 436);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(62, 32);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "???";
            this.lblPassword.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(537, 520);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 44);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmFindUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPermissions);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPermissionsText);
            this.Controls.Add(this.lblPasswordText);
            this.Controls.Add(this.lblEmailText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPhoneText);
            this.Controls.Add(this.lblNameText);
            this.Controls.Add(this.lblUserNameText);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFindUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFindUser";
            this.Text = "frmFindUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFindUser;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblUserNameText;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblPhoneText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEmailText;
        private System.Windows.Forms.Label lblPasswordText;
        private System.Windows.Forms.Label lblPermissionsText;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPermissions;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnDelete;
    }
}