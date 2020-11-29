using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vaida_Sabina_Lab8.Data;
using Vaida_Sabina_Lab8.Models;

namespace Vaida_Sabina_Lab8.Pages.Publisher
{
    public class DetailsModel : PageModel
    {
        private readonly Vaida_Sabina_Lab8.Data.Vaida_Sabina_Lab8Context _context;

        public DetailsModel(Vaida_Sabina_Lab8.Data.Vaida_Sabina_Lab8Context context)
        {
            _context = context;
        }

        public Vaida_Sabina_Lab8.Models.Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
