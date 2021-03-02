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
    public class IndexModel : PageModel
    {
        private readonly cricbuzzz.Data.CricBuzzDataContext _context;

        public IndexModel(cricbuzzz.Data.CricBuzzDataContext context)
        {
            _context = context;
        }

        public IList<OdiRanking> OdiRanking { get;set; }

        public async Task OnGetAsync()
        {
            OdiRanking = await _context.OdiRankings
                .Include(o => o.Country).OrderByDescending(o => o.Rating).ToListAsync();
        }
    }
}
