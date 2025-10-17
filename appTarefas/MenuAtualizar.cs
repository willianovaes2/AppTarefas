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
    public partial class MenuAtualizar : Form
    {
        DAOTarefas dao;
        public MenuAtualizar()
        {
            dao = new DAOTarefas();
            InitializeComponent();
        }

        private void MenuAtualizar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Codigo

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Título

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Descrição

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//Prioridade

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }//Data de Criação / Criação

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }//Prazo

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }//Lembretes

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }//Situação

        private void button1_Click(object sender, EventArgs e)
        {
            //Pegar os dados
            string titulo = textBox2.Text;
            string descricao = textBox3.Text;
            string prioridade = textBox4.Text;
            DateTime criacao = Convert.ToDateTime(textBox5.Text);
            DateTime prazos = Convert.ToDateTime(textBox8.Text);
            DateTime lembrete = Convert.ToDateTime(textBox9.Text);
            string situacao = textBox10.Text;
            int usuarioCategoria = Convert.ToInt32(textBox6.Text);
            //Atualizar
            int codigo = Convert.ToInt32(textBox1.Text);
            dao.Atualizar(codigo, "titulo", titulo);
            dao.Atualizar(codigo, "descricao", descricao);
            dao.Atualizar(codigo, "prioridade", prioridade);
            dao.Atualizar(codigo, "criacao", criacao);
            dao.Atualizar(codigo, "prazos", prazos);
            dao.Atualizar(codigo, "lembrete", lembrete);
            dao.Atualizar(codigo, "usuarioCodigo", usuarioCategoria);
            //Mensagem:
            MessageBox.Show("Atualizado com sucesso!");
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox6.Text = "";
        }//Botão Atualizar / Salvar Alterações

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Botão Voltar

        private void button3_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            textBox2.Text = dao.ConsultarTitulo(codigo);
            textBox3.Text = dao.ConsultarDescricao(codigo);
            textBox4.Text = dao.ConsultarPrioridade(codigo);
            textBox5.Text = dao.ConsultarCriacao(codigo);
            textBox8.Text = dao.ConsultarPrazos(codigo);
            textBox9.Text = dao.ConsultarLembrete(codigo);
            textBox10.Text = dao.ConsultarSituacao(codigo);
            textBox6.Text = dao.ConsultarCodigo(codigo);
        }//Botão Buscar

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }//Usuario Código
    }//Fim da classe
}//Fim do projeto
