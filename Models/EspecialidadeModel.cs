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
       
        public ICollection<EspecialistaModel>? especialistas { get; set; }

      

    }
}
