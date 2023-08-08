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
    public partial class Login : Form
    {
        DAO logL;
        Form1 loginL;
        public Login()
        {
            InitializeComponent();
            logL = new DAO();
            loginL = new Form1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }//Entrar

        private void button2_Click(object sender, EventArgs e)
        {

        }//Sair

        private void login1_TextChanged(object sender, EventArgs e)
        {

        }

        private void senha2_TextChanged(object sender, EventArgs e)
        {

        }
    }//Fim da Classe
}//Fim do projeto
