using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NABE.Models
{
    public class Proveedor
    {
        public int IDProveedor { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [MaxLength(100)]
        public string ApePaterno { get; set; }

        [MaxLength(100)]
        public string ApeMaterno { get; set; }

        [Required, EmailAddress]
        public string Correo { get; set; }

        [MaxLength(18)]
        public string CURP { get; set; }

        [MaxLength(13)]
        public string RFC { get; set; }

        [MaxLength(30)]
        public string INE { get; set; }

        [MaxLength(12)]
        public string Telefono { get; set; }

        public bool TelefonoValidado { get; set; }

        [MaxLength(200)]
        public string Empresa { get; set; }

        [MaxLength(150)]
        public string Direccion { get; set; }

        [MaxLength(200)]
        public string Referencia { get; set; }

        [MaxLength(150)]
        public string Zona { get; set; }

        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string FotoURL { get; set; }

        public string Valoracion { get; set; }

        public string Estatus { get; set; }
    }
}
