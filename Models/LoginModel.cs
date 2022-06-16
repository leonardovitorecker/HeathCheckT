using System.ComponentModel.DataAnnotations;

namespace HeathCheck1.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite o nome do usuario")]
        public string nomeUsuario { get; set; }
        [Required(ErrorMessage = "Digite a senha")]
        public string senha { get; set; }
    }
}
