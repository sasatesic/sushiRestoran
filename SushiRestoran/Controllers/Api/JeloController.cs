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
    public class JeloController : ApiController
    {
        private ApplicationDbContext _context;

        public JeloController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/jela
        [HttpGet]
        [Route("api/jela")]
        public IEnumerable<JeloDto> IzlistajJela()
        {
            return _context.Jelo.ToList().Select(Mapper.Map<Jelo, JeloDto>);
        }

        //GET /api/jelo/1
        [HttpGet]
        [Route("api/jelo/{id}")]
        public IHttpActionResult TraziJelo(int id)
        {
            var jelo = _context.Jelo.SingleOrDefault(j => j.Id == id);

            if (jelo == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Jelo, JeloDto>(jelo));
        }

        //POST /api/jela
        [HttpPost]
        [Route("api/jela")]
        public IHttpActionResult UpisiNovoJelo(JeloDto jeloDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();       
            }

            var jelo = Mapper.Map<JeloDto, Jelo>(jeloDto);
            _context.Jelo.Add(jelo);
            _context.SaveChanges();

            jeloDto.Id = jelo.Id;

            return Created(new Uri(Request.RequestUri + "/" + jelo.Id), jeloDto);
        }

        //PUT /api/jela/1
        [HttpPut]
        [Route("api/jela/{id}")]
        public void IzmeniJelo(int id, JeloDto jeloDto)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var jeloInDb = _context.Jelo.SingleOrDefault(j => j.Id == id);

            if (jeloInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map<JeloDto, Jelo>(jeloDto, jeloInDb);

            _context.SaveChanges();
        }

        //DELETE /api/jela/1
        [HttpDelete]
        [Route("api/jela/{id}")]
        public void ObrisiJelo(int id)
        {
            var jeloInDb = _context.Jelo.SingleOrDefault(j => j.Id == id);

            if (jeloInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            _context.Jelo.Remove(jeloInDb);
            _context.SaveChanges();
        }

        [HttpPost]
        [Route("api/jela/dodajnameni/{id}")]
        public void DodajJeloNaMeni(int id)
        {
            var jeloInDb = _context.Jelo.SingleOrDefault(j => j.Id == id);

            if (jeloInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            jeloInDb.NaMeniju = true;
            _context.SaveChanges();
        }

        [HttpPost]
        [Route("api/jela/obrisisamenija/{id}")]
        public void ObrisiJeloSaMenija(int id)
        {
            var jeloInDb = _context.Jelo.SingleOrDefault(j => j.Id == id);

            if (jeloInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            jeloInDb.NaMeniju = false;
            _context.SaveChanges();
        }
    }
}
