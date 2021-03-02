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
    public class IndexModel : PageModel
    {
        private readonly cricbuzzz.Data.CricBuzzDataContext _context;

        public IndexModel(cricbuzzz.Data.CricBuzzDataContext context)
        {
            _context = context;
        }

        public IList<TestRanking> TestRanking { get;set; }

        public async Task OnGetAsync()
        {
            TestRanking = await _context.TestRankings
                .Include(t => t.Country).OrderByDescending(t => t.Rating).ToListAsync();
        }
    }
}
