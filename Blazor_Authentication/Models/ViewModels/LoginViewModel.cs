using System.ComponentModel.DataAnnotations;

namespace Blazor_Authentication.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor Escriba el nombre de usuario")]
        public string? NombreUsuario { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Por favor Escriba la contraseña")]
        public string? Contraseña { get; set; }
    }
}
