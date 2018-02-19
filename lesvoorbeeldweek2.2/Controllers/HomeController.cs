using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace lesvoorbeeldweek2._2.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string name)
        {
            return $"Hallo {name}";
        }
    }
}