using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NABE.Models;

namespace NABE.Data
{
    public class ProveedoresDAL
    {
        private readonly NabeContext _context;

        public ProveedoresDAL(NabeContext context)
        {
            _context = context;
        }

        /* ================= CONSULTAR ================= */
        public List<Proveedor> Consultar(int? idProveedor = null)
        {
            var paramId = new SqlParameter("@IDProveedor",
                idProveedor.HasValue ? idProveedor : (object)DBNull.Value);

            return _context.Proveedores
                .FromSqlRaw(
                    "EXEC sp_Proveedores_CRUD @Accion='CONSULTAR', @IDProveedor=@IDProveedor",
                    paramId)
                .AsNoTracking()
                .ToList();
        }

        /* ================= CREAR ================= */
        public string Crear(Proveedor model)
        {
            var parametros = new[]
            {
                new SqlParameter("@Accion", "CREAR"),
                new SqlParameter("@Nombre", model.Nombre),
                new SqlParameter("@ApePaterno", model.ApePaterno ?? (object)DBNull.Value),
                new SqlParameter("@ApeMaterno", model.ApeMaterno ?? (object)DBNull.Value),
                new SqlParameter("@Correo", model.Correo),
                new SqlParameter("@CURP", model.CURP ?? (object)DBNull.Value),
                new SqlParameter("@RFC", model.RFC ?? (object)DBNull.Value),
                new SqlParameter("@INE", model.INE ?? (object)DBNull.Value),
                new SqlParameter("@Telefono", model.Telefono ?? (object)DBNull.Value),
                new SqlParameter("@TelefonoValidado", model.TelefonoValidado),
                new SqlParameter("@Empresa", model.Empresa ?? (object)DBNull.Value),
                new SqlParameter("@Direccion", model.Direccion ?? (object)DBNull.Value),
                new SqlParameter("@Referencia", model.Referencia ?? (object)DBNull.Value),
                new SqlParameter("@Zona", model.Zona ?? (object)DBNull.Value),
                new SqlParameter("@Password", model.Password),
                new SqlParameter("@FotoURL", model.FotoURL),
                new SqlParameter("@Valoracion", model.Valoracion ?? (object)DBNull.Value),
                new SqlParameter("@Estatus", "Activo")
            };

            return _context.Database
                .SqlQueryRaw<string>(
                    @"EXEC sp_Proveedores_CRUD
                      @Accion, @Nombre, @ApePaterno, @ApeMaterno, @Correo, @CURP, @RFC,
                      @INE, @Telefono, @TelefonoValidado, @Empresa, @Direccion,
                      @Referencia, @Zona, @Password, @FotoURL, @Valoracion, @Estatus",
                    parametros)
                .AsEnumerable()
                .FirstOrDefault();
        }
    }
}
