using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTarefas
{
    public partial class MenuLogin : Form
    {
        DAOUsuario dao;
        public MenuLogin()
        {
            dao = new DAOUsuario();
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Email

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Senha

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string senha = textBox2.Text;
            Boolean resultado = dao.VerificarLogin(email, senha);

            if (resultado == true)
            {
                MenuPrincipal Menuprincipal = new MenuPrincipal();
                Menuprincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Email e/ou senha inválida, tente novamente");
            }
        }//Botão Entrar

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuCadastrarUsuario menuCadastrarUsuario = new MenuCadastrarUsuario();
            menuCadastrarUsuario.ShowDialog();
        }//Botão Cadastre-se
    }
}
