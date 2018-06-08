using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class RegistrovaniKorisniksController : Controller
    {
        private CinemaContext db = new CinemaContext();

        // GET: RegistrovaniKorisniks
        /*public ActionResult Index()
        {
            return View(db.RegistrovaniKorisnik.ToList());
        }*/


            string apiUrl = "http://cinemawebapp20180607115022.azurewebsites.net/";
        public async Task<ActionResult> Index()
        {
            List<RegistrovaniKorisnik> regKorisnici = new List<RegistrovaniKorisnik>();
            using (var client = new HttpClient())
            {

                //Postavljanje adrese URL od web api servisa
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Clear();

                //definisanje formata koji želimo prihvatiti
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //Asinhrono slanje zahtjeva za podacima o korisnicima

                HttpResponseMessage Res = await client.GetAsync("api/Korisniks");
                //Provjera da li je rezultat uspješan
                if (Res.IsSuccessStatusCode)
                {
                    //spremanje podataka dobijenih iz responsa
                    var response = Res.Content.ReadAsStringAsync().Result;

                    //Deserijalizacija responsa dobijenog iz apija i pretvaranje u listu studenata
                    //korisnici = JsonConvert.DeserializeObject<List<Korisnik>>(response);

                    regKorisnici = (List<RegistrovaniKorisnik>)Newtonsoft.Json.JsonConvert.DeserializeObject(response, typeof(List<RegistrovaniKorisnik>));
                }

                return View(regKorisnici);
            }
        }

        // GET: RegistrovaniKorisniks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistrovaniKorisnik registrovaniKorisnik = db.RegistrovaniKorisnik.Find(id);
            if (registrovaniKorisnik == null)
            {
                return HttpNotFound();
            }
            return View(registrovaniKorisnik);
        }

        // GET: RegistrovaniKorisniks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistrovaniKorisniks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ime,Prezime,Username,Password,DatumRođenja,BrojKartice,Email")] RegistrovaniKorisnik registrovaniKorisnik)
        {
            if (ModelState.IsValid)
            {
                db.RegistrovaniKorisnik.Add(registrovaniKorisnik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(registrovaniKorisnik);
        }

        // GET: RegistrovaniKorisniks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistrovaniKorisnik registrovaniKorisnik = db.RegistrovaniKorisnik.Find(id);
            if (registrovaniKorisnik == null)
            {
                return HttpNotFound();
            }
            return View(registrovaniKorisnik);
        }

        // POST: RegistrovaniKorisniks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ime,Prezime,Username,Password,DatumRođenja,BrojKartice,Email")] RegistrovaniKorisnik registrovaniKorisnik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registrovaniKorisnik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registrovaniKorisnik);
        }

        // GET: RegistrovaniKorisniks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistrovaniKorisnik registrovaniKorisnik = db.RegistrovaniKorisnik.Find(id);
            if (registrovaniKorisnik == null)
            {
                return HttpNotFound();
            }
            return View(registrovaniKorisnik);
        }

        // POST: RegistrovaniKorisniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegistrovaniKorisnik registrovaniKorisnik = db.RegistrovaniKorisnik.Find(id);
            db.RegistrovaniKorisnik.Remove(registrovaniKorisnik);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
