using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRM_web.Models;
using CRM_web.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Http;

namespace CRM_web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        private readonly ApplicationDbContext _context;



        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Index(Users usuario)
        {
            var US = _context.Users.Where(X => X.LoginName == usuario.LoginName).ToList();
            var Email = _context.Users.Where(X=>X.Email == usuario.LoginName).ToList();
            if (US.Count == 0 && Email.Count == 0)
            {
                ViewData["Message"] = "el usuario ingresado o email, es incorrecto";
                return View();
            }
            else
            {
                var con = US.Where(x => x.Password == usuario.Password).ToList();
                var cont = Email.Where(x => x.Password == usuario.Password).ToList();
                if (con.Count == 1 )
                {
                    int ID = con.Select(x => x.UserID).Single();
                    return RedirectToAction("MenuPrincipal", new { id = ID });     
                }
                if (cont.Count == 1)
                {
                    int IDC = cont.Select(x => x.UserID).Single();
                    return RedirectToAction("MenuPrincipal", new { id = IDC });
                }
                else
                {
                    ViewData["Message2"] = "contraseña incorrecta";
                    return View();
                }
            }
        }



        private bool UsuarioExists(string usuario, string contraseña)
        {
            return _context.Users.Any(e => e.LoginName == usuario);
        }

        public async Task<IActionResult> MenuPrincipal(int id)
        {
            var usuario = await _context.Users
                .FirstOrDefaultAsync(m => m.UserID == id);
            var usu = usuario.LoginName;
            var mj = "Hola " + usu;
            ViewData["Message"] =mj;

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
