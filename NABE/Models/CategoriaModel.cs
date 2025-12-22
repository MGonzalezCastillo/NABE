using System.ComponentModel.DataAnnotations;

namespace NABE.Models
{
    public class CategoriaModel
    {
<<<<<<< HEAD
        public int IDCategoria { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [MaxLength(100)]
        public string Descripcion { get; set; }

        [MaxLength(20)]
        public string Estatus { get; set; }
=======
        public int id { get; set; } // Clave primaria automática

        [Required(ErrorMessage = "Este campo es requerido")]
        [MaxLength(199, ErrorMessage = "No puede contener más de 199 caracteres")]
        [MinLength(3, ErrorMessage = "Debe contener un minimo de 3 caracteres")]
        public required string descripcion { get; set; }
>>>>>>> ba2c87546264314666fb6ccf6c3395b02735eada
    }
}
