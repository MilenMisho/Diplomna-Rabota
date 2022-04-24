using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaneTicketsApp.Controllers
{
    public class ForUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
