using System.ComponentModel.DataAnnotations;

namespace Nabe.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public required string Nombre { get; set; }

        [Required]
        public required string Correo { get; set; }

        [Required]
        public required string Clave { get; set; }

        public int PerfilId { get; set; }

        public required Perfil Perfil { get; set; }
    }
}
