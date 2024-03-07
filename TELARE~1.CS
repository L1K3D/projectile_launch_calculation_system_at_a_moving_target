//CEFSA - Centro Educacional da Fundação Salvador Arena
//FESA - Faculdade Engenheiro Salvador Arena
//PBL - Projeto Integrador Entre Disciplinas
//Sistema de Cáculo e Simulação de um Lançamento Balístico com Alvo Móvel

//-----Alunos Envolvidos------

//Erikson Vieira Queiroz - RA: 082220021
//Enzo Brito Alves de Oliveira - RA: 082220040
//Guilherme Alve Barbosa - RA: 082220014
//Heitor Santos Ferreira - RA: 081230042
//Tainara do Nascimento Casimiro - RA: 082220011
//William Santim - RA: 082220033

//Engenharia de Computação - Terceiro Semestre - EC3

//-----Disciplinas Envolvidas-----
//Programação Orientada a Objetos | Professora Leide Vieira
//Calculo Avançado | Professor Daniel Giglio
//Física Geral e Experimental II | Professor João Lamesa
//Banco de Dados II | Professor Flávio Viotti

//Declarando bibliotecas que serão utilizadas ao decorrer do código
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//Define o local e o namespace no qual o arquivo está localizado
namespace PPL_Main.Telas
{

    //Define a classe do visual como instanciamento público
    public partial class TelaResultadosAnteriores : Form
    {

        //Referencia o código do programa principal, para que os métodos e variaveis declaradas possam ser acessiveis nesse trecho do código
        Program referenciaClassePrograma = new Program();

        //Inicializa o visual do WindowsForms juntamente com a execução do método e exibição e obtenção dos dados
        public TelaResultadosAnteriores()
        {
            InitializeComponent();
            ObterDados();
        }

        //Realiza a construção do método que obtem os dados das principais tabelas do programa e preenche os DataGrid's
        private void ObterDados()
        {

            //Realiza o relecionamento e referencia da conexão com o banco de dados com o valor contido na variavel 'enderecamentoBancoDeDados' no programa de execução principal do software, evocado anteriormente em 'referenciaClassePrograma'
            using (SqlConnection conexaoBancoDeDados = new SqlConnection(referenciaClassePrograma.enderecamentoBancoDeDados))
            {

                //Abre conexão com o banco de dados
                conexaoBancoDeDados.Open();

                //Cria comando que seleciona todo o conteudo da tabela de simulações
                var sqlQueryTabelaSimulacoes = "SELECT * FROM simulacoes";

                //Utiliza adaptador SQL referenciando o comando e a conexão com o banco de dados
                using (SqlDataAdapter daSimulacoes = new SqlDataAdapter(sqlQueryTabelaSimulacoes, conexaoBancoDeDados))
                {

                    //Preenche o dataGrid de simulações com o conteúdo coletado na 'query'
                    using (DataTable dtSimulacoes = new DataTable())
                    {

                        daSimulacoes.Fill(dtSimulacoes);
                        dataGridViewTabelaSimulacoes.DataSource = dtSimulacoes;

                    }

                }

                //Cria comando que seleciona todo o conteudo da tabela de projetil
                var sqlQueryTabelaProjetil = "SELECT * FROM projetil";

                //Utiliza adaptador SQL referenciando o comando e a conexão com o banco de dados
                using (SqlDataAdapter daProjetil = new SqlDataAdapter(sqlQueryTabelaProjetil, conexaoBancoDeDados))
                {

                    //Preenche o dataGrid de projetil com o conteúdo coletado na 'query'
                    using (DataTable dtProjetil = new DataTable())
                    {

                        daProjetil.Fill(dtProjetil);
                        dataGridViewTabelaProjetil.DataSource = dtProjetil;

                    }

                }

                //Cria comando que seleciona todo o conteudo da tabela de alvo
                var sqlQueryTabelaAlvo = "SELECT * FROM alvo";

                //Utiliza adaptador SQL referenciando o comando e a conexão com o banco de dados
                using (SqlDataAdapter daAlvo = new SqlDataAdapter(sqlQueryTabelaAlvo, conexaoBancoDeDados))
                {

                    //Preenche o dataGrid de alvo com o conteúdi coletado a 'query'
                    using (DataTable dtAlvo = new DataTable())
                    {

                        daAlvo.Fill(dtAlvo);
                        dataGridViewTabelaAlvo.DataSource = dtAlvo;

                    }

                }

            }

        }

        //Define as ações que serão realizadas após o clique do botão de voltar
        private void voltarButton_Click(object sender, EventArgs e)
        {

            //Atribui uma variavel de referencia a tela que está atualmente ativa
            Form telaAtual = Form.ActiveForm;

            //Atribui um variavel de referencia a tela de menu
            TelaMenu telaMenu = new TelaMenu();

            //Fecha a tela atual
            telaAtual.Close();

            //Abre a tela de menu
            telaMenu.Show();

        }
    }
}
