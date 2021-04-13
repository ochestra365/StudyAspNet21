using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DBHandlingWebApp
{
    public partial class FrmMemoView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request["Num"]))
            {
                Response.Write("잘못된 조치입니다.");
                Response.End();
            }
            else
            {
                var connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
                using (var conn = new SqlConnection(connString))
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand("ViewMemo", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Num", Convert.ToInt32(Request["Num"]));

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        LblNum.Text = Request["Num"];
                        LblName.Text = reader["Name"].ToString();
                        LblEmal.Text = reader["Email"].ToString();
                        LblTitle.Text = reader["Title"].ToString();
                        LblPostDate.Text = reader["PostDate"].ToString();
                        LblPostIP.Text = reader["PostIP"].ToString();
                    }
                    reader.Close();
                }
            }
        }
    }
}