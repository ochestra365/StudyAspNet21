﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) TxtNum.Text = "0";//연산 초기화를 막아준다.
        }

        protected void Botton1_Click(object sender, EventArgs e)
        {
            TxtNum.Text = (int.Parse(TxtNum.Text) + 1).ToString();
        }

        protected void BtnInc_Click(object sender, EventArgs e)
        {
            TxtNum.Text = (int.Parse(TxtNum.Text) - 1).ToString();
        }

        protected void BtnLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.naver.com");
        }

        protected void BtnImage_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}