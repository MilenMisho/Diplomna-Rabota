using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlaneTicketsApp.Data;
using PlaneTicketsApp.Domain;
using PlaneTicketsApp.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PlaneTicketsApp.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext context;

        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpPost]

        public IActionResult Create(OrderCreateVM bindingModel)
        {
            if (this.ModelState.IsValid)
            {
                string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                var user = this.context.Users.SingleOrDefault(u => u.Id == userId);
                var ev = this.context.Flights.SingleOrDefault(e => e.Id == bindingModel.FlightId);

                if (user == null || ev == null || ev.CountTickets < bindingModel.TicketNumber)
                {

                    return this.RedirectToAction("Index", "Flights");
                }
                Reserve orderForDb = new Reserve
                {
                    DateOfReservation = DateTime.UtcNow,

                    FlightId = ev.Id,
                    UserId = userId,
                    TicketNumber = bindingModel.TicketNumber,
                    Price = ev.PricePerTicket,
                    Discount = ev.Discount,


                };

                ev.CountTickets -= bindingModel.TicketNumber;
                this.context.Flights.Update(ev);
                this.context.Reservations.Add(orderForDb);
                this.context.SaveChanges();
            }
            return this.RedirectToAction("Index", "Flights");
        }
        [Authorize(Roles = "Administrator")]
        public IActionResult Index()
        {
            string userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = context.Users.SingleOrDefault(u => u.Id == userId);

            List<OrderAllVM> orders = context
                 .Reservations
                 .Select(x => new OrderAllVM
                 {
                     Id = x.Id,
                     DateOfReservation = x.DateOfReservation.ToString("dd-mm-yyyy hh:mm", CultureInfo.InvariantCulture),
                     FlightId = x.Id,
                     FlightNumber = x.Flight.FlightNumber,
                     Plane = x.Flight.Plane.PlaneNumber,
                     Picture = x.Flight.Plane.Picture,



                     User = x.User.UserName,

                     CountTickets = x.TicketNumber,
                     PricePerTicket = x.Price,
                     Discount = x.Discount,
                     TotalPrice = x.TotalPrice,


                 }).ToList();

            return View(orders);
        }
        [Authorize]
        public IActionResult My(string searchString)
        {
            string currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = this.context.Users.SingleOrDefault(u => u.Id == currentUserId);
            if (user == null)
            {
                return null;
            }
            List<OrderAllVM> orders = this.context.Reservations
               .Where(x => x.UserId == user.Id)

                  .Select(x => new OrderAllVM
                  {
                      Id = x.Id,
                      DateOfReservation = x.DateOfReservation.ToString("dd-mm-yyyy hh:mm", CultureInfo.InvariantCulture),
                      FlightId = x.Id,
                      FlightNumber=x.Flight.FlightNumber,
                      Plane=x.Flight.Plane.PlaneNumber,
                      Picture=x.Flight.Plane.Picture,



                      User = x.User.UserName,

                      CountTickets = x.TicketNumber,
                      PricePerTicket = x.Price,
                      Discount = x.Discount,
                      TotalPrice = x.TotalPrice,


                  }).ToList();

            //if (!String.IsNullOrEmpty(searchString))
            //{
            //    orders = orders.Where(o => o.Model.Contains(searchString)).ToList();
            //}
            return this.View(orders);
        }
    }
}