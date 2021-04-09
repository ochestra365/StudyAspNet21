using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace FirstWebApp
{
    public class Global : System.Web.HttpApplication//전체 프로그램이 실행되는 곳.
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }
        protected void Application_End(object sender, EventArgs e)
        {

        }
        protected void Session_Start(object sender, EventArgs e)
        {

        }
        protected void Session_End(object sender, EventArgs e)
        {

        }

    }
}