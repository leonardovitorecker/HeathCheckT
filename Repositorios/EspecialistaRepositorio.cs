using HeathCheck1.Database;
using HeathCheck1.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HeathCheck1.Repositorios
{
    public class EspecialistaRepositorio : IEspecialistaRepositorio
    {
        private readonly Context _bancocontext;

      
        public EspecialistaRepositorio(Context context)
        {
            _bancocontext = context;
        }



        public List<EspecialidadeModel> ListarEspecialidade(int id)
        {

            var lista = new List<SelectListItem>();
            var especialidades = _bancocontext.especialidades.ToList();
            try
            {
                foreach (var item in especialidades)
                {
                    var option = new SelectListItem()
                    {
                        Text = item.nome,
                        Value = item.nome,
                        Selected = (item.id == id)
                    };

                    lista.Add(option);


                }
                return especialidades;
            }

            catch (Exception ex)
            {
                throw;
            }

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


