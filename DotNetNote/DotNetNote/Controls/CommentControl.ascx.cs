using DotNetNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetNote.Controls
{
    public partial class CommentControl : System.Web.UI.UserControl
    {
        private DBRepository _repository;

        public CommentControl()
        {
            _repository = new DBRepository();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // 데이터 출력(현재 게시글의 번호(Id)에 해당하는 댓글 리스트)
                ctlCommentList.DataSource =
                    _repository.GetNoteComments(Convert.ToInt32(Request["Id"]));
                ctlCommentList.DataBind();
            }
        }

        protected void btnWriteComment_Click(object sender, EventArgs e)
        {
            NoteComment comment = new NoteComment();
            comment.BoardId = Convert.ToInt32(Request["Id"]); // 부모글
            comment.Name = txtName.Text; // 이름
            comment.Password = txtPassword.Text; // 암호
            comment.Opinion = txtOpinion.Text; // 댓글

            // 데이터 입력
            _repository.AddNoteComment(comment);

            Response.Redirect(
                $"{Request.ServerVariables["SCRIPT_NAME"]}?Id={Request["Id"]}");//동적으로 웹페이지를 움직이게 한다.
        }
    }
}