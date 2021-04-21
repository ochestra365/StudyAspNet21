using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyPortpolioWeb.Data;
using MyPortpolioWeb.Models;

namespace MyPortpolioWeb.Controllers
{
    public class ContactsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Contacts
        [HttpGet]
        public async Task<IActionResult> Index()//IactionResult는 윈도우의 기본 제공 작업처리를 비동기시키고 본인의 커스터마이즈화된 기능을 수행한다.
        {
            return View();
        }
       
        [HttpPost]
        public async Task<IActionResult> Index([Bind("Id,Name,Email,Contets")] Contacts contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contact.RegDate = DateTime.Now;
                    _context.Add(contact);
                    await _context.SaveChangesAsync();

                    ViewBag.Message = "감사합니다. 연락드리겠습니다.";

                    //return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                ModelState.Clear();
                ViewBag.Message = $"예외가 발생했습니다. {ex.Message}";
            }
           
            return View();
        }
    }
}
