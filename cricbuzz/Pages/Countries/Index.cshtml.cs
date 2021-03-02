using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using cricbuzzz.BusinessLayer;
using cricbuzzz.Data;

namespace cricbuzz.Countries
{
    public class IndexModel : PageModel
    {
        private readonly cricbuzzz.Data.CricBuzzDataContext _context;

        public IndexModel(cricbuzzz.Data.CricBuzzDataContext context)
        {
            _context = context;
        }

        public IList<Country> Country { get;set; }

        public async Task OnGetAsync()
        {
            Country = await _context.Countries.ToListAsync();
        }
    }
}
