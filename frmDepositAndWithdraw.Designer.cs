namespace BankSystemWinForm
{
    partial class frmDepositAndWithdraw
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
            this.btnFind = new System.Windows.Forms.Button();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.lblDepositAndWithdraw = new System.Windows.Forms.Label();
            this.txtDepositOrWithdrawAmount = new System.Windows.Forms.TextBox();
            this.btnDepositAndWithdraw = new System.Windows.Forms.Button();
            this.lblAccountNumberText = new System.Windows.Forms.Label();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblPhoneText = new System.Windows.Forms.Label();
            this.lblEmailText = new System.Windows.Forms.Label();
            this.lblPinCodeText = new System.Windows.Forms.Label();
            this.lblBalanceText = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPinCode = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblDepositOrWithdraw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(621, 57);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 41);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(293, 57);
            this.txtAccountNumber.Multiline = true;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(307, 32);
            this.txtAccountNumber.TabIndex = 2;
            // 
            // lblDepositAndWithdraw
            // 
            this.lblDepositAndWithdraw.AutoSize = true;
            this.lblDepositAndWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositAndWithdraw.Location = new System.Drawing.Point(22, 442);
            this.lblDepositAndWithdraw.Name = "lblDepositAndWithdraw";
            this.lblDepositAndWithdraw.Size = new System.Drawing.Size(224, 32);
            this.lblDepositAndWithdraw.TabIndex = 3;
            this.lblDepositAndWithdraw.Text = "Deposit Amount:";
            // 
            // txtDepositOrWithdrawAmount
            // 
            this.txtDepositOrWithdrawAmount.Location = new System.Drawing.Point(315, 442);
            this.txtDepositOrWithdrawAmount.Multiline = true;
            this.txtDepositOrWithdrawAmount.Name = "txtDepositOrWithdrawAmount";
            this.txtDepositOrWithdrawAmount.Size = new System.Drawing.Size(307, 32);
            this.txtDepositOrWithdrawAmount.TabIndex = 4;
            // 
            // btnDepositAndWithdraw
            // 
            this.btnDepositAndWithdraw.Location = new System.Drawing.Point(645, 433);
            this.btnDepositAndWithdraw.Name = "btnDepositAndWithdraw";
            this.btnDepositAndWithdraw.Size = new System.Drawing.Size(95, 41);
            this.btnDepositAndWithdraw.TabIndex = 5;
            this.btnDepositAndWithdraw.Text = "Deposit";
            this.btnDepositAndWithdraw.UseVisualStyleBackColor = true;
            this.btnDepositAndWithdraw.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblAccountNumberText
            // 
            this.lblAccountNumberText.AutoSize = true;
            this.lblAccountNumberText.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumberText.Location = new System.Drawing.Point(23, 120);
            this.lblAccountNumberText.Name = "lblAccountNumberText";
            this.lblAccountNumberText.Size = new System.Drawing.Size(204, 29);
            this.lblAccountNumberText.TabIndex = 7;
            this.lblAccountNumberText.Text = "Account Number:";
            this.lblAccountNumberText.Visible = false;
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameText.Location = new System.Drawing.Point(23, 164);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(84, 29);
            this.lblNameText.TabIndex = 8;
            this.lblNameText.Text = "Name:";
            this.lblNameText.Visible = false;
            // 
            // lblPhoneText
            // 
            this.lblPhoneText.AutoSize = true;
            this.lblPhoneText.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneText.Location = new System.Drawing.Point(24, 207);
            this.lblPhoneText.Name = "lblPhoneText";
            this.lblPhoneText.Size = new System.Drawing.Size(88, 29);
            this.lblPhoneText.TabIndex = 9;
            this.lblPhoneText.Text = "Phone:";
            this.lblPhoneText.Visible = false;
            // 
            // lblEmailText
            // 
            this.lblEmailText.AutoSize = true;
            this.lblEmailText.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailText.Location = new System.Drawing.Point(24, 253);
            this.lblEmailText.Name = "lblEmailText";
            this.lblEmailText.Size = new System.Drawing.Size(77, 29);
            this.lblEmailText.TabIndex = 10;
            this.lblEmailText.Text = "Email:";
            this.lblEmailText.Visible = false;
            // 
            // lblPinCodeText
            // 
            this.lblPinCodeText.AutoSize = true;
            this.lblPinCodeText.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinCodeText.Location = new System.Drawing.Point(30, 297);
            this.lblPinCodeText.Name = "lblPinCodeText";
            this.lblPinCodeText.Size = new System.Drawing.Size(110, 29);
            this.lblPinCodeText.TabIndex = 11;
            this.lblPinCodeText.Text = "PinCode:";
            this.lblPinCodeText.Visible = false;
            // 
            // lblBalanceText
            // 
            this.lblBalanceText.AutoSize = true;
            this.lblBalanceText.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceText.Location = new System.Drawing.Point(30, 341);
            this.lblBalanceText.Name = "lblBalanceText";
            this.lblBalanceText.Size = new System.Drawing.Size(102, 29);
            this.lblBalanceText.TabIndex = 12;
            this.lblBalanceText.Text = "Balance:";
            this.lblBalanceText.Visible = false;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(273, 120);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(46, 29);
            this.lblAccountNumber.TabIndex = 13;
            this.lblAccountNumber.Text = "???";
            this.lblAccountNumber.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(273, 164);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 29);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "???";
            this.lblName.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(273, 207);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(46, 29);
            this.lblPhone.TabIndex = 15;
            this.lblPhone.Text = "???";
            this.lblPhone.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(273, 253);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 29);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "???";
            this.lblEmail.Visible = false;
            // 
            // lblPinCode
            // 
            this.lblPinCode.AutoSize = true;
            this.lblPinCode.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinCode.Location = new System.Drawing.Point(273, 297);
            this.lblPinCode.Name = "lblPinCode";
            this.lblPinCode.Size = new System.Drawing.Size(46, 29);
            this.lblPinCode.TabIndex = 17;
            this.lblPinCode.Text = "???";
            this.lblPinCode.Visible = false;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(273, 341);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(46, 29);
            this.lblBalance.TabIndex = 18;
            this.lblBalance.Text = "???";
            this.lblBalance.Visible = false;
            // 
            // lblDepositOrWithdraw
            // 
            this.lblDepositOrWithdraw.AutoSize = true;
            this.lblDepositOrWithdraw.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositOrWithdraw.Location = new System.Drawing.Point(310, 545);
            this.lblDepositOrWithdraw.Name = "lblDepositOrWithdraw";
            this.lblDepositOrWithdraw.Size = new System.Drawing.Size(46, 29);
            this.lblDepositOrWithdraw.TabIndex = 19;
            this.lblDepositOrWithdraw.Text = "???";
            this.lblDepositOrWithdraw.Visible = false;
            // 
            // frmDepositAndWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 715);
            this.Controls.Add(this.lblDepositOrWithdraw);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblPinCode);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblBalanceText);
            this.Controls.Add(this.lblPinCodeText);
            this.Controls.Add(this.lblEmailText);
            this.Controls.Add(this.lblPhoneText);
            this.Controls.Add(this.lblNameText);
            this.Controls.Add(this.lblAccountNumberText);
            this.Controls.Add(this.btnDepositAndWithdraw);
            this.Controls.Add(this.txtDepositOrWithdrawAmount);
            this.Controls.Add(this.lblDepositAndWithdraw);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Name = "frmDepositAndWithdraw";
            this.Text = "frmDeposit";
            this.Load += new System.EventHandler(this.frmDepositAndWithdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Label lblDepositAndWithdraw;
        private System.Windows.Forms.TextBox txtDepositOrWithdrawAmount;
        private System.Windows.Forms.Button btnDepositAndWithdraw;
        private System.Windows.Forms.Label lblAccountNumberText;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblPhoneText;
        private System.Windows.Forms.Label lblEmailText;
        private System.Windows.Forms.Label lblPinCodeText;
        private System.Windows.Forms.Label lblBalanceText;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPinCode;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblDepositOrWithdraw;
    }
}