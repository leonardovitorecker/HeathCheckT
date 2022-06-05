using HeathCheck1.Database;
using HeathCheck1.Models;
using HeathCheck1.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HeathCheck1.Controllers
{
    public class AgendamentoController : Controller
    {

        private readonly IConsultaRepositorio _consultaRepositorio;


        private readonly Context _bancocontext;


        public AgendamentoController(IConsultaRepositorio consultaRepositorio, Context context)
        {
            _consultaRepositorio = consultaRepositorio;

            _bancocontext = context;

        }


        // GET: AgendamentoController/Salvar
        public ActionResult Salvar()
        {

            return View();
        }

        // POST: EspecialistaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ConsultaModel consulta)
        {


            _consultaRepositorio.SalvarConsulta(consulta);
            return RedirectToAction("Index");
        }
    }
}
