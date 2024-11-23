using System.ComponentModel.DataAnnotations;

namespace GerenciadorApi.ViewModels
{
    public class SignInParamVM
    {
        [Required(ErrorMessage = "E-Mail é obrigatório")]
        [EmailAddress(ErrorMessage = "E-Mail inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        public string Senha { get; set; }
    }
}