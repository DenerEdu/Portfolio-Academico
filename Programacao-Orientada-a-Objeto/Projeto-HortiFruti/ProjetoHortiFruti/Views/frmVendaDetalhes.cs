using ProjetoHortiFruti.Controllers;
using ProjetoHortiFruti.Models;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace ProjetoHortiFruti.Views
{
    public partial class frmVendaDetalhes : Form
    {
        Venda vendaSelecionada;
        VendaItemController vendaItemController = new VendaItemController();

        public frmVendaDetalhes(Venda venda)
        {
            InitializeComponent();
            dgvVendaItens.AutoGenerateColumns = false;

            vendaSelecionada = venda;
        }

        private void frmVendaDetalhes_Load(object sender, EventArgs e)
        {
            CarregarDadosVenda();
            CarregarItens();
        }

        #region CarregarPropriedade
        private object CarregarPropriedade(object propriedade, string nomeDaPropriedade)
        {
            try
            {
                object retorno = "";

                if (nomeDaPropriedade.Contains("."))
                {
                    PropertyInfo[] propertyInfoArray;
                    string propriedadeAntesDoPonto;

                    propriedadeAntesDoPonto = nomeDaPropriedade.Substring(0, nomeDaPropriedade.IndexOf("."));

                    if (propriedade != null)
                    {
                        propertyInfoArray = propriedade.GetType().GetProperties();

                        foreach (PropertyInfo propertyInfo in propertyInfoArray)
                        {
                            if (propertyInfo.Name == propriedadeAntesDoPonto)
                            {
                                retorno = CarregarPropriedade(propertyInfo.GetValue(propriedade, null),
                                    nomeDaPropriedade.Substring(nomeDaPropriedade.IndexOf(".") + 1));
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Type typeProperty;
                    PropertyInfo propertyInfo;

                    if (propriedade != null)
                    {
                        typeProperty = propriedade.GetType();
                        propertyInfo = typeProperty.GetProperty(nomeDaPropriedade);
                        retorno = propertyInfo.GetValue(propriedade, null);
                    }
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private void dgvVendaItens_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dgvVendaItens.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dgvVendaItens.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = CarregarPropriedade(dgvVendaItens.Rows[e.RowIndex].DataBoundItem,
                        dgvVendaItens.Columns[e.ColumnIndex].DataPropertyName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void CarregarDadosVenda()
        {
            txtUsuarioId.Text = vendaSelecionada.Usuario.UsuarioId.ToString();
            txtNomeUsuario.Text = vendaSelecionada.Usuario.Nome;
            txtClienteId.Text = vendaSelecionada.Cliente.ClienteId.ToString();
            txtNomeCliente.Text = vendaSelecionada.Cliente.Nome;
            txtVendaId.Text = vendaSelecionada.VendaId.ToString();
            txtDataHora.Text = vendaSelecionada.DtHora.ToShortDateString();
        }

        private void CarregarItens()
        {
            dgvVendaItens.DataSource = null;
            dgvVendaItens.DataSource = vendaItemController.GetByVenda(vendaSelecionada.VendaId);
            dgvVendaItens.Update();
            dgvVendaItens.Refresh();
        }
    }
}
