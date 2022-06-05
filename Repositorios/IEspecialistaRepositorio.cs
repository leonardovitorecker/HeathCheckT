using HeathCheck1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HeathCheck1.Repositorios
{
    public interface IEspecialistaRepositorio
    {
        List<EspecialistaModel> ListarEspecialistas();

   

        EspecialistaModel SalvarEspecialista(EspecialistaModel especialista);
       
       
    }
}
