using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using cricbuzzz.BusinessLayer;
using cricbuzzz.Data;

namespace cricbuzz.Tours
{
    public class CreateModel : PageModel
    {
        private readonly cricbuzzz.Data.CricBuzzDataContext _context;

        public CreateModel(cricbuzzz.Data.CricBuzzDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CountryId"] = new SelectList(_context.Countries, "Id", "CountryName");
            return Page();
        }

        [BindProperty]
        public Tour Tour { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Tours.Add(Tour);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
