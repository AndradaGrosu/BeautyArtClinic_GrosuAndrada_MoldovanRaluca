using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data;
using BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models;

namespace BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Pages.Servicii
{
    public class CreateModel : PageModel
    {
        private readonly BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data.BeautyArtClinic_GrosuAndrada_MoldovanRalucaContext _context;

        public CreateModel(BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data.BeautyArtClinic_GrosuAndrada_MoldovanRalucaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DepartamentID"] = new SelectList(_context.Set<Departament>(), "ID", "NumeDepartament");
        ViewData["MedicID"] = new SelectList(_context.Set<Medic>(), "ID", "NumeMedic");
            return Page();
        }

        [BindProperty]
        public Serviciu Serviciu { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            _context.Serviciu.Add(Serviciu);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
