using ProjetoHortiFruti.Controllers;
using ProjetoHortiFruti.Models;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace ProjetoHortiFruti.Views
{
    public partial class frmVenda : Form
    {
        Usuario usuarioVenda;
        Cliente clienteVenda;
        Produto produtoVenda;

        Venda venda;

        VendaController vendaController = new VendaController();
        VendaItemController vendaItemController = new VendaItemController();

        public frmVenda()
        {
            InitializeComponent();
            dgvVendaItens.AutoGenerateColumns = false;
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
                MessageBox.Show(ex.Message, "Atenção...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show(ex.Message, "Atenção...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void PesquisarUsuario()
        {
            frmUsuarioSelecao frm = new frmUsuarioSelecao(true);
            DialogResult dialogResult = frm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                usuarioVenda = frm.usuarioSelecao;

                txtUsuarioId.Text = usuarioVenda.UsuarioId.ToString();
                txtNomeUsuario.Text = usuarioVenda.Nome;
            }
        }

        private void PesquisarCliente()
        {
            frmClienteSelecao frm = new frmClienteSelecao(true);
            DialogResult dialogResult = frm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                clienteVenda = frm.clienteSelecao;

                txtClienteId.Text = clienteVenda.ClienteId.ToString();
                txtNomeCliente.Text = clienteVenda.Nome;
            }
        }

        private void PesquisarProduto()
        {
            frmProdutoSelecao frm = new frmProdutoSelecao(true);
            DialogResult dialogResult = frm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                produtoVenda = frm.produtoSelecao;

                txtProdutoId.Text = produtoVenda.ProdutoId.ToString();
                txtDescricao.Text = produtoVenda.Descricao;

                txtQuantidadeItem.Focus();
            }
        }

        private void AtualizarGrade(int vendaId)
        {
            dgvVendaItens.DataSource = null;
            dgvVendaItens.DataSource = vendaItemController.GetByVenda(vendaId);
            dgvVendaItens.Update();
            dgvVendaItens.Refresh();
        }

        private void AdicionarItem()
        {
            if (usuarioVenda == null)
            {
                MessageBox.Show("É necessário selecionar o usuário.", "Atenção...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnPesquisarUsuario.Focus();
                return;
            }

            if (clienteVenda == null)
            {
                MessageBox.Show("É necessário selecionar o cliente.", "Atenção...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnPesquisarCliente.Focus();
                return;
            }

            if (produtoVenda == null)
            {
                MessageBox.Show("É necessário selecionar o produto.", "Atenção...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnPesquisarProduto.Focus();
                return;
            }

            int quantidade = 0;
            if (int.TryParse(txtQuantidadeItem.Text, out quantidade) && (quantidade > 0) && (quantidade <= 99))
            {
                if (venda == null)
                {
                    venda = new Venda();
                    venda.Usuario = usuarioVenda;
                    venda.Cliente = clienteVenda;
                    venda.DtHora = DateTime.Now;
                    venda.Status = 'P';

                    venda.VendaId = vendaController.Inserir(venda);

                    txtVendaId.Text = venda.VendaId.ToString();
                    txtDataHora.Text = venda.DtHora.ToString();
                }

                VendaItem vendaItem = new VendaItem();
                vendaItem.Venda = venda;
                vendaItem.Produto = produtoVenda;
                vendaItem.Quantidade = quantidade;
                vendaItem.ValorUnitario = produtoVenda.Preco;

                if (vendaItemController.Inserir(vendaItem) > 0)
                {
                    AtualizarGrade(venda.VendaId);

                    produtoVenda = null;
                    txtProdutoId.Clear();
                    txtDescricao.Clear();
                    txtQuantidadeItem.Text = "1";
                }
                else
                {
                    MessageBox.Show("Falha ao inserir produto!", "Atenção...",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnPesquisarProduto.Focus();
                }
            }
            else
            {
                MessageBox.Show("A quantidade deve ser um número inteiro, maior que 0 (zero) e menor ou igual a 99.", "Atenção...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidadeItem.Focus();
            }
        }

        VendaItem GetVendaItem()
        {
            if (dgvVendaItens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.", "Informação...",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else
                return (dgvVendaItens.SelectedRows[0].DataBoundItem as VendaItem);
        }

        private void RemoverItem()
        {
            VendaItem itemSelecionado = GetVendaItem();

            if (itemSelecionado == null)
                return;

            if (MessageBox.Show("Deseja realmente remover este produto?", "Confirmação...",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                vendaItemController.Excluir(venda.VendaId, itemSelecionado.VendaItemId);
                AtualizarGrade(venda.VendaId);
            }
        }

        private void FinalizarVenda()
        {
            if (venda != null)
            {
                if (MessageBox.Show("Deseja realmente Finalizar esta venda?", "Confirmação...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (vendaController.AlterarStatus(venda.VendaId, 'F') > 0)
                    {
                        MessageBox.Show("Venda finalizada com sucesso.", "Informação...",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparTela();
                    }
                    else
                        MessageBox.Show("A Venda não foi encontrada no banco de dados.", "Atenção...",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Nenhuma Venda criada para ser Finalizada.", "Atenção...",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CancelarVenda()
        {
            if (venda != null)
            {
                if (MessageBox.Show("Deseja realmente Cancelar esta venda?", "Confirmação...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (vendaController.AlterarStatus(venda.VendaId, 'C') > 0)
                    {
                        MessageBox.Show("Venda cancelada com sucesso.", "Informação...",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparTela();
                    }
                    else
                        MessageBox.Show("A Venda não foi encontrada no banco de dados.", "Atenção...",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show("Nenhuma Venda criada para ser Cancelada.", "Atenção...",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void LimparTela()
        {
            usuarioVenda = null;
            clienteVenda = null;
            produtoVenda = null;
            venda = null;

            txtUsuarioId.Clear();
            txtNomeUsuario.Clear();
            txtClienteId.Clear();
            txtNomeCliente.Clear();
            txtVendaId.Clear();
            txtDataHora.Clear();
            txtProdutoId.Clear();
            txtDescricao.Clear();
            txtQuantidadeItem.Text = "1";
            dgvVendaItens.DataSource = null;
            btnPesquisarUsuario.Focus();
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            AdicionarItem();
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            RemoverItem();
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e)
        {
            CancelarVenda();
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            FinalizarVenda();
        }

        private void btnFecharTela_Click(object sender, EventArgs e)
        {
            if (venda == null)
                Close();
            else
                CancelarVenda();
        }

        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            PesquisarUsuario();
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            PesquisarCliente();
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            PesquisarProduto();
        }
    }
}
