using Microsoft.AspNetCore.Mvc;

namespace MVCAPPTAG.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public int Add(int x, int y) 
        {
            return x + y;
        }
        public int Subtract(int x, int y)
        {
            return x-y;
        }
        public int Multiply(int x, int y)
        {
            return x*y;
        }
    }
}
