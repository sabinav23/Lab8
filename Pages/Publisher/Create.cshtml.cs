using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Vaida_Sabina_Lab8.Data;
using Vaida_Sabina_Lab8.Models;

namespace Vaida_Sabina_Lab8.Pages.Publisher
{
    public class CreateModel : PageModel
    {
        private readonly Vaida_Sabina_Lab8.Data.Vaida_Sabina_Lab8Context _context;

        public CreateModel(Vaida_Sabina_Lab8.Data.Vaida_Sabina_Lab8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Vaida_Sabina_Lab8.Models.Publisher Publisher { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
