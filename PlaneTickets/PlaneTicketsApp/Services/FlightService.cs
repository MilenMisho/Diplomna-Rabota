using PlaneTicketsApp.Abstractions;
using PlaneTicketsApp.Data;
using PlaneTicketsApp.Domain;
using PlaneTicketsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneTicketsApp.Services
{
    public class FlightService : IFlightService
    {




        private readonly ApplicationDbContext _context;
        public FlightService(ApplicationDbContext context)
        {
            _context = context;
        }





        public bool Create(int flightnumber, string startingdestination, string endingdestination, DateTime takeoffdateandtime, DateTime landingdateandtime, Plane plane, int priceperticket)
        {
            Flight item = new Flight
            {
                FlightNumber = flightnumber,
                StartingDestination = startingdestination,
                EndingDestination = startingdestination,
                TakeOffDateAndTime = takeoffdateandtime,
                LandingDateAndTime = landingdateandtime,
                Plane = plane,
                PricePerTicket = priceperticket
            };
            _context.Add(item);
            return _context.SaveChanges() != 0;
        }





       public bool UpdateFlight(int FlightId, int flightnumber, string startingdestination, string endingdestination, DateTime takeoffdateandtime, DateTime landingdateandtime, Plane plane, int priceperticket)
        {
            var flight = GetFlightById(FlightId);
            if (flight == default(Flight))
            {
                return false;
            }
            flight.FlightNumber = flightnumber;
            flight.StartingDestination = startingdestination;
            flight.EndingDestination = endingdestination;
            flight.TakeOffDateAndTime = takeoffdateandtime;
            flight.LandingDateAndTime = landingdateandtime;
            flight.Plane = plane;
            flight.PricePerTicket = priceperticket;
            _context.Update(flight);
            return _context.SaveChanges() != 0;
        }



        public Flight GetFlightById(int flightId) 
        {
            return _context.Flights.Find(flightId);
        }




        




        public bool RemoveById(int flightId)
        {
            var flight = GetFlightById(flightId);
            if (flight == default(Flight))
            {
                return false;
            }
            _context.Remove(flight);
            return _context.SaveChanges() != 0;
        }

        public List<Flight> GetFlights()
        {
            List<Flight> flights = _context.Flights.ToList();
            return flights;
        }
    }
}
