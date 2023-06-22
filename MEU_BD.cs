using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace organizador_de_alunos
{
    internal class MEU_BD
    {
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost; username=root; password=;database=sga_estudantes_bd_t4");



        public MySqlConnection getConexao
        {
            get
            {
                return conexao;
            }
        }
        public void abrirConexao()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
        }
        public void fecharConexao()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }



        }
    }
}
