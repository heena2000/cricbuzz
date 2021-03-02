using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using cricbuzzz.BusinessLayer;
using cricbuzzz.Data;

namespace cricbuzz.Tours
{
    public class IndexModel : PageModel
    {
        private readonly cricbuzzz.Data.CricBuzzDataContext _context;

        public IndexModel(cricbuzzz.Data.CricBuzzDataContext context)
        {
            _context = context;
        }

        public IList<Tour> Tour { get;set; }

        public async Task OnGetAsync()
        {
            Tour = await _context.Tours
                .Include(t => t.Country).ToListAsync();
        }
    }
}
