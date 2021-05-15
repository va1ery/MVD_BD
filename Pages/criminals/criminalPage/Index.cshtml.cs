using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MVD_BD.Models;

namespace MVD_BD.Pages.criminals.criminalPage
{
    public class IndexModel : PageModel
    {
        private readonly MVD_BD.Models.MVDContext _context;

        public IndexModel(MVD_BD.Models.MVDContext context)
        {
            _context = context;
        }

        public IList<Преступники> Преступники { get;set; }

        public async Task OnGetAsync()
        {
            Преступники = await _context.Преступникиs
                .Include(п => п.КодВидаПреступленияNavigation)
                .Include(п => п.КодСотрудникаNavigation).ToListAsync();
        }
    }
}
