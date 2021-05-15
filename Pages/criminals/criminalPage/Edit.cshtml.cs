using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVD_BD.Models;

namespace MVD_BD.Pages.criminals.criminalPage
{
    public class EditModel : PageModel
    {
        private readonly MVD_BD.Models.MVDContext _context;

        public EditModel(MVD_BD.Models.MVDContext context)
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
           ViewData["КодВидаПреступления"] = new SelectList(_context.ВидыПреступленийs, "КодВидаПреступления", "КодВидаПреступления");
           ViewData["КодСотрудника"] = new SelectList(_context.Сотрудникиs, "КодСотрудника", "КодСотрудника");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Преступники).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ПреступникиExists(Преступники.НомерДела))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ПреступникиExists(long id)
        {
            return _context.Преступникиs.Any(e => e.НомерДела == id);
        }
    }
}
