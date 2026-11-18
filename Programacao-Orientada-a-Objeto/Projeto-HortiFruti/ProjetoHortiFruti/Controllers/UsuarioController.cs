using ProjetoHortiFruti.Models;
using ProjetoHortiFruti.Services;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoHortiFruti.Controllers
{
    public class UsuarioController
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        public int Inserir(Usuario usuario)
        {
            string query =
                "INSERT INTO Usuario (nome, cpf, telefone, email, cargo, setor, senha) " +
                "VALUES (@Nome, @Cpf, @Telefone, @Email, @Cargo, @Setor, @Senha)";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Nome", usuario.Nome);
            command.Parameters.AddWithValue("@Cpf", usuario.Cpf);
            command.Parameters.AddWithValue("@Telefone", usuario.Telefone);
            command.Parameters.AddWithValue("@Email", usuario.Email);
            command.Parameters.AddWithValue("@Cargo", usuario.Cargo);
            command.Parameters.AddWithValue("@Setor", usuario.Setor);
            command.Parameters.AddWithValue("@Senha", usuario.Senha);

            return dataBase.ExecuteSQL(command);
        }

        public int Alterar(Usuario usuario)
        {
            string query =
                "UPDATE Usuario SET " +
                "nome = @Nome, " +
                "cpf = @Cpf, " +
                "telefone = @Telefone, " +
                "email = @Email, " +
                "cargo = @Cargo, " +
                "setor = @Setor, " +
                "senha = @Senha " +
                "WHERE usuario_id = @UsuarioId";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Nome", usuario.Nome);
            command.Parameters.AddWithValue("@Cpf", usuario.Cpf);
            command.Parameters.AddWithValue("@Telefone", usuario.Telefone);
            command.Parameters.AddWithValue("@Email", usuario.Email);
            command.Parameters.AddWithValue("@Cargo", usuario.Cargo);
            command.Parameters.AddWithValue("@Setor", usuario.Setor);
            command.Parameters.AddWithValue("@Senha", usuario.Senha);
            command.Parameters.AddWithValue("@UsuarioId", usuario.UsuarioId);

            return dataBase.ExecuteSQL(command);
        }

        public int Excluir(int usuarioId)
        {
            string query =
                "DELETE FROM Usuario " +
                "WHERE usuario_id = @UsuarioId";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@UsuarioId", usuarioId);

            return dataBase.ExecuteSQL(command);
        }

        public Usuario GetById(int usuarioId)
        {
            string query =
                "SELECT * " +
                "FROM Usuario " +
                "WHERE usuario_id = @UsuarioId " +
                "ORDER BY nome";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@UsuarioId", usuarioId);

            DataTable dataTable = dataBase.GetDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                Usuario usuario = new Usuario();
                usuario.UsuarioId = (int)dataTable.Rows[0]["usuario_id"];
                usuario.Nome = (string)dataTable.Rows[0]["nome"];
                usuario.Cpf = (string)dataTable.Rows[0]["cpf"];
                usuario.Telefone = (string)dataTable.Rows[0]["telefone"];
                usuario.Email = (string)dataTable.Rows[0]["email"];
                usuario.Cargo = (string)dataTable.Rows[0]["cargo"];
                usuario.Setor = (string)dataTable.Rows[0]["setor"];
                usuario.Senha = (string)dataTable.Rows[0]["senha"];

                return usuario;
            }
            else
                return null;
        }

        public UsuarioCollection GetByFilter(string filtro = "")
        {
            string query = "SELECT * FROM Usuario ";

            if (filtro != "")
                query += " WHERE " + filtro;

            query += " ORDER BY nome";

            SqlCommand command = new SqlCommand(query);

            DataTable dataTable = dataBase.GetDataTable(command);
            UsuarioCollection usuarios = new UsuarioCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                Usuario usuario = new Usuario();
                usuario.UsuarioId = (int)row["usuario_id"];
                usuario.Nome = (string)row["nome"];
                usuario.Cpf = (string)row["cpf"];
                usuario.Telefone = (string)row["telefone"];
                usuario.Email = (string)row["email"];
                usuario.Cargo = (string)row["cargo"];
                usuario.Setor = (string)row["setor"];
                usuario.Senha = (string)row["senha"];

                usuarios.Add(usuario);
            }
            return usuarios;
        }

        public UsuarioCollection GetAll()
        {
            return GetByFilter();
        }

        public UsuarioCollection GetByName(string value)
        {
            return GetByFilter("nome LIKE '%" + value + "%'");
        }
    }
}
