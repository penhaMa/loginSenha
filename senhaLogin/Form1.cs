using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace senhaLogin
{
    public partial class Form1 : Form
    {
        DAO cada;
        Login log;
        public Form1()
        {
            InitializeComponent();
            log = new Login();
            cada = new DAO();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.ShowDialog();
            try
            {
                string result = cada.Inserir(login.Text, senha.Text, "login");
                MessageBox.Show(result);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);
            }//Fim do try catch
        }//Cadastrar

        private void button2_Click(object sender, EventArgs e)
        {

        }//Sair

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void senha_TextChanged(object sender, EventArgs e)
        {

        }
    }//Fim da classe
}//Fim do projeto
