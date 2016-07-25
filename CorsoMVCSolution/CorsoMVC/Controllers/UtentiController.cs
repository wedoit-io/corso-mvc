namespace CorsoMVC.Controllers
{
    using System.Net;
    using System.Web.Mvc;
    using CorsoMVC.Models;

    public class UtentiController : Controller
    {
        public ActionResult Index()
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        public ActionResult SempliceTesto()
        {
            var result = new ContentResult();
            result.ContentType = "text/plain";
            result.Content = "Ciao, Maurizio!";

            return result;
        }

        public ActionResult HtmlManuale()
        {
            var result = new ContentResult();
            result.ContentType = "text/html";
            result.Content =
                "<html><head><title>Ciao, Mauurizio!</title></head><body><h1>Ciao, Maurizio!<h1></body></html>";

            return result;
        }

        public ActionResult PrimoView()
        {
            return this.View();
        }

        public ActionResult NomeVariabile(string nome, string cognome)
        {
            object modello = string.Format("{1} {0}", nome, cognome);

            return this.View(modello);
        }

        public ActionResult GetPersona()
        {
            var mario = new Persona();
            mario.Nome = "Mario";
            mario.Cognome = "Rossi";
            mario.Eta = 31;

            var stefano = new Persona();
            stefano.Nome = "Stefano";
            stefano.Cognome = "Teodorani";
            stefano.Eta = 54;

            return this.View(new[] { mario, stefano });
        }
    }
}
