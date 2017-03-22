namespace Unosquare.PassCore.Web.Controllers
{
    using Microsoft.AspNet.Mvc;
    using System.IO;

    /// <summary>
    /// This controller is simply a placeholder to redirect any non-matching URL
    /// to provide the context of the SPA (single page application) index
    /// Examine the routing configuration in the Startup class
    /// </summary>
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var fileContent = System.IO.File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "index.html"));
            return Content(fileContent, "text/html");
        }
    }
}
