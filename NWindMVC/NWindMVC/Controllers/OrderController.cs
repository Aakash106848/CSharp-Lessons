using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NWindMVC.Models;

namespace NWindMVC.Controllers
{
    public class OrderController : Controller
    {
        // GET: OrderController
        private RepositoryOrders _repositoryOrders;
        public OrderController(RepositoryOrders repository)
        {
            _repositoryOrders = repository;
        }
        public ActionResult Index()
        {
            List<int> orderIds = _repositoryOrders.GetAllOrderId();
            OrderIdsViewModel idViewmodel = new OrderIdsViewModel(orderIds);

            return View(idViewmodel);
        }
        public ActionResult OrderList() 
        {
            List<Order> order = _repositoryOrders.AllOrders();
            return View(order);
        }
        public ActionResult GetOrderDetail()
        {
            var order = _repositoryOrders.GetOrderId();
            return View(order);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GetOrderDetail(IFormCollection collection, int OrderId, Order order)
        {
            return RedirectToAction("Details", new { OrderId });
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
			//var order = _repositoryOrders.FindOrderById(OrderId);
			//return View(order);
			Order order = _repositoryOrders.FindOrderById(id);
			List<OrderDetail> orderList = _repositoryOrders.FindOrderDetailByOrderId(id);
			ViewData["OrderDetails"] = orderList;
			return View(order);
		}

        // GET: OrderController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderController/Create
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

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderController/Edit/5
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

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderController/Delete/5
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
