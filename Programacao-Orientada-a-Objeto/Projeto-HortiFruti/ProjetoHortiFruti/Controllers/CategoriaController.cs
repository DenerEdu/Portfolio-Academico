using ProjetoHortiFruti.Models;
using ProjetoHortiFruti.Services;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoHortiFruti.Controllers
{
    public class CategoriaController
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        public int Inserir(Categoria categoria)
        {
            string query =
                "INSERT INTO Categoria (nome, descricao, setor, tipo_armazenamento, temperatura_ideal, perecivel, observacao) " +
                "VALUES (@Nome, @Descricao, @Setor, @TipoArmazenamento, @TemperaturaIdeal, @Perecivel, @Observacao)";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Nome", categoria.Nome);
            command.Parameters.AddWithValue("@Descricao", categoria.Descricao);
            command.Parameters.AddWithValue("@Setor", categoria.Setor);
            command.Parameters.AddWithValue("@TipoArmazenamento", categoria.TipoArmazenamento);
            command.Parameters.AddWithValue("@TemperaturaIdeal", categoria.TemperaturaIdeal);
            command.Parameters.AddWithValue("@Perecivel", categoria.Perecivel);
            command.Parameters.AddWithValue("@Observacao", categoria.Observacao);

            return dataBase.ExecuteSQL(command);
        }

        public int Alterar(Categoria categoria)
        {
            string query =
                "UPDATE Categoria SET " +
                "nome = @Nome, " +
                "descricao = @Descricao, " +
                "setor = @Setor, " +
                "tipo_armazenamento = @TipoArmazenamento, " +
                "temperatura_ideal = @TemperaturaIdeal, " +
                "perecivel = @Perecivel, " +
                "observacao = @Observacao " +
                "WHERE categoria_id = @CategoriaId";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Nome", categoria.Nome);
            command.Parameters.AddWithValue("@Descricao", categoria.Descricao);
            command.Parameters.AddWithValue("@Setor", categoria.Setor);
            command.Parameters.AddWithValue("@TipoArmazenamento", categoria.TipoArmazenamento);
            command.Parameters.AddWithValue("@TemperaturaIdeal", categoria.TemperaturaIdeal);
            command.Parameters.AddWithValue("@Perecivel", categoria.Perecivel);
            command.Parameters.AddWithValue("@Observacao", categoria.Observacao);
            command.Parameters.AddWithValue("@CategoriaId", categoria.CategoriaId);

            return dataBase.ExecuteSQL(command);
        }

        public int Excluir(int categoriaId)
        {
            string query =
                "DELETE FROM Categoria " +
                "WHERE categoria_id = @CategoriaId";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@CategoriaId", categoriaId);

            return dataBase.ExecuteSQL(command);
        }

        public Categoria GetById(int categoriaId)
        {
            string query =
                "SELECT * " +
                "FROM Categoria " +
                "WHERE categoria_id = @CategoriaId " +
                "ORDER BY nome";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@CategoriaId", categoriaId);

            DataTable dataTable = dataBase.GetDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                Categoria categoria = new Categoria();
                categoria.CategoriaId = (int)dataTable.Rows[0]["categoria_id"];
                categoria.Nome = (string)dataTable.Rows[0]["nome"];
                categoria.Descricao = (string)dataTable.Rows[0]["descricao"];
                categoria.Setor = (string)dataTable.Rows[0]["setor"];
                categoria.TipoArmazenamento = (string)dataTable.Rows[0]["tipo_armazenamento"];
                categoria.TemperaturaIdeal = (string)dataTable.Rows[0]["temperatura_ideal"];
                categoria.Perecivel = (string)dataTable.Rows[0]["perecivel"];
                categoria.Observacao = (string)dataTable.Rows[0]["observacao"];

                return categoria;
            }
            else
                return null;
        }

        public CategoriaCollection GetByFilter(string filtro = "")
        {
            string query = "SELECT * FROM Categoria ";

            if (filtro != "")
                query += " WHERE " + filtro;

            query += " ORDER BY nome";

            SqlCommand command = new SqlCommand(query);

            DataTable dataTable = dataBase.GetDataTable(command);
            CategoriaCollection categorias = new CategoriaCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                Categoria categoria = new Categoria();
                categoria.CategoriaId = (int)row["categoria_id"];
                categoria.Nome = (string)row["nome"];
                categoria.Descricao = (string)row["descricao"];
                categoria.Setor = (string)row["setor"];
                categoria.TipoArmazenamento = (string)row["tipo_armazenamento"];
                categoria.TemperaturaIdeal = (string)row["temperatura_ideal"];
                categoria.Perecivel = (string)row["perecivel"];
                categoria.Observacao = (string)row["observacao"];

                categorias.Add(categoria);
            }
            return categorias;
        }

        public CategoriaCollection GetAll()
        {
            return GetByFilter();
        }

        public CategoriaCollection GetByName(string value)
        {
            return GetByFilter("nome LIKE '%" + value + "%'");
        }
    }
}
