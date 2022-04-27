#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyFirstCoreMVC.Models;

namespace MyFirstCoreMVC.Controllers
{
    public class MvcsController : Controller
    {
        private readonly FirstCoreMVCContext _context;

        public MvcsController(FirstCoreMVCContext context)
        {
            _context = context;
        }

        // GET: Mvcs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mvcs.ToListAsync());
        }

        // GET: Mvcs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mvc = await _context.Mvcs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mvc == null)
            {
                return NotFound();
            }

            return View(mvc);
        }

        // GET: Mvcs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mvcs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] Mvc mvc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mvc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mvc);
        }

        // GET: Mvcs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mvc = await _context.Mvcs.FindAsync(id);
            if (mvc == null)
            {
                return NotFound();
            }
            return View(mvc);
        }

        // POST: Mvcs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Mvc mvc)
        {
            if (id != mvc.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mvc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MvcExists(mvc.Id))
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
            return View(mvc);
        }

        // GET: Mvcs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mvc = await _context.Mvcs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mvc == null)
            {
                return NotFound();
            }

            return View(mvc);
        }

        // POST: Mvcs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mvc = await _context.Mvcs.FindAsync(id);
            _context.Mvcs.Remove(mvc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MvcExists(int id)
        {
            return _context.Mvcs.Any(e => e.Id == id);
        }
    }
}
