using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SushiRestoran.Dtos
{
    public class JeloDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Polje Naziv je obavezno")]
        [StringLength(255)]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Polje Sastojci je obavezno")]
        public string Sastojci { get; set; }
        [Required(ErrorMessage = "Polje Broj Komada je obavezno")]
        [Range(1, 50, ErrorMessage = "Broj komada mora biti izmedju 1 i 50")]
        public int BrojKomada { get; set; }
        [Required(ErrorMessage = "Polje Jedinicna Cena je obavezno")]
        public double JedinicnaCena { get; set; }
        public bool NaMeniju { get; set; }

        [Required(ErrorMessage = "Polje Tip Sushija je obavezno")]
        public int TipSushijaId { get; set; }
    }
}