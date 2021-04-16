﻿using DotNetNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetNote.Board
{
    public partial class BoardView : System.Web.UI.Page
    {
        private string _Id;//현재 게시글 번호
        private string _mode;//뷰에서 넘겨주는 모드 값.(Edit)
        protected void Page_Load(object sender, EventArgs e)
        {
            lnkDelete.NavigateUrl = $"BoardDelete.aspx?Id={Request["Id"]}";
            lnkModify.NavigateUrl = $"BoardWrite.aspx?Id={Request["Id"]}&Mode=Edit";
            lnkReply.NavigateUrl = $"BoardWrite.aspx?Id={Request["Id"]}&Mode=Reply";

            _Id = Request["Id"];
            if (_Id == null) Response.Redirect("BoardList.aspx");
            if (!Page.IsPostBack) DisplayData();
        }

        private void DisplayData()
        {
            var repo = new DBRepository();
            Note note = repo.GetNoteById(Convert.ToInt32(_Id));

            lblNum.Text = _Id;
            lblName.Text = note.Name;
            lblEmail.Text = string.Format("<a href='mailto:{0}'>{0}</a>", note.Email);
            lblTitle.Text = note.Title;

            string content = note.Content;

            string encoding = note.Encoding;
            if (encoding == "Text")
            {
                lblContent.Text = Helpers.HTMLUtility.EncodeWithTabAndSpace(content);
            }
            else if (encoding == "Mixed")
            {
                lblContent.Text = content.Replace("\r\n", "<br />");
            }
            else
            {
                lblContent.Text = content;
            }
            lblReadCount.Text = note.ReadCount.ToString();
            lblHomepage.Text = $"<a href='{note.Homepage}' target='_blank'>{note.Homepage}</a>";
            lblPostDate.Text = note.PostDate.ToString();
            lblPostIP.Text = note.PostIp;
        }
    }
}