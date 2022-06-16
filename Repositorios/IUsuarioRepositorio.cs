using HeathCheck1.Models;

namespace HeathCheck1.Repositorios
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarPorLogin(string nomeUsuario);
        UsuarioModel Salvar(UsuarioModel usuario);
        List<UsuarioModel> Listar();
    }
}
