using Nabe.Models;
using NuGet.Protocol.Plugins;
using System.Data;
using Microsoft.Data.SqlClient;

namespace NABE.Data
{
    public class CategoriasDAL
    {
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
            //exito
            catch (Exception)
            {
                //e.Message
                throw;
            }
        }
    }
}
