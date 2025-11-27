using System.ComponentModel.DataAnnotations;

namespace Nabe.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required]
        public required string Nombre { get; set; }

        public string? Descripcion { get; set; }
    }
}
