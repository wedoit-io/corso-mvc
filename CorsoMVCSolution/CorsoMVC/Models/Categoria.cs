namespace CorsoMVC.Models
{
    using System.Collections.Generic;

    public class Categoria
    {
        public string Titolo { get; set; }

        public int Id { get; set; }

        public List<Articolo> Articoli { get; set; }
    }
}
