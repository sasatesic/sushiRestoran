using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SushiRestoran.Models
{
    public class StavkaNarudzbine
    {
        public int Id { get; set; }
        public int Kolicina { get; set; }
        public double JedinicnaCena { get; set; }
        public double Vrednost { get; set; }

        public Narudzbina Narudzbina { get; set; }
        public int NarudzbinaId { get; set; }

        public Jelo Jelo { get; set; }
        public int JeloId { get; set; }
    }
}