namespace CorsoMVC.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Persona : IValidatableObject
    {
        [Required]
        public string Nome { get; set; }

        public string Cognome { get; set; }

        public int Eta { get; set; }

        public bool Admin { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (this.Eta < 30)
            {
                yield return new ValidationResult("Età non può essere meno di 30.");
            }

            if (this.Nome.StartsWith("A"))
            {
                yield return new ValidationResult("I nomi non devono iniziare con la lettera 'A'");
            }
        }
    }
}
