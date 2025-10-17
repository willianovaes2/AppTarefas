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
    public partial class MenuExcluir : Form
    {
        DAOTarefas dao;
        public MenuExcluir()
        {
            dao = new DAOTarefas(); 
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Código

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(textBox1.Text);
            MessageBox.Show(dao.Deletar(codigo));
        }//Botão Excluir

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Botão Voltar
    }
}
