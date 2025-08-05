using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyEncryption;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Padarosa.Model
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Preco { get; set; }
        public int Id_Categoria { get; set; }
        public int Id_Responsavel { get; set; }

        public bool Cadastrar()
        {
            string comando = "INSERT INTO produtos (nome, preco, id_categoria, id_respcadastro) " +
                "VALUES (@nome, @preco, @id_categoria, @id_responsavel)";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);
            cmd.Parameters.AddWithValue("@nome", Name);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@id_categoria",Id_Categoria);
            cmd.Parameters.AddWithValue("@id_responsavel", Id_Responsavel);
            
            
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
        public bool Editar()
        {
            string comando = "UPDATE produtos SET nome = @nome, " +
                "preco = @preco, id_categoria = @id_categoria WHERE id = @id";

            

            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", Name);
            cmd.Parameters.AddWithValue("@preco", Preco);
            cmd.Parameters.AddWithValue("@id_categoria", Id_Categoria); 
            cmd.Parameters.AddWithValue("@id", Id);

           

            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
        public bool Editar2()
        {
            string comando = "UPDATE produtos SET nome = @nome, " +
                "preco = @preco WHERE id = @id";



            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@nome", Name);
            cmd.Parameters.AddWithValue("@preco", Preco);
            
            cmd.Parameters.AddWithValue("@id", Id);



            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
        public DataTable Listar()
        {

            string comando = " SELECT * FROM `produtos` ";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Prepare();
            // Declarar tabela que irá receber o resultado:
            DataTable tabela = new DataTable();
            // Preencher a tabela com o resultado da consulta
            tabela.Load(cmd.ExecuteReader());
            conexaoBD.Desconectar(con);
            return tabela;
        }
        public bool Remover()
        {
            string comando = "DELETE FROM produtos WHERE id = @id";
            Banco conexaoBD = new Banco();
            MySqlConnection con = conexaoBD.ObterConexao();
            MySqlCommand cmd = new MySqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Prepare();
            try
            {
                if (cmd.ExecuteNonQuery() == 0)
                {
                    conexaoBD.Desconectar(con);
                    return false;
                }
                else
                {
                    conexaoBD.Desconectar(con);
                    return true;
                }
            }
            catch
            {
                conexaoBD.Desconectar(con);
                return false;
            }
        }
    }
}
