using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReportsEmailManagement
{
    public static class SQLConnection
    {
        static public string ConnStringNoPro = "Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=Maintenance;User ID=sa;Password=" + Properties.Settings.Default.Password + ";Connect Timeout=3600";
        static public string ConnString = "Provider=SQLOLEDB;Data Source=" + Properties.Settings.Default.Server + ";Initial Catalog=Maintenance;User ID=sa;Password=" + Properties.Settings.Default.Password + ";Connect Timeout=60";
    }

    public static class SQLTABLES
    {
        public static DataTable AddressList;
        public static DataTable ReportList;
        public static DataTable RecipientReportList;
        public static DataTable StoredProcList;
    }

    public static class SQLSELECT
    {
        static public DataRow GetInfoForRemove(string Type,string FullName)
        {
            string query = "select ea.Type,ea.Email from Maintenance.dbo.EmailAssignment ea (nolock) inner join Maintenance.dbo.EmailAddressList el (nolock) on el.EmailAddress = ea.Email where ea.Type = '" + Type + "' and el.FullName = '" + FullName + "'";
            DataRow dr = SQLMAIN.getDataRow(query);
            return dr;
        }
        static public DataTable GetEmailListByType(string Type)
        {
            string query = "select el.FullName as [Full Name],el.Company as Company from Maintenance.dbo.EmailAssignment ea (nolock) inner join Maintenance.dbo.EmailAddressList el (nolock) on el.EmailAddress = ea.Email where ea.Type = '" + Type + "' and Active = 1  order by ea.Type,el.FullName";
            DataTable dt = SQLMAIN.getDataTable(query);
            return dt;
        }
        static public DataTable GetEmailListByTypeWithInactive(string Type)
        {
            string query = "select el.FullName as [Full Name],el.Company as Company, CASE WHEN ea.Active = 0 THEN 'Inactive' ELSE 'Active' END as Status from Maintenance.dbo.EmailAssignment ea (nolock) inner join Maintenance.dbo.EmailAddressList el (nolock) on el.EmailAddress = ea.Email where ea.Type = '" + Type + "'  order by ea.Type,el.FullName";
            DataTable dt = SQLMAIN.getDataTable(query);
            return dt;
        }
    }
    public static class SQLINSERT
    {
        static public void AddNewRecipient(string FullName, string EmailAddress,string Company)
        {
            System.Data.SqlClient.SqlConnection conn = new SqlConnection(SQLConnection.ConnStringNoPro);
            conn.Open();
            SqlCommand comm = new SqlCommand("insert into Maintenance.dbo.EmailAddressList (FullName, EmailAddress, Company) VALUES ('" + FullName + "','" + EmailAddress + "','" + Company + "')", conn);
            comm.ExecuteScalar();
            conn.Close();
        }
        static public void AddRecipientToReport(string Type, string Email)
        {
            System.Data.SqlClient.SqlConnection conn = new SqlConnection(SQLConnection.ConnStringNoPro);
            conn.Open();
            SqlCommand comm = new SqlCommand("insert into Maintenance.dbo.EmailAssignment (Type,Email,Active) VALUES ('" + Type + "','" + Email + "',1)", conn);
            comm.ExecuteScalar();
            conn.Close();
        }
    }
    public static class SQLUPDATE
    {
        static public void UpdateRecipient(string FullName, string EmailAddress)
        {
            System.Data.SqlClient.SqlConnection conn = new SqlConnection(SQLConnection.ConnStringNoPro);
            conn.Open();
            SqlCommand comm = new SqlCommand("UPDATE Maintenance.dbo.EmailAddressList set FullName = '" + FullName + "', EmailAddress = '" + EmailAddress + "' where FullName = '" + FullName + "' or EmailAddress = '" + EmailAddress + "'", conn);
            comm.ExecuteScalar();
            conn.Close();
        }
        static public void ActivateRecipient(string Type, string Email)
        {
            System.Data.SqlClient.SqlConnection conn = new SqlConnection(SQLConnection.ConnStringNoPro);
            conn.Open();
            SqlCommand comm = new SqlCommand("UPDATE Maintenance.dbo.EmailAssignment set Active = 1 where Type = '" + Type + "' and Email = '" + Email + "'", conn);
            comm.ExecuteScalar();
            conn.Close();
        }
        static public void DeactivateRecipient(string Type, string Email)
        {
            System.Data.SqlClient.SqlConnection conn = new SqlConnection(SQLConnection.ConnStringNoPro);
            conn.Open();
            SqlCommand comm = new SqlCommand("UPDATE Maintenance.dbo.EmailAssignment set Active = 0 where Type = '" + Type + "' and Email = '" + Email + "'", conn);
            comm.ExecuteScalar();
            conn.Close();
        }
    }
    public static class SQLDELETE
    {
        static public void DeleteRecipient(string Type, string Email)
        {
            System.Data.SqlClient.SqlConnection conn = new SqlConnection(SQLConnection.ConnStringNoPro);
            conn.Open();
            SqlCommand comm = new SqlCommand("DELETE FROM Maintenance.dbo.EmailAssignment where Type = '" + Type + "' and Email = '" + Email + "'", conn);
            comm.ExecuteScalar();
            conn.Close();
        }
    }
    public static class SQLLOAD
    {
        static public DataTable GetAllSPsUsed()
        {
            try
            {
                string query = "exec TlkGrpSystem.dbo.FindInfoInSQL 'GetRecipientsFromType',0";
                SQLTABLES.StoredProcList = SQLMAIN.getDataTable(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return SQLTABLES.StoredProcList;
        }
        static public DataTable GetAllReportTypes()
        {
            try
            {
                string query = "select DISTINCT Type from Maintenance.dbo.EmailAssignment order by Type";
                SQLTABLES.ReportList = SQLMAIN.getDataTable(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return SQLTABLES.ReportList;
        }
        static public DataTable GetAllEmailAddresses()
        {
            try
            {
                string query = "select '' + FullName + ' - ' + Company + '' as [Full Name], EmailAddress as [Email Address] from Maintenance.dbo.EmailAddressList order by FullName";
                SQLTABLES.AddressList = SQLMAIN.getDataTable(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return SQLTABLES.AddressList;
        }
        static public DataTable GetReportListByEmail(string Email)
        {
            try
            {
                string query = "select Type as [Report Name], CASE WHEN Active = 0 THEN 'Inactive' ELSE 'Active' END as Status from Maintenance.dbo.EmailAssignment where Email = '" + Email + "'  order by Type";
                SQLTABLES.RecipientReportList = SQLMAIN.getDataTable(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return SQLTABLES.RecipientReportList;
        }
    }
    public static class SQLMAIN
    {
        static public DataRow getDataRow(string query)
        {
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(query, SQLConnection.ConnString);
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);
            DataTable dt = new DataTable();
            dAdapter.Fill(dt);
            DataRow dr = dt.Rows[0];
            return dr;
        }
        static public DataTable getDataTable(string query)
        {
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(query, SQLConnection.ConnString);
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);
            DataTable dt = new DataTable();
            dAdapter.Fill(dt);
            return dt;
        }
    }
}
