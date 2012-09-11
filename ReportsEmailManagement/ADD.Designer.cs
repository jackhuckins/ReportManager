namespace ReportsEmailManagement
{
    partial class ADD
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
            this.btnAddEmailAddress = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAddressList = new System.Windows.Forms.ComboBox();
            this.btnClearReport = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.btnAddReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkTLK = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddEmailAddress
            // 
            this.btnAddEmailAddress.Location = new System.Drawing.Point(179, 128);
            this.btnAddEmailAddress.Name = "btnAddEmailAddress";
            this.btnAddEmailAddress.Size = new System.Drawing.Size(75, 23);
            this.btnAddEmailAddress.TabIndex = 17;
            this.btnAddEmailAddress.Text = "Add";
            this.btnAddEmailAddress.UseVisualStyleBackColor = true;
            this.btnAddEmailAddress.Click += new System.EventHandler(this.btnAddEmailAddress_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Email Address:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(98, 128);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(98, 49);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(156, 20);
            this.txtFullName.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 76);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(156, 20);
            this.txtEmail.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Full Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkTLK);
            this.panel1.Controls.Add(this.txtCompany);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnAddEmailAddress);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 161);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Add Recipient";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbAddressList);
            this.panel2.Controls.Add(this.btnClearReport);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtReport);
            this.panel2.Controls.Add(this.btnAddReport);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(280, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 161);
            this.panel2.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "First Recipient:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbAddressList
            // 
            this.cmbAddressList.FormattingEnabled = true;
            this.cmbAddressList.Location = new System.Drawing.Point(101, 49);
            this.cmbAddressList.Name = "cmbAddressList";
            this.cmbAddressList.Size = new System.Drawing.Size(156, 21);
            this.cmbAddressList.TabIndex = 24;
            // 
            // btnClearReport
            // 
            this.btnClearReport.Location = new System.Drawing.Point(101, 102);
            this.btnClearReport.Name = "btnClearReport";
            this.btnClearReport.Size = new System.Drawing.Size(75, 23);
            this.btnClearReport.TabIndex = 28;
            this.btnClearReport.Text = "Clear";
            this.btnClearReport.UseVisualStyleBackColor = true;
            this.btnClearReport.Click += new System.EventHandler(this.btnClearReport_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Report Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(101, 76);
            this.txtReport.Name = "txtReport";
            this.txtReport.Size = new System.Drawing.Size(156, 20);
            this.txtReport.TabIndex = 26;
            // 
            // btnAddReport
            // 
            this.btnAddReport.Location = new System.Drawing.Point(182, 102);
            this.btnAddReport.Name = "btnAddReport";
            this.btnAddReport.Size = new System.Drawing.Size(75, 23);
            this.btnAddReport.TabIndex = 25;
            this.btnAddReport.Text = "Add";
            this.btnAddReport.UseVisualStyleBackColor = true;
            this.btnAddReport.Click += new System.EventHandler(this.btnAddReport_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "Add Report";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(463, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(378, 179);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 27;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(98, 102);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(156, 20);
            this.txtCompany.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Company:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkTLK
            // 
            this.chkTLK.AutoSize = true;
            this.chkTLK.Location = new System.Drawing.Point(7, 132);
            this.chkTLK.Name = "chkTLK";
            this.chkTLK.Size = new System.Drawing.Size(81, 17);
            this.chkTLK.TabIndex = 28;
            this.chkTLK.Text = "TLKGroup?";
            this.chkTLK.UseVisualStyleBackColor = true;
            this.chkTLK.CheckedChanged += new System.EventHandler(this.chkTLK_CheckedChanged);
            // 
            // ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 210);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ADD";
            this.Text = "ADD";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmailAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.Button btnAddReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAddressList;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.CheckBox chkTLK;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label5;
    }
}