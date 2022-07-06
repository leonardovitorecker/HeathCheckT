
using HeathCheck1.Models;

namespace HeathCheck1.Models
{
    public interface ISessao
    {
        void CriarSessaoDoUsuario(UsuarioModel usuario);
        void RemoverSessaoUsuario();
        UsuarioModel BuscarSessaoDoUsuario();
        void CriarSessaoDoEspecialista(EspecialistaModel especialista);
        void RemoverSessaoEspecialista();
        EspecialistaModel BuscarSessaoDoEspecialista();

    }
}
