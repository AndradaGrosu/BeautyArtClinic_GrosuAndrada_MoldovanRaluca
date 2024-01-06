﻿using System.ComponentModel.DataAnnotations;

namespace BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Models
{
    public class Programare
    {
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataProgramare { get; set; }

        public int? ServiciuID { get; set; }
     
        public Serviciu Serviciu { get; set; }

        public int? ClientID { get; set; }
        public Client Client { get; set; }
    }
}
