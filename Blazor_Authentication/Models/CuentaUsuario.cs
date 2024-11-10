using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_Authentication.Models;

public class CuentaUsuario
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

    public int Id { get; set; }
    public string? NombreUsuario { get; set; }
    public string? Contraseña { get; set; }
    public string? Rol {  get; set; }
}
