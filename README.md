# _Study ASP.NET_
<span style="color:red">ASP.NET My Portfolio Project</span>
<br>
![포트폴리오 깃허브](https://github.com/ochestra365/StudyAspNet21/tree/main/BasicMVCModel2/MyPortpolioWeb)<br>
<img src="https://github.com/ochestra365/StudyAspNet21/blob/main/BasicMVCModel2/MyPortpolioWeb/Image_for_Git_hub/%ED%94%84%EB%A1%9C%ED%95%84.png" width="100%" height="100%" ><br>
조금 더 괜찮은 미래를 위해서!
--------------

## 목차 <br>
1. 간단한 프로그래밍 작성 절차<br>
2. 프로그램 시행 화면 구분<br>
3. 해당코드정리<br>
4. 학습사항 정리<br>
5. 오류 디버깅함과정 정리<br>

------------------
## 1. 간단한 프로그래밍 작성 절차
ASP.NET의 강력한 활용을 통해서 초심자도 웹 사이트를 만들 수 있다.(●'◡'●)<br>
### 작성 전략<br>
1.  MVC모델을 활용한다. 스캐폴딩을 통해서 자동으로 코드가 생성된다. 이후 테일러링 기법을 통해 내 요구사항에 맞게 설계해가면 된다.
2. 누겟페키지를 적극 활용한다.<br><img src="https://github.com/ochestra365/StudyAspNet21/blob/main/BasicMVCModel2/MyPortpolioWeb/Image_for_Git_hub/%EB%88%84%EA%B2%9F%ED%8C%A8%ED%82%A4%EC%A7%80.png" width="40%" height="30%" ><br>
3. DB를 연동이 잘 되어야 한다.
~~~
MVC: 소프트웨어 설계에서 세 가지 구성 요소인 모델(Model), 뷰(View), 컨트롤러(Controller)를 이용한 설계 방식.

스패폴딩:건축용어로 비계라는 의미인데, 작업을 위해 임시로 설치한 가설 발판이나 가설 구조물을 말한다.
프로그래밍 쪽에서는 데이터베이스의 각 테이블에 대한 웹 페이지를 자동으로 생성하는 Dynamic Data 요소를 말한다.

테일러링 기법: 소프트웨어 개발 방법론 테일러링은 프로젝트 상황 및 특성에 맞도록 개발 방법론의 절차, 사용기법 등을 수정 및 보완하는 작업
~~~
--------------
## 2. 프로그램 시행 화면 구분
### 콘솔창에서 바라본 출력화면<br>
가장 먼저 프로그램의 동작 화면부터 살펴보고, 공부한 내용을 기입해 보도록 하겠다.<br>

1. 시작화면
-----------
-----------
<img src="https://github.com/ochestra365/StudyAspNet21/blob/main/BasicMVCModel2/MyPortpolioWeb/Image_for_Git_hub/%EC%B2%AB%ED%99%94%EB%A9%B4.png" width="40%" height="30%" ><br>
웹 사이트의 초기화면이다. 상단의 메뉴 바를 통해서 원하는 세션으로 이동이 가능하다.
~~~
세션(session): 컴퓨터 과학에서, 특히 네트워크 분야에서 반영구적이고 상호작용적인 정보 교환을 전제하는 둘 이상의 통신 장치나 컴퓨터와 사용자 간의 대화나 송수신 연결상태를 의미하는 보안적인 다이얼로그(dialogue) 및 시간대를 가리킨다. 따라서 세션은 연결상태를 유지하는것보다 연결상태의 안정성을 더 중요시 하게된다.
~~~

2.  포트폴리오 메뉴
------------
-----------
더미화면이다. 수정필요<br>
<img src="https://github.com/ochestra365/StudyAspNet21/blob/main/BasicMVCModel2/MyPortpolioWeb/Image_for_Git_hub/%ED%8F%AC%ED%8A%B8%ED%8F%B4%EB%A6%AC%EC%98%A41.png" width="40%" height="30%" ><br>
스튜디오 버튼<br>

<img src="https://github.com/ochestra365/StudyAspNet21/blob/main/BasicMVCModel2/MyPortpolioWeb/Image_for_Git_hub/%ED%8F%AC%ED%8A%B8%ED%8F%B4%EB%A6%AC%EC%98%A42.png" width="40%" height="30%" ><br>
Work 버튼<br>

<img src="https://github.com/ochestra365/StudyAspNet21/blob/main/BasicMVCModel2/MyPortpolioWeb/Image_for_Git_hub/%ED%8F%AC%ED%8A%B8%ED%8F%B4%EB%A6%AC%EC%98%A44.png" width="40%" height="30%" ><br>
Favorite 버튼<br>

3. 접촉 메뉴
----------------
-----------
<img src="https://github.com/ochestra365/StudyAspNet21/blob/main/BasicMVCModel2/MyPortpolioWeb/Image_for_Git_hub/%EC%A0%91%EC%B4%89.png" ><br>
버튼을 누르면 나의 DB로 넘어오게 된다.<br>

4. 로그인 화면
---------
-----------
<img src="https://github.com/ochestra365/StudyAspNet21/blob/main/BasicMVCModel2/MyPortpolioWeb/Image_for_Git_hub/%EB%A1%9C%EA%B7%B8%EC%9D%B8%ED%99%94%EB%A9%B4.png" width="40%" height="30%" ><br>
로그인 창 화면이다.<br>
<img src="https://github.com/ochestra365/StudyAspNet21/blob/main/BasicMVCModel2/MyPortpolioWeb/Image_for_Git_hub/%EB%A1%9C%EA%B7%B8%EC%9D%B8%ED%9B%84%20%EA%B4%80%EB%A6%AC%EC%9E%90%20%ED%99%94%EB%A9%B4.png" width="40%" height="30%" ><br>
로그인 이후 관리자 화면에서 조정할 수 있다.

5. 게시판 CURD
---------
-----------
<img src="https://github.com/ochestra365/StudyAspNet21/blob/main/BasicMVCModel2/MyPortpolioWeb/Image_for_Git_hub/%EA%B2%8C%EC%8B%9C%ED%8C%90%EC%B0%BD%EC%B6%9C.png" width="40%" height="30%" ><br>
게시판의 Create<br>
<img src="https://github.com/ochestra365/StudyAspNet21/blob/main/BasicMVCModel2/MyPortpolioWeb/Image_for_Git_hub/%EA%B2%8C%EC%8B%9C%ED%8C%90%EC%9E%91%EC%84%B1.png" width="40%" height="30%" ><br>
게시판의 Read
<img src="https://github.com/ochestra365/StudyAspNet21/blob/main/BasicMVCModel2/MyPortpolioWeb/Image_for_Git_hub/%EA%B2%8C%EC%8B%9C%ED%8C%90%EC%88%98%EC%A0%95.png" width="40%" height="30%" ><br>
게시판의 Update
<img src="https://github.com/ochestra365/StudyAspNet21/blob/main/BasicMVCModel2/MyPortpolioWeb/Image_for_Git_hub/%EA%B2%8C%EC%8B%9C%ED%8C%90%20%EC%82%AD%EC%A0%9C.pngg" width="40%" height="30%" ><br>
게시판의 Delete

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

## 5. 오류 디버깅함과정 정리
----------------
ASP.NET 학습 리포지터리(컴퓨터 공학적 지식이 부족하다 보니 웹과 서버의 상호작용에 대해 이해하기 어려웠다.)<br>
서버의 백 로직과 UI구성에 대해 배우더라도 해당 파트는 패스트 캠퍼스에서 따로 공부를 해야 할 거 같다.<br>
이번 깃허브는 웹에 대한 이해를 보다 심층적으로 하기 위해서 공부할 것이다. 그래야 내가 회사에서 적응하는 데 도움이 될 거 같다.<br>
내 웹페이지를 만들고 거기에 지식을 쌓아 올리는 것도 도움이 될 거 같다<br>
가장 먼저 네트워크에 대한 기본 지식과 OSI7게층에 대한 기본 지식을 기입하고 내 생각들을 발달시켜 이해해볼 것이다.<br> 
연결문자열에 대한 오탈자나 시작프로그램 설정을 잘못한 것이 문제가 될 수 있다.<br>
웹 브라우저로 날라갈 떄는 UTF 파일로 변환된다.
"물고기 잡아주지 말고, 잡는 법을 가르쳐라"-->부지런해야 
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
