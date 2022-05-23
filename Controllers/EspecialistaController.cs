using HeathCheck1.Models;
using HeathCheck1.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeathCheck1.Controllers
{
    public class EspecialistaController : Controller
    {
        private readonly IEspecialistaRepositorio _especialistaRepositorio;

        public EspecialistaController(IEspecialistaRepositorio especialistaRepositorio)
        {
            _especialistaRepositorio = especialistaRepositorio;
         


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
            return View();
        }

        // POST: EspecialistaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EspecialistaModel especialista)
        {

            _especialistaRepositorio.SalvarEspecialista(especialista);
            return RedirectToAction("Index");
        }


       
    }
}
