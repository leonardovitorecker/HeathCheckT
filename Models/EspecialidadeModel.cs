using HeathCheck1.Database;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeathCheck1.Models
{
    public class EspecialidadeModel
    {
        
      

        


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? nome { get; set; }
        public List<SelectListItem>? especialidades { get; set; }
        public ICollection<EspecialistaModel>? especialistas { get; set; }

        public List<SelectListItem> CarregaEspecialidades(int id)
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
                return lista;
            }

            catch (Exception ex)
            {
                throw;
            }

        }

    }
}
