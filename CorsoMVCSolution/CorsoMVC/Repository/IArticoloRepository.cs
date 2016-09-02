namespace CorsoMVC.Repository
{
    using System.Collections.Generic;
    using CorsoMVC.Models;

    public interface IArticoloRepository
    {
        IEnumerable<Articolo> GetAll(int categoria);

        void Create(Articolo articolo, int categoria);
    }
}
