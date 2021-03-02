using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using cricbuzzz.BusinessLayer;
using cricbuzzz.Data;

namespace cricbuzz.TestRankings
{
    public class DeleteModel : PageModel
    {
        private readonly cricbuzzz.Data.CricBuzzDataContext _context;

        public DeleteModel(cricbuzzz.Data.CricBuzzDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TestRanking TestRanking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TestRanking = await _context.TestRankings
                .Include(t => t.Country).FirstOrDefaultAsync(m => m.Id == id);

            if (TestRanking == null)
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

            TestRanking = await _context.TestRankings.FindAsync(id);

            if (TestRanking != null)
            {
                _context.TestRankings.Remove(TestRanking);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
