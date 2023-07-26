namespace BankSystemWinForm
{
    partial class frmFindClient
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
            this.txtFindClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblEmailText = new System.Windows.Forms.Label();
            this.lblPhoneText = new System.Windows.Forms.Label();
            this.lblPinCodeText = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPinCode = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAccNumber = new System.Windows.Forms.Label();
            this.lblAccountNumberText = new System.Windows.Forms.Label();
            this.lblBalanceText = new System.Windows.Forms.Label();
            this.lblClientBalance = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFindClient
            // 
            this.txtFindClient.Location = new System.Drawing.Point(335, 80);
            this.txtFindClient.Multiline = true;
            this.txtFindClient.Name = "txtFindClient";
            this.txtFindClient.Size = new System.Drawing.Size(263, 42);
            this.txtFindClient.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Number:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(621, 80);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 42);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(440, 329);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(81, 42);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "???";
            this.lblPhone.Visible = false;
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameText.Location = new System.Drawing.Point(12, 244);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(117, 42);
            this.lblNameText.TabIndex = 6;
            this.lblNameText.Text = "Name";
            this.lblNameText.Visible = false;
            // 
            // lblEmailText
            // 
            this.lblEmailText.AutoSize = true;
            this.lblEmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailText.Location = new System.Drawing.Point(12, 385);
            this.lblEmailText.Name = "lblEmailText";
            this.lblEmailText.Size = new System.Drawing.Size(110, 42);
            this.lblEmailText.TabIndex = 8;
            this.lblEmailText.Text = "Email";
            this.lblEmailText.Visible = false;
            // 
            // lblPhoneText
            // 
            this.lblPhoneText.AutoSize = true;
            this.lblPhoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneText.Location = new System.Drawing.Point(12, 317);
            this.lblPhoneText.Name = "lblPhoneText";
            this.lblPhoneText.Size = new System.Drawing.Size(127, 42);
            this.lblPhoneText.TabIndex = 7;
            this.lblPhoneText.Text = "Phone";
            this.lblPhoneText.Visible = false;
            // 
            // lblPinCodeText
            // 
            this.lblPinCodeText.AutoSize = true;
            this.lblPinCodeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinCodeText.Location = new System.Drawing.Point(12, 452);
            this.lblPinCodeText.Name = "lblPinCodeText";
            this.lblPinCodeText.Size = new System.Drawing.Size(162, 42);
            this.lblPinCodeText.TabIndex = 9;
            this.lblPinCodeText.Text = "PinCode";
            this.lblPinCodeText.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(440, 385);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 42);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "???";
            this.lblEmail.Visible = false;
            // 
            // lblPinCode
            // 
            this.lblPinCode.AutoSize = true;
            this.lblPinCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPinCode.Location = new System.Drawing.Point(440, 452);
            this.lblPinCode.Name = "lblPinCode";
            this.lblPinCode.Size = new System.Drawing.Size(81, 42);
            this.lblPinCode.TabIndex = 13;
            this.lblPinCode.Text = "???";
            this.lblPinCode.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(440, 244);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(81, 42);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "???";
            this.lblName.Visible = false;
            // 
            // lblAccNumber
            // 
            this.lblAccNumber.AutoSize = true;
            this.lblAccNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccNumber.Location = new System.Drawing.Point(440, 168);
            this.lblAccNumber.Name = "lblAccNumber";
            this.lblAccNumber.Size = new System.Drawing.Size(81, 42);
            this.lblAccNumber.TabIndex = 5;
            this.lblAccNumber.Text = "???";
            this.lblAccNumber.Visible = false;
            // 
            // lblAccountNumberText
            // 
            this.lblAccountNumberText.AutoSize = true;
            this.lblAccountNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumberText.Location = new System.Drawing.Point(12, 168);
            this.lblAccountNumberText.Name = "lblAccountNumberText";
            this.lblAccountNumberText.Size = new System.Drawing.Size(286, 42);
            this.lblAccountNumberText.TabIndex = 4;
            this.lblAccountNumberText.Text = "AccountNumber";
            this.lblAccountNumberText.Visible = false;
            // 
            // lblBalanceText
            // 
            this.lblBalanceText.AutoSize = true;
            this.lblBalanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceText.Location = new System.Drawing.Point(12, 513);
            this.lblBalanceText.Name = "lblBalanceText";
            this.lblBalanceText.Size = new System.Drawing.Size(154, 42);
            this.lblBalanceText.TabIndex = 16;
            this.lblBalanceText.Text = "Balance";
            this.lblBalanceText.Visible = false;
            // 
            // lblClientBalance
            // 
            this.lblClientBalance.AutoSize = true;
            this.lblClientBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientBalance.Location = new System.Drawing.Point(440, 513);
            this.lblClientBalance.Name = "lblClientBalance";
            this.lblClientBalance.Size = new System.Drawing.Size(81, 42);
            this.lblClientBalance.TabIndex = 17;
            this.lblClientBalance.Text = "???";
            this.lblClientBalance.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(404, 597);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(161, 57);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmFindClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 666);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblClientBalance);
            this.Controls.Add(this.lblBalanceText);
            this.Controls.Add(this.lblPinCode);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPinCodeText);
            this.Controls.Add(this.lblEmailText);
            this.Controls.Add(this.lblPhoneText);
            this.Controls.Add(this.lblNameText);
            this.Controls.Add(this.lblAccNumber);
            this.Controls.Add(this.lblAccountNumberText);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFindClient);
            this.Name = "frmFindClient";
            this.Text = "frmFindClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFindClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblEmailText;
        private System.Windows.Forms.Label lblPhoneText;
        private System.Windows.Forms.Label lblPinCodeText;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPinCode;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAccNumber;
        private System.Windows.Forms.Label lblAccountNumberText;
        private System.Windows.Forms.Label lblBalanceText;
        private System.Windows.Forms.Label lblClientBalance;
        private System.Windows.Forms.Button btnDelete;
    }
}