using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppExercicio.Models;

namespace AppExercicio.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Usuario()
        {
            var usu = new Usuario();
            return View();
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usu)
        {
            if (string.IsNullOrEmpty(usu.Nome))
            {
                ModelState.AddModelError("Nome", "O campo nome é obrigatorio");
            }

            if (string.IsNullOrEmpty(usu.Login))
            {
                ModelState.AddModelError("Login", "O campo login é obrigatorio");
            }

            if (string.IsNullOrEmpty(usu.Senha))
            {
                ModelState.AddModelError("Senha", "O campo Senha é obrigatorio");
            }

            if (ModelState.IsValid)
            {
                return View("Resultado", usu);
            }
            return View(usu);
        }

        public ActionResult Resultado(Usuario usu)
        {
            return View(usu);
        }


      

    }
}