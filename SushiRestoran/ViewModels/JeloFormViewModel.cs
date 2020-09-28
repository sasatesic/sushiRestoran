using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SushiRestoran.Models;
using System.ComponentModel.DataAnnotations;

namespace SushiRestoran.ViewModels
{
    public class JeloFormViewModel
    {
        public IEnumerable<TipSushija> TipoviSushija { get; set; }

        public int? Id { get; set; }

        [Required(ErrorMessage = "Polje Naziv je obavezno")]
        [StringLength(255)]
        public string Naziv { get; set; }
        [Required(ErrorMessage = "Polje Sastojci je obavezno")]
        public string Sastojci { get; set; }
        [Required(ErrorMessage = "Polje Broj Komada je obavezno")]
        [Range(1, 50, ErrorMessage = "Broj komada mora biti izmedju 1 i 50")]
        public int? BrojKomada { get; set; }
        [Required(ErrorMessage = "Polje Jedinicna Cena je obavezno")]
        public double? JedinicnaCena { get; set; }
        public bool NaMeniju { get; set; }

        [Required(ErrorMessage = "Polje Tip Sushija je obavezno")]
        public int? TipSushijaId { get; set; }

        public JeloFormViewModel()
        {
            Id = 0;
        }
        public JeloFormViewModel(Jelo jelo)
        {
            Id = jelo.Id;
            Naziv = jelo.Naziv;
            JedinicnaCena = jelo.JedinicnaCena;
            BrojKomada = jelo.BrojKomada;
            NaMeniju = jelo.NaMeniju;
            Sastojci = jelo.Sastojci;
            TipSushijaId = jelo.TipSushijaId;
        }
    }
}