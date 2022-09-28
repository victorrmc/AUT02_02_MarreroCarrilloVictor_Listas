using AUT02_02_MarreroCarrilloVictor_Listas.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Collections.Generic;
using System.Xml.Linq;


namespace AUT02_02_MarreroCarrilloVictor_Listas.Controllers
{
    public class PersonajeController : Controller
    {
        public static List<Models.Personaje> perso = new List<Models.Personaje>() {

        new Models.Personaje() { id = 1, name = "Philp Dunphy", family = "Dunphy", nchildren = 3 },
        new Models.Personaje() { id = 2, name = "Luke Dunphy", family = "Dunphy", nchildren = 0 }

        };
        
        
       
        public IActionResult Index()
        {
            return View(perso);
        }
    }
}
