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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            chkInactive.Checked = true;
            LoadCombos();
            SPList.DataSource = SQLLOAD.GetAllSPsUsed();
        }

        private void LoadCombos()
        {
            cmbAddressList.DataSource = SQLLOAD.GetAllEmailAddresses();
            cmbAddressList.DisplayMember = "Full Name";
            cmbReportList.DataSource = SQLLOAD.GetAllReportTypes();
            cmbReportList.DisplayMember = "Type";
            ReportCombo.DataSource = SQLLOAD.GetAllReportTypes();
            ReportCombo.DisplayMember = "Type";
            RecipientReportList.DataSource = SQLLOAD.GetReportListByEmail(((System.Data.DataRowView)(cmbAddressList.SelectedItem)).Row.ItemArray[1].ToString());
        }

        private void ReportCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chkInactive.Checked == true)
            {
                string Type = ((System.Data.DataRowView)(ReportCombo.SelectedItem)).Row.ItemArray[0].ToString();
                AddressListGrid.DataSource = SQLSELECT.GetEmailListByTypeWithInactive(Type);
            }
            else
            {
                string Type = ((System.Data.DataRowView)(ReportCombo.SelectedItem)).Row.ItemArray[0].ToString();
                AddressListGrid.DataSource = SQLSELECT.GetEmailListByType(Type);
            }
        }

        private void BtnAddRecipient_Click(object sender, EventArgs e)
        {
            if (SelectedEmailAddress == string.Empty)
            {
                MessageBox.Show("Email Address not selected");
            }
            else
            {
                if (SelectedReport == string.Empty)
                {
                    MessageBox.Show("Report not selected");
                }
                else
                {
                    EmailIndex = cmbAddressList.SelectedIndex;
                    TypeIndex = cmbReportList.SelectedIndex;
                    ReportIndex = ReportCombo.SelectedIndex;
                    SQLINSERT.AddRecipientToReport(SelectedReport, SelectedEmailAddress);
                    LoadCombos();
                    ReportCombo.SelectedIndex = ReportIndex;
                    cmbAddressList.SelectedIndex = EmailIndex;
                    cmbReportList.SelectedIndex = TypeIndex;
                }
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (SelectedEmailAddress == string.Empty)
            {
                MessageBox.Show("Email Address not selected");
            }
            else
            {
                if (SelectedReport == string.Empty)
                {
                    MessageBox.Show("Report not selected");
                }
                else
                {
                    EmailIndex = cmbAddressList.SelectedIndex;
                    TypeIndex = cmbReportList.SelectedIndex;
                    ReportIndex = ReportCombo.SelectedIndex;
                    SQLUPDATE.ActivateRecipient(SelectedReport, SelectedEmailAddress);
                    LoadCombos();
                    ReportCombo.SelectedIndex = ReportIndex;
                    cmbAddressList.SelectedIndex = EmailIndex;
                    cmbReportList.SelectedIndex = TypeIndex;
                }
            }

        }

        private void BtnDeactivateRecipient_Click(object sender, EventArgs e)
        {
            if (SelectedEmailAddress == string.Empty)
            {
                MessageBox.Show("Email Address not selected");
            }
            else
            {
                if (SelectedReport == string.Empty)
                {
                    MessageBox.Show("Report not selected");
                }
                else
                {
                    EmailIndex = cmbAddressList.SelectedIndex;
                    TypeIndex = cmbReportList.SelectedIndex;
                    ReportIndex = ReportCombo.SelectedIndex;
                    SQLUPDATE.DeactivateRecipient(SelectedReport, SelectedEmailAddress); 
                    LoadCombos();
                    ReportCombo.SelectedIndex = ReportIndex;
                    cmbAddressList.SelectedIndex = EmailIndex;
                    cmbReportList.SelectedIndex = TypeIndex;
                }
            }
        }

        private string SelectedEmailAddress = string.Empty;
        private string SelectedReport = string.Empty;
        private int EmailIndex = 0;
        private int TypeIndex = 0;
        private int ReportIndex = 0;

        private void cmbAddressList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedEmailAddress = ((System.Data.DataRowView)(cmbAddressList.SelectedItem)).Row.ItemArray[1].ToString();
                RecipientReportList.DataSource = SQLLOAD.GetReportListByEmail(((System.Data.DataRowView)(cmbAddressList.SelectedItem)).Row.ItemArray[1].ToString());
            }
            catch
            {
            }
        }

        private void cmbReportList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SelectedReport = ((System.Data.DataRowView)(cmbReportList.SelectedItem)).Row.ItemArray[0].ToString();
                ReportCombo.SelectedIndex = cmbReportList.SelectedIndex;
            }
            catch
            {
            }
        }

        private void ReportListGrid_DoubleClick(object sender, EventArgs e)
        {
        }

        private void btnAddEmailAddress_Click(object sender, EventArgs e)
        {
            EmailIndex = cmbAddressList.SelectedIndex;
            TypeIndex = cmbReportList.SelectedIndex;
            ReportIndex = ReportCombo.SelectedIndex;
            //SQLINSERT.AddNewRecipient(txtFullName.Text, txtEmail.Text);
            ADD ad = new ADD();
            ad.ShowDialog();
            if (ad.DialogResult == DialogResult.OK)
            {
                LoadCombos();
                ReportCombo.SelectedIndex = ReportIndex;
                cmbAddressList.SelectedIndex = EmailIndex;
                cmbReportList.SelectedIndex = TypeIndex;
            }
            else
            {
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            EmailIndex = cmbAddressList.SelectedIndex;
            TypeIndex = cmbReportList.SelectedIndex;
            ReportIndex = ReportCombo.SelectedIndex;
            string ReportName = ReportCombo.Text;
            string FullName = ((System.Data.DataRowView)(((Infragistics.Win.UltraWinGrid.UltraGridRow)(this.AddressListGrid.Selected.Rows.All[0])).ListObject)).Row.ItemArray[0].ToString();
            DataRow dr = SQLSELECT.GetInfoForRemove(ReportName, FullName);
            string Type = dr.ItemArray[0].ToString();
            string Email = dr.ItemArray[1].ToString();
            SQLDELETE.DeleteRecipient(Type, Email);
            LoadCombos();
            ReportCombo.SelectedIndex = ReportIndex;
            cmbAddressList.SelectedIndex = EmailIndex;
            cmbReportList.SelectedIndex = TypeIndex;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SPList.DataSource = SQLLOAD.GetAllSPsUsed();
        }
    }
}
