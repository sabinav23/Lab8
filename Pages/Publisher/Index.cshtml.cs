using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Vaida_Sabina_Lab8.Data;
using Vaida_Sabina_Lab8.Models;

namespace Vaida_Sabina_Lab8.Pages.Publish
{
    public class IndexModel : PageModel
    {
        private readonly Vaida_Sabina_Lab8.Data.Vaida_Sabina_Lab8Context _context;

        public IndexModel(Vaida_Sabina_Lab8.Data.Vaida_Sabina_Lab8Context context)
        {
            _context = context;
        }

        public IList<Vaida_Sabina_Lab8.Models.Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
