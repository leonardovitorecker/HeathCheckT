using HeathCheck1.Models;

namespace HeathCheck1.Repositorios
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel Salvar(UsuarioModel usuario);
        List<UsuarioModel> Listar();
    }
}
