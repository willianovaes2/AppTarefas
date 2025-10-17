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
    public partial class MenuPrincipal : Form
    {
        DAOTarefas dao;
        public MenuPrincipal()
        {
            dao = new DAOTarefas();
            InitializeComponent();
            //Chamar TODOS OS MÉTODOS NA ORDEM
            ConfigurarGrid();//Estruturando o Grid
            NomeDados();//Nomear as colunas
            dao.PreencherVetor();//Preencher os vetores e consultar o banco
            AdicionarDados();//Inserir os dados na tela, linha por linha
        }//Fim do construtor

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Código

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuCadastrar menuCadastrar = new MenuCadastrar();
            menuCadastrar.ShowDialog();
        }//Botão Nova Tarefa / Cadastrar

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAtualizar menuAtualizar = new MenuAtualizar();
            menuAtualizar.ShowDialog();
        }//Botão Editar / Atualizar

        private void button3_Click(object sender, EventArgs e)
        {
            MenuExcluir menuExcluir = new MenuExcluir();
            menuExcluir.ShowDialog();
        }//Botão Excluir

        public void AdicionarDados()
        {
            for (int i = 0; i < dao.QuantidadeDeDados(); i++)
            {
                dataGridView1.Rows.Add(dao.titulo[i], dao.descricao[i], dao.prioridade[i], dao.criacao[i], dao.prazos[i], dao.lembrete[i], dao.situacao[i]);
            }//fim do for
        }//fim do método

        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Adicionar linhas
            dataGridView1.AllowUserToDeleteRows = false;//Apagar Linhas
            dataGridView1.AllowUserToResizeColumns = false;//Modificar Colunas
            dataGridView1.AllowUserToResizeRows = false;//Modificar Linhas
            dataGridView1.ColumnCount = 7;
        }//fim do configurarGrid

        public void NomeDados()
        {
            dataGridView1.Columns[0].Name = "Título";
            dataGridView1.Columns[1].Name = "Descrição";
            dataGridView1.Columns[2].Name = "Prioridade";
            dataGridView1.Columns[3].Name = "Criação";
            dataGridView1.Columns[4].Name = "Prazos";
            dataGridView1.Columns[5].Name = "Lembretes";
            dataGridView1.Columns[6].Name = "Situação";
        }//fim do método
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//dataGridView

        private void button4_Click(object sender, EventArgs e)
        {
                      
        }//Botão Buscar
    }
}
