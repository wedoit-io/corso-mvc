namespace CorsoMVC.Repository
{
    using System.Collections.Generic;
    using CorsoMVC.Models;

    public interface IArticoloRepository
    {
        IEnumerable<Articolo> GetAll();

        void Create(Articolo articolo);
    }
}
