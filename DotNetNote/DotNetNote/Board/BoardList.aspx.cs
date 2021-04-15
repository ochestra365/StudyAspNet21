using DotNetNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetNote.Board
{
    public partial class BoardList : System.Web.UI.Page
    {
        private DBRepository _repo;
        //검색모드: true, 보통: false
        public bool SearchMode { get; set; } = false;
        public string SearchField { get; set; }
        public string SearchQuery { get; set; }
        public int PageIndex = 0; // 현재 보여줄 페이지 번호
        public int RecordCount = 0;//총 레코드 수
        public BoardList()
        {
            _repo = new DBRepository();//SqlConnection 생성
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            // 검색 모드 결정
            SearchMode =
                (!string.IsNullOrEmpty(Request.QueryString["SearchField"]) &&
                    !string.IsNullOrEmpty(Request.QueryString["SearchQuery"]));
            if (SearchMode)
            {
                SearchField = Request.QueryString["SearchField"];
                SearchQuery = Request.QueryString["SearchQuery"];
            }
            // 쿼리스트링에 따른 페이지 보여주기
            if (Request["Page"] != null)
            {
                // Page는 보여지는 쪽은 1, 2, 3, ... 코드단에서는 0, 1, 2, ...
                PageIndex = Convert.ToInt32(Request["Page"]) - 1;
            }
            else
            {
                PageIndex = 0; // 1 페이지
            }

            // 쿠키를 사용한 리스트 페이지 번호 유지 적용: 
            //    100번째 페이지의 글 보고, 다시 리스트 왔을 때 100번째 페이지 표시
            if (Request.Cookies["DotNetNote"] != null)
            {
                if (!String.IsNullOrEmpty(
                    Request.Cookies["DotNetNote"]["PageNum"]))
                {
                    PageIndex = Convert.ToInt32(
                        Request.Cookies["DotNetNote"]["PageNum"]);
                }
                else
                {
                    PageIndex = 0;
                }
            }

            if (!SearchMode)
            {
                RecordCount = _repo.GetCountAll();
            }

            LblTotalRecord.Text = $"Total Record : {RecordCount}";

            if (Request["Pgae"] != null)
            {
                PageIndex = Convert.ToInt32(Request["Page"]) - 1;
            }
            else
            {
                PageIndex = 0;
            }
            PagingControl.PageIndex = PageIndex;
            PagingControl.RecordCount = RecordCount;

            if (!Page.IsPostBack)
            {
                DisplayData();
            }
        }

        private void DisplayData()
        {
            if (!SearchMode)
            {
                GrvNotes.DataSource = _repo.GetAll(0);// 페이징은 0부터 시행한다.
            }

            GrvNotes.DataBind();//데이터바인딩 끝
        }

        protected void GrvNotes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}