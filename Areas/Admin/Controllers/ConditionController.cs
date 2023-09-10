using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookInventory.Data;
using BookInventory.Entities;

namespace BookInventory.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ConditionController : Controller
    {
        private readonly BookInventoryDbContext _context;

        public ConditionController(BookInventoryDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Condition
        public async Task<IActionResult> Index()
        {
              return _context.Condition != null ? 
                          View(await _context.Condition.ToListAsync()) :
                          Problem("Entity set 'BookInventoryDbContext.Condition'  is null.");
        }

        // GET: Admin/Condition/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Condition == null)
            {
                return NotFound();
            }

            var condition = await _context.Condition
                .FirstOrDefaultAsync(m => m.Id == id);
            if (condition == null)
            {
                return NotFound();
            }

            return View(condition);
        }

        // GET: Admin/Condition/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Condition/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DescriptiveName")] Condition condition)
        {
            if (ModelState.IsValid)
            {
                _context.Add(condition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(condition);
        }

        // GET: Admin/Condition/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Condition == null)
            {
                return NotFound();
            }

            var condition = await _context.Condition.FindAsync(id);
            if (condition == null)
            {
                return NotFound();
            }
            return View(condition);
        }

        // POST: Admin/Condition/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DescriptiveName")] Condition condition)
        {
            if (id != condition.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(condition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConditionExists(condition.Id))
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
            return View(condition);
        }

        // GET: Admin/Condition/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Condition == null)
            {
                return NotFound();
            }

            var condition = await _context.Condition
                .FirstOrDefaultAsync(m => m.Id == id);
            if (condition == null)
            {
                return NotFound();
            }

            return View(condition);
        }

        // POST: Admin/Condition/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Condition == null)
            {
                return Problem("Entity set 'BookInventoryDbContext.Condition'  is null.");
            }
            var condition = await _context.Condition.FindAsync(id);
            if (condition != null)
            {
                _context.Condition.Remove(condition);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConditionExists(int id)
        {
          return (_context.Condition?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
