using System.Security.Policy;

namespace BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models.ViewModels
{
    public class MedicIndexData
    {
        public IEnumerable<Medic> Medici { get; set; }
        public IEnumerable<Departament> Departamente{ get; set; }
    }
}
