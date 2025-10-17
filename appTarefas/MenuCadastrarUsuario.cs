using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace appTarefas
{
    public partial class MenuCadastrarUsuario : Form
    {
        DAOUsuario dao;
        public MenuCadastrarUsuario()
        {
            dao = new DAOUsuario();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Coletar os dados
                string nome = textBox3.Text;
                string email = textBox1.Text;
                string senha = textBox2.Text;


                dao.Inserir(nome, email, senha);

                //Confirmar que foi inserido
                MessageBox.Show($"Cadastrado com sucesso!!!");
                //Limpar os campos após o cadastro
                textBox3.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Algo deu errado!!!! \n\n {ex}");
            }
        }//Botão Cadastre-se

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Nome

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Email

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Senha

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Botão Voltar
    }
}
