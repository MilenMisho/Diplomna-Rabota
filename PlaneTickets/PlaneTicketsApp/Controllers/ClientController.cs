using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlaneTicketsApp.Data;
using PlaneTicketsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneTicketsApp.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext context;
        public ClientController(ApplicationDbContext context)
        {
            this.context = context;
        }
        // GET: ClientController
        public ActionResult AllClients()
        {
            List<ClientBindingAllViewModel> users = context.Users
                .Select(
                clients => new ClientBindingAllViewModel
                {
                    Id = clients.Id,
                    UserName = clients.UserName,
                    FirstName = clients.FirstName,
                    LastName = clients.LastName,
                    Email = clients.Email,
                    PhoneNumber = clients.PhoneNumber
                }).ToList();

            return View(users);
        }


        public ActionResult Details(int id)
        {
            return View();
        }


        public ActionResult Create()
        {
            return View();
        }


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

        public ActionResult Edit(int id)
        {
            return View();
        }


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

        public ActionResult Delete(int id)
        {
            return View();
        }


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
