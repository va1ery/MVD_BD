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
    public class DeleteModel : PageModel
    {
        private readonly MVD_BD.Models.MVDContext _context;

        public DeleteModel(MVD_BD.Models.MVDContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Преступники Преступники { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Преступники = await _context.Преступникиs
                .Include(п => п.КодВидаПреступленияNavigation)
                .Include(п => п.КодСотрудникаNavigation).FirstOrDefaultAsync(m => m.НомерДела == id);

            if (Преступники == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Преступники = await _context.Преступникиs.FindAsync(id);

            if (Преступники != null)
            {
                _context.Преступникиs.Remove(Преступники);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
