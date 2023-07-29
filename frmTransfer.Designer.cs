namespace BankSystemWinForm
{
    partial class frmTransfer
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
            this.txtAccNumberFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccNumberTo = new System.Windows.Forms.TextBox();
            this.btnFind2 = new System.Windows.Forms.Button();
            this.lblFoundAccountNumber = new System.Windows.Forms.Label();
            this.lblFoundAccountNumber2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAccNumberFrom
            // 
            this.txtAccNumberFrom.Location = new System.Drawing.Point(346, 45);
            this.txtAccNumberFrom.Multiline = true;
            this.txtAccNumberFrom.Name = "txtAccNumberFrom";
            this.txtAccNumberFrom.Size = new System.Drawing.Size(308, 33);
            this.txtAccNumberFrom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Number to Transfer From:";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(684, 41);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 33);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account Number to Transfer To:";
            // 
            // txtAccNumberTo
            // 
            this.txtAccNumberTo.Location = new System.Drawing.Point(345, 178);
            this.txtAccNumberTo.Multiline = true;
            this.txtAccNumberTo.Name = "txtAccNumberTo";
            this.txtAccNumberTo.Size = new System.Drawing.Size(308, 33);
            this.txtAccNumberTo.TabIndex = 4;
            // 
            // btnFind2
            // 
            this.btnFind2.Location = new System.Drawing.Point(684, 178);
            this.btnFind2.Name = "btnFind2";
            this.btnFind2.Size = new System.Drawing.Size(75, 33);
            this.btnFind2.TabIndex = 5;
            this.btnFind2.Text = "Find";
            this.btnFind2.UseVisualStyleBackColor = true;
            this.btnFind2.Click += new System.EventHandler(this.btnFind2_Click);
            // 
            // lblFoundAccountNumber
            // 
            this.lblFoundAccountNumber.AutoSize = true;
            this.lblFoundAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundAccountNumber.Location = new System.Drawing.Point(12, 99);
            this.lblFoundAccountNumber.Name = "lblFoundAccountNumber";
            this.lblFoundAccountNumber.Size = new System.Drawing.Size(45, 25);
            this.lblFoundAccountNumber.TabIndex = 6;
            this.lblFoundAccountNumber.Text = "???";
            this.lblFoundAccountNumber.Visible = false;
            // 
            // lblFoundAccountNumber2
            // 
            this.lblFoundAccountNumber2.AutoSize = true;
            this.lblFoundAccountNumber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoundAccountNumber2.Location = new System.Drawing.Point(12, 239);
            this.lblFoundAccountNumber2.Name = "lblFoundAccountNumber2";
            this.lblFoundAccountNumber2.Size = new System.Drawing.Size(45, 25);
            this.lblFoundAccountNumber2.TabIndex = 7;
            this.lblFoundAccountNumber2.Text = "???";
            this.lblFoundAccountNumber2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Transfer Amount:";
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.Location = new System.Drawing.Point(346, 299);
            this.txtTransferAmount.Multiline = true;
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(308, 33);
            this.txtTransferAmount.TabIndex = 9;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(684, 299);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(75, 33);
            this.btnTransfer.TabIndex = 10;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtTransferAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFoundAccountNumber2);
            this.Controls.Add(this.lblFoundAccountNumber);
            this.Controls.Add(this.btnFind2);
            this.Controls.Add(this.txtAccNumberTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAccNumberFrom);
            this.Name = "frmTransfer";
            this.Text = "frmTransfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccNumberFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccNumberTo;
        private System.Windows.Forms.Button btnFind2;
        private System.Windows.Forms.Label lblFoundAccountNumber;
        private System.Windows.Forms.Label lblFoundAccountNumber2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTransferAmount;
        private System.Windows.Forms.Button btnTransfer;
    }
}