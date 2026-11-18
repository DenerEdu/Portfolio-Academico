using ProjetoHortiFruti.Models;
using ProjetoHortiFruti.Services;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoHortiFruti.Controllers
{
    public class ClienteController
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        public int Inserir(Cliente cliente)
        {
            string query =
                "INSERT INTO Cliente (nome, cpf, telefone, email, endereco, bairro, cidade) " +
                "VALUES (@Nome, @Cpf, @Telefone, @Email, @Endereco, @Bairro, @Cidade)";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@Cpf", cliente.Cpf);
            command.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            command.Parameters.AddWithValue("@Email", cliente.Email);
            command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            command.Parameters.AddWithValue("@Bairro", cliente.Bairro);
            command.Parameters.AddWithValue("@Cidade", cliente.Cidade);

            return dataBase.ExecuteSQL(command);
        }

        public int Alterar(Cliente cliente)
        {
            string query =
                "UPDATE Cliente SET " +
                "nome = @Nome, " +
                "cpf = @Cpf, " +
                "telefone = @Telefone, " +
                "email = @Email, " +
                "endereco = @Endereco, " +
                "bairro = @Bairro, " +
                "cidade = @Cidade " +
                "WHERE cliente_id = @ClienteId";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Nome", cliente.Nome);
            command.Parameters.AddWithValue("@Cpf", cliente.Cpf);
            command.Parameters.AddWithValue("@Telefone", cliente.Telefone);
            command.Parameters.AddWithValue("@Email", cliente.Email);
            command.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            command.Parameters.AddWithValue("@Bairro", cliente.Bairro);
            command.Parameters.AddWithValue("@Cidade", cliente.Cidade);
            command.Parameters.AddWithValue("@ClienteId", cliente.ClienteId);

            return dataBase.ExecuteSQL(command);
        }

        public int Excluir(int clienteId)
        {
            string query =
                "DELETE FROM Cliente " +
                "WHERE cliente_id = @ClienteId";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@ClienteId", clienteId);

            return dataBase.ExecuteSQL(command);
        }

        public Cliente GetById(int clienteId)
        {
            string query =
                "SELECT * " +
                "FROM Cliente " +
                "WHERE cliente_id = @ClienteId " +
                "ORDER BY nome";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@ClienteId", clienteId);

            DataTable dataTable = dataBase.GetDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                Cliente cliente = new Cliente();
                cliente.ClienteId = (int)dataTable.Rows[0]["cliente_id"];
                cliente.Nome = (string)dataTable.Rows[0]["nome"];
                cliente.Cpf = (string)dataTable.Rows[0]["cpf"];
                cliente.Telefone = (string)dataTable.Rows[0]["telefone"];
                cliente.Email = (string)dataTable.Rows[0]["email"];
                cliente.Endereco = (string)dataTable.Rows[0]["endereco"];
                cliente.Bairro = (string)dataTable.Rows[0]["bairro"];
                cliente.Cidade = (string)dataTable.Rows[0]["cidade"];

                return cliente;
            }
            else
                return null;
        }

        public ClienteCollection GetByFilter(string filtro = "")
        {
            string query = "SELECT * FROM Cliente ";

            if (filtro != "")
                query += " WHERE " + filtro;

            query += " ORDER BY nome";

            SqlCommand command = new SqlCommand(query);

            DataTable dataTable = dataBase.GetDataTable(command);
            ClienteCollection clientes = new ClienteCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                Cliente cliente = new Cliente();
                cliente.ClienteId = (int)row["cliente_id"];
                cliente.Nome = (string)row["nome"];
                cliente.Cpf = (string)row["cpf"];
                cliente.Telefone = (string)row["telefone"];
                cliente.Email = (string)row["email"];
                cliente.Endereco = (string)row["endereco"];
                cliente.Bairro = (string)row["bairro"];
                cliente.Cidade = (string)row["cidade"];

                clientes.Add(cliente);
            }
            return clientes;
        }

        public ClienteCollection GetAll()
        {
            return GetByFilter();
        }

        public ClienteCollection GetByName(string value)
        {
            return GetByFilter("nome LIKE '%" + value + "%'");
        }
    }
}
