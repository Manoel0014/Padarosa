using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using Padarosa.Model;

namespace Padarosa
{
    public partial class FrmCaixa : Form
    {
        //Variaveis Global
        Model.Usuario usuario;
        Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
        public FrmCaixa(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
           
        }
        public void AtualizarDgv()
        {
            dgvComanda.DataSource = ordemComanda.Listar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
         if(txbComanda.Text == "" || txbComanda.Text.Length < 2)
            {
                MessageBox.Show("Informe corretamente o número da comanda", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ordemComanda.Id_ficha = int.Parse(txbComanda.Text);
                DataTable consulta = ordemComanda.BuscarFicha();
                if (consulta.Rows.Count == 0)
                {
                    MessageBox.Show("Não existe lançamento nessa comanda", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvComanda.DataSource = consulta;
                    //Mostrar no label o total
                    lblValor.Text = "R$" + consulta.Compute("Sum(Total_item)", "True").ToString();
                }
            }
        }

        private void cbxPagamentoRecebido_CheckedChanged(object sender, EventArgs e)
        {
            // Ativar ou desativar o btnEncerrar
            btnEncerrar.Enabled = cbxPagamentoRecebido.Checked;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            DialogResult pergunta = MessageBox.Show($"Tem certeza que deseja encerrar a comanda {ordemComanda.Id_ficha}?", 
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pergunta == DialogResult.Yes)
            {
                if (ordemComanda.Encerrar())
                {
                    MessageBox.Show("Comanda encerrada", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnEncerrar.Enabled = false;
                    cbxPagamentoRecebido.Checked = false;

                    dgvComanda.DataSource = null;
                    //Apagar o numero da comanda
                    txbComanda.Clear();
                }
                else
                {
                    MessageBox.Show("Falha ao encerrar comanda", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
