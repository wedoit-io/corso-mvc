﻿namespace CorsoMVC.Controllers
{
    using System.Web.Mvc;
    using CorsoMVC.Models;
    using CorsoMVC.Repository;

    public class ArticoloController : Controller
    {
        private readonly IArticoloRepository articoloRepository = new ArticoloRepositoryInMemoria();

        public ActionResult Index(int categoria)
        {
            var all = this.articoloRepository.GetAll(categoria);

            return this.View(all);
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Titolo,Testo")] Articolo articolo, int categoria)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View("Create", articolo);
            }

            this.articoloRepository.Create(articolo, categoria);

            return this.RedirectToAction("Index");
        }
    }
}
