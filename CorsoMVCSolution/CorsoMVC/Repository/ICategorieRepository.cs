namespace CorsoMVC.Repository
{
    using System.Collections.Generic;
    using CorsoMVC.Models;

    public interface ICategorieRepository
    {
        IEnumerable<Categoria> GetAll();

        void Create(Categoria categoria);
    }
}