using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CinemaWebApp.Models;

namespace CinemaWebApp.Controllers
{
    public class RegistrovaniKorisniksController : ApiController
    {
        private CinemaModel db = new CinemaModel();

        // GET: api/RegistrovaniKorisniks
        public IQueryable<RegistrovaniKorisnik> GetRegistrovaniKorisnik()
        {
            return db.RegistrovaniKorisnik;
        }

        // GET: api/RegistrovaniKorisniks/5
        [ResponseType(typeof(RegistrovaniKorisnik))]
        public IHttpActionResult GetRegistrovaniKorisnik(int id)
        {
            RegistrovaniKorisnik registrovaniKorisnik = db.RegistrovaniKorisnik.Find(id);
            if (registrovaniKorisnik == null)
            {
                return NotFound();
            }

            return Ok(registrovaniKorisnik);
        }

        // PUT: api/RegistrovaniKorisniks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRegistrovaniKorisnik(int id, RegistrovaniKorisnik registrovaniKorisnik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != registrovaniKorisnik.Id)
            {
                return BadRequest();
            }

            db.Entry(registrovaniKorisnik).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RegistrovaniKorisnikExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/RegistrovaniKorisniks
        [ResponseType(typeof(RegistrovaniKorisnik))]
        public IHttpActionResult PostRegistrovaniKorisnik(RegistrovaniKorisnik registrovaniKorisnik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RegistrovaniKorisnik.Add(registrovaniKorisnik);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = registrovaniKorisnik.Id }, registrovaniKorisnik);
        }

        // DELETE: api/RegistrovaniKorisniks/5
        [ResponseType(typeof(RegistrovaniKorisnik))]
        public IHttpActionResult DeleteRegistrovaniKorisnik(int id)
        {
            RegistrovaniKorisnik registrovaniKorisnik = db.RegistrovaniKorisnik.Find(id);
            if (registrovaniKorisnik == null)
            {
                return NotFound();
            }

            db.RegistrovaniKorisnik.Remove(registrovaniKorisnik);
            db.SaveChanges();

            return Ok(registrovaniKorisnik);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RegistrovaniKorisnikExists(int id)
        {
            return db.RegistrovaniKorisnik.Count(e => e.Id == id) > 0;
        }
    }
}