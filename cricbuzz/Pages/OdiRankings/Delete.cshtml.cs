using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using cricbuzzz.BusinessLayer;
using cricbuzzz.Data;

namespace cricbuzz.OdiRankings
{
    public class DeleteModel : PageModel
    {
        private readonly cricbuzzz.Data.CricBuzzDataContext _context;

        public DeleteModel(cricbuzzz.Data.CricBuzzDataContext context)
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OdiRanking = await _context.OdiRankings.FindAsync(id);

            if (OdiRanking != null)
            {
                _context.OdiRankings.Remove(OdiRanking);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
