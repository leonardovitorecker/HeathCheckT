using HeathCheck1.Database;
using HeathCheck1.Models;

namespace HeathCheck1.Repositorios
{
    public class EspecialistaRepositorio : IEspecialistaRepositorio
    {
        private readonly Context _bancocontext;
        public EspecialistaRepositorio(Context context)
        {
            _bancocontext = context;
        }

        public EspecialidadeModel ListarEspecialidadePorId(int id)
        {
            return _bancocontext.especialidades.FirstOrDefault(x =>x.id== id);

        }

        public List<EspecialistaModel> ListarEspecialistas()
        {
            return _bancocontext.especialistas.ToList();
        }

        public EspecialistaModel SalvarEspecialista(EspecialistaModel especialista)
        {
            _bancocontext.especialistas.Add(especialista);
            _bancocontext.SaveChanges();

            return especialista;
        }
        
    }
}
