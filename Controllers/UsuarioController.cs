using HeathCheck1.Models;
using HeathCheck1.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeathCheck1.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;


        }

        // GET: UsuarioController/Create
        public ActionResult Salvar()
        {

            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Salvar(UsuarioModel usuario)
        {

            _usuarioRepositorio.Salvar(usuario);
            return RedirectToAction("Index","Login");
        }

       

   
    }
}
