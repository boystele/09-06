using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class FUNCAOController : Controller
    {
        EMPRESAEntities ctx = new EMPRESAEntities();

        public ActionResult Index()
        {

            return View(ctx.Funcao.ToList());
        }

        public ActionResult Details(int id)
        {
            var detalhes = ctx.Funcao.Find(id);
            ctx.SaveChanges();
            return View(detalhes);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Funcao create)
        {
            if (ModelState.IsValid)
            {
                ctx.Funcao.Add(create);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }


        public ActionResult Delete(int id)
        {
            EMPRESAEntities ctx = new EMPRESAEntities();
            var objetoDeletar = ctx.Funcao.Find(id);
            ctx.Funcao.Remove(objetoDeletar);
            ctx.SaveChanges();
            return View(objetoDeletar);
        }

        [HttpPost]
        public ActionResult Delete(Funcao cliente)
        {
            if (ModelState.IsValid)
            {
                EMPRESAEntities ctx = new EMPRESAEntities();
                ctx.Entry(cliente).State = System.Data.Entity.EntityState.Deleted;
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public ActionResult Edit(int id)
        {
            var editar = ctx.Funcao.Find(id);
            ctx.SaveChanges();
            return View(editar);
        }

        [HttpPost]
        public ActionResult Edit(Funcao FUNCAO)
        {
            if (ModelState.IsValid)
            {
                ctx.Entry(FUNCAO).State = System.Data.Entity.EntityState.Modified;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}