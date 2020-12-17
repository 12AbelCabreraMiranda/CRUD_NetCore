using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autentication_crud.DataContext;
using Autentication_crud.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Autentication_crud.Controllers
{
    public class LoginController : Controller
    {
        private readonly AutenticationContext _context;
        public LoginController(AutenticationContext context) => _context = context;

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModels loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var userAut = _context.UserSecurity
                    .Where(x => x.UserName == loginViewModel.UserName && x.UserPassword == loginViewModel.UserPassword)
                    .FirstOrDefault();

                if (userAut != null)
                {                    
                    //Session["User"] = $"{userAut.UserName}";
                    return Redirect("/User/RegisteredUsers");
                }
                else {
                    TempData["UserIncorrecto"] = "Usuario o Contraseña no válido.!";
                    return View(loginViewModel); 
                }
            }
            return View(loginViewModel);
        }
    }
}
