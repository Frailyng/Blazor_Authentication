using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_Authentication.Models;

[Table("user_account")]
public class CuentaUsuario
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]

    public int Id { get; set; }

    [Column("nombre_usuario")]
    [MaxLength(100)]

    public string? NombreUsuario { get; set; }

    [Column("contraseña")]
    [MaxLength(100)]

    public string? Contraseña { get; set; }

    [Column("rol")]
    [MaxLength(20)]

    public string? Rol {  get; set; }
}
