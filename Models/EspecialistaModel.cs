using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeathCheck1.Models
{
    public class EspecialistaModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public string? name { get; set; }
        public string? sobrenome { get; set; }

        public string? registro { get; set; }

        public string? email { get; set; }

        public string? telefone { get; set; }
        public string? senha { get; set; }

        public int especialidadeid { get; set; }

        public EspecialidadeModel? especialidade { get; set; }

     
    }
}
