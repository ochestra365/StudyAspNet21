# _Study ASP.NET_
<span style="color:red">ASP.NET My Portfolio Project</span>
<br>
![포트폴리오 깃허브](https://github.com/ochestra365/StudyAspNet21/tree/main/BasicMVCModel2/MyPortpolioWeb)<br>
<img src="https://github.com/ochestra365/StudyAspNet21/blob/main/BasicMVCModel2/MyPortpolioWeb/Image_for_Git_hub/%ED%94%84%EB%A1%9C%ED%95%84.png" width="100%" height="100%" ><br>
조금 더 괜찮은 미래를 위해서!
--------------

## 웹페이지 프로필 작성
목차 <br>
1. 간단한 프로그래밍 작성 절차<br>
2. 프로그램 시행 화면 구분<br>
3. 해당코드정리<br>
4. 학습사항 정리<br>

------------------
## 1. 간단한 프로그래밍 작성 절차
__우리가 평소에 알고 있는 주소록은 무엇일까?__<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EB%A1%9D.png" width="60%" height="40%" ><br>
위 사진은 네이버의 주소록이다. 주소록의 기능에 대해서 알아보도록 하자!!(●'◡'●)<br>
### 작성 전략<br>
1.  MVC모델을 활용한다.
2. 누겟페키지를 적극 활용한다.
3. 주소를 수정할 수 있어야 한다.
4. 주소를 삭제할 수 있어야 한다.<br>

--------------
## 2. 프로그램 시행해보기
### 콘솔창에서 바라본 출력화면<br>
가장 먼저 프로그램의 동작 화면부터 살펴보고, 공부한 내용을 기입해 보도록 하겠다.<br>

1. 시작화면
-----------
-----------
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%B6%9C%EB%A0%A5%ED%99%94%EB%A9%B4.png" width="40%" height="30%" ><br>
콘솔창의 초기 출력화면이다.

2.  주소입력
------------
-----------
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%9E%85%EB%A0%A5.png" width="40%" height="30%" ><br>
1번을 누르고 다음과 같은 주소를 입력해 보았다.<br>

3. 주소검색
----------------
-----------
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EA%B2%80%EC%83%89.png" width="40%" height="30%" ><br>
2번을 누르고<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EA%B2%80%EC%83%892.png" width="40%" height="30%" ><br>
나의 이름을 적어보고 검색(Enter)을 해보았다.<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EA%B2%80%EC%83%893.png" width="40%" height="30%" ><br>
검색창에서 나의 정보가 나왔다.<br>

4. 주소수정
---------
-----------
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%88%98%EC%A0%95.png" width="40%" height="30%" ><br>
이번엔 3번을 눌러서 주소를 수정해보자.<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%88%98%EC%A0%952.png" width="40%" height="30%" ><br>
해당 화면과 같이 수정을 해보았다.

5. 주소전체출력
---------
-----------
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%A0%84%EC%B2%B4%EC%B6%9C%EB%A0%A5.png" width="40%" height="30%" ><br>
어느 날 해커가 들어와서 나의 프로그램에 장난질을 했다!!<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%A0%84%EC%B2%B4%EC%B6%9C%EB%A0%A52.png" width="40%" height="30%" ><br>
슬프게도 나의 프로그램은 보안이 약해서 그대로 뚫려버렸다... 보안 공부를 해야 할 필요가 있다!!

6. 주소삭제
------------
-----------
해커가 장난질 한 주소를 지워보자.<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%82%AD%EC%A0%9C.png" width="40%" height="30%" ><br>
주소삭제란에 들어가서 주소를 삭제해보았다.<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%82%AD%EC%A0%9C2.png" width="40%" height="30%" ><br>
삭제가 완료되었다.<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%EC%A3%BC%EC%86%8C%EC%82%AD%EC%A0%9C3.png" width="40%" height="30%" ><br>
검색을 해보니 컵라면이 삭제되었다!!!!<br>

7. 프로그램 종료
-------------
-----------
 해당 프로그램을 종료하는 것까지 마무리해보았다.<br>
<img src="https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/%EC%BA%A1%EC%B3%90%EC%82%AC%EC%A7%84/%ED%94%84%EB%A1%9C%EA%B7%B8%EB%9E%A8%20%EC%A2%85%EB%A3%8C.png" width="40%" height="30%" ><br>


## 3. 해당코드정리
----------------
-----------
코드의 내용이 방대하여 주소를 남길테니 해당 하이퍼링크를 클릭해보길 바란다.<br>
![Addressinfo.cs](https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/AddressInfo.cs "프로퍼티 생성")<br>
![AddressManager.cs](https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/AddressManager.cs "기능생성")<br>
![DataFileManageer.cs ](https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/DataFileManageer.cs "데이터 읽기 및 저장 생성")<br>
![MainApp.cs  ](https://github.com/ochestra365/StudyCSharp21/blob/main/chap99/AddressBookApp/MainApp.cs "MainApp 구동")<br>

## 4. 학습사항 정리
----------------


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
