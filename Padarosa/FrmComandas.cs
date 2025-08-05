using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa
{
    public partial class FrmComandas : Form
    {
        //Variaveis Global
        Model.Usuario usuario;
        Model.Produto produto = new Model.Produto();
        Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
        public FrmComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            dgvProdutos.DataSource = produto.Listar();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvProdutos.SelectedCells[0].RowIndex;
            //Atribuir o ID do produto no txb
            txbInforProduto.Text = dgvProdutos.Rows[linhaSelecionada].Cells[0].Value.ToString();
            // Atribuir o nome para o txb
            txbLancaProduto.Text = dgvProdutos.Rows[linhaSelecionada].Cells[1].Value.ToString();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //Verificar se os campos foram preenchidos 
            if (txbComanda.Text == "" || txbComanda.Text.Length < 2)
            {
                MessageBox.Show("Informe o numero da comanda!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (txbInforProduto.Text == "")
            {
                MessageBox.Show("Informe o codigo do produto!", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Habilitar o campo de lançamento
                grbLancamentos.Enabled = true;
                txbLancaProduto.Enabled = false;

                // Desativar o grb inforações
                grbInformacoes.Enabled = false;
                txbInforProduto.Enabled = false ;
            }

        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if(txbQuantidade.Text == "")
            {
                MessageBox.Show("Informe a quantidade!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult r = MessageBox.Show($"Tem certeza que deseja lançar {txbQuantidade.Text}" +
                    $" {txbLancaProduto.Text} na comanda {txbComanda.Text}?", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Se sim:
                if ( r == DialogResult.Yes )
                {
                    ordemComanda.Id_resp = usuario.Id;
                   ordemComanda.Id_produto = int.Parse(txbInforProduto.Text);
                    ordemComanda.Id_ficha = int.Parse(txbComanda.Text);
                    ordemComanda.Quantidade = int.Parse(txbQuantidade.Text);
                    ordemComanda.Situacao = 1; // Inserir na comanda ativa
                    if (ordemComanda.Cadastrar()) 
                    {
                        MessageBox.Show("Lançamento efetuado com sucesso", "Sucesso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txbComanda.Clear();
                        txbInforProduto.Clear();
                        txbLancaProduto.Clear();
                        txbQuantidade.Clear();
                        grbLancamentos.Enabled = false;
                        grbInformacoes.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Falha ao efetuar lançamento", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                   ResetarCampos();
                }
            }
        }
        public void ResetarCampos()
        {
            grbLancamentos.Enabled = false;
            grbInformacoes.Enabled = true;

            txbComanda.Clear() ;
            txbInforProduto.Clear();
            txbLancaProduto.Clear();
            txbQuantidade.Clear();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            ResetarCampos();
        }
    }
}
