using System;
using System.Windows.Forms;
using P1POO.Controllers;
using P1POO.Models;

namespace P1POO.Views
{
    public partial class FormCadastroBrinquedo : Form
    {
        private BrinquedoController controller;

        public FormCadastroBrinquedo(BrinquedoController controller)
        {
            InitializeComponent();
            this.controller = controller;
            AtualizarListBox();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoBarras.Text) ||
                string.IsNullOrWhiteSpace(txtDescricao.Text) ||
                string.IsNullOrWhiteSpace(txtPreco.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtIdadeMinima.Text) ||
                string.IsNullOrWhiteSpace(txtNomeFabricante.Text) ||
                string.IsNullOrWhiteSpace(txtCnpjFabricante.Text))
            {
                MessageBox.Show("Preencha todos os campos para cadastrar o brinquedo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal preco;
            if (!decimal.TryParse(txtPreco.Text.Trim(), out preco) || preco < 0)
            {
                MessageBox.Show("Informe um valor numérico válido para o preço.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreco.Focus();
                return;
            }

            int idadeMinima;
            if (!int.TryParse(txtIdadeMinima.Text.Trim(), out idadeMinima) || idadeMinima < 0)
            {
                MessageBox.Show("Informe um número inteiro válido para a idade mínima.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdadeMinima.Focus();
                return;
            }

            try
            {
                Fabricante fabricante = new Fabricante(txtCnpjFabricante.Text.Trim(), txtNomeFabricante.Text.Trim());

                Brinquedo brinquedo = new Brinquedo(
                    txtCodigoBarras.Text.Trim(),
                    txtDescricao.Text.Trim(),
                    preco,
                    txtCategoria.Text.Trim(),
                    idadeMinima,
                    fabricante
                );

                controller.Adicionar(brinquedo);
                AtualizarListBox();
                LimparCampos();
                MessageBox.Show("Brinquedo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxBrinquedos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um brinquedo na lista para remover.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente remover o brinquedo selecionado?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                try
                {
                    controller.Remover(listBoxBrinquedos.SelectedIndex);
                    AtualizarListBox();
                    MessageBox.Show("Brinquedo removido com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao remover: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (listBoxBrinquedos.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um brinquedo na lista para visualizar os detalhes.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Brinquedo brinquedoSelecionado = controller.ObterPorIndice(listBoxBrinquedos.SelectedIndex);
                FormVisualizarBrinquedo formVisualizar = new FormVisualizarBrinquedo(brinquedoSelecionado);
                formVisualizar.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarListBox()
        {
            listBoxBrinquedos.Items.Clear();
            foreach (Brinquedo b in controller.ListarTodos())
            {
                listBoxBrinquedos.Items.Add(b.ObterDadosCompletos());
            }
        }

        private void LimparCampos()
        {
            txtCodigoBarras.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtCategoria.Clear();
            txtIdadeMinima.Clear();
            txtNomeFabricante.Clear();
            txtCnpjFabricante.Clear();
            txtCodigoBarras.Focus();
        }
    }
}
