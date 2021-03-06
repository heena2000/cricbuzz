﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly cricbuzzz.Data.CricBuzzDataContext _context;

        public DetailsModel(cricbuzzz.Data.CricBuzzDataContext context)
        {
            _context = context;
        }

        public Country Country { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Country = await _context.Countries.FirstOrDefaultAsync(m => m.Id == id);

            if (Country == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
