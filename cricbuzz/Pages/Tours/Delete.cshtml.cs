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
    public class DeleteModel : PageModel
    {
        private readonly cricbuzzz.Data.CricBuzzDataContext _context;

        public DeleteModel(cricbuzzz.Data.CricBuzzDataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tour Tour { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Tour = await _context.Tours
                .Include(t => t.Country).FirstOrDefaultAsync(m => m.Id == id);

            if (Tour == null)
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

            Tour = await _context.Tours.FindAsync(id);

            if (Tour != null)
            {
                _context.Tours.Remove(Tour);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
