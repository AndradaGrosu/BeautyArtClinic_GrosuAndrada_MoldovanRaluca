using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data;
using BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Pages.Servicii
{
    public class IndexModel : PageModel
    {
        private readonly BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data.BeautyArtClinic_GrosuAndrada_MoldovanRalucaContext _context;

        public IndexModel(BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data.BeautyArtClinic_GrosuAndrada_MoldovanRalucaContext context)
        {
            _context = context;
        }

        public IList<Serviciu> Serviciu { get; set; } = default!;
        public ServiciuData ServiciuD { get; set; }
        public int ServicuID { get; set; }
        public int DepartamentID { get; set; }
        public string TitleSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            ServiciuD = new ServiciuData();
            TitleSort = String.IsNullOrEmpty(sortOrder) ? "title_desc" : "";

            Serviciu = await _context.Serviciu
                .Include(s => s.Departament)
                .Include(s => s.Medic).ToListAsync();


            switch (sortOrder)
            {
                case "title_desc":
                    ServiciuD.Servicii = ServiciuD.Servicii.OrderByDescending(s =>
                   s.DENUMIRE);
                    break;

                case "title":
                    ServiciuD.Servicii = ServiciuD.Servicii.OrderBy(s => s.DENUMIRE);
                    break;

            }
        }
    }
}