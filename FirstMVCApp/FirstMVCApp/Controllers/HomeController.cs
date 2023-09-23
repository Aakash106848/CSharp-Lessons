using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO;


namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
            //searches  for a html file for the current method
            //its a method and finds homr
        }
        public IActionResult DoLogin(string txtUser, string txtPwd)
        {
            ViewData["userValue"] = $"{txtUser},{txtPwd}";
            return View();
        }
        public IActionResult SayHello(String name)
        {
            if (string.IsNullOrEmpty(name))
            {
                ViewData["v1"] = "Name is Empty"
;
            }
            else
            {
                ViewData["v1"] = name;
            }
            return View();
            //transfer business logic to presentation using veiw
        }
        public IActionResult Add(int x, int y)
        {
            int result = x + y;
            ViewData["addresult"] = result;
            return View();
        }
        public IActionResult Multiply(int x, int y)
        {
            int result = x * y;
            ViewData["addresult"] = result;
            return View("Add");
        }
        public IActionResult Divide(int x, int y)
        {
            int result = x / y;
            ViewData["addresult"] = result;
            return View("Add");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult AddNewBook()
        {
            Book book = new Book();

            return View(book);
        }
        public IActionResult SaveNewBook(Book pBook)
        {
            String fName = @"C:\temp\BookReports.txt";
            string strBook = $"{pBook.BookID},{pBook.Title},{pBook.Cost},{pBook.AuthorName}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine($"{strBook}");
            }
            return View(pBook);
        }
        public Book StringToBook(string[] data, Book book)
        {
            book.BookID = int.Parse(data[0]);
            book.Title = data[1];
            book.Cost = int.Parse(data[2]);
            book.AuthorName = data[3];

            return book;
        }
        public IActionResult ListAllBook()
        {
            string fName = @"C:\temp\BookReports.txt";
            List<Book> list = new List<Book>();
            using (StreamReader sr = new StreamReader(fName, true))
            {
                string strBook = $"{sr.ReadLine()}";
                string[] data = strBook.Split(',');
                Book book = StringToBook(data, new Book());
                list.Add(book);
                while (!sr.EndOfStream)
                {
                    strBook = sr.ReadLine().ToString();
                    data = strBook.Split(",");
                    book = StringToBook(data, new Book());
                    list.Add(book);
                }

                return View(list);
            }
        }
    }
}
