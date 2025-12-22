namespace Microsoft
{
    public class Data
    {
        public class SqlClient
        {
            internal class SqlConnection
            {
                private string connectionString;

                public SqlConnection(string connectionString)
                {
                    this.connectionString = connectionString;
                }
            }
        }
    }
}