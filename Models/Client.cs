using System.ComponentModel.DataAnnotations;

namespace BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models
{
    public class Client
    {
        public int ID { get; set; }
        [RegularExpression(@"^[A-Z]+[a-z\s]*$")]
        [StringLength(30, MinimumLength = 3)]
        [Display(Name = "Nume")]
        public string? NumeClient { get; set; }
        [RegularExpression(@"^[A-Z]+[a-z\s]*$", ErrorMessage = "Prenumele trebuie sa inceapa cu majuscula (ex. Ana sau Ana Maria sau AnaMaria")]
        [StringLength(30, MinimumLength = 3)]
        [Display(Name = "Prenume")]
        public string? PrenumeClient { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [RegularExpression(@"^0\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Telefonul trebuie sa fie de forma '0712-111-123' sau '0712.111.123' sau '0712 111 123' si sa inceapa cu 0")]
        public string Telefon { get; set; }
        [Display(Name = "Client")]
        public string? NumeComplet
        {
            get
            {
                return NumeClient + " " + PrenumeClient;
            }
        }
        public ICollection<Programare> Programari { get; set; }
    }
}
