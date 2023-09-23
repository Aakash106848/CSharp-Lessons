using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCEFApp.Models;

namespace MVCEFApp.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: AppointmentController
        public ActionResult Index()
        {
            List<Appoinment> appoinment = RepositoryAppoinment.GetAppoinments();
            if (appoinment != null && appoinment.Count > 0)
            {
                return View(appoinment);
            }
            else
            {
                return View("Create");
            }
        }

        // GET: AppointmentController/Details/5
        public ActionResult Details(int id)
        {
            Appoinment appoinment = RepositoryAppoinment.GetAppoinmentById(id);
            return View(appoinment);
        }

        // GET: AppointmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppointmentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Appoinment pAppoinment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryAppoinment.AddNewAppoinment(pAppoinment);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AppointmentController/Edit/5
        public ActionResult Edit(int id)
        {
            Appoinment appoinment = RepositoryAppoinment.GetAppoinmentById(id);
            return View(appoinment);
        }

        // POST: AppointmentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,Appoinment pAppoinment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    RepositoryAppoinment.ModifyAppoinment(pAppoinment);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AppointmentController/Delete/5
        public ActionResult Delete(int id)
        {
            Appoinment appoinment = RepositoryAppoinment.GetAppoinmentById(id);
            return View(appoinment);
        }

        // POST: AppointmentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection,Appoinment pAppoinment)
        {
            try
            {
                if (ModelState.IsValid) 
                {
                    RepositoryAppoinment.RemoveAppoinment(id);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
