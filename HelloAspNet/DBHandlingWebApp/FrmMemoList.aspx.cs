﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DBHandlingWebApp
{
    public partial class FrmMemoList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            using (var conn = new SqlConnection(connString))
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                SqlCommand cmd = new SqlCommand("ListMemo", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Memos");

                GrvMemoList.DataSource = ds;
                GrvMemoList.DataBind();
            }
        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            var connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            using (var conn = new SqlConnection(connString))
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                SqlCommand cmd = new SqlCommand("SearchMemo", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SearchField", CboSearch.SelectedValue);
                cmd.Parameters.AddWithValue("@SearchQuery", TxtSearch.Text.Replace("--", ""));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Memos");

                GrvMemoList.DataSource = ds.Tables[0].DefaultView;
                GrvMemoList.DataBind();
            }
        }
    }
}