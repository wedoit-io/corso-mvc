namespace CorsoMVC.Repository
{
    using System.Collections.Generic;
    using System.Web;
    using CorsoMVC.Models;

    public class ArticoloRepositoryInMemoria : IArticoloRepository
    {
        public IEnumerable<Articolo> GetAll()
        {
            var lista = HttpContext.Current.Application["Articoli"];
            if (lista == null)
            {
                HttpContext.Current.Application["Articoli"] = new List<Articolo>();
            }

            return (IEnumerable<Articolo>)HttpContext.Current.Application["Articoli"];
        }

        public void Create(Articolo articolo)
        {
            var lista = HttpContext.Current.Application["Articoli"];
            if (lista == null)
            {
                HttpContext.Current.Application["Articoli"] = new List<Articolo>();
            }

            var articoli = (List<Articolo>)HttpContext.Current.Application["Articoli"];
            articoli.Add(articolo);
        }
    }
}
