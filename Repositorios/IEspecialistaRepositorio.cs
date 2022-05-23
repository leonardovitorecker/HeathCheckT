using HeathCheck1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HeathCheck1.Repositorios
{
    public interface IEspecialistaRepositorio
    {
        List<EspecialistaModel> ListarEspecialistas();

      List<EspecialidadeModel> ListarEspecialidade(int id);

        EspecialistaModel SalvarEspecialista(EspecialistaModel especialista);
       

    }
}
