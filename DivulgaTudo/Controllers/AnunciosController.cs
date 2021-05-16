using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DivulgaTudo.Models;

namespace DivulgaTudo.Controllers
{
    public class AnunciosController : Controller
    {
        private DivulgaTudoContext db = new DivulgaTudoContext();


        // GET: Anuncios
        public ActionResult Index()
        {
            return View(db.Anuncios.ToList());
        }



        // GET: Anuncios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anuncios anuncios = db.Anuncios.Find(id);
            if (anuncios == null)
            {
                return HttpNotFound();
            }
            return View(anuncios);
        }



        // GET: Anuncios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anuncios/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "anuncioId,nomeAnuncio,nomeCliente,dataInicial,dataFinal,investimento")] Anuncios anuncios)
        {
            if (ModelState.IsValid)
            {
                db.Anuncios.Add(anuncios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(anuncios);
        }



        // GET: Anuncios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anuncios anuncios = db.Anuncios.Find(id);
            if (anuncios == null)
            {
                return HttpNotFound();
            }
            return View(anuncios);
        }

        // POST: Anuncios/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "anuncioId,nomeAnuncio,nomeCliente,dataInicial,dataFinal,investimento")] Anuncios anuncios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anuncios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anuncios);
        }



        // GET: Anuncios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anuncios anuncios = db.Anuncios.Find(id);
            if (anuncios == null)
            {
                return HttpNotFound();
            }
            return View(anuncios);
        }

        // POST: Anuncios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Anuncios anuncios = db.Anuncios.Find(id);
            db.Anuncios.Remove(anuncios);
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
