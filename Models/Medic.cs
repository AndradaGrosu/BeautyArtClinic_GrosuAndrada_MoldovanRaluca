using System.ComponentModel.DataAnnotations;

namespace BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models
{
    public class Medic
    {
        public int ID { get; set; }
        [Display(Name = "NUME SPECIALIST")]
        public string NumeMedic { get; set; }

        public int? DepartamentID { get; set; }
        public Departament Departament { get; set; }

        public ICollection<Serviciu>Servicii { get; set; }

    }
}
