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
    public class DetailsModel : PageModel
    {
        private readonly cricbuzzz.Data.CricBuzzDataContext _context;

        public DetailsModel(cricbuzzz.Data.CricBuzzDataContext context)
        {
            _context = context;
        }

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
    }
}
