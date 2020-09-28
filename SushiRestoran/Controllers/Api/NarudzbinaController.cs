using SushiRestoran.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SushiRestoran.Dtos;
using AutoMapper;

namespace SushiRestoran.Controllers.Api
{
    public class NarudzbinaController : ApiController
    {
        private ApplicationDbContext _context;

        public NarudzbinaController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        [Route("api/narudzbina")]
        public IHttpActionResult NapraviNovuNarudzbinu(NovaNarudzbinaDto novaNarduzvina)
        {
            double ukupnaVrednost = 0;

            foreach (var jelo in novaNarduzvina.Jela)
            {
                ukupnaVrednost = ukupnaVrednost + Convert.ToDouble(jelo.UkupnaVrednost);
            }

            var narudzbina = new Narudzbina
            {
                DatumVreme = DateTime.Now,
                UkupnaVrednost = ukupnaVrednost,
                Kompletirana = true

            };

            _context.Narudzbina.Add(narudzbina);
            _context.SaveChanges();

            foreach (var jelo in novaNarduzvina.Jela)
            {
                var id = Convert.ToInt32(jelo.JeloId);
                var jeloInDb = _context.Jelo.Single(j => j.Id == id);
                var stavkaNarudzbine = new StavkaNarudzbine()
                {
                    JeloId = Convert.ToInt32(jelo.JeloId),
                    JedinicnaCena = jeloInDb.JedinicnaCena,
                    Kolicina = jelo.Kolicina,
                    Vrednost = jelo.UkupnaVrednost,
                    NarudzbinaId = narudzbina.Id
                };

                _context.StavkaNarudzbine.Add(stavkaNarudzbine);
                _context.SaveChanges();
            }

            return Ok();
        }
    }
}
