using HeathCheck1.Database;
using HeathCheck1.Models;

namespace HeathCheck1.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly Context _bancocontext;
        public UsuarioRepositorio(Context context)
        {
            _bancocontext = context;
        }

        public List<UsuarioModel> Listar()
        {
            return _bancocontext.usuarios.ToList();
        }

        public UsuarioModel Salvar(UsuarioModel usuario)
        {
            _bancocontext.usuarios.Add(usuario);
            _bancocontext.SaveChanges();

            return usuario;
        }
    }
}
