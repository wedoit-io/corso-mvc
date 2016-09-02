namespace CorsoMVC.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using CorsoMVC.Models;

    public class ArticoloRepositoryInMemoria : IArticoloRepository
    {
        public IEnumerable<Articolo> GetAll(int categoria)
        {
            var categorie = HttpContext.Current.Application["Categorie"] as List<Categoria>;
            if (categorie == null)
            {
                throw new Exception("La lista delle categorie è vuota.");
            }

            var categoriaPadre = categorie.SingleOrDefault(c => c.Id == categoria);
            if (categoriaPadre == null)
            {
                throw new Exception("La categoria richiesta non esiste.");
            }

            if (categoriaPadre.Articoli == null)
            {
                categoriaPadre.Articoli = new List<Articolo>();
            }

            return categoriaPadre.Articoli;
        }

        public void Create(Articolo articolo, int categoria)
        {
            var categorie = HttpContext.Current.Application["Categorie"] as List<Categoria>;
            if (categorie == null)
            {
                throw new Exception("La lista delle categorie è vuota.");
            }

            var categoriaPadre = categorie.SingleOrDefault(c => c.Id == categoria);
            if (categoriaPadre == null)
            {
                throw new Exception("La categoria richiesta non esiste.");
            }

            if (categoriaPadre.Articoli == null)
            {
                categoriaPadre.Articoli = new List<Articolo>();
            }

            categoriaPadre.Articoli.Add(articolo);
        }
    }
}
