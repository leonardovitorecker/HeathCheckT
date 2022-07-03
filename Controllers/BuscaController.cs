
using HeathCheck1.Database;
using HeathCheck1.Models;
using HeathCheck1.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace HeathCheck1.Controllers
{
    public class BuscaController : Controller
    {
       
        private readonly IEspecialistaRepositorio _especialistaRepositorio;


        private readonly Context _bancocontext;


        public BuscaController(IEspecialistaRepositorio especialistaRepositorio, Context context)
        {
            _especialistaRepositorio = especialistaRepositorio;

            _bancocontext = context;

        }
        public IActionResult BuscaEspecialista()
        {
            
            return View();

            
        }
        
        public IActionResult ListarEspecialista(string searchstring)
        {
           

            var especialista = from m in _bancocontext.especialistas
                               select m;

            if (!String.IsNullOrEmpty(searchstring))
            {
                especialista = especialista.Where(s => s.name.Contains(searchstring));
            }

            return View(especialista);
        }
      
    }
}
