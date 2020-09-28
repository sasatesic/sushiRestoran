using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SushiRestoran.Models
{
    public class Narudzbina
    {
        public int Id { get; set; }
        public DateTime? DatumVreme { get; set; }
        public double? UkupnaVrednost { get; set; }
        public bool? Kompletirana { get; set; }

        public Narudzbina()
        {
            Id = 0;
        }
    }

}