# StudyAspNet21(MVC 모델이 엄청나게 효율을 높여주는 솔루션 알고리즘이다.!!)
ASP.NET 학습 리포지터리(컴퓨터 공학적 지식이 부족하다 보니 웹과 서버의 상호작용에 대해 이해하기 어려웠다.)<br>
서버의 백 로직과 UI구성에 대해 배우더라도 해당 파트는 패스트 캠퍼스에서 따로 공부를 해야 할 거 같다.<br>
이번 깃허브는 웹에 대한 이해를 보다 심층적으로 하기 위해서 공부할 것이다. 그래야 내가 회사에서 적응하는 데 도움이 될 거 같다.<br>
내 웹페이지를 만들고 거기에 지식을 쌓아 올리는 것도 도움이 될 거 같다<br>
가장 먼저 네트워크에 대한 기본 지식과 OSI7게층에 대한 기본 지식을 기입하고 내 생각들을 발달시켜 이해해볼 것이다.<br> 
연결문자열에 대한 오탈자나 시작프로그램 설정을 잘못한 것이 문제가 될 수 있다.<br>
웹 브라우저로 날라갈 떄는 UTF 파일로 변환된다.
"물고기 잡아주지 말고, 잡는 법을 가르쳐라"-->부지런해야 
-----------
~~~
<?xml version="1.0" encoding="utf-8"?>

<!--
  ASP.NET 애플리케이션을 구성하는 방법에 대한 자세한 내용은 다음을 참조하세요.
  https://go.microsoft.com/fwlink/?LinkId=169433
  -->
<configuration>
	<system.web>
		<compilation debug="true" targetFramework="4.7.2"/>
		<httpRuntime targetFramework="4.7.2"/>
	</system.web>
	<system.codedom>
		<compilers>
			<compiler language="c#;cs;csharp" extension=".cs"
			  type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.CSharpCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
			  warningLevel="4" compilerOptions="/langversion:default /nowarn:1659;1699;1701"/>
			<compiler language="vb;vbs;visualbasic;vbscript" extension=".vb"
			  type="Microsoft.CodeDom.Providers.DotNetCompilerPlatform.VBCodeProvider, Microsoft.CodeDom.Providers.DotNetCompilerPlatform, Version=2.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
			  warningLevel="4" compilerOptions="/langversion:default /nowarn:41008 /define:_MYTYPE=\&quot;Web\&quot; /optionInfer+"/>
		</compilers>
	</system.codedom>
	<connectionStrings>
		<add name="ConnString"
			 connectionString="Data Source=127.0.0.1;Initial Catalog=TestDB;Persist Security Info=True;User ID=sa;Password=mssql_p@ssw0rd!"
			 providerName="System.Data.SqlClient"/>
	</connectionStrings>
</configuration>

~~~
~~~
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
~~~
