using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmAppSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["Cnt"] == null)
            {
                Application.Lock();//먼저 온 사용자가 변수 수정 잠그기
                Application["Cnt"] = 1;
                Application.UnLock();
            }else
            {
                Application["Cnt"] = (int)Application["Cnt"] + 1;
            }

            //Session
            if (Session["Cnt"] == null)
            {
                Session["Cnt"] = 1;
            }
            else
            {
                Session["Cnt"] = (int)Session["Cnt"] + 1;
            }
            //출력
            this.LblApplication.Text = Application["Cnt"].ToString();
            this.LblSession.Text = Session["Cnt"].ToString();
            this.LblSessionID.Text = Session.SessionID;
            this.LblTimeOut.Text = Session.Timeout.ToString();
        }
    }
}