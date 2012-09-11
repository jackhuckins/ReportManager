using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReportsEmailManagement
{
    public partial class ADD : Form
    {
        public ADD()
        {
            InitializeComponent();
            cmbAddressList.DataSource = SQLLOAD.GetAllEmailAddresses();
            cmbAddressList.DisplayMember = "Full Name";
        }

        private void btnAddEmailAddress_Click(object sender, EventArgs e)
        {
            SQLINSERT.AddNewRecipient(txtFullName.Text, txtEmail.Text,txtCompany.Text);
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtCompany.Text = "";
            chkTLK.Checked = false;
        }

        private void btnClearReport_Click(object sender, EventArgs e)
        {
            txtReport.Text = "";
        }

        private void btnAddReport_Click(object sender, EventArgs e)
        {
            SQLINSERT.AddRecipientToReport(txtReport.Text, ((System.Data.DataRowView)(cmbAddressList.SelectedItem)).Row.ItemArray[1].ToString());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtCompany.Text = "";
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void chkTLK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTLK.Checked == true)
            {
                txtEmail.Text = "@tlkgroup.net";
                txtCompany.Text = "TLK Group, LLC";
            }
            else
            {
                txtEmail.Text = "";
                txtCompany.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
