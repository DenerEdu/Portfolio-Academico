using ProjetoHortiFruti.Models;
using ProjetoHortiFruti.Services;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoHortiFruti.Controllers
{
    public class FornecedorController
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        public int Inserir(Fornecedor fornecedor)
        {
            string query =
                "INSERT INTO Fornecedor (razao_social, nome_fantasia, cnpj, telefone, email, endereco, cidade) " +
                "VALUES (@RazaoSocial, @NomeFantasia, @Cnpj, @Telefone, @Email, @Endereco, @Cidade)";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@RazaoSocial", fornecedor.RazaoSocial);
            command.Parameters.AddWithValue("@NomeFantasia", fornecedor.NomeFantasia);
            command.Parameters.AddWithValue("@Cnpj", fornecedor.Cnpj);
            command.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);
            command.Parameters.AddWithValue("@Email", fornecedor.Email);
            command.Parameters.AddWithValue("@Endereco", fornecedor.Endereco);
            command.Parameters.AddWithValue("@Cidade", fornecedor.Cidade);

            return dataBase.ExecuteSQL(command);
        }

        public int Alterar(Fornecedor fornecedor)
        {
            string query =
                "UPDATE Fornecedor SET " +
                "razao_social = @RazaoSocial, " +
                "nome_fantasia = @NomeFantasia, " +
                "cnpj = @Cnpj, " +
                "telefone = @Telefone, " +
                "email = @Email, " +
                "endereco = @Endereco, " +
                "cidade = @Cidade " +
                "WHERE fornecedor_id = @FornecedorId";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@RazaoSocial", fornecedor.RazaoSocial);
            command.Parameters.AddWithValue("@NomeFantasia", fornecedor.NomeFantasia);
            command.Parameters.AddWithValue("@Cnpj", fornecedor.Cnpj);
            command.Parameters.AddWithValue("@Telefone", fornecedor.Telefone);
            command.Parameters.AddWithValue("@Email", fornecedor.Email);
            command.Parameters.AddWithValue("@Endereco", fornecedor.Endereco);
            command.Parameters.AddWithValue("@Cidade", fornecedor.Cidade);
            command.Parameters.AddWithValue("@FornecedorId", fornecedor.FornecedorId);

            return dataBase.ExecuteSQL(command);
        }

        public int Excluir(int fornecedorId)
        {
            string query =
                "DELETE FROM Fornecedor " +
                "WHERE fornecedor_id = @FornecedorId";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@FornecedorId", fornecedorId);

            return dataBase.ExecuteSQL(command);
        }

        public Fornecedor GetById(int fornecedorId)
        {
            string query =
                "SELECT * " +
                "FROM Fornecedor " +
                "WHERE fornecedor_id = @FornecedorId " +
                "ORDER BY razao_social";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@FornecedorId", fornecedorId);

            DataTable dataTable = dataBase.GetDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.FornecedorId = (int)dataTable.Rows[0]["fornecedor_id"];
                fornecedor.RazaoSocial = (string)dataTable.Rows[0]["razao_social"];
                fornecedor.NomeFantasia = (string)dataTable.Rows[0]["nome_fantasia"];
                fornecedor.Cnpj = (string)dataTable.Rows[0]["cnpj"];
                fornecedor.Telefone = (string)dataTable.Rows[0]["telefone"];
                fornecedor.Email = (string)dataTable.Rows[0]["email"];
                fornecedor.Endereco = (string)dataTable.Rows[0]["endereco"];
                fornecedor.Cidade = (string)dataTable.Rows[0]["cidade"];

                return fornecedor;
            }
            else
                return null;
        }

        public FornecedorCollection GetByFilter(string filtro = "")
        {
            string query = "SELECT * FROM Fornecedor ";

            if (filtro != "")
                query += " WHERE " + filtro;

            query += " ORDER BY razao_social";

            SqlCommand command = new SqlCommand(query);

            DataTable dataTable = dataBase.GetDataTable(command);
            FornecedorCollection fornecedores = new FornecedorCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.FornecedorId = (int)row["fornecedor_id"];
                fornecedor.RazaoSocial = (string)row["razao_social"];
                fornecedor.NomeFantasia = (string)row["nome_fantasia"];
                fornecedor.Cnpj = (string)row["cnpj"];
                fornecedor.Telefone = (string)row["telefone"];
                fornecedor.Email = (string)row["email"];
                fornecedor.Endereco = (string)row["endereco"];
                fornecedor.Cidade = (string)row["cidade"];

                fornecedores.Add(fornecedor);
            }
            return fornecedores;
        }

        public FornecedorCollection GetAll()
        {
            return GetByFilter();
        }

        public FornecedorCollection GetByRazaoSocial(string value)
        {
            return GetByFilter("razao_social LIKE '%" + value + "%'");
        }
    }
}
