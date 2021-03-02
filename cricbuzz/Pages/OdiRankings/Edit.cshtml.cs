using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using cricbuzzz.BusinessLayer;
using cricbuzzz.Data;

namespace cricbuzz.OdiRankings
{
    public class EditModel : PageModel
    {
        private readonly cricbuzzz.Data.CricBuzzDataContext _context;

        public EditModel(cricbuzzz.Data.CricBuzzDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public OdiRanking OdiRanking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OdiRanking = await _context.OdiRankings
                .Include(o => o.Country).FirstOrDefaultAsync(m => m.Id == id);

            if (OdiRanking == null)
            {
                return NotFound();
            }
           ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "CountryName");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(OdiRanking).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OdiRankingExists(OdiRanking.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool OdiRankingExists(int id)
        {
            return _context.OdiRankings.Any(e => e.Id == id);
        }
    }
}
