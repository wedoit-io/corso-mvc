namespace CorsoMVC.Repository
{
    using System.Collections.Generic;
    using System.Web;
    using CorsoMVC.Models;

    public class CategoriaRepositoryInMemoria : ICategorieRepository
    {
        public IEnumerable<Categoria> GetAll()
        {
            var lista = HttpContext.Current.Application["Categorie"];
            if (lista == null)
            {
                HttpContext.Current.Application["Categorie"] = new List<Categoria>();
            }

            return (IEnumerable<Categoria>)HttpContext.Current.Application["Categorie"];
        }

        public void Create(Categoria categoria)
        {
            var lista = HttpContext.Current.Application["Categorie"];
            if (lista == null)
            {
                HttpContext.Current.Application["Categorie"] = new List<Categoria>();
            }

            var categorie = (List<Categoria>)HttpContext.Current.Application["Categorie"];

            categoria.Id = categorie.Count + 1;

            categorie.Add(categoria);
        }
    }
}