using System.ComponentModel.DataAnnotations;

namespace NABE.Models
{
    public class Categoria
    {
        public int IDCategoria { get; set; }

        [Required(ErrorMessage = "La descripción es obligatoria")]
        [MaxLength(100)]
        public string Descripcion { get; set; }

        [MaxLength(20)]
        public string Estatus { get; set; }
    }
}
