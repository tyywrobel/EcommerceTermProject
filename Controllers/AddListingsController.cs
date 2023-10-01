using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EcommerceTermProject.Models;

namespace EcommerceTermProject.Controllers
{
    public class AddListingsController : Controller
    {
        private readonly EcommerceContext _context;

        public AddListingsController(EcommerceContext context)
        {
            _context = context;
        }

        // GET: AddListings
        public async Task<IActionResult> Index()
        {
              return _context.ListProduct != null ? 
                          View(await _context.ListProduct.ToListAsync()) :
                          Problem("Entity set 'EcommerceContext.ListProduct'  is null.");
        }

        // GET: AddListings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ListProduct == null)
            {
                return NotFound();
            }

            var addListings = await _context.ListProduct
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addListings == null)
            {
                return NotFound();
            }

            return View(addListings);
        }

        // GET: AddListings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AddListings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductName,Address,City,State,Zipcode")] AddListings addListings)
        {
            if (ModelState.IsValid)
            {
                _context.Add(addListings);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(addListings);
        }

        // GET: AddListings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ListProduct == null)
            {
                return NotFound();
            }

            var addListings = await _context.ListProduct.FindAsync(id);
            if (addListings == null)
            {
                return NotFound();
            }
            return View(addListings);
        }

        // POST: AddListings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductName,Address,City,State,Zipcode")] AddListings addListings)
        {
            if (id != addListings.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(addListings);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AddListingsExists(addListings.Id))
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
            return View(addListings);
        }

        // GET: AddListings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ListProduct == null)
            {
                return NotFound();
            }

            var addListings = await _context.ListProduct
                .FirstOrDefaultAsync(m => m.Id == id);
            if (addListings == null)
            {
                return NotFound();
            }

            return View(addListings);
        }

        // POST: AddListings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ListProduct == null)
            {
                return Problem("Entity set 'EcommerceContext.ListProduct'  is null.");
            }
            var addListings = await _context.ListProduct.FindAsync(id);
            if (addListings != null)
            {
                _context.ListProduct.Remove(addListings);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AddListingsExists(int id)
        {
          return (_context.ListProduct?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
