using HeathCheck1.Models;
using HeathCheck1.Repositorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HeathCheck1.Controllers
{
    public class LoginEspecialistaController : Controller
    {
        private readonly IEspecialistaRepositorio _especialistaRepositorio;
        private readonly ISessao _sessao;

        public LoginEspecialistaController(IEspecialistaRepositorio especialistaRepositorio,
                               ISessao sessao)
        {
            _especialistaRepositorio = especialistaRepositorio;
           _sessao = sessao;
        }

        // GET: HomeController1
        public ActionResult IndexEspecialista()
        {
         if (_sessao.BuscarSessaoDoEspecialista() != null) return RedirectToAction("TelaEspecialista", "Busca");
            
            return View();
        }

        public IActionResult Sair()
        {
            _sessao.RemoverSessaoEspecialista();

            return RedirectToAction("IndexEspecialista", "LoginEspecialista");

        }

        [HttpPost]
        public IActionResult Entrar(LoginEspecialistaModel loginEspecialistaModel)
    
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EspecialistaModel especialista = _especialistaRepositorio.BuscarPorLoginEspecialista(loginEspecialistaModel.nomeEspecialista);

                    if (especialista != null)
                    {
                        if (especialista.SenhaValida(loginEspecialistaModel.senha))
                        {
                            _sessao.CriarSessaoDoEspecialista(especialista);
                            return RedirectToAction("TelaEspecialista", "Busca");
                        }
                        TempData["MensagemErro"] = $"Senha do especialista inválida. Por favor, tente novamente.";
                    }


                    TempData["MensagemErro"] = $"Especialista e/ou senha inválido(s). Por favor, tente novamente.";
                }

                return View("IndexEspecialista");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos realizar seu login, tente novamante, detalhe do erro: {erro.Message}";
                return RedirectToAction("IndexEspecialista");
            }
        }

    }
      
}
