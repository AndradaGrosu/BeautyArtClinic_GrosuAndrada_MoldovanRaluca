using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models
{
    public class Serviciu
    {
        public int ID { get; set; }
        [Display(Name = "TIP SERVICIU")]
        public string DENUMIRE { get; set; }
        public string DESCRIERE { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500)]
        [Display(Name = "PRET (lei)")]
        public decimal PRET { get; set; }


        public int DepartamentID { get; set; }
        [Display(Name = "DEPARTAMENT")]
        public Departament Departament { get; set; }

        
        public int? MedicID { get; set; }
        [Display(Name = "MEDIC")]
        public Medic Medic { get; set; }

        public ICollection<Programare> Programari { get; set; }
    }
}
