using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SushiRestoran.Models;
using SushiRestoran.ViewModels;
using System.Data.Entity;

namespace SushiRestoran.Controllers
{
    public class NarudzbinaController : Controller
    {
        private ApplicationDbContext _context;

        public NarudzbinaController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Narudzbina
        [Authorize]
        public ActionResult Index()
        {
            var jela = _context.Jelo.ToList();

            var viewModel = new NarudzbinaFormViewModel
            {
                Jela = jela
            };
  
            return View(viewModel);
        }
        [Authorize]
        public ActionResult ListaNarudzbina()
        {
            var narudzbine = _context.Narudzbina.ToList();

            return View(narudzbine);
        }
    }
}