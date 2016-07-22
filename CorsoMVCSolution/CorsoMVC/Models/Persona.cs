// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Persona.cs" company="">
//   
// </copyright>
// <summary>
//   The persona.
// </summary>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CorsoMVC.Models
{
    /// <summary>
    /// The persona.
    /// </summary>
    public class Persona
    {
        /// <summary>
        /// Gets or sets the nome.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Gets or sets the cognome.
        /// </summary>
        public string Cognome { get; set; }

        /// <summary>
        /// Gets or sets the eta.
        /// </summary>
        public int Eta { get; set; }
    }
}