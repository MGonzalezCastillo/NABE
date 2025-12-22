using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Nabe.Models;

namespace Nabe.Data
{
    public class PerfilesDAL
    {
        private readonly NabeContext _context;

        public PerfilesDAL(NabeContext context)
        {
            _context = context;
        }

        /* ================= CONSULTAR ================= */
        public List<PerfilesModel> Consultar(int? idPerfil = null)
        {
            var idParam = new SqlParameter("@IDPerfil",
                idPerfil.HasValue ? idPerfil : (object)DBNull.Value);

            return _context.Perfiles
                .FromSqlRaw(
                    "EXEC sp_Perfiles_CRUD @Accion='CONSULTAR', @IDPerfil=@IDPerfil",
                    idParam)
                .AsNoTracking()
                .ToList();
        }

        /* ================= CREAR ================= */
        public string Crear(PerfilesModel model)
        {
            var accion = new SqlParameter("@Accion", "CREAR");
            var clave = new SqlParameter("@Clave", model.Clave);
            var descripcion = new SqlParameter("@Descripcion", model.Descripcion);

            var mensaje = _context.Database
                .SqlQueryRaw<string>(
                    "EXEC sp_Perfiles_CRUD @Accion, @Clave, @Descripcion",
                    accion, clave, descripcion)
                .AsEnumerable()
                .FirstOrDefault();

            return mensaje;
        }

        /* ================= ACTUALIZAR ================= */
        public string Actualizar(PerfilesModel model)
        {
            var parametros = new[]
            {
                new SqlParameter("@Accion", "ACTUALIZAR"),
                new SqlParameter("@IDPerfil", model.IDPerfil),
                new SqlParameter("@Clave", model.Clave),
                new SqlParameter("@Descripcion", model.Descripcion),
                new SqlParameter("@Estatus", model.Estatus ?? (object)DBNull.Value)
            };

            return _context.Database
                .SqlQueryRaw<string>(
                    "EXEC sp_Perfiles_CRUD @Accion, @IDPerfil, @Clave, @Descripcion, @Estatus",
                    parametros)
                .AsEnumerable()
                .FirstOrDefault();
        }

        /* ================= ELIMINAR ================= */
        public string Eliminar(int idPerfil)
        {
            var parametros = new[]
            {
                new SqlParameter("@Accion", "ELIMINAR"),
                new SqlParameter("@IDPerfil", idPerfil)
            };

            return _context.Database
                .SqlQueryRaw<string>(
                    "EXEC sp_Perfiles_CRUD @Accion, @IDPerfil",
                    parametros)
                .AsEnumerable()
                .FirstOrDefault();
        }
    }
}
