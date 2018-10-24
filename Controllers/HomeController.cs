using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel.Models;

namespace ViewModel.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            User Message = new User()
            {
                message = "You'll Never Walk Alone"
            };
            return View("Index", Message);
        }
        [HttpGet]
        [Route("Numbers")]
        public IActionResult Numbers()
        {
            User Numbers = new User()
            {
                numbers = new int[] {1, 2, 3, 10, 43, 5}
            };
            return View("Numbers", Numbers);
        }
        [HttpGet]
        [Route("Peoples")]
        public IActionResult Peoples()
        {
            User Peoples = new User()
            {
                peoples = new string[] {"Moose Phillips", "Sarah", "Jerry", "Rene Ricky", "Barbarah"}
            };
            return View("Peoples", Peoples);
        }
        [HttpGet]
        [Route("Person")]
        public IActionResult Person()
        {
            User Peoples = new User()
            {
                peoples = new string[] {"Moose Phillips", "Sarah", "Jerry", "Rene Ricky", "Barbarah"}
            };
            return View("Person", Peoples);
        }
    }
}
