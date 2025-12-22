using Microsoft.Data.SqlClient;


namespace NABE.Data
{
    public class Connection
    {
        public SqlConnection GetConnection() {

            string ConnectionString = string.Empty;

            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            ConnectionString = builder.GetSection("ConnectionStrings:ConnectionBD").Value;

            return new SqlConnection(ConnectionString);
        }
    }
}
