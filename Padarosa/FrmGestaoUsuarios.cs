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
    public partial class FrmGestaoUsuarios : Form
    {
        //Variaveis Global
        Model.Usuario usuario;
        public FrmGestaoUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            //Puxar os dados da tabela usuario
            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            dgvUsuarios.DataSource = usuario.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txbCadastrarEmail.Text.Length < 6)
            {
                MessageBox.Show("O Email informado é invalido!", "Erro! ", 
                    MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else if (txbCadastrarNome.Text.Length < 7)
                {
                    MessageBox.Show("O nome informado é invalido!","Erro! ",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            else if (txbCadastrarSenha.Text.Length < 7)
            {
                MessageBox.Show( "A senha informado é invalido!","Erro! ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                //Iniciar o cadastro no bd:
                //Instanciar o usuario
                Model.Usuario usuario = new Model.Usuario();    
                usuario.Email = txbCadastrarEmail.Text;
                usuario.NomeCompleto = txbCadastrarNome.Text;
                usuario.Senha = txbCadastrarSenha.Text;

                if (usuario.Cadastrar () == true)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso! ", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Limpar os campo de cadastro: 
                    txbCadastrarEmail.Clear();
                    txbCadastrarNome.Clear();
                    txbCadastrarSenha.Clear();

                    //Puxar os dados da tabela usuario
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("Falha ao cadastrar o usuário", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);   
                }
            }

            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txbEditarEmail.Text.Length < 6)
            {
                MessageBox.Show( "O Email informado é invalido!","Erro! ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbEditarNome.Text.Length < 7)
            {
                MessageBox.Show("O nome informado é invalido!","Erro! ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txbEditarSenha.Text.Length < 3 )
            {
                MessageBox.Show( "A senha informado é invalido!","Erro! ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                // Inicia a edição no bd
                this.usuario.NomeCompleto = txbEditarNome.Text;
                this.usuario.Email = txbEditarEmail.Text;
                this.usuario.Senha = txbEditarSenha.Text;

                //Executar o .Modificar()
                if (this.usuario.Modificar())
                {
                    MessageBox.Show("Usuário modificado com sucesso! ", "Sucesso!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                    //Limparos campos e desabilitar os grbs
                    grbEditar.Enabled = false;
                    grbApagar.Enabled = false;
                    txbEditarEmail.Clear();
                    txbEditarSenha.Clear();
                    txbCadastrarNome.Clear();
                   

                }
                else
                {
                    MessageBox.Show("Falha ao modificar o usuario! ", "Erro!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

               
                AtualizarDgv();
            }
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult apagar = MessageBox.Show("Tem certeza que deseja apagar esse usuário? ", "Atenção!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (apagar == DialogResult.Yes)
            {
                
                //Puxar os dados da tabela usuario
                if (this.usuario.Remover())
                {
                    MessageBox.Show("Usuário removido com sucesso! ", "Sucesso!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                    //Limparos campos e desabilitar os grbs
                    grbEditar.Enabled = false;
                    grbApagar.Enabled = false;
                    txbEditarEmail.Clear();
                    txbEditarSenha.Clear();
                    txbCadastrarNome.Clear();
                    lblApagar.Text = "Selecione o usuario que deseja apagar. ";

                }
                else
                {
                    MessageBox.Show("Falha ao remover o usuario! ", "Erro!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvUsuarios.SelectedCells[0].RowIndex;
            //Atribuir os dados da linha selecionada no grbEditar
           this.usuario.NomeCompleto = dgvUsuarios.Rows[linhaSelecionada].Cells[1].Value.ToString();
            this.usuario.Email=txbEditarEmail.Text = dgvUsuarios.Rows[linhaSelecionada].Cells[2].Value.ToString();
            this.usuario.Id = (int)dgvUsuarios.Rows[linhaSelecionada].Cells[0].Value;


            // Atribuir os dados da linha selecionada no grbEditar
            txbEditarNome.Text = this.usuario.NomeCompleto;
            txbEditarEmail.Text = this.usuario.Email;
            //Ativar o grbEditar
            grbEditar.Enabled = true;

            //Ativar o grbApagar
            grbApagar.Enabled = true;
            lblApagar.Text= $"{this.usuario.Id} - {this.usuario.NomeCompleto}";
        }
    }
}
