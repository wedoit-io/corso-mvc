namespace CorsoMVC.Areas.Admin.Controllers
{
    using System.Web.Mvc;

    public class UtentiController : Controller
    {
        public ActionResult HtmlManuale()
        {
            var result = new ContentResult();
            result.ContentType = "text/html";
            result.Content =
                "<html><head><title>Ciao, Mauurizio!</title></head><body><h1>Ciao, Maurizio! (admin)<h1></body></html>";

            return result;
        }
    }
}
