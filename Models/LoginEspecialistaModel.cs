using System.ComponentModel.DataAnnotations;

namespace HeathCheck1.Models
{
    public class LoginEspecialistaModel
    {
        [Required(ErrorMessage = "Digite o nome do especialista")]
        public string nomeEspecialista { get; set; }
        [Required(ErrorMessage = "Digite a senha")]
        public string senha { get; set; }
    }
}
