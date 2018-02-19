using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyHowest;

namespace lesvoorbeeldweek2._2.Controllers
{
    public class HomeController : Controller
    {
        private string[] groenten = { "rode kool", "spruitjes", "carote", "zurkool" };


        public ViewResult Index(string name)
        {
            ViewBag.date = DateTime.Now.Hour < 12 ? "Goeiemorgen" : "goeienamiddag";
            return View();
        }

        public ViewResult Groenten(string zoekGroente)
        {
            ViewBag.Groenten = groenten;
            if (!string.IsNullOrEmpty(zoekGroente))
                ViewBag.Zoekresultaat = $"de gezochte groente is " +
                                        $"de {Array.IndexOf(groenten, zoekGroente) + 1}e uit de lijst";
        }

        public ViewResult Student()
        {
            List<Student> studenten = new List<Student>
            {
                new Student {Id = 23, Naam = "jeff", AfstudeerGraad = Graad.Voldoening}
            new Student { Id = 23, Naam = "jeff", AfstudeerGraad = Graad.Voldoening };
        };
        ViewBag.Studenten = studenten;
            return View();
    };

    }

}
