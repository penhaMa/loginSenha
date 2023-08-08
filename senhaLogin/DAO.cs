using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace senhaLogin
{
    
    class DAO
    {
        public MySqlConnection conexao;
        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;database=login;Uid=root;password=");
            try
            {
                conexao.Open();//Abrir a conexão com o banco de dados
                MessageBox.Show("Conectado");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }
        }//Fim do Construtor

        //Métodos de inserção
        public string Inserir(string nome, string senha, string nomeTabela)
        {
            string inserir = $"Insert into {nomeTabela}(nome, senha) values('{nome}','{senha}')";
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado";
            return resultado;
        }//Fim da inserir

    }//Fim da classe
}//Fim do Projeto
