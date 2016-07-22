// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UtentiController.cs" company="">
//   
// </copyright>
// <summary>
//   The utenti controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Net;
using CorsoMVC.Models;

namespace CorsoMVC.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    /// The utenti controller.
    /// </summary>
    public class UtentiController : Controller
    {
        /// <summary>
        /// The index.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public ActionResult Index()
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        /// <summary>
        /// The semplice testo.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult SempliceTesto()
        {
            var result = new ContentResult();
            result.ContentType = "text/plain";
            result.Content = "Ciao, Maurizio!";

            return result;
        }

        /// <summary>
        /// The html manuale.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult HtmlManuale()
        {
            var result = new ContentResult();
            result.ContentType = "text/html";
            result.Content =
                "<html><head><title>Ciao, Mauurizio!</title></head><body><h1>Ciao, Maurizio!<h1></body></html>";

            return result;
        }

        /// <summary>
        /// The primo view.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult PrimoView()
        {
            return this.View();
        }

        /// <summary>
        /// The nome variabile.
        /// </summary>
        /// <param name="nome">
        /// The nome.
        /// </param>
        /// <param name="cognome">
        /// The cognome.
        /// </param>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult NomeVariabile(string nome, string cognome)
        {
            object modello = string.Format("{1} {0}", nome, cognome);

            return this.View(modello);
        }

        /// <summary>
        /// The persona.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult GetPersona()
        {
            Persona mario = new Persona();
            mario.Nome = "Mario";
            mario.Cognome = "Rossi";
            mario.Eta = 31;

            return this.View(mario);
        }
    }
}