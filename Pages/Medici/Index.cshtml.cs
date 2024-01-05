using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data;
using BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models;

namespace BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Pages.Medici
{
    public class IndexModel : PageModel
    {
        private readonly BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data.BeautyArtClinic_GrosuAndrada_MoldovanRalucaContext _context;

        public IndexModel(BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data.BeautyArtClinic_GrosuAndrada_MoldovanRalucaContext context)
        {
            _context = context;
        }

        public IList<Medic> Medic { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Medic = await _context.Medic
                .Include(m => m.Departament).ToListAsync();
        }
    }
}
