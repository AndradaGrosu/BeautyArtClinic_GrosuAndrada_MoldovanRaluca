using System.ComponentModel.DataAnnotations;

namespace BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models
{
    public class Client
    {
        public int ID { get; set; }
        [Display(Name = "Nume")]
        public string NumeClient { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public ICollection<Programare> Programari { get; set; }
    }
}
