using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autentication_crud.DataContext;
using Autentication_crud.Models;
using Autentication_crud.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Autentication_crud.Controllers
{
    public class UserController : Controller
    {
        private readonly AutenticationContext _context;
        public UserController(AutenticationContext context) => _context = context;
        
       

        //Consulta de datos de usuarios
        public async Task<ActionResult> RegisteredUsers()
        {            
            //PERMITE MOSTRAR LOS DATOS DE LOS USUARIOS CON ESTADO=1 EN TABLA
            var Usu = await _context.UserSecurity.Where(x => x.UserState == 1).Include(x => x.UserData).ToListAsync();
            return View(Usu);
        }

        public IActionResult NewUser()
        {
            return View();
        }
        //Insertando nuevos usuarios a la Base de Datos...
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NewUser(NewUserViewModel newUserViewModel)
        {

            if (ModelState.IsValid)
            {
                //Fecha del sistema
                DateTime FechaSistema = System.DateTime.Now;
                
                //Consultando usuario si existe en la Base de Datos...
                var userExist = _context.UserSecurity.Where(u => u.UserName.Equals(newUserViewModel.UserName)).ToList();
                
                if (userExist.Count.Equals(0))
                { 
                    //Modelo UserData
                    try
                    {
                        var DatosUsuarios = new UserData()
                        {
                            Name = newUserViewModel.Name,
                            LastName = newUserViewModel.LastName
                        };
                
                        _context.UserData.Add(DatosUsuarios);
                        await _context.SaveChangesAsync();

                        //Modelo UserSecurity
                        var SeguridadUsuarios = new UserSecurity()
                        {                    
                            UserName = newUserViewModel.UserName,
                            UserPassword = newUserViewModel.UserPassword,
                            UserRegisteredDate = FechaSistema,
                            UserState = 1,                    
                            UserDataId = DatosUsuarios.UserDataId
                        };

                        _context.UserSecurity.Add(SeguridadUsuarios);
                        await _context.SaveChangesAsync();

                        TempData["mensaje"] = "Usuario Registrado Exitosamente";

                        return RedirectToAction(nameof(RegisteredUsers));                                            
                    }
                    catch(Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                 
                }
                else
                {
                    TempData["mensaje"] = "El usuario ya existe.!";
                    return View();
                    
                }

            }
            return View(newUserViewModel);
        }

        //Método de Actualización de Usuario
        public IActionResult UsersUpdate(int id)
        {
            NewUserViewModel modelUser = new NewUserViewModel();
            var usuS = (from s in _context.UserSecurity
                        join d in _context.UserData
                        on s.UserDataId equals d.UserDataId

                        where s.UserSecurityId == id
                        select new NewUserViewModel
                        {
                            UserDataId = d.UserDataId,
                            UserSecurityId = s.UserSecurityId,
                            Name = d.Name,
                            LastName = d.LastName,
                            UserName = s.UserName,
                            UserPassword = s.UserPassword
                        }).ToList();

            modelUser.UserDataId = usuS[0].UserDataId;
            modelUser.UserSecurityId = usuS[0].UserSecurityId;

            modelUser.Name = usuS[0].Name;
            modelUser.LastName = usuS[0].LastName;
            modelUser.UserName = usuS[0].UserName;
            modelUser.UserPassword = usuS[0].UserPassword;

            return View(modelUser);
        }

        [HttpPost]
        public async Task<IActionResult> UsersUpdate(NewUserViewModel userViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //Consultando usuario si existe en la Base de Datos...
                    var userExistUpdate = _context.UserSecurity.Where(u => u.UserName.Equals(userViewModel.UserName)).ToList();

                    if (userExistUpdate.Count.Equals(0))
                    { 
                        var datosUsuario = _context.UserData.FirstOrDefault(d => d.UserDataId == userViewModel.UserDataId);
                        var seguridadUsuario = _context.UserSecurity.FirstOrDefault(s => s.UserSecurityId == userViewModel.UserSecurityId);

                        if(datosUsuario!=null && seguridadUsuario != null)
                        {
                            datosUsuario.Name = userViewModel.Name;
                            datosUsuario.LastName = userViewModel.LastName;
                            seguridadUsuario.UserName = userViewModel.UserName;
                            seguridadUsuario.UserPassword = userViewModel.UserPassword;

                            _context.Update(datosUsuario);
                            _context.Update(seguridadUsuario);
                            await _context.SaveChangesAsync();
                            TempData["mensajeUpdate"] = "Datos actualizados del Usuario";
                        }
                    
                    }
                    else
                    {
                        TempData["mensajeUpdateExiste"] = "No puede utilizar este usuario, Ya existe.!";
                        return View();
                    }
                }                
                return Redirect("/User/RegisteredUsers");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
