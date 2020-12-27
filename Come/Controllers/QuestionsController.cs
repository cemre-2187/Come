using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Come.Data;
using Come.Models;
using Microsoft.AspNetCore.Authorization;

namespace Come.Controllers
{
    public class QuestionsController : Controller
    {
        private readonly ComeContext _context;

        public QuestionsController(ComeContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Admin")]
        // GET: Questions
        public async Task<IActionResult> Index()
        {
            var comeContext = _context.Questions.Include(q => q.Category);
            return View(await comeContext.ToListAsync());
        }
        [Authorize(Roles = "Admin")]
        // GET: Questions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions
                .Include(q => q.Category)
                .FirstOrDefaultAsync(m => m.QuestionId == id);
            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }










        public IActionResult Ask()
        {
            var Date = DateTime.Now;
            ViewData["Date"] = Date;
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId");
            return View();
        }

        // POST: Questions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Ask([Bind("QuestionId,Title,Description,Body,User,Image,Date,IsApproved,CategoryId")] Question question)
        {
            if (ModelState.IsValid)
            {
                var Date = DateTime.Now;
                ViewData["Date"] = Date;
                _context.Add(question);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", question.CategoryId);
            return View(question);
        }
       
        // GET: Questions/Edit/5
      























        // GET: Questions/Create
        public IActionResult Create()
        {
            var Date = DateTime.Now;
            ViewData["Date"] = Date;
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId");
            return View();
        }

        // POST: Questions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
     
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create([Bind("QuestionId,Title,Description,Body,User,Image,Date,IsApproved,CategoryId")] Question question)
        {
            if (ModelState.IsValid)
            {
                var Date = DateTime.Now;
                ViewData["Date"] = Date;
                _context.Add(question);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", question.CategoryId);
            return View(question);
        }
        [Authorize(Roles = "Admin")]
        // GET: Questions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions.FindAsync(id);
            if (question == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", question.CategoryId);
            return View(question);
        }

        // POST: Questions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuestionId,Title,Description,Body,User,Image,Date,IsApproved,CategoryId")] Question question)
        {
            if (id != question.QuestionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(question);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionExists(question.QuestionId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryId", question.CategoryId);
            return View(question);
        }
        [Authorize(Roles = "Admin")]
        // GET: Questions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var question = await _context.Questions
                .Include(q => q.Category)
                .FirstOrDefaultAsync(m => m.QuestionId == id);
            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }
        [Authorize(Roles = "Admin")]
        // POST: Questions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var question = await _context.Questions.FindAsync(id);
            _context.Questions.Remove(question);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionExists(int id)
        {
            return _context.Questions.Any(e => e.QuestionId == id);
        }
    }
}
