using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asp_razor_contoso.Data;
using asp_razor_contoso.models;

namespace asp_razor_contoso.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly asp_razor_contoso.Data.ApplicationDbContext _context;

        public IndexModel(asp_razor_contoso.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
