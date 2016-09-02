namespace CorsoMVC.Controllers
{
    using System.Web.Mvc;
    using CorsoMVC.Models;
    using CorsoMVC.Repository;

    public class CategoriaController : Controller
    {
        private readonly ICategorieRepository categorieRepository = new CategoriaRepositoryInMemoria();

        public ActionResult Index()
        {
            var all = this.categorieRepository.GetAll();

            return this.View(all);
        }

        public ActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Titolo")] Categoria categoria)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View("Create", categoria);
            }

            this.categorieRepository.Create(categoria);

            return this.RedirectToAction("Index");
        }
    }
}