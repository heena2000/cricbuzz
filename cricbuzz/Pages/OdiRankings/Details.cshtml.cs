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
    public class DetailsModel : PageModel
    {
        private readonly cricbuzzz.Data.CricBuzzDataContext _context;

        public DetailsModel(cricbuzzz.Data.CricBuzzDataContext context)
        {
            _context = context;
        }

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
    }
}
