using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strUserId = "";
            string strPassword = string.Empty;//""
            string strName = "";
            string strAge = "";

            strUserId = Request.Params["TxtUserId"];//GET형식 가져올 때//Requst.QueryString["TxtUserId"];
            strPassword = Request.Params["TxtPassword"];// 1. GET/POST 뭐든 지 불러옴
            strName = Request.Form["TxtName"];//POST형식
            strAge = Request["TxtAge"];//2. GET/POST 뭐든지 불러옴
            var result = $@"입력하신 아이디는 {strUserId}이고<br />
                            암호는 {strPassword}입니다. <br/>이름은 {strName}이고<br/>
                            나이는 {strAge}입니다. <br/>";
            LblResult.Text = result;

            LblIpAddress.Text = Request.UserHostAddress;
        }
        //요청에서 가장 중요한 것은 매개변수이다. 로컬에서 서버에 전달해줄 때 가장 중요한 것은 form post querystring get값 params는 get이나 post 뭐든지 불러온다.
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}