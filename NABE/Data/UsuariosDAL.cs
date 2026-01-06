using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Nabe.Models;
using System.Data;
using static Microsoft.Data.SqlClient;

namespace NABE.Data
{
    public class UsuariosDAL
    {
        private readonly IConfiguration _configuration;

        public UsuariosDAL(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(
                _configuration.GetConnectionString("DefaultConnection"));
        }

        // ================= CREAR =================
        public void Crear(UsuarioModel u)
        {
            using SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand("sp_Usuarios_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", "CREAR");
            cmd.Parameters.AddWithValue("@Nombre", u.Nombre);
            cmd.Parameters.AddWithValue("@ApePaterno", u.ApePaterno);
            cmd.Parameters.AddWithValue("@ApeMaterno", (object?)u.ApeMaterno ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Correo", u.Correo);
            cmd.Parameters.AddWithValue("@Direccion", (object?)u.Direccion ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Telefono", (object?)u.Telefono ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Referencia", (object?)u.Referencia ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Password", u.Password);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        // ================= CONSULTAR =================
        public List<UsuarioModel> Consultar()
        {
            var lista = new List<UsuarioModel>();

            using SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand("sp_Usuarios_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Accion", "CONSULTAR");

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new UsuarioModel
                {
                    IDUsuario = Convert.ToInt32(dr["IDUsuario"]),
                    Nombre = dr["Nombre"].ToString()!,
                    ApePaterno = dr["ApePaterno"].ToString()!,
                    ApeMaterno = dr["ApeMaterno"]?.ToString(),
                    Correo = dr["Correo"].ToString()!,
                    Telefono = dr["Telefono"]?.ToString(),
                    Estatus = dr["Estatus"]?.ToString()
                });
            }

            return lista;
        }

        // ================= OBTENER POR ID =================
        public UsuarioModel? Obtener(int id)
        {
            using SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand("sp_Usuarios_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", "CONSULTAR");
            cmd.Parameters.AddWithValue("@IDUsuario", id);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (!dr.Read()) return null;

            return new UsuarioModel
            {
                IDUsuario = Convert.ToInt32(dr["IDUsuario"]),
                Nombre = dr["Nombre"].ToString()!,
                ApePaterno = dr["ApePaterno"].ToString()!,
                ApeMaterno = dr["ApeMaterno"]?.ToString(),
                Correo = dr["Correo"].ToString()!,
                Telefono = dr["Telefono"]?.ToString(),
                Estatus = dr["Estatus"]?.ToString()
            };
        }

        // ================= ACTUALIZAR =================
        public void Actualizar(UsuarioModel u)
        {
            using SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand("sp_Usuarios_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", "ACTUALIZAR");
            cmd.Parameters.AddWithValue("@IDUsuario", u.IDUsuario);
            cmd.Parameters.AddWithValue("@Nombre", u.Nombre);
            cmd.Parameters.AddWithValue("@ApePaterno", u.ApePaterno);
            cmd.Parameters.AddWithValue("@ApeMaterno", (object?)u.ApeMaterno ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Correo", u.Correo);
            cmd.Parameters.AddWithValue("@Direccion", (object?)u.Direccion ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Telefono", (object?)u.Telefono ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Referencia", (object?)u.Referencia ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Password",
                string.IsNullOrEmpty(u.Password) ? DBNull.Value : u.Password);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        // ================= ELIMINAR =================
        public void Eliminar(int id)
        {
            using SqlConnection conn = GetConnection();
            SqlCommand cmd = new SqlCommand("sp_Usuarios_CRUD", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Accion", "ELIMINAR");
            cmd.Parameters.AddWithValue("@IDUsuario", id);

            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
