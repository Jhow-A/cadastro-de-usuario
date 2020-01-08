using CadastroUsuario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroUsuario.Controllers
{
    public class HomeController : Controller
    {
        private dbCadastroUsuarioEntities db = new dbCadastroUsuarioEntities();

        [HttpGet]
        public ActionResult CadastrarUsuario()
        {
            Cadastro model = new Cadastro();
            return View(model);
        }

        [HttpPost]
        public ActionResult CadastrarUsuario(Cadastro model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                db.Cadastro.Add(model);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Banco de Dados", "Não foi possível cadastrar o usuário");
                return View(model);
            }

            return RedirectToAction("ListarUsuarios");
        }

        public ActionResult ListarUsuarios()
        {
            return View(db.Cadastro.ToList());
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}