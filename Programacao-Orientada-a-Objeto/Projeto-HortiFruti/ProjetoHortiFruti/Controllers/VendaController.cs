using ProjetoHortiFruti.Models;
using ProjetoHortiFruti.Services;
using System;
using System.Data;
using System.Data.SqlClient;

namespace ProjetoHortiFruti.Controllers
{
    public class VendaController
    {
        DataBaseSqlServer dataBase = new DataBaseSqlServer();

        public int Inserir(Venda venda)
        {
            string query =
                "INSERT INTO Venda (data_hora, cliente_id, usuario_id, status) " +
                "VALUES (@DataHora, @ClienteId, @UsuarioId, @Status);" +
                "SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@DataHora", venda.DtHora);
            command.Parameters.AddWithValue("@ClienteId", venda.Cliente.ClienteId);
            command.Parameters.AddWithValue("@UsuarioId", venda.Usuario.UsuarioId);
            command.Parameters.AddWithValue("@Status", venda.Status);

            object retorno = dataBase.ExecuteScalar(command);

            if (retorno != null)
                return Convert.ToInt32(retorno);
            else
                return 0;
        }

        public int Alterar(Venda venda)
        {
            string query =
                "UPDATE Venda SET " +
                "data_hora = @DataHora, " +
                "cliente_id = @ClienteId, " +
                "usuario_id = @UsuarioId, " +
                "status = @Status " +
                "WHERE venda_id = @VendaId";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@VendaId", venda.VendaId);
            command.Parameters.AddWithValue("@DataHora", venda.DtHora);
            command.Parameters.AddWithValue("@ClienteId", venda.Cliente.ClienteId);
            command.Parameters.AddWithValue("@UsuarioId", venda.Usuario.UsuarioId);
            command.Parameters.AddWithValue("@Status", venda.Status);

            return dataBase.ExecuteSQL(command);
        }

        public int AlterarStatus(int vendaId, char status)
        {
            string query =
                "UPDATE Venda SET " +
                "status = @Status " +
                "WHERE venda_id = @VendaId";

            SqlCommand command = new SqlCommand(query);

            command.Parameters.AddWithValue("@VendaId", vendaId);
            command.Parameters.AddWithValue("@Status", status);

            return dataBase.ExecuteSQL(command);
        }

        public int Excluir(int vendaId)
        {
            string queryItens = "DELETE FROM Venda_item WHERE venda_id = @VendaId";
            SqlCommand commandItens = new SqlCommand(queryItens);
            commandItens.Parameters.AddWithValue("@VendaId", vendaId);
            dataBase.ExecuteSQL(commandItens);

            string query = "DELETE FROM Venda WHERE venda_id = @VendaId";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@VendaId", vendaId);

            return dataBase.ExecuteSQL(command);
        }

        public Venda GetById(int vendaId)
        {
            string query = "SELECT * FROM Venda WHERE venda_id = @VendaId";

            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@VendaId", vendaId);

            DataTable dataTable = dataBase.GetDataTable(command);
            UsuarioController usuarioController = new UsuarioController();
            ClienteController clienteController = new ClienteController();

            if (dataTable.Rows.Count > 0)
            {
                Venda venda = new Venda();
                venda.VendaId = Convert.ToInt32(dataTable.Rows[0]["venda_id"]);
                venda.DtHora = Convert.ToDateTime(dataTable.Rows[0]["data_hora"]);
                venda.Cliente = clienteController.GetById(Convert.ToInt32(dataTable.Rows[0]["cliente_id"]));
                venda.Usuario = usuarioController.GetById(Convert.ToInt32(dataTable.Rows[0]["usuario_id"]));
                venda.Status = Convert.ToChar(dataTable.Rows[0]["status"]);

                return venda;
            }
            else
                return null;
        }

        private VendaCollection GetByFilter(string filtro = "")
        {
            string query = "SELECT * FROM Venda ";

            if (filtro != "")
                query += " WHERE " + filtro;

            query += " ORDER BY data_hora";

            SqlCommand command = new SqlCommand(query);

            DataTable dataTable = dataBase.GetDataTable(command);
            VendaCollection vendas = new VendaCollection();
            UsuarioController usuarioController = new UsuarioController();
            ClienteController clienteController = new ClienteController();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Venda venda = new Venda();
                venda.VendaId = Convert.ToInt32(dataRow["venda_id"]);
                venda.DtHora = Convert.ToDateTime(dataRow["data_hora"]);
                venda.Cliente = clienteController.GetById(Convert.ToInt32(dataRow["cliente_id"]));
                venda.Usuario = usuarioController.GetById(Convert.ToInt32(dataRow["usuario_id"]));
                venda.Status = Convert.ToChar(dataRow["status"]);

                vendas.Add(venda);
            }
            return vendas;
        }

        public VendaCollection GetAll()
        {
            return GetByFilter();
        }

        public VendaCollection GetByPeriodo(DateTime dtInicial, DateTime dtFinal)
        {
            DateTime dtInicialZeroHoras = dtInicial.Date;
            DateTime dtFinalUltimaHora = new DateTime(dtFinal.Year, dtFinal.Month, dtFinal.Day, 23, 59, 59);

            string where =
                "data_hora " +
                "BETWEEN '" + dtInicialZeroHoras + "' " +
                "AND '" + dtFinalUltimaHora + "' ";

            return GetByFilter(where);
        }

        public VendaCollection GetByUsuario(int usuarioId)
        {
            return GetByFilter("usuario_id = " + usuarioId);
        }

        public VendaCollection GetByCliente(int clienteId)
        {
            return GetByFilter("cliente_id = " + clienteId);
        }

        public VendaCollection GetByStatus(string status)
        {
            return GetByFilter("status = '" + status + "'");
        }

        public VendaCollection GetByVendaId(int vendaId)
        {
            VendaCollection vendaCollection = new VendaCollection();
            Venda venda = GetById(vendaId);
            if (venda != null)
                vendaCollection.Add(venda);
            return vendaCollection;
        }
    }
}
