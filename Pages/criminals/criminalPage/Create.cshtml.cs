using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVD_BD.Models;

namespace MVD_BD.Pages.criminals.criminalPage
{
    public class CreateModel : PageModel
    {
        private readonly MVD_BD.Models.MVDContext _context;

        public CreateModel(MVD_BD.Models.MVDContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["КодВидаПреступления"] = new SelectList(_context.ВидыПреступленийs, "КодВидаПреступления", "КодВидаПреступления");
        ViewData["КодСотрудника"] = new SelectList(_context.Сотрудникиs, "КодСотрудника", "КодСотрудника");
            return Page();
        }

        [BindProperty]
        public Преступники Преступники { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Преступникиs.Add(Преступники);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
