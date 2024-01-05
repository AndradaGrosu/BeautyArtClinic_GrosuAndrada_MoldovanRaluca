using System.ComponentModel.DataAnnotations;

namespace BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models
{
    public class Departament
    {
        public int ID { get; set; }
        [Display(Name = "DEPARTAMENT")]
        public string NumeDepartament { get; set; }

        public ICollection<Serviciu> Servicii { get; set; }
        public ICollection<Medic> Medici { get; set; }
    }
}
