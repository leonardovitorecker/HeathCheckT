
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace HeathCheck1.Models
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _httpContext;

        public Sessao(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public EspecialistaModel BuscarSessaoDoEspecialista()
        {
            string sessaoEspecialista = _httpContext.HttpContext.Session.GetString("sessaoEspecialistaLogado");

            if (string.IsNullOrEmpty(sessaoEspecialista)) return null;

            return JsonConvert.DeserializeObject<EspecialistaModel>(sessaoEspecialista);
        }

        public UsuarioModel BuscarSessaoDoUsuario()
        {
            string sessaoUsuario = _httpContext.HttpContext.Session.GetString("sessaoUsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario)) return null;

            return JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);
        }

        public void CriarSessaoDoEspecialista(EspecialistaModel especialista)
        {
            string valor = JsonConvert.SerializeObject(especialista);

            _httpContext.HttpContext.Session.SetString("sessaoEspecialistaLogado", valor);
        }

        public void CriarSessaoDoUsuario(UsuarioModel usuario)
        {
            string valor = JsonConvert.SerializeObject(usuario);

            _httpContext.HttpContext.Session.SetString("sessaoUsuarioLogado", valor);
        }

        public void RemoverSessaoEspecialista()
        {
            _httpContext.HttpContext.Session.Remove("sessaoEspecialistaLogado");
        }

        public void RemoverSessaoUsuario()
        {
            _httpContext.HttpContext.Session.Remove("sessaoUsuarioLogado");
        }
    }
}
