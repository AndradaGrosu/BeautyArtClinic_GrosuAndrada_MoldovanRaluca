using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data;
using BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models;
using Microsoft.AspNetCore.Authorization;

namespace BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Pages.Medici
{
    [Authorize(Roles = "Admin")]
    public class CreateModel : PageModel
    {
        private readonly BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data.BeautyArtClinic_GrosuAndrada_MoldovanRalucaContext _context;

        public CreateModel(BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data.BeautyArtClinic_GrosuAndrada_MoldovanRalucaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DepartamentID"] = new SelectList(_context.Departament, "ID", "NumeDepartament");
            return Page();
        }

        [BindProperty]
        public Medic Medic { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {

            _context.Medic.Add(Medic);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
