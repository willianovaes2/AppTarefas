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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//dataGridView

        private void button4_Click(object sender, EventArgs e)
        {

        }//Botão Buscar
    }
}
