using Nabe.Models;
using NuGet.Protocol.Plugins;
using System.Data;
using Microsoft.Data.SqlClient;
<<<<<<< HEAD
>>>>>>> ba2c87546264314666fb6ccf6c3395b02735eada
=======
>>>>>>> ba2c87546264314666fb6ccf6c3395b02735eada

namespace NABE.Data
{
    public class CategoriasDAL
    {
<<<<<<< HEAD
<<<<<<< HEAD
        private readonly NabeDbContext _context;

        public CategoriasDAL(NabeDbContext context)
        {
            _context = context;
        }

        /* ========== CONSULTAR ========== */
        public List<Categoria> Consultar(int? idCategoria = null)
        {
            var idParam = new SqlParameter("@IDCategoria",
                idCategoria.HasValue ? idCategoria : (object)DBNull.Value);

            return _context.Categorias
                .FromSqlRaw(
                    "EXEC sp_Categorias_CRUD @Operacion='S', @IDCategoria=@IDCategoria",
                    idParam)
                .AsNoTracking()
                .ToList();
        }

        /* ========== CREAR ========== */
        public int Crear(Categoria model)
        {
            var parametros = new[]
            {
                new SqlParameter("@Operacion", "I"),
                new SqlParameter("@Descripcion", model.Descripcion),
                new SqlParameter("@Estatus", model.Estatus ?? "Activo")
            };

            return _context.Database
                .SqlQueryRaw<int>(
                    "EXEC sp_Categorias_CRUD @Operacion, @Descripcion, @Estatus",
                    parametros)
                .AsEnumerable()
                .First();
        }

        /* ========== ACTUALIZAR ========== */
        public void Actualizar(Categoria model)
        {
            var parametros = new[]
            {
                new SqlParameter("@Operacion", "U"),
                new SqlParameter("@IDCategoria", model.IDCategoria),
                new SqlParameter("@Descripcion", model.Descripcion),
                new SqlParameter("@Estatus", model.Estatus)
            };

            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Categorias_CRUD @Operacion, @IDCategoria, @Descripcion, @Estatus",
                parametros);
        }

        /* ========== ELIMINAR ========== */
        public void Eliminar(int idCategoria)
        {
            var parametros = new[]
            {
                new SqlParameter("@Operacion", "D"),
                new SqlParameter("@IDCategoria", idCategoria)
            };

            _context.Database.ExecuteSqlRaw(
                "EXEC sp_Categorias_CRUD @Operacion, @IDCategoria",
                parametros);
=======
=======
>>>>>>> ba2c87546264314666fb6ccf6c3395b02735eada
        public static void CreateCategoria(CategoriaModel categoria)
        {
            try
            {
                using (SqlConnection con = new Connection().GetConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandText = "ProcCreateCategoria";
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@descripcion", categoria.descripcion);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                //e.Message
                throw;
            }
<<<<<<< HEAD
>>>>>>> ba2c87546264314666fb6ccf6c3395b02735eada
=======
>>>>>>> ba2c87546264314666fb6ccf6c3395b02735eada
        }
    }
}
