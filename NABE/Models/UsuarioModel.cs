using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nabe.Models
{
    public class UsuarioModel
    {
        public int IDUsuario { get; set; }

        [Required]
        public string Nombre { get; set; } = null!;

        [Required]
        public string ApePaterno { get; set; } = null!;

        public string? ApeMaterno { get; set; }

        [Required, EmailAddress]
        public string Correo { get; set; } = null!;

        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Referencia { get; set; }

        [Required]
        [NotMapped] // solo para el formulario
        public string Password { get; set; } = null!;

        public string? Estatus { get; set; }
    }
}