using DotNetNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetNote.Board
{
    public partial class BoardWrite : System.Web.UI.Page
    {
        public BoardWriteFormType Formtype { get; set; } = BoardWriteFormType.Write;//글쓰기가 기본 값.
        private string _Id;//리스트에서 넘겨주는 번호
        protected void Page_Load(object sender, EventArgs e)
        {
            _Id = Request["Id"];//get/post 다 넘겨받음.
            if (!Page.IsPostBack)
            {
                switch (Formtype)
                {
                    case BoardWriteFormType.Write:
                        LblTitleDescription.Text = "글쓰기 - 다음 필드들을 입력하세요.";
                        break;
                    case BoardWriteFormType.Modify:
                        LblTitleDescription.Text = "글 수정 - 아래 필드들을 수정하세요.";
                        DisplayDataForModify();
                        break;
                    case BoardWriteFormType.Reply:
                        LblTitleDescription.Text = "글 수정 - 다음 필드들을 입력하세요.";
                        DisplaydataForReply();
                        break;
                }
            }
        }

        private void DisplaydataForReply()
        {
            throw new NotImplementedException();
        }

        private void DisplayDataForModify()
        {
            throw new NotImplementedException();
        }

        protected void chkUpload_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btnWrite_Click(object sender, EventArgs e)
        {
            if (IsImageTextCorrect())
            {

                Note note = new Note();
                note.Id = Convert.ToInt32(_Id);//없으면 0
                note.Name = txtName.Text;//필수
                note.Email = txtEmail.Text;
                note.Homepage = txtHomepage.Text;//필수, 추가할 것.
                note.Content = txtContent.Text;
                note.FileName = "";
                note.FileSize = 0;
                note.Password = txtPassword.Text;
                note.PostIp = Request.UserHostAddress;
                note.Encoding = rdoEncoding.SelectedValue;//Text, Html, Mixed

                DBRepository repo = new DBRepository();
                switch (Formtype)
                {
                    case BoardWriteFormType.Write:
                        repo.Add(note);
                        Response.Redirect("BoardList.aspx");
                        break;
                    case BoardWriteFormType.Modify:
                        break;
                    case BoardWriteFormType.Reply:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                lblError.Text = "보안코드가 틀립니다. 다시 입력하세요";
            }
        }

        private bool IsImageTextCorrect()
        {
            if (Page.User.Identity.IsAuthenticated)//이미 로그인했으면
            {
                return true;
            }
            else
            {
                if (Session["ImageText"] != null)
                {
                    return (txtImageText.Text == Session["ImageText"].ToString());
                }
            }
            return false;
        }
    }
}