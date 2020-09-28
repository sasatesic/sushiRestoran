using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SushiRestoran.Dtos
{
    public class StavkaNarudzbineDto
    {
        public string JeloId { get; set; }
        public int Kolicina { get; set; }
        public int UkupnaVrednost { get; set; }
    }
}