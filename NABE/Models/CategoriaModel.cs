using System.ComponentModel.DataAnnotations;

namespace Nabe.Models
{
    public class Categoria
    {
        public int Id { get; set; } // Clave primaria automática

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public required string Nombre { get; set; }

        public string? Descripcion { get; set; } // Opcional
    }
}
