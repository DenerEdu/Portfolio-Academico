using ProjetoHortiFruti.Models;
using ProjetoHortiFruti.Services;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoHortiFruti.Controllers
{
    public class VendaItemController
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        public int Inserir(VendaItem vendaItem)
        {
            string query =
                "INSERT INTO Venda_item (venda_id, produto_id, quantidade, valor_unitario) " +
                "VALUES (@VendaId, @ProdutoId, @Quantidade, @ValorUnitario);";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@VendaId", vendaItem.Venda.VendaId);
            command.Parameters.AddWithValue("@ProdutoId", vendaItem.Produto.ProdutoId);
            command.Parameters.AddWithValue("@Quantidade", vendaItem.Quantidade);
            command.Parameters.AddWithValue("@ValorUnitario", vendaItem.ValorUnitario);

            return dataBase.ExecuteSQL(command);
        }

        public int Alterar(VendaItem vendaItem)
        {
            string query =
                "UPDATE Venda_item SET " +
                "produto_id = @ProdutoId, " +
                "quantidade = @Quantidade, " +
                "valor_unitario = @ValorUnitario " +
                "WHERE venda_id = @VendaId " +
                "AND venda_item_id = @VendaItemId";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@ProdutoId", vendaItem.Produto.ProdutoId);
            command.Parameters.AddWithValue("@Quantidade", vendaItem.Quantidade);
            command.Parameters.AddWithValue("@ValorUnitario", vendaItem.ValorUnitario);
            command.Parameters.AddWithValue("@VendaId", vendaItem.Venda.VendaId);
            command.Parameters.AddWithValue("@VendaItemId", vendaItem.VendaItemId);

            return dataBase.ExecuteSQL(command);
        }

        public int Excluir(int VendaId, int VendaItemId)
        {
            string query =
                "DELETE FROM Venda_item " +
                "WHERE venda_id = @VendaId " +
                "AND venda_item_id = @VendaItemId";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@VendaId", VendaId);
            command.Parameters.AddWithValue("@VendaItemId", VendaItemId);

            return dataBase.ExecuteSQL(command);
        }

        private VendaItemCollection GetByFilter(string filtro = "")
        {
            string query = "SELECT * FROM Venda_item ";

            if (filtro != "")
                query += " WHERE " + filtro;

            SqlCommand command = new SqlCommand(query);

            DataTable dataTable = dataBase.GetDataTable(command);
            VendaItemCollection vendaItens = new VendaItemCollection();
            ProdutoController produtoController = new ProdutoController();
            VendaController vendaController = new VendaController();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                VendaItem vendaItem = new VendaItem();
                vendaItem.VendaItemId = Convert.ToInt32(dataRow["venda_item_id"]);
                vendaItem.Venda = vendaController.GetById(Convert.ToInt32(dataRow["venda_id"]));
                vendaItem.Produto = produtoController.GetById(Convert.ToInt32(dataRow["produto_id"]));
                vendaItem.Quantidade = Convert.ToInt32(dataRow["quantidade"]);
                vendaItem.ValorUnitario = Convert.ToDecimal(dataRow["valor_unitario"]);

                vendaItens.Add(vendaItem);
            }
            return vendaItens;
        }

        public VendaItemCollection GetByVenda(int vendaId)
        {
            return GetByFilter("venda_id = " + vendaId);
        }
    }
}
