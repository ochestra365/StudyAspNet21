using System;
using DBHandlingWebApp.Models;
using System.Configuration;
using System.Data.SqlClient;

namespace DBHandlingWebApp
{
    public partial class FrmMemoWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnWirte_Click(object sender, EventArgs e)
        {
            Memo memo = new Memo();
            memo.PostIP = Request.UserHostAddress;
            memo.PostDate = DateTime.Now;
            memo.Title = TxtTitle.Text;
            memo.Name = TextName.Text;
            memo.Email = TextEmail.Text;
            //초반에 생성자를 만들어서 네이밍이 꼬여버림
            var connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;

            using (var conn=new SqlConnection(connString))
            {
                try
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                    SqlCommand cmd = new SqlCommand("WriteMemo", conn); //저장프로시저
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", memo.Name);
                    cmd.Parameters.AddWithValue("@Email", memo.Email);
                    cmd.Parameters.AddWithValue("@Title", memo.Title);
                    cmd.Parameters.AddWithValue("@PostDate", memo.PostDate);
                    cmd.Parameters.AddWithValue("@PostIP", memo.PostIP);

                    cmd.ExecuteNonQuery();

                    LblResult.Text = "저장되었습니다.";
                }
                catch (Exception ex)
                {
                    LblResult.Text = $"예외발생 : {ex}";
                }
            }
        }
        protected void BtnList_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmMemoList.aspx");
        }
    }
}