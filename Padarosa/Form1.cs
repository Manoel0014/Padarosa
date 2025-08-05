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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text.Length < 6)
            {
                MessageBox.Show("E-mail inválido", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 3)
            {
                MessageBox.Show("Senjha inválida", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Model.Usuario usuario = new Model.Usuario();
                usuario.Email = txbEmail.Text;
                usuario.Senha = txbSenha.Text;
                // Variavel p/ armazenar o resultado do lugar (SELECT):
                DataTable resultado = new DataTable();
                resultado = usuario.Logar();

                //Verificar se a tabela tem pelo uma linha

                if (resultado.Rows.Count > 0)
                {
                   
                    // Armazenar as infos do usuarios no obj
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                    usuario.Id = (int)resultado.Rows[0]["id"];

                    //Mudar para o menu principal
                    FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal(usuario);
                    this.Hide();
                    formMenuPrincipal.ShowDialog();
                    this.Hide();
                
                }
                else
                {
                    MessageBox.Show("Usuario ou senha inválida", "Erro", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
