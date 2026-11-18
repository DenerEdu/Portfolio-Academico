using ProjetoHortiFruti.Controllers;
using ProjetoHortiFruti.Models;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace ProjetoHortiFruti.Views
{
    public partial class frmVendaHistorico : Form
    {
        public frmVendaHistorico()
        {
            InitializeComponent();
            dgvRegistros.AutoGenerateColumns = false;
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

        private void dgvRegistros_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if ((dgvRegistros.Rows[e.RowIndex].DataBoundItem != null) &&
                    (dgvRegistros.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                {
                    e.Value = CarregarPropriedade(dgvRegistros.Rows[e.RowIndex].DataBoundItem,
                        dgvRegistros.Columns[e.ColumnIndex].DataPropertyName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção...",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        private void Pesquisar()
        {
            int id = 0;

            VendaController vendaController = new VendaController();
            VendaCollection vendaCollection = new VendaCollection();

            dgvRegistros.DataSource = null;

            switch (cbxFiltro.SelectedIndex)
            {
                case 0:
                    vendaCollection = vendaController.GetByPeriodo(dtpInicial.Value, dtpFinal.Value);
                    break;
                case 1:
                    {
                        if (int.TryParse(txtCodigo.Text, out id))
                            vendaCollection = vendaController.GetByUsuario(id);
                    }
                    break;
                case 2:
                    {
                        if (int.TryParse(txtCodigo.Text, out id))
                            vendaCollection = vendaController.GetByVendaId(id);
                    }
                    break;
                case 3:
                    {
                        string status = "";
                        switch (cbxStatus.SelectedIndex)
                        {
                            case 0:
                                status = "F";
                                break;
                            case 1:
                                status = "P";
                                break;
                            case 2:
                                status = "C";
                                break;
                        }

                        vendaCollection = vendaController.GetByStatus(status);
                    }
                    break;
                case 4:
                    vendaCollection = vendaController.GetAll();
                    break;
            }

            dgvRegistros.DataSource = vendaCollection;
            dgvRegistros.Update();
            dgvRegistros.Refresh();
        }

        private Venda GetRegistro()
        {
            if (dgvRegistros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado.", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            else
            {
                return dgvRegistros.SelectedRows[0].DataBoundItem as Venda;
            }
        }

        private void ChamarTelaVisualizacao()
        {
            Venda vendaSelecionada = GetRegistro();
            if (vendaSelecionada != null)
            {
                frmVendaDetalhes frm = new frmVendaDetalhes(vendaSelecionada);
                frm.ShowDialog();
            }
        }

        private void AlterarStatus(bool IsFinalizar)
        {
            Venda vendaSelecionada = GetRegistro();

            string statusTratado = IsFinalizar ? "Finalizar" : "Cancelar";
            char status = IsFinalizar ? 'F' : 'C';

            if (vendaSelecionada != null)
            {
                if (vendaSelecionada.Status != 'P')
                    MessageBox.Show("Não é possível " + statusTratado + " um registro " + vendaSelecionada.StatusTratado + ".", "Atenção",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    VendaController vendaController = new VendaController();

                    if (MessageBox.Show("Deseja realmente " + statusTratado + " esta venda?", "Confirmação...",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (vendaController.AlterarStatus(vendaSelecionada.VendaId, status) > 0)
                        {
                            MessageBox.Show("Venda atualizada com sucesso.", "Informação...",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Pesquisar();
                        }
                        else
                            MessageBox.Show("A Venda não foi encontrada no banco de dados.", "Atenção...",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void Excluir()
        {
            Venda vendaSelecionada = GetRegistro();

            if (vendaSelecionada != null)
            {
                if (vendaSelecionada.Status != 'P')
                    MessageBox.Show("Não é possível excluir um registro " + vendaSelecionada.StatusTratado + ".", "Atenção",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (MessageBox.Show("Deseja realmente excluir o registro?", "Confirmação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        VendaController vendaController = new VendaController();

                        if (vendaController.Excluir(vendaSelecionada.VendaId) > 0)
                        {
                            MessageBox.Show("Registro excluído com sucesso.", "Informação",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Pesquisar();
                        }
                        else
                            MessageBox.Show("Não foi possível excluir o registro.", "Atenção",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            AjustarFiltros();
        }

        private void OcultarFiltroTodos()
        {
            pnlPeriodo.Visible = false;
            cbxStatus.Visible = false;
            txtCodigo.Visible = false;
            lblFiltro.Visible = false;
        }

        private void AjustarFiltros()
        {
            OcultarFiltroTodos();

            lblFiltro.Visible = true;
            switch (cbxFiltro.SelectedIndex)
            {
                case 0:
                    {
                        lblFiltro.Text = "Período";
                        pnlPeriodo.Visible = true;
                    }
                    break;
                case 1:
                case 2:
                    {
                        lblFiltro.Text = "Código";
                        txtCodigo.Visible = true;
                    }
                    break;
                case 3:
                    {
                        lblFiltro.Text = "Status";
                        cbxStatus.Visible = true;
                    }
                    break;
                case 4:
                    lblFiltro.Visible = false;
                    break;
            }
        }

        private void frmVendaHistorico_Load(object sender, EventArgs e)
        {
            OcultarFiltroTodos();
            cbxFiltro.SelectedIndex = 4;
            cbxStatus.SelectedIndex = 1;
            Pesquisar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            AlterarStatus(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AlterarStatus(false);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            ChamarTelaVisualizacao();
        }
    }
}
