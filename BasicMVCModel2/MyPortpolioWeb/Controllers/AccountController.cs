using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyPortpolioWeb.Data;
using MyPortpolioWeb.Models;

namespace MyPortpolioWeb.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]//데이터를 가져온다.
        public IActionResult Login()
        {
            var account = new Account();
            return View(account);
        }

        [HttpPost]//버튼을 누르면 데이터가 전송된다.

        public async Task<IActionResult> Login([Bind("Email,Password")] Account account)
        {
            bool isvalid = true;//고쳤다!!!!!!!!!!!!!!!!
            if (/*ModelState.IsValid*/isvalid)
            {
                var result = CheckAccount(account.Email, account.Password);
                if(result==null)//계정이 없음
                {//계정이 없음. Home/Index 이동
                    ViewBag.Message = "해당 계정이 없는데?";
                    return View("Login");
                }
                else
                {//로그인
                    HttpContext.Session.SetString("UserEmail", result.Email);
                    return RedirectToAction("Index","Home");
                }
            }

            return View("Login");
        }

        private Account CheckAccount(string email, string password)
        {
            return _context.Account.SingleOrDefault(a => a.Email.Equals(email) && a.Password.Equals(password));
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
