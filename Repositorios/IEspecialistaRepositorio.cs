using HeathCheck1.Models;

namespace HeathCheck1.Repositorios
{
    public interface IEspecialistaRepositorio
    {
        List<EspecialistaModel> ListarEspecialistas();

       EspecialidadeModel ListarEspecialidadePorId(int id);

        EspecialistaModel SalvarEspecialista(EspecialistaModel especialista);

    }
}
