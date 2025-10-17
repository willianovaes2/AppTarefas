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
    public partial class MenuCadastrar : Form
    {
        DAOTarefas dao;
        public MenuCadastrar()
        {
            dao = new DAOTarefas();
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Titulo

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Descrição

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//Prioridade

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }//Data da crição

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
            try
            {
                //Coletar os dados
                string titulo = textBox2.Text;
                string descricao = textBox3.Text;
                string prioridade = textBox4.Text;
                DateTime criacao = Convert.ToDateTime(textBox5.Text);
                DateTime prazos = Convert.ToDateTime(textBox8.Text);
                DateTime lembrete = Convert.ToDateTime(textBox9.Text);
                string situacao = textBox10.Text;
                int usuarioCodigo = Convert.ToInt32(textBox6.Text);

                dao.Inserir(titulo, descricao, prioridade, criacao, prazos, lembrete, situacao, usuarioCodigo);

                //Confirmar que foi inserido
                MessageBox.Show($"Cadastrado com sucesso!!! \n\nTítulo: {titulo}\n Descricao: {descricao} \nPrioridade: {prioridade} \nCriação: {criacao} \nPrazos: {prazos} \nLembrete: {lembrete} \nSituação: {situacao} \nCódigo usuário: {usuarioCodigo}");
                //Limpar os campos após o cadastro
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                textBox6.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Algo deu errado!!!! \n\n {ex}");
            }
        }//Botão Cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Botão Voltar

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }//Código Usuário
    }
}
