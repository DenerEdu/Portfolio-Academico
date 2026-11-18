using ProjetoHortiFruti.Models;
using ProjetoHortiFruti.Services;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoHortiFruti.Controllers
{
    public class ProdutoController
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        public int Inserir(Produto produto)
        {
            string query =
                "INSERT INTO Produto (descricao, categoria, unidade_medida, preco, estoque, origem, codigo_barras) " +
                "VALUES (@Descricao, @Categoria, @UnidadeMedida, @Preco, @Estoque, @Origem, @CodigoBarras)";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Descricao", produto.Descricao);
            command.Parameters.AddWithValue("@Categoria", produto.Categoria);
            command.Parameters.AddWithValue("@UnidadeMedida", produto.UnidadeMedida);
            command.Parameters.AddWithValue("@Preco", produto.Preco);
            command.Parameters.AddWithValue("@Estoque", produto.Estoque);
            command.Parameters.AddWithValue("@Origem", produto.Origem);
            command.Parameters.AddWithValue("@CodigoBarras", produto.CodigoBarras);

            return dataBase.ExecuteSQL(command);
        }

        public int Alterar(Produto produto)
        {
            string query =
                "UPDATE Produto SET " +
                "descricao = @Descricao, " +
                "categoria = @Categoria, " +
                "unidade_medida = @UnidadeMedida, " +
                "preco = @Preco, " +
                "estoque = @Estoque, " +
                "origem = @Origem, " +
                "codigo_barras = @CodigoBarras " +
                "WHERE produto_id = @ProdutoId";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@Descricao", produto.Descricao);
            command.Parameters.AddWithValue("@Categoria", produto.Categoria);
            command.Parameters.AddWithValue("@UnidadeMedida", produto.UnidadeMedida);
            command.Parameters.AddWithValue("@Preco", produto.Preco);
            command.Parameters.AddWithValue("@Estoque", produto.Estoque);
            command.Parameters.AddWithValue("@Origem", produto.Origem);
            command.Parameters.AddWithValue("@CodigoBarras", produto.CodigoBarras);
            command.Parameters.AddWithValue("@ProdutoId", produto.ProdutoId);

            return dataBase.ExecuteSQL(command);
        }

        public int Excluir(int produtoId)
        {
            string query =
                "DELETE FROM Produto " +
                "WHERE produto_id = @ProdutoId";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@ProdutoId", produtoId);

            return dataBase.ExecuteSQL(command);
        }

        public Produto GetById(int produtoId)
        {
            string query =
                "SELECT * " +
                "FROM Produto " +
                "WHERE produto_id = @ProdutoId " +
                "ORDER BY descricao";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@ProdutoId", produtoId);

            DataTable dataTable = dataBase.GetDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                Produto produto = new Produto();
                produto.ProdutoId = (int)dataTable.Rows[0]["produto_id"];
                produto.Descricao = (string)dataTable.Rows[0]["descricao"];
                produto.Categoria = (string)dataTable.Rows[0]["categoria"];
                produto.UnidadeMedida = (string)dataTable.Rows[0]["unidade_medida"];
                produto.Preco = Convert.ToDecimal(dataTable.Rows[0]["preco"]);
                produto.Estoque = Convert.ToInt32(dataTable.Rows[0]["estoque"]);
                produto.Origem = (string)dataTable.Rows[0]["origem"];
                produto.CodigoBarras = (string)dataTable.Rows[0]["codigo_barras"];

                return produto;
            }
            else
                return null;
        }

        private ProdutoCollection GetByFilter(string filtro = "")
        {
            string query = "SELECT * FROM Produto ";

            if (filtro != "")
                query += " WHERE " + filtro;

            query += " ORDER BY descricao";

            SqlCommand command = new SqlCommand(query);

            DataTable dataTable = dataBase.GetDataTable(command);
            ProdutoCollection produtos = new ProdutoCollection();

            foreach (DataRow row in dataTable.Rows)
            {
                Produto produto = new Produto();
                produto.ProdutoId = (int)row["produto_id"];
                produto.Descricao = (string)row["descricao"];
                produto.Categoria = (string)row["categoria"];
                produto.UnidadeMedida = (string)row["unidade_medida"];
                produto.Preco = Convert.ToDecimal(row["preco"]);
                produto.Estoque = Convert.ToInt32(row["estoque"]);
                produto.Origem = (string)row["origem"];
                produto.CodigoBarras = (string)row["codigo_barras"];

                produtos.Add(produto);
            }
            return produtos;
        }

        public ProdutoCollection GetAll()
        {
            return GetByFilter();
        }

        public ProdutoCollection GetByDescricao(string value)
        {
            return GetByFilter("descricao LIKE '%" + value + "%'");
        }
    }
}
