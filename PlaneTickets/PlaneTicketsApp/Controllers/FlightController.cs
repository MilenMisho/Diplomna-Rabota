//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using PlaneTicketsApp.Abstractions;
//using PlaneTicketsApp.Data;
//using PlaneTicketsApp.Domain;
//using PlaneTicketsApp.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace PlaneTicketsApp.Controllers
//{
//    public class FlightController : Controller
//    {
//        private readonly ApplicationDbContext context;
//        public FlightController(ApplicationDbContext context)
//        {
//            this.context = context;
//        }
//        private readonly IFlightService _flightService;
//        public FlightController(IFlightService flightService)
//        {
//            this._flightService = flightService;
//        }

//        public ActionResult AllFlights()
//        {
//            List<FlightBindingAllViewModel> flights = context.FlightBindingAllViewModel
//                .Select(
//                flights => new FlightBindingAllViewModel
//                {
//                    Id = flights.Id,
//                    FlightNumber = flights.FlightNumber,
//                    StartingDestination = flights.StartingDestination,
//                    EndingDestination = flights.EndingDestination,
//                    TakeOffDateAndTime = flights.TakeOffDateAndTime,
//                    LandingDateAndTime = flights.LandingDateAndTime,
//                    Plane = flights.Plane,
//                    PricePerTicket = flights.PricePerTicket,
//                    Discount = flights.Discount
//                }).ToList();

//            return View(flights);
//        }
//        public ActionResult Details(int id)
//        {
//            return View();
//        }


//        [HttpPost]
//        public ActionResult Create(FlightBindingAllViewModel bindingModel)
//        {
//            if (ModelState.IsValid)
//            {
//                var created = _flightService.Create(bindingModel.FlightNumber, bindingModel.StartingDestination, bindingModel.EndingDestination, bindingModel.TakeOffDateAndTime, bindingModel.LandingDateAndTime, bindingModel.PlaneId, bindingModel.PricePerTicket);
//                if (created)
//                {
//                    return this.RedirectToAction("Success");
//                }
//            }
//            return this.View();
//        }


//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }


//        public ActionResult Edit(int id)
//        {
//            return View();
//        }


//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public actionresult edit(int id)
//        //{
//        //    flight item = _flightservice.getflightbyid(id);
//        //    if (item == null)
//        //    {
//        //        return notfound();
//        //    }
//        //    return view();

//        //}


//        public ActionResult Delete(int id)
//        {
//            return View();
//        }


//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//            //UDRI SIRENE!
//        }
//    }
//}
