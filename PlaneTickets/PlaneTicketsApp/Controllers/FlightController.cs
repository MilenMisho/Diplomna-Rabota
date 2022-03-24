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
    public class FlightController : Controller
    {
        private readonly ApplicationDbContext context;
        public FlightController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public ActionResult AllFlights()
        {
            List<FlightBindingAllViewModel> flights = context.FlightBindingAllViewModel
                .Select(
                flights => new FlightBindingAllViewModel
                {
                    Id = flights.Id,
                    FlightNumber = flights.FlightNumber,
                    StartingDestination = flights.StartingDestination,
                    EndingDestination = flights.EndingDestination,
                    TakeOffDateAndTime = flights.TakeOffDateAndTime,
                    LandingDateAndTime = flights.LandingDateAndTime,
                    Plane = flights.Plane,
                    PricePerTicket = flights.PricePerTicket,
                    Discount = flights.Discount
                }).ToList();

            return View(flights);
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
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

        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientController/Edit/5
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

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientController/Delete/5
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
