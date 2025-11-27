using System.ComponentModel.DataAnnotations;

namespace Nabe.Models
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Required]
        public required string Nombre { get; set; }

        [Required]
        public required string ApellidoPaterno { get; set; }

        [Required]
        public required string ApellidoMaterno { get; set; }

        [Required]
        public required string Telefono { get; set; }

        [Required]
        [EmailAddress]
        public required string Correo { get; set; }

        [Required]
        public required string Direccion { get; set; }

        [Required]
        public required string Zona { get; set; }

        [Required]
        public required string Contrasena { get; set; }

        // ❗ OJO: ConfirmarContraseña NO se guarda en la BD, solo para validación en formularios
        [Compare("Contrasena", ErrorMessage = "Las contraseñas no coinciden.")]
        public string? ConfirmarContrasena { get; set; }

        public int? Valoracion { get; set; }
    }
}
