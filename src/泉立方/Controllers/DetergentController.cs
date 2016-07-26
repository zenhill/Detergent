using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace 泉立方.Controllers
{
    public class DetergentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}