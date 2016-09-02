namespace CorsoMVC.Models
{
    using System.ComponentModel.DataAnnotations;
    using CorsoMVC.Controllers;

    public class Articolo
    {
        [Required]
        public string Titolo { get; set; }

        public string Testo { get; set; }

        public Categoria Categoria { get; set; }
    }
}
