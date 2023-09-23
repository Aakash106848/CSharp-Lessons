using Microsoft.AspNetCore.Mvc;

namespace MVCAPPTAG.Controllers
{
    public class PartialViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tabs()
        {
            ViewData["data1"] = "Tom and Jerry are Good friends";
            return View();
        }
    }
}
