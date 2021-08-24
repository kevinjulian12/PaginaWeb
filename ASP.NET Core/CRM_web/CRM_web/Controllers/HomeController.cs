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
        public async Task<ActionResult> Index(Usuario usuario)
        {
            var US = _context.Usuarios.Where(X => X.Usuario_ == usuario.Usuario_).ToList();
            if (US.Count == 0)
            {
                
            }
            var con = US.Where(x => x.Contraseña == usuario.Contraseña).ToList();

            if (con.Count > 0)
            {
                int ID = con.Select(x => x.id).Single();
               // await MenuPrincipal(id);
                return RedirectToAction("MenuPrincipal",new{ id = ID});
            }
            else
            {
                return Content(string.Format("No Hay Datos Asociados"));
            }
            
        }



        private bool UsuarioExists(string usuario, string contraseña)
        {
            return _context.Usuarios.Any(e => e.Usuario_ == usuario);
        }

        public async Task<IActionResult> MenuPrincipal(int id)
        {
            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.id == id);
            var usu = usuario.Usuario_;
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
