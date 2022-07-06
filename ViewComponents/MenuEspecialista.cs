using HeathCheck1.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HeathCheck1.ViewComponents
{
    public class MenuEspecialista : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string sessaoEspecialista = HttpContext.Session.GetString("sessaoEspecialistaLogado");

            if (string.IsNullOrEmpty(sessaoEspecialista)) return null;

            EspecialistaModel especialista = JsonConvert.DeserializeObject<EspecialistaModel>(sessaoEspecialista);

            return View(especialista);
        }
    }
}
