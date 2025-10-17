using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace appTarefas
{
    class DAOTarefas
    {
        public MySqlConnection conexao;//Criando uma chave para a classe MYSQLCONNECTION
        public string dados;
        public string comando;
        public int i;
        public int contador;
        public int[] codigo;
        public string[] titulo;
        public string[] descricao;
        public string[] prioridade;
        public DateTime[] criacao;
        public DateTime[] prazos;
        public DateTime[] lembrete;
        public string[] situacao;
        public int[] usuarioCodigo;
        public string msg;

        public DAOTarefas()
        {
            //Conectar com o banco
            conexao = new MySqlConnection("server=localhost;DataBase=apptarefas;Uid=root;Password=;Convert Zero DateTime=True");
            try
            {
                conexao.Open();//Tenta abrir a conexao com o Banco de Dados
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Algo deu errado!\n\n {erro}");
                conexao.Close();//Fechar a conexao
            }//fim do try_catch
        }//fim do construtor

        public void Inserir(string titulo, string descricao, string prioridade, DateTime criacao, DateTime prazos, DateTime lembrete, string situacao, int usuarioCodigo)
        {
            try
            {
                //Modificar
                MySqlParameter parameter1 = new MySqlParameter();
                parameter1.ParameterName = "@Date";
                parameter1.MySqlDbType = MySqlDbType.Date;
                parameter1.Value = $"{criacao.Year}-{criacao.Month}-{criacao.Day}";

                MySqlParameter parameter2 = new MySqlParameter();
                parameter2.ParameterName = "@Date";
                parameter2.MySqlDbType = MySqlDbType.Date;
                parameter2.Value = $"{prazos.Year}-{prazos.Month}-{prazos.Day}";

                MySqlParameter parameter3 = new MySqlParameter();
                parameter3.ParameterName = "@Date";
                parameter3.MySqlDbType = MySqlDbType.Date;
                parameter3.Value = $"{lembrete.Year}-{lembrete.Month}-{lembrete.Day}";


                dados = $"('','{titulo}','{descricao}','{prioridade}','{parameter1.Value}','{parameter2.Value}','{parameter3.Value}','{situacao}','{usuarioCodigo}')";
                comando = $"Insert into tarefas(codigo, titulo, descricao, prioridade, criacao, prazos, lembrete, situacao, usuarioCodigo) values{dados}";
                //Lançar os dados no banco
                MySqlCommand sql = new MySqlCommand(comando, conexao);
                string resultado = "" + sql.ExecuteNonQuery();// Comando de inserção/Ações

            }
            catch (Exception erro)
            {
                MessageBox.Show($"Algo deu Errado!\n\n {erro}");
            }//fim do catch
        }//fim do inserir

        //Método para preencher o vetor
        public void PreencherVetor()
        {
            string query = "select * from tarefas";//Comando SQL para acesso aos dados
            //Instanciar os vetores
            codigo = new int[100];
            titulo = new string[100];
            descricao = new string[100];
            prioridade = new string[100];
            criacao = new DateTime[100];
            prazos = new DateTime[100];
            lembrete = new DateTime[100];
            situacao= new string[100];
            usuarioCodigo = new int[100];

            //Reafirmar que eu quero preencher com 0 e "" os vetores
            for (i = 0; i < 100; i++)
            {
                codigo[i] = 0;
                titulo[i] = "";
                descricao[i] = "";
                prioridade[i] = "";
                criacao[i] = new DateTime();
                prazos[i] = new DateTime();
                lembrete[i] = new DateTime();
                situacao[i] = "";
                usuarioCodigo[i] = 0;
            }//fim do for

            //Executar o comando no BD
            MySqlCommand coletar = new MySqlCommand(query, conexao);
            //Leitura dos dados do Banco - Por linha
            MySqlDataReader leitura = coletar.ExecuteReader();

            i = 0;
            contador = 0;
            //Buscar os dados do banco e preencher o vetor
            while (leitura.Read())
            {
                codigo[i] = Convert.ToInt32(leitura["codigo"]);
                titulo[i] = leitura["titulo"] + "";
                descricao[i] = leitura["descricao"] + "";
                prioridade[i] = leitura["prioridade"] + "";
                criacao[i] = Convert.ToDateTime(leitura["criacao"]);
                prazos[i] = Convert.ToDateTime(leitura["prazos"]);
                lembrete[i] = Convert.ToDateTime(leitura["lembrete"]);
                situacao[i] = leitura["situacao"] + "";
                usuarioCodigo[i] = Convert.ToInt32(leitura["usuarioCodigo"]);
                i++;//Ande pelo vetor
                contador++;//Contar exatamente quantos dados foram inseridos
            }//fim do while

            //Fechar a leitura dos dados com o banco de dados
            leitura.Close();
        }//fim do preencher

        public int QuantidadeDeDados()
        {
            return contador;
        }//fim do método

        public string ConsultarTudo()
        {
            //Preencher o vetor
            PreencherVetor();
            msg = "";//Instanciando a variável
            for (i = 0; i < contador; i++)
            {
                msg += $"\n\nCódigo: {codigo[i]} \nTítulo: {titulo[i]}\n Descricao: {descricao[i]} \nPrioridade: {prioridade[i]} \nCriação: {criacao[i]} \nPrazos: {prazos[i]} \nLembrete: {lembrete[i]} \nSituação: {situacao[i]} \nCódigo usuário: {usuarioCodigo[i]}";
            }//fim do for
            //Mostrar todos os dados do BD
            return msg;
        }//fim do método

        public string ConsultarPorCodigo(int codigo)
        {
            PreencherVetor();
            msg = "";
            for (i = 0; i < contador; i++)
            {
                if (this.codigo[i] == codigo)
                {
                    msg += $"\n\nCódigo: {this.codigo[i]} \nTítulo: {titulo[i]}\n Descricao: {descricao[i]} \nPrioridade: {prioridade[i]} \nCriação: {criacao[i]} \nPrazos: {prazos[i]} \nLembrete: {lembrete[i]} \nSituação: {situacao[i]} \nCódigo usuário: {usuarioCodigo[i]}";
                    return msg;
                }//fim do if
            }//fim do método
            return "\n\nCódigo informado não foi encontrado!";
        }//fim do método

        public string ConsultarTitulo(int codigo)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (this.codigo[i] == codigo)
                {
                    return titulo[i] + "";
                }//fim do if
            }//fim do for
            return "Código não existe!";
        }//fim do método

        public string ConsultarDescricao(int codigo)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (this.codigo[i] == codigo)
                {
                    return descricao[i] + "";
                }//fim do if
            }//fim do for
            return "Código não existe!";
        }//fim do método

        public string ConsultarPrioridade(int codigo)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (this.codigo[i] == codigo)
                {
                    return prioridade[i] + "";
                }//fim do if
            }//fim do for
            return "Código não existe!";
        }//fim do método

        public string ConsultarCriacao(int codigo)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (this.codigo[i] == codigo)
                {
                    return criacao[i] + "";
                }//fim do if
            }//fim do for
            return "Código não existe!";
        }//fim do método

        public string ConsultarPrazos(int codigo)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (this.codigo[i] == codigo)
                {
                    return prazos[i] + "";
                }//fim do if
            }//fim do for
            return "Código não existe!";
        }//fim do método

        public string ConsultarLembrete(int codigo)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (this.codigo[i] == codigo)
                {
                    return lembrete[i] + "";
                }//fim do if
            }//fim do for
            return "Código não existe!";
        }//fim do método
        public string ConsultarSituacao(int codigo)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (this.codigo[i] == codigo)
                {
                    return situacao[i] + "";
                }//fim do if
            }//fim do for
            return "Código não existe!";
        }//fim do método
        public string ConsultarCodigo(int codigo)
        {
            PreencherVetor();
            for (i = 0; i < contador; i++)
            {
                if (this.codigo[i] == codigo)
                {
                    return usuarioCodigo[i] + "";
                }//fim do if
            }//fim do for
            return "Código não existe!";
        }//fim do método

        public string Atualizar(int codigo, string campo, string novoDado)
        {
            try
            {
                string query = $"update tarefas set {campo} = '{novoDado}' where codigo = '{codigo}'";
                //Executar o comando
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + " dado atualizado com sucesso!";
            }
            catch (Exception erro)
            {
                return $"\nAlgo deu errado!\n\n {erro}";
            }
        }//fim do método String

        public string Atualizar(int codigo, string campo, int novoDado)
        {
            try
            {
                string query = $"update tarefas set {campo} = '{novoDado}' where codigo = '{codigo}'";
                //Executar o comando
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + " dado atualizado com sucesso!";
            }
            catch (Exception erro)
            {
                return $"\nAlgo deu errado!\n\n {erro}";
            }
        }//fim do método int

        public string Atualizar(int codigo, string campo, DateTime novoDado)
        {
            try
            {
                MySqlParameter parameter = new MySqlParameter();
                parameter.ParameterName = "@Date";
                parameter.MySqlDbType = MySqlDbType.Date;
                parameter.Value = $"{novoDado.Year}-{novoDado.Month}-{novoDado.Day}";

                string query = $"update tarefas set {campo} = '{parameter.Value}' where codigo = '{codigo}'";
                //Executar o comando
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + " dado atualizado com sucesso!";
            }
            catch (Exception erro)
            {
                return $"\nAlgo deu errado!\n\n {erro}";
            }
        }//fim do método DateTime

        public string Deletar(int codigo)
        {
            try
            {
                string query = $"delete from livro where codigo = '{codigo}'";
                MySqlCommand sql = new MySqlCommand(query, conexao);
                string resultado = "" + sql.ExecuteNonQuery();
                return resultado + " dado excluído!";
            }
            catch (Exception erro)
            {
                return $"Algo deu errado\n\n {erro}";
            }
        }//fim do método
    }
}
