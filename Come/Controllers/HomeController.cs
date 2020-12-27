using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Come.Models;
using Come.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace Come.Controllers
{
    public class HomeController : Controller
    {
        private readonly ComeContext _context;

        public HomeController(ComeContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            var comeContext = _context.Questions.Include(q => q.Category);


                List<Category> categories = new List<Category>();

            foreach (var question in comeContext)
            {
                if (!categories.Any(k => k.CategoryId == question.CategoryId))
                    categories.Add(question.Category);
            }

            ViewData["Category"] = categories ;

            return View(await comeContext.ToListAsync());
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("Kategoriler")]
        public IActionResult Categories()
        {
            return View();
        }


       
        [Authorize]
        public IActionResult Ask()
        {
            var Date = DateTime.Now;
            ViewData["Date"] = Date;
        
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "Name");
            return View();
        }

        // POST: Questions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Ask([Bind("QuestionId,Title,Description,Body,User,Image,Date,IsApproved,CategoryId")] Question question)
        {
            if (ModelState.IsValid)
            {
                _context.Add(question);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", question.CategoryId);
            return View(question);
        }



        [Route("kategori/{id?}")]
        public IActionResult Category(int? id)
        {
         

            return View(
                _context.Categories.Where(i => i.CategoryId == id).Include(i => i.Questions).Select(i => new CategoryQuestion()
                {
                    Categories = i,
                    Questions = i.Questions
                }).FirstOrDefault()
                );
        }
        [Route("hakkımızda")]
        public IActionResult About()
        {
            return View();
        }

        [Route("iletisim")]
        public IActionResult Contact()
        {
            return View();
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
