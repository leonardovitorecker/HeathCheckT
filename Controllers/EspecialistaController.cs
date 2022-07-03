using HeathCheck1.Database;
using HeathCheck1.Models;
using HeathCheck1.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace HeathCheck1.Controllers
{
    public class EspecialistaController : Controller
    {
        
        private readonly IEspecialistaRepositorio _especialistaRepositorio;


        private readonly Context _bancocontext;


        public EspecialistaController(IEspecialistaRepositorio especialistaRepositorio, Context context)
        {
            _especialistaRepositorio = especialistaRepositorio;

            _bancocontext = context;

        }

        //GET:EspecialistaController/BuscarEspecialidade
        public ActionResult BuscarEspecialidade()
        {
           List<EspecialidadeModel> especialidade = _especialistaRepositorio.ListarEspecialidade();
            return View(especialidade);
          

        }

        // GET: EspecialistaController/Create
        public ActionResult Salvar()
        {
            ViewBag.especialidades = new SelectList(_bancocontext.especialidades, "id", "nome");
            return View();
        }

        // POST: EspecialistaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create( EspecialistaModel especialista)
        {

          
            _especialistaRepositorio.SalvarEspecialista(especialista);
            return RedirectToAction("Index","Login");
        }


       
    }
}
