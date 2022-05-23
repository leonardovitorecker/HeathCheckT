using HeathCheck1.Database;
using HeathCheck1.Models;

namespace HeathCheck1.Repositorios
{
    public class ConsultaRepositorio:IConsultaRepositorio
    {
        private readonly Context _bancocontext;
        public ConsultaRepositorio(Context context)
        {
            _bancocontext = context;
        }

     

    }
}
