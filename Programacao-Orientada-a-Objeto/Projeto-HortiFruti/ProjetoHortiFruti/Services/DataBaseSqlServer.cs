using System.Data;
using System.Data.SqlClient;

namespace ProjetoHortiFruti.Services
{
    public class DataBaseSqlServer
    {
        private SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString =
                "Data Source=.;" +
                "Initial Catalog=ProjetoHortiFruti;" +
                "Integrated Security=SSPI;";

            connection.Open();
            return connection;
        }

        public int ExecuteSQL(SqlCommand command)
        {
            try
            {
                command.Connection = GetConnection();
                return command.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
        }

        public object ExecuteScalar(SqlCommand command)
        {
            command.Connection = GetConnection();
            return command.ExecuteScalar();
        }

        public DataTable GetDataTable(SqlCommand command)
        {
            DataTable dataTable = new DataTable();

            command.Connection = GetConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
    }
}
