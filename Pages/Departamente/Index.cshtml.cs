using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data;
using BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models;
using BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.ViewModels;

namespace BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Pages.Departamente
{
    public class IndexModel : PageModel
    {
        private readonly BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data.BeautyArtClinic_GrosuAndrada_MoldovanRalucaContext _context;

        public IndexModel(BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data.BeautyArtClinic_GrosuAndrada_MoldovanRalucaContext context)
        {
            _context = context;
        }

        public IList<Departament> Departament { get;set; } = default!;

        public MedicIndexData DepartamentData {  get;set; }
        public int DepartamentID { get;set; }
        public int MedicID { get;set; }

        public async Task OnGetAsync(int? id, int? medicID)
        {

            DepartamentData =new MedicIndexData();
            DepartamentData.Departamente=await _context.Departament
                .Include(i=>i.Medici)
                .OrderBy(i=>i.NumeDepartament)
                .ToListAsync();

            if(id!=null)
            {
                DepartamentID = id.Value;
                Departament departament = DepartamentData.Departamente
                    .Where(i => i.ID == id.Value).Single();
                DepartamentData.Medici = departament.Medici;
            }
        }
    }
}
