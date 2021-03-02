using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Autentication_crud.Models;
using Autentication_crud.DataContext;
using Microsoft.AspNetCore.Mvc.Rendering;
using Autentication_crud.ViewModels;

namespace Autentication_crud.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly AutenticationContext _context;
        public HomeController(AutenticationContext context) => _context = context;
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;            
        //}

        public IActionResult Index()
        {
            //DropDownList

            /*
            List<UserData> liData = new List<UserData>();
            liData = (from UserData in _context.UserData select UserData).ToList();

            liData.Insert(0, new UserData { UserDataId = 0, Name = "Select" });


            ViewBag.mostrar=liData;*/

            List<UserData> liData = new List<UserData>();
            liData = _context.UserData.ToList();
            ViewBag.mostrar = liData;

            //var guardarNombre = new NombreTest();
            return View();
        }
        [HttpPost]
        public IActionResult Index(UserDataViewModels model)
        {
            var persona = new NombreTest()
            {
                NombreUserDataId = model.UserDataId
            };

            _context.NombreTest.Add(persona);
            _context.SaveChanges();
            return Redirect("../User/RegisteredUsers");            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
