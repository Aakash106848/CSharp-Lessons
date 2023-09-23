using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NWindMVC.Models;

namespace NWindMVC.Controllers
{
    public class CustomerController : Controller
    {
        private RepositoryCustomer _repositorycustomer;
        public CustomerController(RepositoryCustomer repository)
        {
            _repositorycustomer = repository;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Customerinfo()
        {
            List<Customer> customer = _repositorycustomer.GetAllCustomerId();
            return View(customer);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CustomerInfo(IFormCollection collection,string id,Customer customer)
        {
            return RedirectToAction("Details", new {id});
        }

        // GET: CustomerController/Details/5
        public ActionResult Details(String id)
        {
            Customer customer = _repositorycustomer.FindCustomerById(id);
            List<Order> orderList = _repositorycustomer.GetCustomerOrders(id);
            ViewData["Orders"] = orderList;
            return View(customer);
        }


        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
