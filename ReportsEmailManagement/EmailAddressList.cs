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
    public partial class EmailAddressList : Form
    {
        public EmailAddressList()
        {
            InitializeComponent();
            LoadAddressList();
        }

        private void LoadAddressList()
        {
            ReportListGrid.DataSource = SQLLOAD.GetAllEmailAddresses();
        }

        private void ReportListGrid_Click(object sender, EventArgs e)
        {
            try
            {
                string FullName = ((System.Data.DataRowView)(((Infragistics.Win.UltraWinGrid.UltraGridRow)(this.ReportListGrid.Selected.Rows.All[0])).ListObject)).Row.ItemArray[0].ToString();
                string Email = ((System.Data.DataRowView)(((Infragistics.Win.UltraWinGrid.UltraGridRow)(this.ReportListGrid.Selected.Rows.All[0])).ListObject)).Row.ItemArray[1].ToString();
                txtFullName.Text = FullName;
                txtEmail.Text = Email;
            }
            catch
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SQLUPDATE.UpdateRecipient(txtFullName.Text, txtEmail.Text);
            LoadAddressList();
            txtFullName.Text = "";
            txtEmail.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
        }
    }
}
