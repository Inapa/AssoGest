
using System.Collections.Generic;

using AssoGest.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssoGest.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Name = "Elec" });
            list.Add(new Departamento { Id = 2, Name = "HR" });
            return View(list);
        }
    }
}