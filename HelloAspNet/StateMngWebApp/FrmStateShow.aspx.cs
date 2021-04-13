using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateMngWebApp
{
    public partial class FrmStateShow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtApplication.Text = Application["Now"].ToString();
            TxtSession.Text = Session["Now"].ToString();

            if (Cache["Now"] != null)
                TxtCache.Text = Cache["Now"].ToString();

            if (Request.Cookies["Now"] != null)
                TxtCookies.Text = Server.UrlDecode(Request.Cookies["Now"].Value);

            if (ViewState["Now"] != null)
                TxtViewState.Text = ViewState["Now"].ToString();
        }
    }
}
//클라이언트 쪽이 쿠키고 서버측이 캐쉬이다. 각각의 메모리자원을 사용해서 응답시간을 향상시키는 목적이 있다.