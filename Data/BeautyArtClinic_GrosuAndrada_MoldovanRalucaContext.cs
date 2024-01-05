using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models;

namespace BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Data
{
    public class BeautyArtClinic_GrosuAndrada_MoldovanRalucaContext : DbContext
    {
        public BeautyArtClinic_GrosuAndrada_MoldovanRalucaContext (DbContextOptions<BeautyArtClinic_GrosuAndrada_MoldovanRalucaContext> options)
            : base(options)
        {
        }

        public DbSet<BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Serviciu> Serviciu { get; set; } = default!;
        public DbSet<BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Departament> Departament { get; set; } = default!;
        public DbSet<BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Medic> Medic { get; set; } = default!;
        public DbSet<BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Programare> Programare { get; set; } = default!;
        public DbSet<BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.Client> Client { get; set; } = default!;
    }
}
