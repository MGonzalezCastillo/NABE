using System.ComponentModel.DataAnnotations;

namespace Nabe.Models
{
    public class PerfilesModel
    {
        public int IDPerfil { get; set; }

        [Required]
        public decimal Clave { get; set; }

        [Required]
        [MaxLength(20)]
        public string Descripcion { get; set; }

        public string Estatus { get; set; }
    }
}
