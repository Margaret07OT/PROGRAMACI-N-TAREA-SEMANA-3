using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using myapp.Models;

namespace myapp.Controllers
{
 
    public class FormularioController : Controller
    {
        private readonly ILogger<FormularioController> _logger;

        public FormularioController(ILogger<FormularioController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
         public IActionResult create(Formulario objFormulario)
        {

            ViewData["Message"] = "Thanks for submitting your form";
            ViewData["Message01"] = "First Name:"+ objFormulario.firstName;
            ViewData["Message02"] = "Last Name:"+ objFormulario.lastName;
            ViewData["Message03"] = "Job Title:"+ objFormulario.jobTitle;
            ViewData["Message04"] = "Highest level of education:"+ objFormulario.level;
            ViewData["Message05"] = "Sex:"+ objFormulario.sex;
            ViewData["Message06"] = "Years of experience:"+ objFormulario.years;
            ViewData["Message07"] = "Date:"+ objFormulario.date;
            return View("success");
            
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}