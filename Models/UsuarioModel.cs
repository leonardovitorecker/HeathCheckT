using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeathCheck1.Models
{
    public class UsuarioModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

      
        public string nomeUsuario { get; set; }

       
        public string emailUsuario { get; set; }

    
        public string senhaUsuario { get; set; }
        public List<ConsultaModel> consultas { get; set; }
    }
}
