namespace Nabe.Models
{
    public class PerfilesModel
    {
        public int IDPerfil { get; set; }
        public int Clave { get; set; }
        public required string Descripcion { get; set; }
        public required string Estatus { get; set; }
    }
}
