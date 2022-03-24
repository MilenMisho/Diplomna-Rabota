using Microsoft.EntityFrameworkCore;
using PlaneTicketsApp.Data;
using PlaneTicketsApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneTicketsApp.Abstractions
{
    public interface IFlightService
    {
       public bool Create(int flightnumber, string startingdestination, string endingdestination, int takeoffdateandtime, int landingdateandtime, string plane, int priceperticket);
       bool UpdateFlight(int id, int flightnumber, string startingdestination, string endingdestination, int takeoffdateandtime, int landingdateandtime, string plane, int priceperticket);
       List<Flight> GetFlights();
       Flight GetFlightById(int flightId);
       bool RemoveById(int Id);
    }
}
