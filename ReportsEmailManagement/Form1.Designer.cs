namespace ReportsEmailManagement
{
    partial class Form1
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
            this.AddressListGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.cmbAddressList = new System.Windows.Forms.ComboBox();
            this.cmbReportList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActivate = new System.Windows.Forms.Button();
            this.BtnDeactivateRecipient = new System.Windows.Forms.Button();
            this.btnAddEmailAddress = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAddRecipient = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.chkInactive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReportCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.RecipientReportList = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SPList = new Infragistics.Win.UltraWinGrid.UltraGrid();
            ((System.ComponentModel.ISupportInitialize)(this.AddressListGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecipientReportList)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SPList)).BeginInit();
            this.SuspendLayout();
            // 
            // AddressListGrid
            // 
            this.AddressListGrid.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            this.AddressListGrid.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.AddressListGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.AddressListGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.AddressListGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.AddressListGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.AddressListGrid.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            this.AddressListGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.AddressListGrid.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.AddressListGrid.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.AddressListGrid.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.AddressListGrid.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single;
            this.AddressListGrid.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.AddressListGrid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.AddressListGrid.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.AddressListGrid.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.AddressListGrid.Location = new System.Drawing.Point(4, 78);
            this.AddressListGrid.Name = "AddressListGrid";
            this.AddressListGrid.Size = new System.Drawing.Size(244, 252);
            this.AddressListGrid.TabIndex = 0;
            this.AddressListGrid.Text = "AddressListGrid";
            // 
            // cmbAddressList
            // 
            this.cmbAddressList.FormattingEnabled = true;
            this.cmbAddressList.Location = new System.Drawing.Point(3, 34);
            this.cmbAddressList.Name = "cmbAddressList";
            this.cmbAddressList.Size = new System.Drawing.Size(169, 21);
            this.cmbAddressList.TabIndex = 2;
            this.cmbAddressList.SelectedIndexChanged += new System.EventHandler(this.cmbAddressList_SelectedIndexChanged);
            // 
            // cmbReportList
            // 
            this.cmbReportList.FormattingEnabled = true;
            this.cmbReportList.Location = new System.Drawing.Point(178, 34);
            this.cmbReportList.Name = "cmbReportList";
            this.cmbReportList.Size = new System.Drawing.Size(169, 21);
            this.cmbReportList.TabIndex = 3;
            this.cmbReportList.SelectedIndexChanged += new System.EventHandler(this.cmbReportList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnActivate);
            this.panel1.Controls.Add(this.BtnDeactivateRecipient);
            this.panel1.Controls.Add(this.btnAddEmailAddress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnAddRecipient);
            this.panel1.Controls.Add(this.cmbAddressList);
            this.panel1.Controls.Add(this.cmbReportList);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 64);
            this.panel1.TabIndex = 4;
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(360, 3);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(70, 23);
            this.btnActivate.TabIndex = 9;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // BtnDeactivateRecipient
            // 
            this.BtnDeactivateRecipient.Location = new System.Drawing.Point(436, 3);
            this.BtnDeactivateRecipient.Name = "BtnDeactivateRecipient";
            this.BtnDeactivateRecipient.Size = new System.Drawing.Size(70, 23);
            this.BtnDeactivateRecipient.TabIndex = 8;
            this.BtnDeactivateRecipient.Text = "Deactivate";
            this.BtnDeactivateRecipient.UseVisualStyleBackColor = true;
            this.BtnDeactivateRecipient.Click += new System.EventHandler(this.BtnDeactivateRecipient_Click);
            // 
            // btnAddEmailAddress
            // 
            this.btnAddEmailAddress.Location = new System.Drawing.Point(436, 32);
            this.btnAddEmailAddress.Name = "btnAddEmailAddress";
            this.btnAddEmailAddress.Size = new System.Drawing.Size(70, 23);
            this.btnAddEmailAddress.TabIndex = 2;
            this.btnAddEmailAddress.Text = "Add New";
            this.btnAddEmailAddress.UseVisualStyleBackColor = true;
            this.btnAddEmailAddress.Click += new System.EventHandler(this.btnAddEmailAddress_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(178, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Report:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Recipient:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnAddRecipient
            // 
            this.BtnAddRecipient.Location = new System.Drawing.Point(360, 32);
            this.BtnAddRecipient.Name = "BtnAddRecipient";
            this.BtnAddRecipient.Size = new System.Drawing.Size(70, 23);
            this.BtnAddRecipient.TabIndex = 7;
            this.BtnAddRecipient.Text = "Add";
            this.BtnAddRecipient.UseVisualStyleBackColor = true;
            this.BtnAddRecipient.Click += new System.EventHandler(this.BtnAddRecipient_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.chkInactive);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.AddressListGrid);
            this.panel2.Controls.Add(this.ReportCombo);
            this.panel2.Location = new System.Drawing.Point(271, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 335);
            this.panel2.TabIndex = 9;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(4, 49);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(70, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(244, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Assigned Recipients";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkInactive
            // 
            this.chkInactive.Location = new System.Drawing.Point(151, 51);
            this.chkInactive.Name = "chkInactive";
            this.chkInactive.Size = new System.Drawing.Size(97, 21);
            this.chkInactive.TabIndex = 10;
            this.chkInactive.Text = "Show Inactive";
            this.chkInactive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Report:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ReportCombo
            // 
            this.ReportCombo.FormattingEnabled = true;
            this.ReportCombo.Location = new System.Drawing.Point(76, 24);
            this.ReportCombo.Name = "ReportCombo";
            this.ReportCombo.Size = new System.Drawing.Size(171, 21);
            this.ReportCombo.TabIndex = 3;
            this.ReportCombo.SelectedIndexChanged += new System.EventHandler(this.ReportCombo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1003, 45);
            this.label5.TabIndex = 9;
            this.label5.Text = "Reports Email Management Application";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.RecipientReportList);
            this.panel5.Location = new System.Drawing.Point(12, 138);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(253, 335);
            this.panel5.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "Assigned Reports";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecipientReportList
            // 
            this.RecipientReportList.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            this.RecipientReportList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.RecipientReportList.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.RecipientReportList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.RecipientReportList.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.RecipientReportList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.RecipientReportList.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            this.RecipientReportList.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.RecipientReportList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.RecipientReportList.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.RecipientReportList.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.RecipientReportList.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single;
            this.RecipientReportList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.RecipientReportList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.RecipientReportList.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.RecipientReportList.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.RecipientReportList.Location = new System.Drawing.Point(3, 24);
            this.RecipientReportList.Name = "RecipientReportList";
            this.RecipientReportList.Size = new System.Drawing.Size(244, 306);
            this.RecipientReportList.TabIndex = 0;
            this.RecipientReportList.Text = "ultraGrid1";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.SPList);
            this.panel3.Location = new System.Drawing.Point(530, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(485, 405);
            this.panel3.TabIndex = 14;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(410, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stored Procedures Governed by this Application";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SPList
            // 
            this.SPList.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ExtendLastColumn;
            this.SPList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.SPList.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.SPList.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.SPList.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.SPList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.SPList.DisplayLayout.Override.ColumnAutoSizeMode = Infragistics.Win.UltraWinGrid.ColumnAutoSizeMode.AllRowsInBand;
            this.SPList.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.SPList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.SPList.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.SPList.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.SPList.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Single;
            this.SPList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.SPList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.SPList.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControl;
            this.SPList.DisplayLayout.ViewStyle = Infragistics.Win.UltraWinGrid.ViewStyle.SingleBand;
            this.SPList.Location = new System.Drawing.Point(3, 29);
            this.SPList.Name = "SPList";
            this.SPList.Size = new System.Drawing.Size(477, 371);
            this.SPList.TabIndex = 1;
            this.SPList.Text = "ultraGrid1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 481);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AddressListGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RecipientReportList)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SPList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid AddressListGrid;
        private System.Windows.Forms.ComboBox cmbAddressList;
        private System.Windows.Forms.ComboBox cmbReportList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnDeactivateRecipient;
        private System.Windows.Forms.Button BtnAddRecipient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ReportCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkInactive;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnAddEmailAddress;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel5;
        private Infragistics.Win.UltraWinGrid.UltraGrid RecipientReportList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private Infragistics.Win.UltraWinGrid.UltraGrid SPList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRefresh;
    }
}

