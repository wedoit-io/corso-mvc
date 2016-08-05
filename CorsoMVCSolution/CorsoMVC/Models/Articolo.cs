namespace CorsoMVC.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Articolo
    {
        [Required]
        public string Titolo { get; set; }

        public string Testo { get; set; }
    }
}
