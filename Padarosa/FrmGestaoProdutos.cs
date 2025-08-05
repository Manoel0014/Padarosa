using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Padarosa.Model;

namespace Padarosa
{
    public partial class FrmGestaoProdutos : Form
    {
        //Variaveis Global
        Model.Usuario usuario;
        Model.Produto produto = new Produto();
        Model.Categoria categoria = new Categoria();
        public FrmGestaoProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
            // Obter as categorias do banco
            DataTable resultadoCategorias = categoria.ListarCategoria();
            foreach (DataRow linha in resultadoCategorias.Rows)
            {
                //exemplo 1- Alimentação
                //Adicionar ao combobox
                cmbCadastrarCategoria.Items.Add($"{linha["id"]} - {linha["nome"]}");

            }
        }

        public void AtualizarDgv()
        {
            Model.Produto produto = new Model.Produto();
            dgvProdutos.DataSource = produto.Listar();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbCadastrarNome.Text.Length < 6)
            {
                MessageBox.Show("O nome informado é invalido!", "Erro! ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbCadastrarPreco.Text.Length < 1)
            {
                MessageBox.Show("O preço informado é invalido!", "Erro! ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.Produto produto = new Model.Produto();
                produto.Name = txbCadastrarNome.Text;
                produto.Preco = double.Parse(txbCadastrarPreco.Text);
                // Obter aoenas o id categoria do combobox
                produto.Id_Categoria= int.Parse(cmbCadastrarCategoria.Text.Split('-')[0]);
                produto.Id_Responsavel = usuario.Id;


                if (produto.Cadastrar() == true)
                {
                    MessageBox.Show("Produto cadastrado com sucesso! ", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpar os campo de cadastro: 
                    txbCadastrarNome.Clear();
                    txbCadastrarPreco.Clear();
                    

                    //Puxar os dados da tabela usuario
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o Produto", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbEditarNome.Text.Length < 6)
            {
                MessageBox.Show("O Email informado é invalido!", "Erro! ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbEditarPreco.Text.Length < 1)
            {
                MessageBox.Show("O nome informado é invalido!", "Erro! ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (cmbEditarCategoria.Text != " ") 
            {
                this.produto.Name = txbEditarNome.Text;
                this.produto.Preco = double.Parse(txbEditarPreco.Text);        
                this.produto.Id_Responsavel = usuario.Id;
                produto.Id_Categoria = int.Parse(cmbEditarCategoria.Text.Split('-')[0]);

                //Executar o .Modificar()
                if (this.produto.Editar2())
                {
                    MessageBox.Show("Produto modificado com sucesso! ", "Sucesso!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                    //Limparos campos e desabilitar os grbs
                    grbEditar.Enabled = false;
                    grbApagar.Enabled = false;
                    txbEditarPreco.Clear();
                    txbEditarNome.Clear();



                }
                else
                {
                    MessageBox.Show("Falha ao modificar o produto! ", "Erro!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                AtualizarDgv();

            }
            else
            {
                this.produto.Name = txbEditarNome.Text;
                this.produto.Preco = double.Parse(txbEditarPreco.Text);
                produto.Id_Categoria = int.Parse(cmbCadastrarCategoria.Text.Split('-')[0]);
                this.produto.Id_Responsavel = usuario.Id;
                //Executar o .Modificar()
                if (this.produto.Editar())
                {
                    MessageBox.Show("Produto modificado com sucesso! ", "Sucesso!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                    //Limparos campos e desabilitar os grbs
                    grbEditar.Enabled = false;
                    grbApagar.Enabled = false;
                    txbEditarPreco.Clear();
                    txbEditarNome.Clear();



                }
                else
                {
                    MessageBox.Show("Falha ao modificar o produto! ", "Erro!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                AtualizarDgv();
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvProdutos.SelectedCells[0].RowIndex;
            
            //Atribuir os dados da linha selecionada no grbEditar
            this.produto.Name = dgvProdutos.Rows[linhaSelecionada].Cells[1].Value.ToString();
            this.produto.Preco  = (double)dgvProdutos.Rows[linhaSelecionada].Cells[2].Value;
            this.produto.Id = (int)dgvProdutos.Rows[linhaSelecionada].Cells[0].Value;


            // Atribuir os dados da linha selecionada no grbEditar
            txbEditarNome.Text = this.produto.Name;
            txbEditarPreco.Text = this.produto.Preco.ToString();
            //Ativar o grbEditar
            grbEditar.Enabled = true;

            //Ativar o grbApagar
            grbApagar.Enabled = true;
            lblApagar.Text = $"{this.produto.Id} - {this.produto.Name}";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult apagar = MessageBox.Show("Tem certeza que deseja apagar esse produto? ", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (apagar == DialogResult.Yes)
            {

                //Puxar os dados da tabela usuario
                if (this.produto.Remover())
                {
                    MessageBox.Show("Produto removido com sucesso! ", "Sucesso!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                    //Limparos campos e desabilitar os grbs
                    grbEditar.Enabled = false;
                    grbApagar.Enabled = false;
                    txbEditarNome.Clear();
                    txbEditarPreco.Clear();
                    
                    lblApagar.Text = "Selecione o produto que deseja apagar. ";

                }
                else
                {
                    MessageBox.Show("Falha ao remover o produto! ", "Erro!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
