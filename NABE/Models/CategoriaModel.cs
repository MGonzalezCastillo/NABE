using System.ComponentModel.DataAnnotations;

namespace Nabe.Models
{
    public class CategoriaModel
    {
        public int id { get; set; } // Clave primaria automática

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(199, ErrorMessage = "No puede contener más de 199 caracteres")]
        [MinLength(3, ErrorMessage = "Debe contener un minimo de 3 caracteres")]
        public required string descripcion { get; set; }
    }
}
