using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JnMouraAgenda.Models;

namespace JnMouraAgenda.Controllers
{
    public class DadosAgendaController : Controller
    {
        private Contexto db = new Contexto();

        // GET: DadosAgenda
        public ActionResult Index()
        {
            return View(db.DadosAgenda.ToList());
        }

        // GET: DadosAgenda/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DadosAgenda dadosAgenda = db.DadosAgenda.Find(id);
            if (dadosAgenda == null)
            {
                return HttpNotFound();
            }
            return View(dadosAgenda);
        }

        // GET: DadosAgenda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DadosAgenda/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTelefone,Telefone,Nome,Endereco")] DadosAgenda dadosAgenda)
        {
            if (ModelState.IsValid)
            {
                db.DadosAgenda.Add(dadosAgenda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dadosAgenda);
        }

        // GET: DadosAgenda/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DadosAgenda dadosAgenda = db.DadosAgenda.Find(id);
            if (dadosAgenda == null)
            {
                return HttpNotFound();
            }
            return View(dadosAgenda);
        }

        // POST: DadosAgenda/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTelefone,Telefone,Nome,Endereco")] DadosAgenda dadosAgenda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dadosAgenda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dadosAgenda);
        }

        // GET: DadosAgenda/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DadosAgenda dadosAgenda = db.DadosAgenda.Find(id);
            if (dadosAgenda == null)
            {
                return HttpNotFound();
            }
            return View(dadosAgenda);
        }

        // POST: DadosAgenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DadosAgenda dadosAgenda = db.DadosAgenda.Find(id);
            db.DadosAgenda.Remove(dadosAgenda);
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
