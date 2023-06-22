using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using organizador_de_alunos;

namespace sistema_gestao_estudantes
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            // Define a imagem da picture box via código.
            pictureBox1.Image = Image.FromFile("../../imagens/among-us-sus.gif");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            
            MEU_BD bancodedados = new MEU_BD();


            MySqlDataAdapter adaptdor = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `estudantes` WHERE `Username` = @usn AND `Password` = @psd", bancodedados.getConexao);
            comando.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtUsuario.Text;
            comando.Parameters.Add("@psd", MySqlDbType.VarChar).Value = txtSenha.Text;

            adaptdor.SelectCommand = comando;
            adaptdor.Fill(tabela);

            if (tabela.Rows.Count > 0)
            {
                //MessageBox.Show("SIM");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("NÃO");
            }
        }
    }
}
