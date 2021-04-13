using System;
using System.Configuration;
using System.Data.SqlClient;

namespace DBHandlingWebApp
{
    public partial class FrmDBconn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConn_Click(object sender, EventArgs e)
        {
            var connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                    // LblResult.Text = conn.State.ToString();
                    var query = @"Insert Memos 
                                    Values
                                    ('박성철', 'redplus@devlec.com','박성철입니다.', GetDate(), '127.0.0.1' )";
                    SqlCommand cmd = new SqlCommand(query, conn);//시그니처 개수 만들어주기 위해서 위에 query 변수 만들어 주는 것이다. 뜻은 연결문자열을 매개로 쿼리를 DB에 직접 날린다는 의미이다.
                    cmd.ExecuteNonQuery();

                    LblResult.Text = "데이터저장완료";
                }
                catch (Exception ex)
                {
                    LblResult.Text = $"오류 {ex}";
                }
            }
        }
    }
}