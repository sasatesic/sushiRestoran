using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SushiRestoran.Models;
using System.Data.Entity;
using SushiRestoran.ViewModels;

namespace SushiRestoran.Models
{
    public class JeloController : Controller
    {
        private ApplicationDbContext _context;

        public JeloController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Jelo
        [Authorize]
        public ActionResult Index()
        {
            var jelo = _context.Jelo.Include(j => j.TipSushija).ToList();

            return View(jelo);
        }
        [Authorize]
        public ActionResult Informacije(int id)
        {
            var jelo = _context.Jelo.Include(j => j.TipSushija).SingleOrDefault(j => j.Id == id);

            if (jelo == null)
                return HttpNotFound();

            return View(jelo);
        }
        [Authorize]
        public ActionResult Izmeni(int id)
        {
            var jelo = _context.Jelo.SingleOrDefault(j => j.Id == id);
            var tipoviSushija = _context.TipSushija.ToList();

            if (jelo == null)
                return HttpNotFound();

            var viewModel = new JeloFormViewModel(jelo)
            {   
                TipoviSushija = tipoviSushija
            };

            return View("DodajJelo", viewModel);
        }
        [Authorize]
        public ActionResult DodajJelo()
        {
            var tipoviSushija = _context.TipSushija.ToList();

            var viewModel = new JeloFormViewModel
            {
                TipoviSushija = tipoviSushija
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Sacuvaj(Jelo jelo)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new JeloFormViewModel(jelo)
                {
                    TipoviSushija = _context.TipSushija.ToList()
                };

                return View("DodajJelo", viewModel);
            }
            {
                
            }

            if (jelo.Id == 0)
            {
                _context.Jelo.Add(jelo);
            }
            else
            {
                var jeloUBazi = _context.Jelo.Single(j => j.Id == jelo.Id);
                jeloUBazi.Naziv = jelo.Naziv;
                jeloUBazi.BrojKomada = jelo.BrojKomada;
                jeloUBazi.JedinicnaCena = jelo.JedinicnaCena;
                jeloUBazi.TipSushijaId = jelo.TipSushijaId;
                jeloUBazi.Sastojci = jelo.Sastojci;
                jeloUBazi.NaMeniju= jelo.NaMeniju;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Jelo");
        }

        public ActionResult BrisanjeJela(int id)
        {
            _context.Jelo.Remove(_context.Jelo.Single(j => j.Id == id));
            _context.SaveChanges();
            return RedirectToAction("Index", "Jelo");
        }

        public ActionResult DodajNaMeni(int id)
        {
            var jeloInDb = _context.Jelo.Single(j => j.Id == id);
            jeloInDb.NaMeniju = true;
            _context.SaveChanges();

            return RedirectToAction("Index", "Jelo");
        }

        public ActionResult SkiniSaMenija(int id)
        {
            var jeloInDb = _context.Jelo.Single(j => j.Id == id);
            jeloInDb.NaMeniju = false;
            _context.SaveChanges();

            return RedirectToAction("Index", "Jelo");
        }
    }
}