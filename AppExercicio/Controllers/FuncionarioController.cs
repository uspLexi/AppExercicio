using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppExercicio.Models;

namespace AppExercicio.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Funcionario()
        {
            var func = new Funcionario();
            return View();
        }

        [HttpPost]
        public ActionResult Funcionario(Funcionario func)
        {
            if (string.IsNullOrEmpty(func.Nome))
            {
                ModelState.AddModelError("Nome", "O campo nome é obrigatorio");
            }

            if (string.IsNullOrEmpty(func.Cargo))
            {
                ModelState.AddModelError("Nome", "O campo nome é obrigatorio");
            }

            if (ModelState.IsValid)
            {
                return View("Resultado", func);
            }
            return View(func);
        }

        public ActionResult Resultado(Funcionario func)
        {
            return View(func);
        }

    }
}